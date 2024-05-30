Imports System.Data.SqlClient
Public Class adminlogging
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtusername.Text = "") Then
            MsgBox("Enter the username")
            txtusername.Focus()
            Exit Sub
        End If
        If (txtpassword.Text = "") Then
            MsgBox("Enter the Password")
            txtpassword.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection("Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("select * from login1 where UserName = '" & txtusername.Text & "' and Password='" & txtpassword.Text & "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            clearformfeilds()
            If (rdr.Read()) Then
                MsgBox("login succesfull")
                adminland.Show()
                Me.Hide()
            Else
                MsgBox("Enter valid username and password")
                txtusername.Text = ""
                txtpassword.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clearformfeilds()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.PasswordChar = Nothing
        Else
            txtpassword.PasswordChar = "•"
        End If

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = "•"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        registation.Show()
        Me.Hide()
    End Sub
End Class
