Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub LoadSubmission(index As Integer)
        Dim client As New WebClient()
        Dim response As String = client.DownloadString($"http://localhost:3000/read?index={index}")
        Dim submission As JObject = JObject.Parse(response)

        lblName.Text = submission("name").ToString()
        lblEmail.Text = submission("email").ToString()
        lblPhone.Text = submission("phone").ToString()
        lblGithubLink.Text = submission("github_link").ToString()
        lblStopwatch.Text = submission("stopwatch_time").ToString()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentIndex -= 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
