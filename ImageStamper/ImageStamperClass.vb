Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Reflection

Public Class ImageStamperClass

    Const PadPixels As Integer = 2

    Public Enum StampPositionConstants
        UpperLeft
        UpperMiddle
        UpperRight
        MiddleLeft
        MiddleMiddle
        MiddleRight
        LowerLeft
        LowerMiddle
        LowerRight
    End Enum

    Public Shared Function IsValidImageFile(FilePath As String) As Boolean
        Dim fi As New FileInfo(FilePath)
        Dim ValidFileExtensions As String() = {".jpg", ".gif", ".png", ".bmp"}
        Return ValidFileExtensions.Contains(fi.Extension.ToLower)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="OriginalImagePath"></param>
    ''' <param name="NewImagePath"></param>
    ''' <param name="PhotoDate"></param>
    ''' <param name="DateFormat"></param>
    ''' <param name="FontFamily"></param>
    ''' <param name="FontColor"></param>
    ''' <param name="StampPercentOfImageSize">The % of the image size that the stamp should be</param>
    ''' <param name="UseExifDateIfPossible"></param>
    ''' <param name="StampPosition"></param>
    ''' <remarks></remarks>
    Public Shared Sub ProcessImageAndSave(
        OriginalImagePath As String,
        NewImagePath As String,
        PhotoDate As DateTime,
        DateFormat As String,
        FontFamily As String,
        FontColor As String,
        StampPercentOfImageSize As Double,
        UseExifDateIfPossible As Boolean,
        StampPosition As StampPositionConstants,
        BackgroundFill As Boolean
        )

        Dim TheStampDt As Date = #12:00:00 AM#
        If UseExifDateIfPossible Then TheStampDt = GetDateFromExifInfo(OriginalImagePath)
        If TheStampDt = #12:00:00 AM# Then TheStampDt = PhotoDate
        Dim TheStamp As String = TheStampDt.ToString(DateFormat).ToUpper()

        Using origBmp As New Bitmap(OriginalImagePath)
            Using newBmp As Bitmap = ProcessImage(origBmp, TheStamp, FontFamily, FontColor, StampPercentOfImageSize, StampPosition, BackgroundFill)
                If File.Exists(NewImagePath) Then File.Delete(NewImagePath)
                newBmp.Save(NewImagePath, ImageFormat.Jpeg)
            End Using
        End Using

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="OriginalBmp"></param>
    ''' <param name="TheStamp"></param>
    ''' <param name="FontFamily"></param>
    ''' <param name="FontColor"></param>
    ''' <param name="StampPercentOfImageSize"></param>
    ''' <param name="StampPosition">The % of the image size that the stamp should be</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ProcessImage(
        OriginalBmp As Bitmap,
        TheStamp As String,
        FontFamily As String,
        FontColor As String,
        StampPercentOfImageSize As Double,
        StampPosition As StampPositionConstants,
        BackgroundFill As Boolean
        ) As Bitmap

        Dim TheSolidBrush = GetSolidBrush(FontColor)

        Dim LongestSide As Double = OriginalBmp.Width
        If OriginalBmp.Height > OriginalBmp.Width Then LongestSide = OriginalBmp.Height

        'Font size is in "ems".  The logic below tries to create appropriate font sizes
        Dim FontSize As Integer = 1 'start the font size as 1 em.
        Dim TheFont As New Font(FontFamily, FontSize, FontStyle.Bold)

        Dim newBmp As Bitmap = OriginalBmp.Clone

        Using newGrphX As Graphics = Graphics.FromImage(newBmp)

            newGrphX.CompositingQuality = CompositingQuality.HighQuality
            newGrphX.SmoothingMode = SmoothingMode.HighQuality
            newGrphX.InterpolationMode = InterpolationMode.HighQualityBicubic

            Dim StampSize = newGrphX.MeasureString(TheStamp, TheFont)

            'keep increasing font until the stamp is x% of image's longest side
            Do Until StampSize.Width >= LongestSide * StampPercentOfImageSize
                FontSize += 1
                TheFont.Dispose()
                TheFont = New Font(FontFamily, FontSize, FontStyle.Bold)
                StampSize = newGrphX.MeasureString(TheStamp, TheFont)
            Loop

            Dim xLeft As Double = PadPixels
            Dim xCenter As Double = (OriginalBmp.Width / 2) - (StampSize.Width / 2)
            Dim xRight As Double = OriginalBmp.Width - (StampSize.Width + PadPixels)

            Dim yTop As Double = PadPixels
            Dim yMiddle As Double = (OriginalBmp.Height / 2) - (StampSize.Height / 2)
            Dim yBottom As Double = OriginalBmp.Height - (StampSize.Height + PadPixels)

            Dim xCoord As Integer
            Dim yCoord As Integer

            Select Case StampPosition
                Case StampPositionConstants.LowerLeft
                    xCoord = xLeft
                    yCoord = yBottom
                Case StampPositionConstants.LowerMiddle
                    xCoord = xCenter
                    yCoord = yBottom
                Case StampPositionConstants.LowerRight
                    xCoord = xRight
                    yCoord = yBottom
                Case StampPositionConstants.MiddleLeft
                    xCoord = xLeft
                    yCoord = yMiddle
                Case StampPositionConstants.MiddleMiddle
                    xCoord = xCenter
                    yCoord = yMiddle
                Case StampPositionConstants.MiddleRight
                    xCoord = xRight
                    yCoord = yMiddle
                Case StampPositionConstants.UpperLeft
                    xCoord = xLeft
                    yCoord = yTop
                Case StampPositionConstants.UpperMiddle
                    xCoord = xCenter
                    yCoord = yTop
                Case StampPositionConstants.UpperRight
                    xCoord = xRight
                    yCoord = yTop
                Case Else
                    Throw New ArgumentOutOfRangeException
            End Select

            If BackgroundFill Then
                newGrphX.FillRectangle(Brushes.Black, xCoord, yCoord, StampSize.Width - (PadPixels * 2), StampSize.Height - (PadPixels * 2))
            End If

            newGrphX.DrawString(TheStamp, TheFont, TheSolidBrush, xCoord, yCoord)

        End Using 'newGrphX

        Return newBmp

    End Function

    Protected Shared Function GetDateFromExifInfo(TheImagePath As String) As Date

        Dim result As Date = #12:00:00 AM#

        Using imgFile As New FileStream(TheImagePath, FileMode.Open, FileAccess.Read, FileShare.Read)

            Dim fileBytes(imgFile.Length) As Byte
            imgFile.Read(fileBytes, 0, fileBytes.Length)
            imgFile.Close()

            Using fileMs As New MemoryStream(fileBytes)
                Using targetImg As Image = Image.FromStream(fileMs)

                    Dim propItem As PropertyItem

                    Try
                        propItem = targetImg.GetPropertyItem(36867)
                    Catch ex As ArgumentException
                        Return result
                    End Try

                    Dim sDate As String = System.Text.Encoding.UTF8.GetString(propItem.Value).Trim
                    Dim SecondHalf As String = sDate.Substring(sDate.IndexOf(" "), (sDate.Length - sDate.IndexOf(" ")))
                    Dim FirstHalf As String = sDate.Substring(0, 10)
                    FirstHalf = FirstHalf.Replace(":", "-")
                    sDate = FirstHalf + SecondHalf

                    result = Date.Parse(sDate)

                End Using 'targetImg
            End Using 'fileMs
        End Using 'imgFile

        Return result

    End Function

    Public Shared Function GeneratePreview(
                                           origBmp As Bitmap,
                                           DateStampString As String,
                                           TheFontName As String,
                                           ColorName As String,
                                           BackgroundFill As Boolean
                                           ) As Bitmap

        Return ProcessImage(origBmp, DateStampString, TheFontName, ColorName, 0.75, StampPositionConstants.MiddleMiddle, BackgroundFill)

    End Function

    Public Shared Function GetSolidBrush(ColorName As String) As SolidBrush

        Dim TheBrushColor = Color.FromName(ColorName)

        If Not TheBrushColor.IsKnownColor Then
            If Not ColorName.Contains("#") Then ColorName = "#" & ColorName
            Dim ct = ColorTranslator.FromHtml(ColorName)
            TheBrushColor = ct
        End If

        Dim TheSolidBrush As New SolidBrush(TheBrushColor)

        Return TheSolidBrush

    End Function

End Class



