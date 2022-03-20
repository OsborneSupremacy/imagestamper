using ImageStamper.Objects;
using ImageStamper.Service;
using System.Reflection;
using System.Text;

namespace ImageStamper.Client
{
    public partial class MainForm : Form
    {
        private readonly BatchProcessor _batchProcessor;

        private readonly BatchValidator _batchValidator;

        private readonly Processor _processor;

        private readonly DateTimeFormatterFactory _dateTimeFormatterFactory;

        private PositionConstants _position = PositionConstants.BottomRight;

        public MainForm(
            Processor processor,
            BatchProcessor batchProcessor,
            BatchValidator batchValidator,
            DateTimeFormatterFactory dateTimeFormatterFactory
            )
        {
            this._processor = processor ?? throw new ArgumentNullException(nameof(processor));
            this._batchProcessor = batchProcessor ?? throw new ArgumentNullException(nameof(batchProcessor));
            this._batchValidator = batchValidator ?? throw new ArgumentNullException(nameof(batchValidator));
            this._dateTimeFormatterFactory = dateTimeFormatterFactory ?? throw new ArgumentNullException(nameof(dateTimeFormatterFactory));

            InitializeComponent();

            SetFont(FontTextBox.Font); // doing this so that the displayed name is consistent with the font
            SetSizeText();
            SetInitialFolder();
            SetTempFolder();

            RefreshPreview();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            if (!fontDialog1.ShowDialog().Equals(DialogResult.OK)) return;
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
            if (!colorDialog1.ShowDialog().Equals(DialogResult.OK)) return;
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

            // button name contains word "Button". Remove it to get text corresponding
            // to PositionConstants values.
            var positionName = button.Name.Replace(nameof(Button), string.Empty);

            _position = (PositionConstants)Enum.Parse(typeof(PositionConstants), positionName, true);
        }

        private void RefreshPreviewButton_Click(object sender, EventArgs e) =>
            RefreshPreview();

        private void RefreshPreview()
        {
            var combinedDateTime = DatePicker.Value.Date.Add(TimePicker.Value.TimeOfDay);
            var dateTimeFormatter = _dateTimeFormatterFactory.Create(DateFormatTextBox.Text, TimePicker.Checked, TimeFormatTextBox.Text);

            Bitmap preview = _processor
                .Process(
                    Properties.Resources.IMG_3192,
                    ColorTextBox.BackColor,
                    BackgroundFillCheckBox.Checked,
                    FontTextBox.Font,
                    dateTimeFormatter.Invoke(combinedDateTime),
                    PositionConstants.YCenterXCenter,
                    60
                );

            PreviewPictureBackGroundBox.Image = preview;
            PreviewPictureBackGroundBox.Refresh();
        }

        private void NewTempFolderButton_Click(object sender, EventArgs e) => SetTempFolder();

        private void SetTempFolder() => 
            this.OutputFolderTextbox.Text = GetTempFolderName();

        private string GetTempFolderName() =>
            Path.Combine(Path.GetTempPath(), nameof(ImageStamper), DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));

        private void SetInitialFolder()
        {
            var appDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(ImageStamper)));
            if(!appDirectory.Exists)
                appDirectory.Create();
            this.folderBrowserDialog1.InitialDirectory = appDirectory.FullName;
        }

        private void BackgroundFillCheckBox_CheckedChanged(object sender, EventArgs e) => RefreshPreview();

        private void TimePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

        private void TimeFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

        private void DatePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

        private void DateFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            var outputDirectory = new DirectoryInfo(OutputFolderTextbox.Text);
            if (!outputDirectory.Exists)
                outputDirectory.Create();

            var combinedDateTime = DatePicker.Value.Date.Add(TimePicker.Value.TimeOfDay);
            var dateTimeFormatter = _dateTimeFormatterFactory.Create(DateFormatTextBox.Text, TimePicker.Checked, TimeFormatTextBox.Text);

            var imageFiles = new List<FileInfo>();

            var (isValid, errors) = _batchValidator.Validate(imageFiles, outputDirectory);

            if(!isValid)
            {
                StringBuilder msg = new(@"Please correct the following problems:

");
                errors.ForEach((error) => {
                    msg.AppendLine($"• {error}");
                });
                MessageBox.Show(msg.ToString(), "Problems", MessageBoxButtons.OK);
                return;
            }

            _batchProcessor.ProcessAsync(
                imageFiles,
                outputDirectory,
                ColorTextBox.BackColor,
                BackgroundFillCheckBox.Checked,
                FontTextBox.Font,
                UseExifCheckBox.Checked,
                combinedDateTime,
                dateTimeFormatter,
                _position,
                SizeTrackBar.Value
            ).GetAwaiter().GetResult();
        }

        private void FolderBrowseButton_Click(object sender, EventArgs e)
        {
            Func<string> dialogDelegate = () => {

                if (!folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
                    return string.Empty;

                return folderBrowserDialog1.SelectedPath;
            };

            var result  = StaDialogRunner(dialogDelegate, string.Empty);

            if (string.IsNullOrWhiteSpace(result)) return;
            OutputFolderTextbox.Text = result;
        }

        /// <summary>
        /// Some dialogs needs to be access in STA threads. This should be used for those.
        /// </summary>
        /// <param name="dialogDelegate"></param>
        /// <returns></returns>
        private T StaDialogRunner<T>(Func<T> dialogDelegate, T valueIn) 
        {
            T valueOut = valueIn;

            Thread thread = new(() => {
                valueOut = dialogDelegate.Invoke();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            return valueOut;
        }

    }
}
