Public Class FloeListItem

    Public Event Download(ByVal FilePath As String, ByVal Setname As String)

    Dim _author As String = "Demo"
    Dim _identifier As String = "floe:author:Demo:set:Demo"
    Dim _setname As String = "Demo"

    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            _author = value
            lbl_info.Text = _setname & " by " & _author
            Identifier = "floe:author:" & _author & ":set:" & _setname
        End Set
    End Property

    Public Property Setname As String
        Get
            Return _setname
        End Get
        Set(value As String)
            _setname = value
            lbl_info.Text = _setname & " by " & _author
            Identifier = "floe:author:" & _author & ":set:" & _setname
        End Set
    End Property

    Public Property Identifier As String
        Get
            Return _identifier
        End Get
        Set(value As String)
            _identifier = value
            lbl_identifier.Text = _identifier
        End Set
    End Property

    Public Sub DefinePreviewColors(ByVal Colors As List(Of Color))
        Try
            pnl_color1.BackColor = Colors(0)
            pnl_color2.BackColor = Colors(1)
            pnl_color3.BackColor = Colors(2)
            pnl_color4.BackColor = Colors(3)
            pnl_color5.BackColor = Colors(4)
            pnl_color6.BackColor = Colors(5)
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent Download(String.Format("http://floe.festival.square7.de/{0}_{1}.pcs", Author, Setname), Setname)
    End Sub

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnl_color1.Visible = Not pnl_color1.Visible
        pnl_color2.Visible = Not pnl_color2.Visible
        pnl_color3.Visible = Not pnl_color3.Visible
        pnl_color4.Visible = Not pnl_color4.Visible
        pnl_color5.Visible = Not pnl_color5.Visible
        pnl_color6.Visible = Not pnl_color6.Visible
        lbl_info.Visible = Not lbl_info.Visible
        lbl_identifier.Visible = Not lbl_identifier.Visible
    End Sub

End Class
