Public Class ColorListEntry

    Public Event EntryClick(sender As ColorListEntry)

    Public Property HexCode As String
        Get
            Return ColorTranslator.ToHtml(BackColor)
        End Get
        Set(value As String)
            BackColor = ColorTranslator.FromHtml(value)
            Description = Description
        End Set
    End Property

    Public Property RgbCode As String
        Get
            Return String.Format("{0}; {1}; {2}", BackColor.R.ToString, BackColor.G.ToString, BackColor.B.ToString)
        End Get
        Set(value As String)
            BackColor = Color.FromArgb(Integer.Parse(value.Split(";"c)(0).Trim(" "c)), Integer.Parse(value.Split(";"c)(1).Trim(" "c)), Integer.Parse(value.Split(";"c)(2).Trim(" "c)))
            Description = Description
        End Set
    End Property

    Public Property HsbCode As String
        Get
            Return String.Format("{0}; {1}; {2}", BackColor.GetHue.ToString, BackColor.GetSaturation.ToString, BackColor.GetBrightness.ToString)
        End Get
        Private Set(value As String)

        End Set
    End Property

    Public Property Description As String
        Get
            Return DescriptionLabel.Text.Split("("c)(0).TrimEnd(" "c)
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                DescriptionLabel.Text = HexCode
            Else
                DescriptionLabel.Text = String.Format("{0} ({1})", value, HexCode)
            End If
        End Set
    End Property

    Private Sub ColorListEntry_Click(sender As Object, e As EventArgs) Handles Me.Click
        RaiseEvent EntryClick(Me)
    End Sub

    Private Sub DescriptionLabel_Click(sender As Object, e As EventArgs) Handles DescriptionLabel.Click
        RaiseEvent EntryClick(Me)
    End Sub

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Sub New(ByVal Colorcode As String, Optional ByVal Description As String = "")
        InitializeComponent()
        Me.HexCode = Colorcode
        Me.Description = Description
    End Sub

End Class
