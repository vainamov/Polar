Imports System.Net
Imports System.Reflection

Public Class DownloadFromFloe

    Private WithEvents FLI As FloeListItem
    Private FloeListItems As New List(Of FloeListItem)

    Public Event DownloadFinished(ByVal Path As String)

    Sub Add(ByVal Filename As String, ByVal Colors As List(Of Color))
        Dim tFLI As New FloeListItem
        tFLI.Author = Filename.Split("."c)(0).Split("_"c)(0)
        tFLI.Setname = Filename.Split("."c)(0).Split("_"c)(1)
        tFLI.DefinePreviewColors(Colors)
        tFLI.Dock = DockStyle.Top
        FLI = tFLI
        AddHandler FLI.Download, AddressOf Download
        FloeListItems.Add(FLI)
        Panel2.Controls.Add(FLI)
    End Sub

    Sub Download(ByVal Path As String, ByVal Setname As String)
        Dim WC As WebClient = New WebClient()
        Dim content As String = WC.DownloadString(Path)
        Using SFD As New SaveFileDialog With {.Filter = "Polar-Colorsets (*.pcs)|*.pcs", .Title = "Save", .FileName = Setname}
            If SFD.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(SFD.FileName, content)
                'Dim dcd As New DownloadCompletedDialog
                'dcd.Path = SFD.FileName
                'If dcd.ShowDialog() = DialogResult.Yes Then
                '    RaiseEvent DownloadFinished(SFD.FileName)
                'End If
            End If
        End Using
    End Sub

    Private Sub Search(ByVal SearchString As String)
        Label1.Text = "Results for """ & SearchString & """."
        Dim Query = From Entry As FloeListItem In FloeListItems Where Entry.Author.ToLower.Contains(SearchString.ToLower) OrElse Entry.Setname.ToLower.Contains(SearchString.ToLower) OrElse Entry.Identifier.ToLower.Contains(SearchString.ToLower) Select Entry
        Panel2.Controls.Clear()
        For Each E As FloeListItem In Query
            Panel2.Controls.Add(E)
        Next
    End Sub

    Private Sub CancelSearch()
        Label1.Text = "Search by identifier, name or author."
        Panel2.Controls.Clear()
        For Each E As FloeListItem In FloeListItems
            Panel2.Controls.Add(E)
        Next
    End Sub

    Private Sub SearchTextbox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextbox.TextChanged
        If SearchTextbox.Text = "" Then
            CancelSearch()
        Else
            Search(SearchTextbox.Text)
        End If
    End Sub

    Private Sub DownloadFromFloe_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim WC As New WebClient
        Dim content As String = WC.DownloadString("http://fdev.markab.uberspace.de/proj/floe/floe_list.php")
        For Each Item As String In content.Split("|"c)
            If Not Item = "floe:list" Then
                Dim WC2 As New WebClient
                Dim content2 As String = WC2.DownloadString("http://fdev.markab.uberspace.de/proj/floe/" & Item)
                Dim colors As New List(Of Color)
                For i As Integer = 2 To 8
                    Try
                        colors.Add(ColorTranslator.FromHtml(content2.Split(vbCrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)(i).Split("="c)(1)))
                    Catch
                    End Try
                Next
                Add(Item, colors)
            End If
        Next
    End Sub

    Private Sub SearchTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextbox.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    For Each FLI As FloeListItem In Panel2.Controls
                        FLI.Preview()
                    Next
            End Select
        End If
    End Sub

End Class