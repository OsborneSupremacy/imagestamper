<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateToStampDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateFormatTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FontTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.UsedExifDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToProcessList = New System.Windows.Forms.ListBox()
        Me.AddImagesButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TimeFormatTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OutputFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddFolderButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TimeToStampDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StampSizeInput = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StampPositionGroupBox = New System.Windows.Forms.GroupBox()
        Me.LowerRightRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpperLeftRadioButton = New System.Windows.Forms.RadioButton()
        Me.MiddleRightRadioButton = New System.Windows.Forms.RadioButton()
        Me.MiddleLeftRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpperRightRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerLeftRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerMiddleRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpperMiddleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MiddleMiddleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NewTempFolderButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PreviewPictureBackGroundBox = New System.Windows.Forms.PictureBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.ColorSelectButton = New System.Windows.Forms.Button()
        Me.ColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontSelectButton = New System.Windows.Forms.Button()
        Me.BackgroundFillCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.StampSizeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StampPositionGroupBox.SuspendLayout()
        CType(Me.PreviewPictureBackGroundBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Stamp Images"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateToStampDatePicker
        '
        Me.DateToStampDatePicker.Location = New System.Drawing.Point(633, 37)
        Me.DateToStampDatePicker.Name = "DateToStampDatePicker"
        Me.DateToStampDatePicker.Size = New System.Drawing.Size(257, 20)
        Me.DateToStampDatePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Files to Process:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Stamp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(506, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Format:"
        '
        'DateFormatTextBox
        '
        Me.DateFormatTextBox.Location = New System.Drawing.Point(633, 63)
        Me.DateFormatTextBox.Name = "DateFormatTextBox"
        Me.DateFormatTextBox.Size = New System.Drawing.Size(257, 20)
        Me.DateFormatTextBox.TabIndex = 6
        Me.DateFormatTextBox.Text = "MM/dd/yyyy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(506, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Font:"
        '
        'FontTextBox
        '
        Me.FontTextBox.Location = New System.Drawing.Point(633, 195)
        Me.FontTextBox.Name = "FontTextBox"
        Me.FontTextBox.ReadOnly = True
        Me.FontTextBox.Size = New System.Drawing.Size(174, 20)
        Me.FontTextBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(506, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Stamp Size:"
        '
        'UsedExifDateCheckBox
        '
        Me.UsedExifDateCheckBox.AutoSize = True
        Me.UsedExifDateCheckBox.Location = New System.Drawing.Point(633, 141)
        Me.UsedExifDateCheckBox.Name = "UsedExifDateCheckBox"
        Me.UsedExifDateCheckBox.Size = New System.Drawing.Size(214, 17)
        Me.UsedExifDateCheckBox.TabIndex = 18
        Me.UsedExifDateCheckBox.Text = "Use Date/time from EXIF when possible"
        Me.UsedExifDateCheckBox.UseVisualStyleBackColor = True
        '
        'ToProcessList
        '
        Me.ToProcessList.AllowDrop = True
        Me.ToProcessList.FormattingEnabled = True
        Me.ToProcessList.Location = New System.Drawing.Point(19, 29)
        Me.ToProcessList.Name = "ToProcessList"
        Me.ToProcessList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ToProcessList.Size = New System.Drawing.Size(443, 160)
        Me.ToProcessList.TabIndex = 19
        '
        'AddImagesButton
        '
        Me.AddImagesButton.Location = New System.Drawing.Point(19, 195)
        Me.AddImagesButton.Name = "AddImagesButton"
        Me.AddImagesButton.Size = New System.Drawing.Size(150, 23)
        Me.AddImagesButton.TabIndex = 20
        Me.AddImagesButton.Text = "Add Images"
        Me.AddImagesButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(313, 195)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 23)
        Me.ClearButton.TabIndex = 21
        Me.ClearButton.Text = "Clear Selected"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(506, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Time Stamp:"
        '
        'TimeFormatTextBox
        '
        Me.TimeFormatTextBox.Location = New System.Drawing.Point(633, 115)
        Me.TimeFormatTextBox.Name = "TimeFormatTextBox"
        Me.TimeFormatTextBox.Size = New System.Drawing.Size(257, 20)
        Me.TimeFormatTextBox.TabIndex = 26
        Me.TimeFormatTextBox.Text = "hh:mm tt"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(506, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Time Format:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Output Folder:"
        '
        'OutputFolderTextBox
        '
        Me.OutputFolderTextBox.Location = New System.Drawing.Point(19, 293)
        Me.OutputFolderTextBox.Name = "OutputFolderTextBox"
        Me.OutputFolderTextBox.Size = New System.Drawing.Size(443, 20)
        Me.OutputFolderTextBox.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddFolderButton
        '
        Me.AddFolderButton.Location = New System.Drawing.Point(19, 224)
        Me.AddFolderButton.Name = "AddFolderButton"
        Me.AddFolderButton.Size = New System.Drawing.Size(150, 23)
        Me.AddFolderButton.TabIndex = 30
        Me.AddFolderButton.Text = "Add Folder"
        Me.AddFolderButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'TimeToStampDatePicker
        '
        Me.TimeToStampDatePicker.Checked = False
        Me.TimeToStampDatePicker.CustomFormat = "hh:mm tt"
        Me.TimeToStampDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeToStampDatePicker.Location = New System.Drawing.Point(633, 89)
        Me.TimeToStampDatePicker.Name = "TimeToStampDatePicker"
        Me.TimeToStampDatePicker.ShowCheckBox = True
        Me.TimeToStampDatePicker.ShowUpDown = True
        Me.TimeToStampDatePicker.Size = New System.Drawing.Size(257, 20)
        Me.TimeToStampDatePicker.TabIndex = 32
        Me.TimeToStampDatePicker.Value = New Date(2014, 12, 30, 9, 44, 42, 0)
        '
        'StampSizeInput
        '
        Me.StampSizeInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.StampSizeInput.DecimalPlaces = 2
        Me.StampSizeInput.Location = New System.Drawing.Point(633, 221)
        Me.StampSizeInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StampSizeInput.Name = "StampSizeInput"
        Me.StampSizeInput.Size = New System.Drawing.Size(82, 20)
        Me.StampSizeInput.TabIndex = 33
        Me.StampSizeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.StampSizeInput.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(721, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "% of image's longest side"
        '
        'StampPositionGroupBox
        '
        Me.StampPositionGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.StampPositionGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StampPositionGroupBox.Controls.Add(Me.LowerRightRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.UpperLeftRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.MiddleRightRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.MiddleLeftRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.UpperRightRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.LowerLeftRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.LowerMiddleRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.UpperMiddleRadioButton)
        Me.StampPositionGroupBox.Controls.Add(Me.MiddleMiddleRadioButton)
        Me.StampPositionGroupBox.Location = New System.Drawing.Point(633, 252)
        Me.StampPositionGroupBox.Name = "StampPositionGroupBox"
        Me.StampPositionGroupBox.Size = New System.Drawing.Size(267, 125)
        Me.StampPositionGroupBox.TabIndex = 36
        Me.StampPositionGroupBox.TabStop = False
        '
        'LowerRightRadioButton
        '
        Me.LowerRightRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.LowerRightRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.LowerRightRadioButton.Checked = True
        Me.LowerRightRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LowerRightRadioButton.Location = New System.Drawing.Point(180, 87)
        Me.LowerRightRadioButton.Name = "LowerRightRadioButton"
        Me.LowerRightRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.LowerRightRadioButton.TabIndex = 48
        Me.LowerRightRadioButton.TabStop = True
        Me.LowerRightRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LowerRightRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LowerRightRadioButton.UseVisualStyleBackColor = False
        '
        'UpperLeftRadioButton
        '
        Me.UpperLeftRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.UpperLeftRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpperLeftRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UpperLeftRadioButton.Location = New System.Drawing.Point(7, 15)
        Me.UpperLeftRadioButton.Name = "UpperLeftRadioButton"
        Me.UpperLeftRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.UpperLeftRadioButton.TabIndex = 40
        Me.UpperLeftRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpperLeftRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UpperLeftRadioButton.UseVisualStyleBackColor = False
        '
        'MiddleRightRadioButton
        '
        Me.MiddleRightRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.MiddleRightRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.MiddleRightRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MiddleRightRadioButton.Location = New System.Drawing.Point(180, 51)
        Me.MiddleRightRadioButton.Name = "MiddleRightRadioButton"
        Me.MiddleRightRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.MiddleRightRadioButton.TabIndex = 47
        Me.MiddleRightRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MiddleRightRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MiddleRightRadioButton.UseVisualStyleBackColor = False
        '
        'MiddleLeftRadioButton
        '
        Me.MiddleLeftRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.MiddleLeftRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.MiddleLeftRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MiddleLeftRadioButton.Location = New System.Drawing.Point(6, 51)
        Me.MiddleLeftRadioButton.Name = "MiddleLeftRadioButton"
        Me.MiddleLeftRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.MiddleLeftRadioButton.TabIndex = 41
        Me.MiddleLeftRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MiddleLeftRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MiddleLeftRadioButton.UseVisualStyleBackColor = False
        '
        'UpperRightRadioButton
        '
        Me.UpperRightRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.UpperRightRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpperRightRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UpperRightRadioButton.Location = New System.Drawing.Point(180, 15)
        Me.UpperRightRadioButton.Name = "UpperRightRadioButton"
        Me.UpperRightRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.UpperRightRadioButton.TabIndex = 46
        Me.UpperRightRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpperRightRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UpperRightRadioButton.UseVisualStyleBackColor = False
        '
        'LowerLeftRadioButton
        '
        Me.LowerLeftRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.LowerLeftRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.LowerLeftRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LowerLeftRadioButton.Location = New System.Drawing.Point(6, 87)
        Me.LowerLeftRadioButton.Name = "LowerLeftRadioButton"
        Me.LowerLeftRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.LowerLeftRadioButton.TabIndex = 42
        Me.LowerLeftRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LowerLeftRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LowerLeftRadioButton.UseVisualStyleBackColor = False
        '
        'LowerMiddleRadioButton
        '
        Me.LowerMiddleRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.LowerMiddleRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.LowerMiddleRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LowerMiddleRadioButton.Location = New System.Drawing.Point(93, 87)
        Me.LowerMiddleRadioButton.Name = "LowerMiddleRadioButton"
        Me.LowerMiddleRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.LowerMiddleRadioButton.TabIndex = 45
        Me.LowerMiddleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LowerMiddleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LowerMiddleRadioButton.UseVisualStyleBackColor = False
        '
        'UpperMiddleRadioButton
        '
        Me.UpperMiddleRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.UpperMiddleRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpperMiddleRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UpperMiddleRadioButton.Location = New System.Drawing.Point(93, 15)
        Me.UpperMiddleRadioButton.Name = "UpperMiddleRadioButton"
        Me.UpperMiddleRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.UpperMiddleRadioButton.TabIndex = 43
        Me.UpperMiddleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpperMiddleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UpperMiddleRadioButton.UseVisualStyleBackColor = False
        '
        'MiddleMiddleRadioButton
        '
        Me.MiddleMiddleRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.MiddleMiddleRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.MiddleMiddleRadioButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MiddleMiddleRadioButton.Location = New System.Drawing.Point(93, 51)
        Me.MiddleMiddleRadioButton.Name = "MiddleMiddleRadioButton"
        Me.MiddleMiddleRadioButton.Size = New System.Drawing.Size(81, 30)
        Me.MiddleMiddleRadioButton.TabIndex = 44
        Me.MiddleMiddleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MiddleMiddleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MiddleMiddleRadioButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(506, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Stamp Position:"
        '
        'NewTempFolderButton
        '
        Me.NewTempFolderButton.Location = New System.Drawing.Point(312, 319)
        Me.NewTempFolderButton.Name = "NewTempFolderButton"
        Me.NewTempFolderButton.Size = New System.Drawing.Size(150, 23)
        Me.NewTempFolderButton.TabIndex = 38
        Me.NewTempFolderButton.Text = "New Temp Folder"
        Me.NewTempFolderButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(313, 224)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(150, 23)
        Me.ClearAllButton.TabIndex = 39
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(506, 427)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Stamp Style Preview:"
        '
        'PreviewPictureBackGroundBox
        '
        Me.PreviewPictureBackGroundBox.BackgroundImage = Global.ImageStamper.My.Resources.Resources.IMG_3192
        Me.PreviewPictureBackGroundBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviewPictureBackGroundBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PreviewPictureBackGroundBox.Location = New System.Drawing.Point(509, 443)
        Me.PreviewPictureBackGroundBox.Name = "PreviewPictureBackGroundBox"
        Me.PreviewPictureBackGroundBox.Size = New System.Drawing.Size(385, 69)
        Me.PreviewPictureBackGroundBox.TabIndex = 40
        Me.PreviewPictureBackGroundBox.TabStop = False
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(353, 486)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(150, 23)
        Me.RefreshButton.TabIndex = 42
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(506, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Color:"
        '
        'ColorTextBox
        '
        Me.ColorTextBox.Location = New System.Drawing.Point(633, 169)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.ReadOnly = True
        Me.ColorTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ColorTextBox.TabIndex = 44
        '
        'ColorSelectButton
        '
        Me.ColorSelectButton.Location = New System.Drawing.Point(813, 169)
        Me.ColorSelectButton.Name = "ColorSelectButton"
        Me.ColorSelectButton.Size = New System.Drawing.Size(77, 20)
        Me.ColorSelectButton.TabIndex = 45
        Me.ColorSelectButton.Text = "Select"
        Me.ColorSelectButton.UseVisualStyleBackColor = True
        '
        'ColorPictureBox
        '
        Me.ColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ColorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorPictureBox.Location = New System.Drawing.Point(769, 169)
        Me.ColorPictureBox.Name = "ColorPictureBox"
        Me.ColorPictureBox.Size = New System.Drawing.Size(38, 20)
        Me.ColorPictureBox.TabIndex = 46
        Me.ColorPictureBox.TabStop = False
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowScriptChange = False
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FontDialog1.FontMustExist = True
        Me.FontDialog1.MaxSize = 12
        Me.FontDialog1.MinSize = 12
        Me.FontDialog1.ShowEffects = False
        '
        'FontSelectButton
        '
        Me.FontSelectButton.Location = New System.Drawing.Point(813, 195)
        Me.FontSelectButton.Name = "FontSelectButton"
        Me.FontSelectButton.Size = New System.Drawing.Size(77, 20)
        Me.FontSelectButton.TabIndex = 47
        Me.FontSelectButton.Text = "Select"
        Me.FontSelectButton.UseVisualStyleBackColor = True
        '
        'BackgroundFillCheckBox
        '
        Me.BackgroundFillCheckBox.AutoSize = True
        Me.BackgroundFillCheckBox.Location = New System.Drawing.Point(633, 383)
        Me.BackgroundFillCheckBox.Name = "BackgroundFillCheckBox"
        Me.BackgroundFillCheckBox.Size = New System.Drawing.Size(99, 17)
        Me.BackgroundFillCheckBox.TabIndex = 49
        Me.BackgroundFillCheckBox.Text = "Background Fill"
        Me.BackgroundFillCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 522)
        Me.Controls.Add(Me.BackgroundFillCheckBox)
        Me.Controls.Add(Me.FontSelectButton)
        Me.Controls.Add(Me.ColorSelectButton)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.PreviewPictureBackGroundBox)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.NewTempFolderButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StampSizeInput)
        Me.Controls.Add(Me.TimeToStampDatePicker)
        Me.Controls.Add(Me.AddFolderButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.OutputFolderTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TimeFormatTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddImagesButton)
        Me.Controls.Add(Me.ToProcessList)
        Me.Controls.Add(Me.UsedExifDateCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FontTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateFormatTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateToStampDatePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StampPositionGroupBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ColorPictureBox)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Image Date Stamper"
        CType(Me.StampSizeInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StampPositionGroupBox.ResumeLayout(False)
        CType(Me.PreviewPictureBackGroundBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateToStampDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateFormatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FontTextBox As System.Windows.Forms.TextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UsedExifDateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToProcessList As System.Windows.Forms.ListBox
    Friend WithEvents AddImagesButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TimeFormatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OutputFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AddFolderButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TimeToStampDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StampSizeInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StampPositionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NewTempFolderButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents UpperLeftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MiddleLeftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LowerLeftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LowerMiddleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MiddleMiddleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents UpperMiddleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LowerRightRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MiddleRightRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents UpperRightRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PreviewPictureBackGroundBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorSelectButton As System.Windows.Forms.Button
    Friend WithEvents ColorPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents FontSelectButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundFillCheckBox As CheckBox
End Class
