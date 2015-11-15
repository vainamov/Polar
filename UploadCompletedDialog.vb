Public Class UploadCompletedDialog

    Public Property Identifier As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property

End Class