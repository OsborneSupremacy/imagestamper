using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageStamper.Service;


namespace ImageStamper.Client
{
    public partial class MainForm : Form
    {
        private readonly Processor _processor;

        public MainForm(Processor processor)
        {
            this._processor = processor ?? throw new ArgumentNullException(nameof(processor));
            InitializeComponent();

            SetFont(FontTextBox.Font); // doing this so that the displayed name is consistent with the font
            SetSizeText();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            switch(fontDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    SetFont(fontDialog1.Font);
                    break;
                default:
                    return;
            }
        }

        private void SetFont(Font font)
        {
            FontTextBox.Font = font;
            FontTextBox.Text = $"{font.Name} {font.Style}";
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            switch(colorDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    SetColor(colorDialog1.Color);
                    break;
                default:
                    return;
            }
        }

        private void SetColor(Color color)
        {
            ColorTextBox.BackColor = color;
        }

        private void SizeTrackBar_Scroll(object sender, EventArgs e) => 
            SetSizeText(((TrackBar)sender).Value);

        private void SetSizeText() =>
            SetSizeText(SizeTrackBar.Value);

        private void SetSizeText(int size) => 
            SizeTextBox.Text = $"{size}% of image's longest side";
    }
}
