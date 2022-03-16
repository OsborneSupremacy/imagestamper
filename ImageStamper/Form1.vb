Imports System.IO
Public Class Form1

    Protected TheDefaultColor As Color = Color.Yellow
    Protected TheDefaultFont As Font = New Font("Arial Narrow", 12)

    Private Function TempFolderName() As String
        Return Path.Combine(Path.GetTempPath, My.Application.Info.AssemblyName, Now.ToString("yyyy-MM-dd_HHmm-ssff"))
    End Function

    Protected Enum ItemTypeConstants
        File
        Folder
        DoesNotExist
    End Enum

    Protected Shared Function IsFileOrFolder(ThePath As String) As ItemTypeConstants
        If File.Exists(ThePath) Then Return ItemTypeConstants.File
        If Directory.Exists(ThePath) Then Return ItemTypeConstants.Folder
        Return ItemTypeConstants.DoesNotExist
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim StampPosition As ImageStamperClass.StampPositionConstants = GetPosition()
        Dim DateToStamp As DateTime = GetDateToStamp()
        Dim DateFormat As String = GetDateFormat()

        Dim OutputFolder As String = Me.OutputFolderTextBox.Text

        If Directory.Exists(OutputFolder) Then
            Select Case MsgBox(String.Format("{0} exists.  Delete it?", OutputFolder), vbYesNoCancel)
                Case MsgBoxResult.Cancel, MsgBoxResult.No
                    Exit Sub
                Case MsgBoxResult.Yes, MsgBoxResult.Ok
                    Directory.Delete(OutputFolder, True)
            End Select
        End If

        If Not Directory.Exists(OutputFolder) Then Directory.CreateDirectory(OutputFolder)

        Dim fi As FileInfo = Nothing
        Dim x As Integer = 0

        While x < Me.ToProcessList.Items.Count
            fi = New FileInfo(Me.ToProcessList.Items(x))
            ImageStamperClass.ProcessImageAndSave(fi.FullName, String.Format("{0}\{1}", OutputFolder, fi.Name), GetDateStampString, DateFormat, Me.FontTextBox.Text, Me.ColorTextBox.Text, Me.StampSizeInput.Value / 100.0, Me.UsedExifDateCheckBox.Checked, StampPosition, Me.BackgroundFillCheckBox.Checked)
            x += 1
        End While

        MsgBox(String.Format("{0} Images stamped", x), vbExclamation)
        Process.Start(OutputFolder)

    End Sub

    Public Sub Init()

        Me.OutputFolderTextBox.Text = TempFolderName()

        Me.FontDialog1.Font = TheDefaultFont
        Me.FontTextBox.Text = Me.FontDialog1.Font.Name

        Me.ColorDialog1.Color = TheDefaultColor
        Me.ColorTextBox.Text = TheDefaultColor.Name
        Me.ColorPictureBox.BackColor = TheDefaultColor


        DrawPreview()

    End Sub

    Private Sub ToProcessList_DragDrop(sender As Object, e As DragEventArgs) Handles ToProcessList.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim FilePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            For Each f As String In FilePaths

                Select Case IsFileOrFolder(f)
                    Case ItemTypeConstants.File
                        If ImageStamperClass.IsValidImageFile(f) Then Me.ToProcessList.Items.Add(f)

                    Case ItemTypeConstants.Folder
                        IdentifyImages(f)

                End Select

            Next

        End If

    End Sub

    Private Sub IdentifyImages(TheDirectory As String)

        For Each f As String In Directory.GetFiles(TheDirectory)
            Select Case IsFileOrFolder(f)
                Case ItemTypeConstants.File
                    If ImageStamperClass.IsValidImageFile(f) Then Me.ToProcessList.Items.Add(f)
                Case ItemTypeConstants.Folder
                    IdentifyImages(f)
            End Select
        Next

    End Sub

    Private Sub ToProcessList_DragEnter(sender As Object, e As DragEventArgs) Handles ToProcessList.DragEnter

        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        Dim x As Integer = Me.ToProcessList.SelectedItems.Count
        While x >= 1
            Me.ToProcessList.Items.Remove(Me.ToProcessList.SelectedItems(x - 1))
            x -= 1
        End While

    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        Me.ToProcessList.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FolderBrowserDialog1.ShowDialog()
        If Not Me.FolderBrowserDialog1.SelectedPath.Equals(String.Empty) Then Me.OutputFolderTextBox.Text = Me.FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub AddImagesButton_Click(sender As Object, e As EventArgs) Handles AddImagesButton.Click

        Me.OpenFileDialog1.FileName = String.Empty
        Me.OpenFileDialog1.ShowDialog()

        If Not Me.OpenFileDialog1.FileName.Equals(String.Empty) Then
            For Each f As String In Me.OpenFileDialog1.FileNames
                If ImageStamperClass.IsValidImageFile(f) Then Me.ToProcessList.Items.Add(f)
            Next
        End If

    End Sub

    Private Sub AddFolderButton_Click(sender As Object, e As EventArgs) Handles AddFolderButton.Click
        Me.FolderBrowserDialog1.ShowDialog()
        If Not Me.FolderBrowserDialog1.SelectedPath.Equals(String.Empty) Then Me.IdentifyImages(Me.FolderBrowserDialog1.SelectedPath)
    End Sub

    Private Function GetPosition() As ImageStamperClass.StampPositionConstants

        Dim result As ImageStamperClass.StampPositionConstants = ImageStamperClass.StampPositionConstants.LowerRight

        Dim PosName As String = String.Empty

        For Each cb As RadioButton In StampPositionGroupBox.Controls
            If cb.Checked Then
                PosName = cb.Name.Substring(0, cb.Name.ToLower.IndexOf("radiobutton"))
                result = System.Enum.Parse(GetType(ImageStamperClass.StampPositionConstants), PosName, True)
                Exit For
            End If
        Next

        Return result

    End Function

    Private Sub NewTempFolderButton_Click(sender As Object, e As EventArgs) Handles NewTempFolderButton.Click
        Me.OutputFolderTextBox.Text = TempFolderName()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        DrawPreview()
    End Sub

    Private Sub DrawPreview()

        Me.PreviewPictureBackGroundBox.BackgroundImage = ImageStamperClass.GeneratePreview(ImageStamper.My.Resources.IMG_3192, GetDateStampString, Me.FontTextBox.Text, Me.ColorTextBox.Text, Me.BackgroundFillCheckBox.CheckState)
        Me.PreviewPictureBackGroundBox.Refresh()

    End Sub

    Private Function GetDateStampString() As String

        Dim DateToStamp As DateTime = GetDateToStamp()
        Dim DateFormat As String = GetDateFormat()

        Return DateToStamp.ToString(DateFormat)

    End Function

    ''' <summary>
    ''' combine date and time from inputs
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDateToStamp() As DateTime

        Dim DateToStamp As DateTime = New Date(Me.DateToStampDatePicker.Value.Year, Me.DateToStampDatePicker.Value.Month, Me.DateToStampDatePicker.Value.Day)
        If Me.TimeToStampDatePicker.Checked Then
            DateToStamp += TimeToStampDatePicker.Value.TimeOfDay
        End If

        Return DateToStamp

    End Function

    ''' <summary>
    ''' combine date and time format from inputs
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDateFormat() As String

        Dim DateFormat As String = Me.DateFormatTextBox.Text
        If Me.TimeToStampDatePicker.Checked Then
            DateFormat += " " & Me.TimeFormatTextBox.Text
        End If

        Return DateFormat

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ColorSelectButton.Click, ColorPictureBox.Click
        Me.ColorDialog1.ShowDialog()
        If Not Me.ColorDialog1.Color.IsEmpty Then
            Me.ColorTextBox.Text = Me.ColorDialog1.Color.Name
            Me.ColorPictureBox.BackColor = Me.ColorDialog1.Color
        End If
        DrawPreview()
    End Sub

    Private Sub FontSelectButton_Click(sender As Object, e As EventArgs) Handles FontSelectButton.Click
        Me.FontDialog1.ShowDialog()
        Me.FontTextBox.Text = Me.FontDialog1.Font.Name
        DrawPreview()
    End Sub

End Class
