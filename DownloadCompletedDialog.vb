Public Class DownloadCompletedDialog

    Dim _filepath As String = ""

    Public Property Path As String
        Get
            Return _filepath
        End Get
        Set(value As String)
            _filepath = value
            TextBox1.Text = _filepath
        End Set
    End Property

    Private Sub btn_dir_Click(sender As Object, e As EventArgs) Handles btn_dir.Click
        Process.Start(Path.Replace("\" & Path.Split("\"c).Last, ""))
    End Sub

End Class