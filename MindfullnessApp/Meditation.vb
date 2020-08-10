Public Class Meditation

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Meditation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnFocus_Click(sender As Object, e As EventArgs) Handles btnFocus.Click
        txtTutorial.Text = "Keep your attention focused using any of the five senses. Try focusing on your breath, staring at a candle, or counting beads on a mala. Pay attention to the sensations of inhalation and exhalation without forcing attention."
        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\FocusedMeditation.wav")
    End Sub

    Private Sub btnMantra_Click(sender As Object, e As EventArgs) Handles btnMantra.Click
        txtTutorial.Text = "Instead of using your breath to anchor your focus, chant a word or sound. A popular sound that can be used is ""Om."" This is a Hindu and Buddhist meditation technique that helps you become more aware of your surroundings. (Play ""Om"" sound)"
        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\MantraMeditation.wav")
    End Sub

    Private Sub btnBody_Click(sender As Object, e As EventArgs) Handles btnBody.Click
        txtTutorial.Text = "Synchronize your mind and bring attention to your body. Simply imagine a light moving from your forehead, to your arms, your legs and eventually reaching your toes. Notice any aches, pains, tension or discomfort in your body."
        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\BodyScan.wav")
    End Sub

    Private Sub Meditation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Parent = Sky
        lblMeditation.Parent = Sky
        lblInstruction.Parent = Sky
    End Sub
End Class