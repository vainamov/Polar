Public Class aboutform

    Private Sub btn_homepage_Click(sender As Object, e As EventArgs) Handles btn_homepage.Click
        Process.Start("http://www.thatpolar.cf")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.vb-paradise.de/index.php/Thread/63566-IniLib-08-11-2011/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.festival.cf")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.twitter.com/festivaldev")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://www.hdwallpapers.im/fog_over_a_pine_forest-wallpaper.html")
    End Sub

End Class