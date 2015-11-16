Imports System.Net
Imports System.Reflection

Public Class DownloadFromFloe

    Private WithEvents FLI As FloeListItem
    Private FloeListItems As New List(Of FloeListItem)

    Sub Add(ByVal Filename As String)
        Dim tFLI As New FloeListItem
        tFLI.Author = Filename.Split("."c)(0).Split("_"c)(0)
        tFLI.Setname = Filename.Split("."c)(0).Split("_"c)(1)
        tFLI.Dock = DockStyle.Top
        FLI = tFLI
        AddHandler FLI.Download, AddressOf Download
        FloeListItems.Add(FLI)
        Panel2.Controls.Add(FLI)
    End Sub

    Sub Download(ByVal Path As String)
        Dim WC As WebClient = New WebClient()
        Dim content As String = WC.DownloadString(Path)
        Using SFD As New SaveFileDialog With {.Filter = "Polar-Colorsets (*.pcs)|*.pcs", .Title = "Save"}
            If SFD.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(SFD.FileName, content)
                Dim dcd As New DownloadCompletedDialog
                dcd.Path = SFD.FileName
                If dcd.ShowDialog() = DialogResult.Yes Then
                    'Process.Start(Application.ExecutablePath & " " & SFD.FileName)
                End If
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
        Dim WC As WebClient = New WebClient()
        Dim content As String = WC.DownloadString("http://floe.festival.square7.de/floe_list.php")
        For Each Item As String In content.Split("|"c)
            If Not Item = "floe:list" Then
                Add(Item)
            End If
        Next
    End Sub

End Class