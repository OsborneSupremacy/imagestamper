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
            this.label5 = new System.Windows.Forms.Label();
            this.SizeTrackBar = new System.Windows.Forms.TrackBar();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.PositionGroupBox = new System.Windows.Forms.GroupBox();
            this.YCenterRightButton = new System.Windows.Forms.RadioButton();
            this.BottomXCenterButton = new System.Windows.Forms.RadioButton();
            this.TopLeftButton = new System.Windows.Forms.RadioButton();
            this.BottomLeftButton = new System.Windows.Forms.RadioButton();
            this.TopXCenterButton = new System.Windows.Forms.RadioButton();
            this.BottomRightButton = new System.Windows.Forms.RadioButton();
            this.YCenterXCenterButton = new System.Windows.Forms.RadioButton();
            this.TopRight = new System.Windows.Forms.RadioButton();
            this.YCenterLeftButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.BackgroundFillCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewPictureBackGroundBox = new System.Windows.Forms.PictureBox();
            this.RefreshPreviewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            this.PositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBackGroundBox)).BeginInit();
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
            this.SelectFontButton.Location = new System.Drawing.Point(524, 221);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 0;
            this.SelectFontButton.Text = "Font";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // FontTextBox
            // 
            this.FontTextBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FontTextBox.Location = new System.Drawing.Point(605, 222);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.Location = new System.Drawing.Point(605, 278);
            this.SizeTrackBar.Maximum = 100;
            this.SizeTrackBar.Minimum = 1;
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(274, 45);
            this.SizeTrackBar.TabIndex = 15;
            this.SizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SizeTrackBar.Value = 20;
            this.SizeTrackBar.Scroll += new System.EventHandler(this.SizeTrackBar_Scroll);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(605, 249);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(274, 23);
            this.SizeTextBox.TabIndex = 16;
            this.SizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PositionGroupBox
            // 
            this.PositionGroupBox.Controls.Add(this.YCenterRightButton);
            this.PositionGroupBox.Controls.Add(this.BottomXCenterButton);
            this.PositionGroupBox.Controls.Add(this.TopLeftButton);
            this.PositionGroupBox.Controls.Add(this.BottomLeftButton);
            this.PositionGroupBox.Controls.Add(this.TopXCenterButton);
            this.PositionGroupBox.Controls.Add(this.BottomRightButton);
            this.PositionGroupBox.Controls.Add(this.YCenterXCenterButton);
            this.PositionGroupBox.Controls.Add(this.TopRight);
            this.PositionGroupBox.Controls.Add(this.YCenterLeftButton);
            this.PositionGroupBox.Location = new System.Drawing.Point(605, 315);
            this.PositionGroupBox.Name = "PositionGroupBox";
            this.PositionGroupBox.Size = new System.Drawing.Size(274, 112);
            this.PositionGroupBox.TabIndex = 18;
            this.PositionGroupBox.TabStop = false;
            // 
            // YCenterRightButton
            // 
            this.YCenterRightButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.YCenterRightButton.Location = new System.Drawing.Point(183, 47);
            this.YCenterRightButton.Name = "YCenterRightButton";
            this.YCenterRightButton.Size = new System.Drawing.Size(80, 25);
            this.YCenterRightButton.TabIndex = 28;
            this.YCenterRightButton.Text = "                     ";
            this.YCenterRightButton.UseVisualStyleBackColor = true;
            this.YCenterRightButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // BottomXCenterButton
            // 
            this.BottomXCenterButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BottomXCenterButton.Location = new System.Drawing.Point(97, 78);
            this.BottomXCenterButton.Name = "BottomXCenterButton";
            this.BottomXCenterButton.Size = new System.Drawing.Size(80, 25);
            this.BottomXCenterButton.TabIndex = 27;
            this.BottomXCenterButton.Text = "                     ";
            this.BottomXCenterButton.UseVisualStyleBackColor = true;
            this.BottomXCenterButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // TopLeftButton
            // 
            this.TopLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TopLeftButton.Location = new System.Drawing.Point(11, 16);
            this.TopLeftButton.Name = "TopLeftButton";
            this.TopLeftButton.Size = new System.Drawing.Size(80, 25);
            this.TopLeftButton.TabIndex = 20;
            this.TopLeftButton.Text = "                     ";
            this.TopLeftButton.UseVisualStyleBackColor = true;
            this.TopLeftButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // BottomLeftButton
            // 
            this.BottomLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BottomLeftButton.Location = new System.Drawing.Point(11, 78);
            this.BottomLeftButton.Name = "BottomLeftButton";
            this.BottomLeftButton.Size = new System.Drawing.Size(80, 25);
            this.BottomLeftButton.TabIndex = 26;
            this.BottomLeftButton.Text = "                     ";
            this.BottomLeftButton.UseVisualStyleBackColor = true;
            this.BottomLeftButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // TopXCenterButton
            // 
            this.TopXCenterButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TopXCenterButton.Location = new System.Drawing.Point(97, 16);
            this.TopXCenterButton.Name = "TopXCenterButton";
            this.TopXCenterButton.Size = new System.Drawing.Size(80, 25);
            this.TopXCenterButton.TabIndex = 21;
            this.TopXCenterButton.Text = "                     ";
            this.TopXCenterButton.UseVisualStyleBackColor = true;
            this.TopXCenterButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // BottomRightButton
            // 
            this.BottomRightButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BottomRightButton.Checked = true;
            this.BottomRightButton.Location = new System.Drawing.Point(184, 78);
            this.BottomRightButton.Name = "BottomRightButton";
            this.BottomRightButton.Size = new System.Drawing.Size(80, 25);
            this.BottomRightButton.TabIndex = 24;
            this.BottomRightButton.TabStop = true;
            this.BottomRightButton.Text = "                     ";
            this.BottomRightButton.UseVisualStyleBackColor = true;
            this.BottomRightButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // YCenterXCenterButton
            // 
            this.YCenterXCenterButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.YCenterXCenterButton.Location = new System.Drawing.Point(97, 47);
            this.YCenterXCenterButton.Name = "YCenterXCenterButton";
            this.YCenterXCenterButton.Size = new System.Drawing.Size(80, 25);
            this.YCenterXCenterButton.TabIndex = 25;
            this.YCenterXCenterButton.Text = "                     ";
            this.YCenterXCenterButton.UseVisualStyleBackColor = true;
            this.YCenterXCenterButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // TopRight
            // 
            this.TopRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.TopRight.Location = new System.Drawing.Point(183, 16);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(80, 25);
            this.TopRight.TabIndex = 22;
            this.TopRight.Text = "                     ";
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // YCenterLeftButton
            // 
            this.YCenterLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.YCenterLeftButton.Location = new System.Drawing.Point(11, 47);
            this.YCenterLeftButton.Name = "YCenterLeftButton";
            this.YCenterLeftButton.Size = new System.Drawing.Size(80, 25);
            this.YCenterLeftButton.TabIndex = 23;
            this.YCenterLeftButton.Text = "                     ";
            this.YCenterLeftButton.UseVisualStyleBackColor = true;
            this.YCenterLeftButton.CheckedChanged += new System.EventHandler(this.PositionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Position";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackgroundFillCheckBox
            // 
            this.BackgroundFillCheckBox.AutoSize = true;
            this.BackgroundFillCheckBox.Location = new System.Drawing.Point(605, 197);
            this.BackgroundFillCheckBox.Name = "BackgroundFillCheckBox";
            this.BackgroundFillCheckBox.Size = new System.Drawing.Size(108, 19);
            this.BackgroundFillCheckBox.TabIndex = 20;
            this.BackgroundFillCheckBox.Text = "Background Fill";
            this.BackgroundFillCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreviewPictureBackGroundBox
            // 
            this.PreviewPictureBackGroundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPictureBackGroundBox.Image = global::ImageStamper.Client.Properties.Resources.IMG_3192;
            this.PreviewPictureBackGroundBox.Location = new System.Drawing.Point(494, 445);
            this.PreviewPictureBackGroundBox.Name = "PreviewPictureBackGroundBox";
            this.PreviewPictureBackGroundBox.Size = new System.Drawing.Size(385, 69);
            this.PreviewPictureBackGroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewPictureBackGroundBox.TabIndex = 21;
            this.PreviewPictureBackGroundBox.TabStop = false;
            // 
            // RefreshPreviewButton
            // 
            this.RefreshPreviewButton.Location = new System.Drawing.Point(494, 520);
            this.RefreshPreviewButton.Name = "RefreshPreviewButton";
            this.RefreshPreviewButton.Size = new System.Drawing.Size(385, 23);
            this.RefreshPreviewButton.TabIndex = 23;
            this.RefreshPreviewButton.Text = "Refresh Stamp Style Preview";
            this.RefreshPreviewButton.UseVisualStyleBackColor = true;
            this.RefreshPreviewButton.Click += new System.EventHandler(this.RefreshPreviewButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(891, 555);
            this.Controls.Add(this.RefreshPreviewButton);
            this.Controls.Add(this.PreviewPictureBackGroundBox);
            this.Controls.Add(this.BackgroundFillCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PositionGroupBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.SizeTrackBar);
            this.Controls.Add(this.label5);
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
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image Stamper";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            this.PositionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBackGroundBox)).EndInit();
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
        private Label label5;
        private TrackBar SizeTrackBar;
        private TextBox SizeTextBox;
        private GroupBox PositionGroupBox;
        private Label label6;
        private RadioButton TopLeftButton;
        private RadioButton YCenterRightButton;
        private RadioButton BottomXCenterButton;
        private RadioButton BottomLeftButton;
        private RadioButton TopXCenterButton;
        private RadioButton BottomRightButton;
        private RadioButton YCenterXCenterButton;
        private RadioButton TopRight;
        private RadioButton YCenterLeftButton;
        private CheckBox BackgroundFillCheckBox;
        private PictureBox PreviewPictureBackGroundBox;
        private Button RefreshPreviewButton;
    }
}