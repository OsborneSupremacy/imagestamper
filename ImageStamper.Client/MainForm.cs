using ImageStamper.Objects;
using ImageStamper.Service;

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
            var dateTimeFormatter = _dateTimeFormatterFactory.Create(DateFormatTextBox.Text, TimePicker.Checked, TimeFormatTextBox.Text);

            Bitmap preview = _processor
                .Process(
                    Properties.Resources.IMG_3192,
                    ColorTextBox.BackColor,
                    BackgroundFillCheckBox.Checked,
                    FontTextBox.Font,
                    dateTimeFormatter.Invoke(DatePicker.Value, TimePicker.Value),
                    PositionConstants.YCenterXCenter,
                    50
                );

            PreviewPictureBackGroundBox.Image = preview;
            PreviewPictureBackGroundBox.Refresh();
        }

        private void BackgroundFillCheckBox_CheckedChanged(object sender, EventArgs e) => RefreshPreview();

        private void TimePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

        private void TimeFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

        private void DatePicker_ValueChanged(object sender, EventArgs e) => RefreshPreview();

        private void DateFormatTextBox_Leave(object sender, EventArgs e) => RefreshPreview();

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
