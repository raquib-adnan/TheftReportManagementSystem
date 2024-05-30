Imports System.Data.SqlClient
Public Class userstatus
    Dim connectionString As String = "Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtComplaintID.Text = ""

    End Sub
    Private Sub btnGetStatus_Click(sender As Object, e As EventArgs) Handles btnGetStatus.Click
        Dim complaintID As Integer

        If Integer.TryParse(txtComplaintID.Text, complaintID) Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "SELECT Status FROM RComplaints WHERE ComplaintID = @ComplaintID"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@ComplaintID", complaintID)
                        Dim status As Object = command.ExecuteScalar()
                        If status IsNot Nothing Then
                            lblStatus.Text = $"Your Complaint: {status}"
                        Else
                            lblStatus.Text = "Complaint not found."
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Invalid complaint ID. Please enter a valid integer.")
        End If
    End Sub
    Private Sub ClearFormFields()

        txtComplaintID.Clear()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtComplaintID.Clear()
        lblStatus.Text = ""
        userlanding.Show()
        Me.Hide()
    End Sub

    Private Sub txtComplaintID_TextChanged(sender As Object, e As EventArgs) Handles txtComplaintID.TextChanged

    End Sub
End Class