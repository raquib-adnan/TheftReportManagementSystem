Imports System.Data.SqlClient

Public Class admincomplaints
    Private Sub btnLoadComplaintsPending_Click(sender As Object, e As EventArgs) Handles btnLoadComplaintsPending.Click
        LoadComplaintsByStatus("Pending")
    End Sub

    Private Sub btnLoadComplaintsAccepted_Click(sender As Object, e As EventArgs) Handles btnLoadComplaintsAccepted.Click
        LoadComplaintsByStatus("Accepted")
    End Sub

    Private Sub btnLoadComplaintsRejected_Click(sender As Object, e As EventArgs) Handles btnLoadComplaintsRejected.Click
        LoadComplaintsByStatus("Rejected")
    End Sub

    Private Sub btnLoadComplaintsInProgress_Click(sender As Object, e As EventArgs) Handles btnLoadComplaintsInProgress.Click
        LoadComplaintsByStatus("In-Progress")
    End Sub

    Private Sub btnLoadComplaintsClosed_Click(sender As Object, e As EventArgs) Handles btnLoadComplaintsClosed.Click
        LoadComplaintsByStatus("Closed")
    End Sub

    Private Sub LoadComplaintsByStatus(status As String)
        Dim connectionString As String = "Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True"
        Dim query As String = $"SELECT ComplaintID, Name, Age, Contact, Location, Date, Status, Description, ModelName, ModelId FROM RComplaints WHERE Status = '{status}'"
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim dataAdapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                ' Check if the DataGridView exists and has columns
                dgvComplaints.DataSource = dataTable

                ' Set column headers
                dgvComplaints.Columns("ComplaintID").HeaderText = "Complaint ID"
                dgvComplaints.Columns("Name").HeaderText = "Name"
                dgvComplaints.Columns("Age").HeaderText = "Age"
                dgvComplaints.Columns("Contact").HeaderText = "Contact"
                dgvComplaints.Columns("Location").HeaderText = "Location"
                dgvComplaints.Columns("Date").HeaderText = "Date"
                dgvComplaints.Columns("Status").HeaderText = "Status"
                dgvComplaints.Columns("Description").HeaderText = "Description"
                dgvComplaints.Columns("ModelName").HeaderText = "ModelName"
                dgvComplaints.Columns("ModelId").HeaderText = "ModelID" ' Corrected column name

                ' Additional customization (if needed)
                ' dgvComplaints.AutoResizeColumns()



                connection.Close()
            Catch ex As Exception
                MessageBox.Show($"Error loading {status} complaints: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminland.Show()
        Me.Hide()
    End Sub
End Class
