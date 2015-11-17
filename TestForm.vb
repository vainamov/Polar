Public Class TestForm

    Private ColorList As New List(Of Color)

    Sub LoadColors(ByVal Colors As List(Of ColorListEntry))
        For Each C As ColorListEntry In Colors
            If Not C.Description = String.Empty Then
                cbx_background.Items.Add(C.Description)
                cbx_foreground.Items.Add(C.Description)
            Else
                cbx_background.Items.Add(C.HexCode)
                cbx_foreground.Items.Add(C.HexCode)
            End If
            ColorList.Add(ColorTranslator.FromHtml(C.HexCode))
        Next
    End Sub

    Private Sub cbx_background_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_background.SelectedIndexChanged
        lbl_playground.BackColor = ColorList(cbx_background.SelectedIndex)
    End Sub

    Private Sub cbx_foreground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_foreground.SelectedIndexChanged
        lbl_playground.ForeColor = ColorList(cbx_foreground.SelectedIndex)
    End Sub

    Private Sub TextTextbox_TextChanged(sender As Object, e As EventArgs) Handles TextTextbox.TextChanged
        lbl_playground.Text = TextTextbox.Text
    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        Using FD As New FontDialog
            FD.FontMustExist = True
            FD.Font = lbl_playground.Font
            FD.ShowColor = False
            FD.ShowEffects = True
            Try
                If FD.ShowDialog() = DialogResult.OK Then
                    lbl_playground.Font = FD.Font
                End If
            Catch
                MessageBox.Show("Only TrueType-fonts are supported.", "Polar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class