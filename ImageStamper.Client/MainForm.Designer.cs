using ImageStamper.Service;
using System.ComponentModel;

namespace ImageStamper.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SelectFontButton = new System.Windows.Forms.Button();
            this.FontTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontDialog1.MaxSize = 1;
            this.fontDialog1.MinSize = 1;
            // 
            // SelectFontButton
            // 
            this.SelectFontButton.Location = new System.Drawing.Point(405, 206);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 0;
            this.SelectFontButton.Text = "Font";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // FontTextBox
            // 
            this.FontTextBox.Location = new System.Drawing.Point(486, 207);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.ReadOnly = true;
            this.FontTextBox.Size = new System.Drawing.Size(274, 23);
            this.FontTextBox.TabIndex = 1;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(486, 178);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.ReadOnly = true;
            this.ColorTextBox.Size = new System.Drawing.Size(274, 23);
            this.ColorTextBox.TabIndex = 2;
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.Location = new System.Drawing.Point(405, 177);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(75, 23);
            this.SelectColorButton.TabIndex = 3;
            this.SelectColorButton.Text = "Color";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(486, 12);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(274, 23);
            this.DatePicker.TabIndex = 4;
            // 
            // TimePicker
            // 
            this.TimePicker.Checked = false;
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(486, 41);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowCheckBox = true;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(274, 23);
            this.TimePicker.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.SelectColorButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.FontTextBox);
            this.Controls.Add(this.SelectFontButton);
            this.Name = "MainForm";
            this.Text = "Image Stamper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontDialog fontDialog1;
        private Button SelectFontButton;
        private TextBox FontTextBox;
        private TextBox ColorTextBox;
        private Button SelectColorButton;
        private ColorDialog colorDialog1;
        private DateTimePicker DatePicker;
        private DateTimePicker TimePicker;
    }
}