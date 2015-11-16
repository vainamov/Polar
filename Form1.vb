Public Class Form1

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        Dim abtfrm As New aboutform
        abtfrm.ShowDialog()
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Using OFD As New OpenFileDialog With {.Filter = "Polar-Colorsets (*.pcs)|*.pcs", .Title = "Load colorset"}
            If OFD.ShowDialog() = DialogResult.OK Then
                Dim mainfrm As New mainform
                mainfrm.Show()
                Me.Hide()
                mainfrm.LoadFromFile(OFD.FileName)
            End If
        End Using
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Using SFD As New SaveFileDialog With {.Filter = "Polar-Colorsets (*.pcs)|*.pcs", .Title = "New colorset"}
            If SFD.ShowDialog() = DialogResult.OK Then
                Dim mainfrm As New mainform
                mainfrm.Show()
                Me.Hide()
                mainfrm.CreateFile(SFD.FileName)
            End If
        End Using
    End Sub

    Sub ExecuteParameter()
        Try
            Dim args() As String = Environment.GetCommandLineArgs
            If args(1) <> Nothing Then
                Dim Filepath As String = args(1)
                Dim mainfrm As New mainform
                mainfrm.Show()
                Me.Hide()
                mainfrm.LoadFromFile(Filepath)
            End If
        Catch

        End Try
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ExecuteParameter()
    End Sub

End Class
