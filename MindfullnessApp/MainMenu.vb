'Oasis Application designed for Spark Hackathon
'Date: Aug. 9, 2020
'By: Harish Umapathithasan, Mijal Shrestha, Nathes Mehanathan, Iman Cheema
Public Class MainMenu

    Dim strName As String = InputBox("Enter your name:", "Name")

    Dim quotes = New String() {"""Things work out best for those" & vbCrLf & "who make the best of how" & vbCrLf & "things work out.""" & vbCrLf & "- John Wooden",
                               """All our dreams can come true," & vbCrLf & "if we have the courage to pursue" & vbCrLf & "them.""" & vbCrLf & " - Walt Disney",
                               """If people are doubting how far you" & vbCrLf & "can go, go so far that you can't" & vbCrLf & "hear them anymore." & vbCrLf & "- Michele Ruiz",
                               """It’s no use going back to" & vbCrLf & "yesterday, because I was a" & vbCrLf & "different person then.""" & vbCrLf & "- Lewis Carroll""",
                               """Work hard, be kind," & vbCrLf & "And amazing things will happen." & vbCrLf & "- Conan O’Brien""",
                               """Whatever you are, be a good one." & vbCrLf & "- Abraham Lincoln"""}

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display
        Me.lblTitle.Text = "Hello, " & strName
        Randomize()
        Dim intChoose As Integer
        intChoose = Int((5 - 1 + 1) * Rnd() + 1)
        Me.lblQuote.Text = quotes(intChoose)

        lblTitle.Parent = Sky
        lblIntro.Parent = Sky
        lblQuote.Parent = Sky
    End Sub


    Private Sub btnJournal_Click(sender As Object, e As EventArgs) Handles btnJournal.Click
        Me.Hide()
        Journal.Show()
    End Sub

    Private Sub btnEating_Click(sender As Object, e As EventArgs) Handles btnEating.Click
        Me.Hide()
        FoodTracker.Show()
    End Sub

    Private Sub btnMeditation_Click(sender As Object, e As EventArgs) Handles btnMeditation.Click
        Me.Hide()
        Meditation.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        Help.Show()
    End Sub

End Class
