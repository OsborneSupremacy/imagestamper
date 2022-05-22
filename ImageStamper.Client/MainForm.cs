using ImageStamper.Client.Service;
using ImageStamper.Objects;
using ImageStamper.Service;
using Microsoft.Extensions.Options;

namespace ImageStamper.Client;

public partial class MainForm : Form
{
    private readonly Settings _settings;

    private readonly BatchProcessor _batchProcessor;

    private readonly BatchValidator _batchValidator;

    private readonly Processor _processor;

    private readonly DateTimeFormatterFactory _dateTimeFormatterFactory;

    private PositionConstants _position = PositionConstants.BottomRight;

    private readonly HashSet<string> _supportedImageTypes = new();

    public MainForm(
        IOptions<Settings> settingsOptions,
        Processor processor,
        BatchProcessor batchProcessor,
        BatchValidator batchValidator,
        DateTimeFormatterFactory dateTimeFormatterFactory
        )
    {
        this._settings = settingsOptions?.Value ?? throw new ArgumentNullException(nameof(settingsOptions));
        this._processor = processor ?? throw new ArgumentNullException(nameof(processor));
        this._batchProcessor = batchProcessor ?? throw new ArgumentNullException(nameof(batchProcessor));
        this._batchValidator = batchValidator ?? throw new ArgumentNullException(nameof(batchValidator));
        this._dateTimeFormatterFactory = dateTimeFormatterFactory ?? throw new ArgumentNullException(nameof(dateTimeFormatterFactory));
        this._supportedImageTypes = _settings.SupportedImageTypes.ToHashSet();

        InitializeComponent();

        SetFont(FontTextBox.Font); // doing this so that the displayed name is consistent with the font
        SetSizeText();
        ClientFunctions.CreateAndGetInitialFolder();
        SetTempFolder();

        RefreshPreview();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        this.openFileDialog1.Filter = ClientFunctions.ComposeFileDialogFilter(_supportedImageTypes);
    }

    private void SelectFontButton_Click(object sender, EventArgs e)
    {
        if (!fontDialog1.IsResponseOk()) return;
        SetFont(fontDialog1.Font);
        RefreshPreview();
    }

    private void SetFont(Font font)
    {
        FontTextBox.Font = font;
        FontTextBox.Text = $"{font.Name} {font.Style}";
    }

    private void SelectColorButton_Click(object sender, EventArgs e)
    {
        if (!colorDialog1.IsResponseOk()) return;
        SetColor(colorDialog1.Color);
        RefreshPreview();
    }

    private void SetColor(Color color) =>
        ColorTextBox.BackColor = color;

    private void SizeTrackBar_Scroll(object sender, EventArgs e) =>
        SetSizeText(((TrackBar)sender).Value);

    private void SetSizeText() =>
        SetSizeText(SizeTrackBar.Value);

    private void SetSizeText(int size) =>
        SizeTextBox.Text = $"{size}% of image's longest side";

    private void PositionButton_Click(object sender, EventArgs e)
    {
        var button = (RadioButton)sender;
        if (!button.Checked) return;

        _position = ClientFunctions.GetPositionFromName(button.Name);
    }

    private void RefreshPreviewButton_Click(object sender, EventArgs e) => RefreshPreview();

    private void RefreshPreview()
    {
        var (combinedDateTime, dateTimeFormatter) = GetDateTimeObjects();

        Bitmap preview = _processor
            .Process(
                Properties.Resources.IMG_3192,
                ColorTextBox.BackColor,
                BackgroundFillCheckBox.Checked,
                FontTextBox.Font,
                dateTimeFormatter.Invoke(combinedDateTime),
                PositionConstants.YCenterXCenter,
                60
            )!;

        PreviewPictureBackGroundBox.Image = preview;
        PreviewPictureBackGroundBox.Refresh();
    }

    private void NewTempFolderButton_Click(object sender, EventArgs e) => SetTempFolder();

    private void SetTempFolder() =>
        this.OutputFolderTextbox.Text = ClientFunctions.GetTempFolderName();

    private void BackgroundFillCheckBox_CheckedChanged(object sender, EventArgs e) => RefreshPreview();

    private void TimePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

    private void TimeFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

    private void DatePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

    private void DateFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

    private void ExecuteButton_Click(object sender, EventArgs e)
    {
        var imageFiles = ToProcessListbox.GetFiles();
        var outputDirectory = ClientFunctions.GetOrCreateDirectory(OutputFolderTextbox.Text);

        var (isValid, errors) = _batchValidator.Validate(imageFiles, outputDirectory);
        if (!isValid)
        {
            ClientFunctions.ComposeAndDisplayInvalidMessage(errors);
            return;
        }

        var (combinedDateTime, dateTimeFormatter) = GetDateTimeObjects();

        var settings = new BatchProcessSettings(
            imageFiles,
            outputDirectory,
            ColorTextBox.BackColor,
            BackgroundFillCheckBox.Checked,
            FontTextBox.Font,
            UseExifCheckBox.Checked,
            combinedDateTime,
            dateTimeFormatter,
            _position,
            SizeTrackBar.Value);

        ClientFunctions.ExecuteBatchProcess(_batchProcessor, settings);
        ClientFunctions.OpenInExplorer(outputDirectory.FullName);
    }

    private void FolderBrowseButton_Click(object sender, EventArgs e)
    {
        if (!folderBrowserDialog1.TryGetDirectoryName(out var result)) return;
        OutputFolderTextbox.Text = result;
    }

    private void AddImagesButton_Click(object sender, EventArgs e) =>
        ToProcessListbox.AddRangeNewOnly(
            openFileDialog1.GetSelectedFiles()
        );

    private void AddFolderButton_Click(object sender, EventArgs e) =>
        ToProcessListbox.AddRangeNewOnly(
            folderBrowserDialog1.GetFiles(_supportedImageTypes)
        );

    private void ClearAllButton_Click(object sender, EventArgs e) =>
        ToProcessListbox.Items.Clear();

    private void ClearSelectedButton_Click(object sender, EventArgs e) =>
        ToProcessListbox.RemoveSelectedItems();

    private (DateTime combinedDateTime, Func<DateTime, string> dateTimeFormatter) GetDateTimeObjects() =>
        (
            DatePicker.Value.Date.Add(TimePicker.Value.TimeOfDay),
            _dateTimeFormatterFactory.Create(DateFormatTextBox.Text, TimePicker.Checked, TimeFormatTextBox.Text)
        );
}
