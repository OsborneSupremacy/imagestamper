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

        private Font _selectedFont = new("Arial Narrow", 1);

        private Color _selectedColor = Color.Yellow;

        public MainForm(Processor processor)
        {
            this._processor = processor ?? throw new ArgumentNullException(nameof(processor));
            InitializeComponent();

            SetFont(_selectedFont);
            SetColor(_selectedColor);
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
            _selectedFont = font;
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
            _selectedColor = color;
            ColorTextBox.Text = color.Name;
        }

    }
}
