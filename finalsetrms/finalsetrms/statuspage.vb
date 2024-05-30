Imports System.Data.SqlClient
Public Class statuspage
    Dim connectionString As String = "Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True"
    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim complaintID As String = txtComplaintID.Text.Trim()

        If String.IsNullOrEmpty(complaintID) Then
            MessageBox.Show("Please enter a valid ComplaintID.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Name, Contact, Date, Location, Description, Status FROM RComplaints WHERE ComplaintID = @ComplaintID"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ComplaintID", complaintID)

                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txtName.Text = reader("Name").ToString()
                    txtContact.Text = reader("Contact").ToString()
                    txtLocation.Text = reader("Location").ToString()
                    txtDescription.Text = reader("Description").ToString()
                    txtStatus.Text = reader("Status").ToString()



                    cmbStatus.SelectedItem = reader("Status").ToString()
                Else
                    MessageBox.Show("Complaint not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving complaint details: " & ex.Message)
        End Try
    End Sub

    Private Sub btStatus_Click(sender As Object, e As EventArgs) Handles btStatus.Click
        Dim complaintID As String = txtComplaintID.Text.Trim()
        Dim newStatus As String = cmbStatus.SelectedItem.ToString()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE RComplaints SET Status = @Status WHERE ComplaintID = @ComplaintID"
                Dim updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@ComplaintID", complaintID)
                updateCommand.Parameters.AddWithValue("@Status", newStatus)

                updateCommand.ExecuteNonQuery()

                MessageBox.Show("Status updated successfully.")
                txtComplaintID.Clear()
                txtName.Text = ""
                txtContact.Text = ""
                cmbStatus.SelectedIndex = -1
                txtLocation.Text = ""
                txtStatus.Text = ""
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminland.Show()
        Me.Hide()
    End Sub
End Class