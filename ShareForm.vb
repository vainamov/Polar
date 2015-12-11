Imports System.Net

Public Class ShareForm

    Public Property FilePathOnLocal As String
    Public Property FilePathOnServer As String
    Public Property SetName As String
        Get
            Return NameTextbox.Text
        End Get
        Set(value As String)
            NameTextbox.Text = value
        End Set
    End Property
    Public Property AuthorName As String
        Get
            Return AuthorTextbox.Text
        End Get
        Set(value As String)
            AuthorTextbox.Text = value
        End Set
    End Property

    Public Function UploadColorSet(ByVal Filepath As String) As Boolean
        Dim Response As String
        Using WC As New WebClient
            Dim responseArray As Byte()
            responseArray = WC.UploadFile("http://fdev.markab.uberspace.de/proj/floe/floe_upload.php", Filepath)
            Response = System.Text.Encoding.ASCII.GetString(responseArray)
        End Using
        If Response = "error" Then
            Return False
        Else
            FilePathOnServer = Response
            Return True
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        System.IO.File.Copy(FilePathOnLocal, Environment.CurrentDirectory & "/" & AuthorTextbox.Text & "_" & NameTextbox.Text & ".pcs")
        If UploadColorSet(Environment.CurrentDirectory & "/" & AuthorTextbox.Text & "_" & NameTextbox.Text & ".pcs") Then
            System.IO.File.Delete(Environment.CurrentDirectory & "/" & AuthorTextbox.Text & "_" & NameTextbox.Text & ".pcs")
        Else
            FilePathOnServer = "error"
        End If
    End Sub

    Private Sub Textbox_TextChanged(sender As Object, e As EventArgs) Handles NameTextbox.TextChanged, AuthorTextbox.TextChanged
        NameTextbox.ForeColor = Color.Black
        AuthorTextbox.ForeColor = Color.Black
        Dim tOk As Boolean = True
        If Not String.IsNullOrEmpty(NameTextbox.Text) AndAlso Not String.IsNullOrEmpty(AuthorTextbox.Text) Then
            If NameTextbox.Text.Contains("/") OrElse NameTextbox.Text.Contains("\") OrElse NameTextbox.Text.Contains(" ") OrElse NameTextbox.Text.Contains(":") Then
                NameTextbox.ForeColor = Color.Red
                tOk = False
            End If
            If AuthorTextbox.Text.Contains("/") OrElse AuthorTextbox.Text.Contains("\") OrElse AuthorTextbox.Text.Contains(" ") OrElse AuthorTextbox.Text.Contains(":") Then
                AuthorTextbox.ForeColor = Color.Red
                tOk = False
            End If
            If tOk Then
                UploadButton.Enabled = True
            Else
                UploadButton.Enabled = False
            End If
        End If
    End Sub

End Class