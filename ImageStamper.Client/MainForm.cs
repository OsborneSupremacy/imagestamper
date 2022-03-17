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

        private Font _selectedFont = new Font("Arial Narrow", 1);

        public MainForm(Processor processor)
        {
            this._processor = processor ?? throw new ArgumentNullException(nameof(processor));
            InitializeComponent();
            SetFontName(_selectedFont);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            switch(fontDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    SetFontName(fontDialog1.Font);
                    break;
                default:
                    return;
            }
        }

        private void SetFontName(Font font)
        {
            _selectedFont = font;
            FontTextBox.Text = $"{font.Name} {font.Style}";
        }
    }
}
