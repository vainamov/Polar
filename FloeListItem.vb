Public Class FloeListItem

    Public Event Download(ByVal FilePath As String)

    Dim _author As String = "Demo"
    Dim _identifier As String = "floe:author:Demo:set:Demo"
    Dim _setname As String = "Demo"

    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            _author = value
            Label1.Text = _setname & " by " & _author
            Identifier = "floe:author:" & _author & ":set:" & _setname
        End Set
    End Property

    Public Property Setname As String
        Get
            Return _setname
        End Get
        Set(value As String)
            _setname = value
            Label1.Text = _setname & " by " & _author
            Identifier = "floe:author:" & _author & ":set:" & _setname
        End Set
    End Property

    Public Property Identifier As String
        Get
            Return _identifier
        End Get
        Set(value As String)
            _identifier = value
            Label2.Text = _identifier
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent Download(String.Format("http://floe.festival.square7.de/{0}_{1}.pcs", Author, Setname))
    End Sub

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

End Class
