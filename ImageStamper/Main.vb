Module Main

    Public Sub Main(ByVal CmdArgs() As String)

        Using ThisForm As New Form1
            With ThisForm
                .Init()
                .ShowDialog()
                .Dispose()
            End With
        End Using

    End Sub

End Module
