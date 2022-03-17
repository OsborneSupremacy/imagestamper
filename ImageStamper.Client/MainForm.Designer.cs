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
            this.DateFormatTextBox = new System.Windows.Forms.TextBox();
            this.TimeFormatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UseExifCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.FontMustExist = true;
            this.fontDialog1.MaxSize = 9;
            this.fontDialog1.MinSize = 9;
            // 
            // SelectFontButton
            // 
            this.SelectFontButton.Location = new System.Drawing.Point(524, 196);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 0;
            this.SelectFontButton.Text = "Font";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // FontTextBox
            // 
            this.FontTextBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontTextBox.Location = new System.Drawing.Point(605, 197);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.ReadOnly = true;
            this.FontTextBox.Size = new System.Drawing.Size(274, 21);
            this.FontTextBox.TabIndex = 1;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BackColor = System.Drawing.Color.Yellow;
            this.ColorTextBox.Location = new System.Drawing.Point(605, 168);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.ReadOnly = true;
            this.ColorTextBox.Size = new System.Drawing.Size(274, 23);
            this.ColorTextBox.TabIndex = 2;
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.Location = new System.Drawing.Point(524, 167);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(75, 23);
            this.SelectColorButton.TabIndex = 3;
            this.SelectColorButton.Text = "Color";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(605, 52);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(274, 23);
            this.DatePicker.TabIndex = 4;
            // 
            // TimePicker
            // 
            this.TimePicker.Checked = false;
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(605, 110);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowCheckBox = true;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(274, 23);
            this.TimePicker.TabIndex = 5;
            // 
            // DateFormatTextBox
            // 
            this.DateFormatTextBox.Location = new System.Drawing.Point(605, 81);
            this.DateFormatTextBox.Name = "DateFormatTextBox";
            this.DateFormatTextBox.Size = new System.Drawing.Size(274, 23);
            this.DateFormatTextBox.TabIndex = 6;
            this.DateFormatTextBox.Text = "MM/dd/yyyy";
            // 
            // TimeFormatTextBox
            // 
            this.TimeFormatTextBox.Location = new System.Drawing.Point(605, 139);
            this.TimeFormatTextBox.Name = "TimeFormatTextBox";
            this.TimeFormatTextBox.Size = new System.Drawing.Size(274, 23);
            this.TimeFormatTextBox.TabIndex = 7;
            this.TimeFormatTextBox.Text = "hh:mm tt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Format";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time Format";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UseExifCheckBox
            // 
            this.UseExifCheckBox.AutoSize = true;
            this.UseExifCheckBox.Checked = true;
            this.UseExifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseExifCheckBox.Location = new System.Drawing.Point(605, 27);
            this.UseExifCheckBox.Name = "UseExifCheckBox";
            this.UseExifCheckBox.Size = new System.Drawing.Size(228, 19);
            this.UseExifCheckBox.TabIndex = 12;
            this.UseExifCheckBox.Text = "Use date/time from EXIF when present";
            this.UseExifCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.UseExifCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeFormatTextBox);
            this.Controls.Add(this.DateFormatTextBox);
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
        private TextBox DateFormatTextBox;
        private TextBox TimeFormatTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox UseExifCheckBox;
    }
}