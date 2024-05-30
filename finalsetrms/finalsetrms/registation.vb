Imports System.Data.SqlClient

Public Class registation
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click

        If String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtpassword.Text) OrElse String.IsNullOrEmpty(txtemail.Text) Then
            MessageBox.Show("All fields are required.")
            Return
        End If


        Dim connectionString As String = "Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True"
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("INSERT INTO login1 (Email, Username, Password) VALUES (@Email, @Username, @Password)", connection)
                    command.Parameters.AddWithValue("@Email", txtemail.Text)
                    command.Parameters.AddWithValue("@Username", txtusername.Text)
                    command.Parameters.AddWithValue("@Password", txtpassword.Text)

                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
            MessageBox.Show("Registration successful. Redirecting to login page.")

            adminlogging.Show()
            Me.Close()
        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminlogging.Show()
        Me.Hide()
    End Sub
    Private Sub registation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = "•"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.PasswordChar = Nothing
        Else
            txtpassword.PasswordChar = "•"
        End If
    End Sub
End Class