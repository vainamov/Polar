Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports INILib

Public Class mainform

    Dim Database As IniFile
    WithEvents CLE As ColorListEntry
    Dim ChosenCLE As ColorListEntry
    Dim DatabasePath As String
    Dim ColorListEntries As New List(Of ColorListEntry)

    Private Sub mainform_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control Then
            Dim addclrfrm As New addcolorform
            If addclrfrm.ShowDialog() = DialogResult.OK Then
                Dim HexCode As String
                Dim c As Color
                If Regex.IsMatch(addclrfrm.Colorcode, "#[0-9a-fA-F]{6}$") Then
                    HexCode = addclrfrm.Colorcode
                ElseIf Regex.IsMatch(addclrfrm.Colorcode, "([0-9]{1,3}; ){2}[0-9]{1,3}$") Then
                    c = Color.FromArgb(Integer.Parse(addclrfrm.Colorcode.Split(";"c)(0).Trim(" "c)), Integer.Parse(addclrfrm.Colorcode.Split(";"c)(1).Trim(" "c)), Integer.Parse(addclrfrm.Colorcode.Split(";"c)(2).Trim(" "c)))
                    HexCode = ColorTranslator.ToHtml(c)
                ElseIf Regex.IsMatch(addclrfrm.Colorcode, "((0|1),?[0-9]*; ){3}((0|1),?[0-9]*){1}") Then
                    Dim tCMYK As New List(Of Double)
                    tCMYK.AddRange({Double.Parse(addclrfrm.Colorcode.Split(";"c)(0).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(1).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(2).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(3).Trim(" "c))})
                    Dim tRGB As List(Of Integer) = FestivalColorConverter.CMYKtoRGB(tCMYK)
                    c = Color.FromArgb(tRGB(0), tRGB(1), tRGB(2))
                    HexCode = ColorTranslator.ToHtml(c)
                End If
                AddColor(HexCode, addclrfrm.Description)
            End If
        ElseIf e.KeyCode = Keys.S AndAlso e.Control Then
            Dim sf As New ShareForm
            sf.FilePathOnLocal = DatabasePath
            If sf.ShowDialog() = DialogResult.OK Then
                If Not sf.FilePathOnServer = "error" Then
                    Dim ucd As New UploadCompletedDialog
                    ucd.Identifier = String.Format("floe:author:{0}:set:{1}", sf.AuthorName, sf.SetName)
                    ucd.ShowDialog()
                End If
            End If
        ElseIf e.KeyCode = Keys.F AndAlso e.Control
            Dim dff As New DownloadFromFloe
            dff.Show()
        Else

        End If
    End Sub

    Public Sub LoadFromFile(ByVal Path As String)
        DatabasePath = Path
        Database = New IniFile(Path)
        For Each KVP As IniFileKeyValuePair In Database.Sections("polar.database").KeyValues
            If Not KVP.Value = "none" Then
                CLE = New ColorListEntry(KVP.Value, KVP.Key)
                AddHandler CLE.EntryClick, AddressOf CLE_Clicked
                CLE.Dock = DockStyle.Top
                ColorListContainer.Controls.Add(CLE)
                ColorListEntries.Add(CLE)
            End If
        Next
    End Sub

    Public Sub CreateFile(ByVal Path As String)
        DatabasePath = Path
        System.IO.File.WriteAllText(Path, "[polar.database]" & Environment.NewLine & "none = none")
        Database = New IniFile(Path)
    End Sub

    Public Sub CLE_Clicked(sender As ColorListEntry)
        ChosenCLE = sender
        cms_ColorListEntry.Show(sender, 0, sender.Height)
    End Sub

    Public Sub AddColor(ByVal ColorCode As String, ByVal Description As String)
        CLE = New ColorListEntry(ColorCode, Description)
        AddHandler CLE.EntryClick, AddressOf CLE_Clicked
        CLE.Dock = DockStyle.Top
        ColorListContainer.Controls.Add(CLE)
        ColorListEntries.Add(CLE)
        Dim KVP As New IniFileKeyValuePair
        KVP.Key = Description
        KVP.Value = ColorCode
        Database.Sections("polar.database").KeyValues.Add(KVP)
        Database.Save(DatabasePath)
        Database = New IniFile(DatabasePath)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        ColorListContainer.Controls.Remove(ChosenCLE)
        ColorListEntries.Remove(ChosenCLE)
        For Each KVP As IniFileKeyValuePair In Database.Sections("polar.database").KeyValues
            If KVP.Key = ChosenCLE.Description AndAlso KVP.Value = ChosenCLE.HexCode Then
                Database.Sections("polar.database").KeyValues.Remove(KVP)
                Database.Save(DatabasePath)
                Database = New IniFile(DatabasePath)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Search(ByVal SearchString As String)
        Label1.Text = "Results for """ & SearchString & """."
        Dim Query = From Entry As ColorListEntry In ColorListEntries Where Entry.Description.ToLower.Contains(SearchString.ToLower) OrElse Entry.HexCode.ToLower.Contains(SearchString.ToLower) Select Entry
        ColorListContainer.Controls.Clear()
        For Each E As ColorListEntry In Query
            ColorListContainer.Controls.Add(E)
        Next
    End Sub

    Private Sub CancelSearch()
        Label1.Text = "Press Ctrl+N to add an entry."
        ColorListContainer.Controls.Clear()
        For Each E As ColorListEntry In ColorListEntries
            ColorListContainer.Controls.Add(E)
        Next
    End Sub

    Private Sub mainform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub CopyHexcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHEXToolStripMenuItem.Click
        Clipboard.SetText(ChosenCLE.HexCode)
    End Sub

    Private Sub CopyRGBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRGBToolStripMenuItem.Click
        Dim tRGB As List(Of Integer) = FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode)
        Clipboard.SetText(String.Format("{0}; {1}; {2}", tRGB(0), tRGB(1), tRGB(2)))
    End Sub

    Private Sub CopyHSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHSBToolStripMenuItem.Click
        Dim tHSBV As List(Of Double) = FestivalColorConverter.toHSBV(FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode))
        Clipboard.SetText(String.Format("{0}; {1}; {2}", tHSBV(0), tHSBV(1), tHSBV(2)))
    End Sub

    Private Sub CopyARGBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyARGBToolStripMenuItem.Click
        Dim tARGB As List(Of Integer) = FestivalColorConverter.HEXtoARGB(ChosenCLE.HexCode)
        Clipboard.SetText(String.Format("{0}; {1}; {2}; {3}", tARGB(0), tARGB(1), tARGB(2), tARGB(3)))
    End Sub

    Private Sub CopyHSLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHSLToolStripMenuItem.Click
        Dim tHSL As List(Of Double) = FestivalColorConverter.toHSL(FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode))
        Clipboard.SetText(String.Format("{0}; {1}; {2}", tHSL(0), tHSL(1), tHSL(2)))
    End Sub

    Private Sub CopyHSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHSIToolStripMenuItem.Click
        Dim tHSI As List(Of Double) = FestivalColorConverter.toHSI(FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode))
        Clipboard.SetText(String.Format("{0}; {1}; {2}", tHSI(0), tHSI(1), tHSI(2)))
    End Sub

    Private Sub CopyCMYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCMYToolStripMenuItem.Click
        Dim tCMY As List(Of Double) = FestivalColorConverter.toCMY(FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode))
        Clipboard.SetText(String.Format("{0}; {1}; {2}", tCMY(0), tCMY(1), tCMY(2)))
    End Sub

    Private Sub CopyCMYKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCMYKToolStripMenuItem.Click
        Dim tCMYK As List(Of Double) = FestivalColorConverter.toCMYK(FestivalColorConverter.HEXtoRGB(ChosenCLE.HexCode))
        Clipboard.SetText(String.Format("{0}; {1}; {2}; {3}", tCMYK(0), tCMYK(1), tCMYK(2), tCMYK(3)))
    End Sub

    Private Sub SearchTextbox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextbox.TextChanged
        If SearchTextbox.Text = "" Then
            CancelSearch()
        Else
            Search(SearchTextbox.Text)
        End If
    End Sub

    Private Sub btn_addColor_Click(sender As Object, e As EventArgs) Handles btn_addColor.Click
        Dim addclrfrm As New addcolorform
        If addclrfrm.ShowDialog() = DialogResult.OK Then
            Dim HexCode As String
            Dim c As Color
            If Regex.IsMatch(addclrfrm.Colorcode, "#[0-9a-fA-F]{6}$") Then
                HexCode = addclrfrm.Colorcode
            ElseIf Regex.IsMatch(addclrfrm.Colorcode, "([0-9]{1,3}; ){2}[0-9]{1,3}$") Then
                c = Color.FromArgb(Integer.Parse(addclrfrm.Colorcode.Split(";"c)(0).Trim(" "c)), Integer.Parse(addclrfrm.Colorcode.Split(";"c)(1).Trim(" "c)), Integer.Parse(addclrfrm.Colorcode.Split(";"c)(2).Trim(" "c)))
                HexCode = ColorTranslator.ToHtml(c)
            ElseIf Regex.IsMatch(addclrfrm.Colorcode, "((0|1),?[0-9]*; ){3}((0|1),?[0-9]*){1}") Then
                Dim tCMYK As New List(Of Double)
                tCMYK.AddRange({Double.Parse(addclrfrm.Colorcode.Split(";"c)(0).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(1).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(2).Trim(" "c)), Double.Parse(addclrfrm.Colorcode.Split(";"c)(3).Trim(" "c))})
                Dim tRGB As List(Of Integer) = FestivalColorConverter.CMYKtoRGB(tCMYK)
                c = Color.FromArgb(tRGB(0), tRGB(1), tRGB(2))
                HexCode = ColorTranslator.ToHtml(c)
            End If
            AddColor(HexCode, addclrfrm.Description)
        End If
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim sf As New ShareForm
        sf.FilePathOnLocal = DatabasePath
        If sf.ShowDialog() = DialogResult.OK Then
            If Not sf.FilePathOnServer = "error" Then
                Dim ucd As New UploadCompletedDialog
                ucd.Identifier = String.Format("floe:author:{0}:set:{1}", sf.AuthorName, sf.SetName)
                ucd.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btn_floe_Click(sender As Object, e As EventArgs) Handles btn_floe.Click
        Dim dff As New DownloadFromFloe
        dff.Show()
    End Sub

End Class