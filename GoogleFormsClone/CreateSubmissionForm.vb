Imports System.Collections.Specialized
Imports System.Net

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatchRunning Then
            Timer1.Stop()
            btnStartPause.Text = "Start"
        Else
            Timer1.Start()
            btnStartPause.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New WebClient()
        Dim formData As New NameValueCollection()
        formData.Add("name", txtName.Text)
        formData.Add("email", txtEmail.Text)
        formData.Add("phone", txtPhone.Text)
        formData.Add("github_link", txtGithubLink.Text)
        formData.Add("stopwatch_time", lblStopwatch.Text)

        Try
            Dim responseBytes As Byte() = client.UploadValues("http://localhost:3000/submit", "POST", formData)
            Dim responseBody As String = (New Text.UTF8Encoding()).GetString(responseBytes)
            MessageBox.Show("Submission Successful!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click

    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
