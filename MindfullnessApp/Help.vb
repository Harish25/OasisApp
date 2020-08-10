Public Class Help

    Private Sub Help_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Parent = Sky
    End Sub

    Private Sub linklblOasis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblOasis.LinkClicked
        Process.Start("https://oasismindfulness.wixsite.com/mysite")
    End Sub

    Private Sub linklblUrl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblUrl.LinkClicked
        Process.Start("https://mindyourmind.ca/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://kidshelpphone.ca/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://jack.org/Home")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.heretohelp.bc.ca/managing-depression")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://www.crisisservicescanada.ca/en/")
    End Sub
End Class