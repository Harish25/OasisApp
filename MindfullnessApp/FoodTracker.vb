Public Class FoodTracker

    Private Sub FoodTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Parent = Sky
        lblDescription.Parent = Sky
        lblAge.Parent = Sky
        lblDescription.Parent = Sky
        lblFeedback.Parent = Sky
    End Sub

    Private Sub FoodTracker_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim age, calories As Integer
        age = txtAge.Text
        calories = txtCalories.Text

        Select Case age
            Case 0 To 3
                If calories > 999 And calories < 1401 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 1000 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
            Case 4 To 8
                If calories > 1399 And calories < 1601 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 1400 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
            Case 9 To 13
                If calories > 1599 And calories < 2201 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 1600 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
            Case 14 To 30
                If calories > 1999 And calories < 2801 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 2000 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
            Case 31 To 50
                If calories > 1999 And calories < 2601 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 2000 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
            Case > 50
                If calories > 1799 And calories < 2401 Then
                    txtFeedback.Text = "You meet your daily required calories. Good job!"
                ElseIf calories < 1800 Then
                    txtFeedback.Text = "You are under your daily required calories."
                Else
                    txtFeedback.Text = "You are over your daily required calories"
                End If
        End Select

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class