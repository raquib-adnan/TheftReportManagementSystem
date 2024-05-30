Public Class Form1
    Private Sub userlog_Click(sender As Object, e As EventArgs) Handles userlog.Click
        userlanding.show()
        Me.Hide()
    End Sub

    Private Sub adminlog_Click(sender As Object, e As EventArgs) Handles adminlog.Click
        adminlogging.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub
End Class
