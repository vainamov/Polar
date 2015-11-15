Imports System.Text.RegularExpressions

Public Class addcolorform

    Private Sub ColorcodeTextbox_TextChanged(sender As Object, e As EventArgs) Handles ColorcodeTextbox.TextChanged
        Button2.Enabled = False
        ColorcodeTextbox.ForeColor = Color.Black
        Select Case ComboBox1.SelectedIndex
            Case 0
                If Regex.IsMatch(ColorcodeTextbox.Text, "#[0-9a-fA-F]{6}$") Then
                    Panel1.BackColor = ColorTranslator.FromHtml(ColorcodeTextbox.Text)
                    Button2.Enabled = True
                    ColorcodeTextbox.ForeColor = Color.LimeGreen
                Else
                    ColorcodeTextbox.ForeColor = Color.Red
                End If
            Case 1
                If Regex.IsMatch(ColorcodeTextbox.Text, "([0-9]{1,3}; ){2}[0-9]{1,3}$") Then
                    Dim R As Integer = Integer.Parse(ColorcodeTextbox.Text.Split(";"c)(0).Trim(" "c))
                    Dim G As Integer = Integer.Parse(ColorcodeTextbox.Text.Split(";"c)(1).Trim(" "c))
                    Dim B As Integer = Integer.Parse(ColorcodeTextbox.Text.Split(";"c)(2).Trim(" "c))
                    If R > 255 OrElse R < 0 OrElse G > 255 OrElse G > 255 OrElse G < 0 OrElse B > 255 OrElse B < 0 Then
                        ColorcodeTextbox.ForeColor = Color.Red
                    Else
                        Panel1.BackColor = Color.FromArgb(R, G, B)
                        Button2.Enabled = True
                        ColorcodeTextbox.ForeColor = Color.LimeGreen
                    End If
                Else
                    ColorcodeTextbox.ForeColor = Color.Red
                End If
            Case 2
                If Regex.IsMatch(ColorcodeTextbox.Text, "((0|1),?[0-9]*; ){3}((0|1),?[0-9]*){1}$") Then
                    Dim tCMYK As New List(Of Double)
                    tCMYK.AddRange({Double.Parse(ColorcodeTextbox.Text.Split(";"c)(0).Trim(" "c)), Double.Parse(ColorcodeTextbox.Text.Split(";"c)(1).Trim(" "c)), Double.Parse(ColorcodeTextbox.Text.Split(";"c)(2).Trim(" "c)), Double.Parse(ColorcodeTextbox.Text.Split(";"c)(3).Trim(" "c))})
                    Dim tRGB As List(Of Integer) = FestivalColorConverter.CMYKtoRGB(tCMYK)
                    Panel1.BackColor = Color.FromArgb(tRGB(0), tRGB(1), tRGB(2))
                    Button2.Enabled = True
                    ColorcodeTextbox.ForeColor = Color.LimeGreen
                Else
                    ColorcodeTextbox.ForeColor = Color.Red
                End If
        End Select
    End Sub

    Public Property Colorcode As String
        Get
            Return ColorcodeTextbox.Text
        End Get
        Private Set(value As String)

        End Set
    End Property

    Public Property Description As String
        Get
            Return DescriptionTextbox.Text
        End Get
        Private Set(value As String)

        End Set
    End Property

End Class