Imports System.IO
Imports System.Text

Public Class Journal

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Journal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim strDriveLetter As String = InputBox("Enter Drive Letter to save under (Ex.: C,D,E)" & vbCrLf & "(Usually 'C'):", "Drive Letter")
        Dim strDate As String = InputBox("Enter date:", "Date")
        Dim filePath As String = "C:\Users\Public\MindfullnessDiary.txt"

        If My.Computer.FileSystem.FileExists(filePath) Then 'Check if save file exists
            My.Computer.FileSystem.WriteAllText(filePath, vbCrLf & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(filePath, "Entry Date: " & strDate & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(filePath, txtDiary.Text, True)
            MessageBox.Show("Diary saved")
        Else    'If file does not exist create file
            Dim fileCreator As FileStream = File.Create(filePath)
            Dim diaryText As Byte() = New UTF8Encoding(True).GetBytes(txtDiary.Text)
            fileCreator.Close()
            My.Computer.FileSystem.WriteAllText(filePath, "Entry Date: " & strDate & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(filePath, txtDiary.Text, True)

            MessageBox.Show("New File Created - File Directory: """ & filePath & """" & vbCrLf & "Diary saved")
        End If
    End Sub

    Private Sub Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Parent = Sky
        lblExplain.Parent = Sky
    End Sub
End Class