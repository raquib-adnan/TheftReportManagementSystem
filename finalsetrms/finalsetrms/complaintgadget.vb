Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing
Public Class complaintgadget
    Private complaintDetails As String = ""
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Or txtAge.Text = "" Or txtContact.Text = "" Or txtLocation.Text = "" Then
            MessageBox.Show("Please fill in all mandatory fields.")
            Return
        End If
        If dtpIncidentDate.Value > DateTime.Today Then
            MessageBox.Show("Date cannot be in the Present/future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Data Source=LAPTOP-E24II76P\SQLEXPRESS01;Initial Catalog=TRMS;Integrated Security=True"
        Dim complaintID As String = GenerateRandomComplaintID()
        Dim Status As String = "Pending"
        Dim PrintDocument As New PrintDocument
        Dim details As String = $"  Complaint Registered Details - 

                            Your Complaint ID: {complaintID}

                            Name: {txtName.Text},

                            Age: {txtAge.Text}
                             
                            Contact: {txtContact.Text}, 

                            Location: {txtLocation.Text}, 

                            Complaint Type: {cbComplainType.SelectedItem.ToString()},

                            ModelName: {txtmodelname.Text},

                            ModelID: {txtmodelid.Text}"

        complaintDetails = details

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO RComplaints (ComplaintID, Name, Age, Contact, Date, Location, ModelName, ModelID, Description, Status) VALUES (@ComplaintID, @Name, @Age, @Contact, @Date, @Location, @ModelName, @ModelID, @Description, @Status)"
                Dim command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@ComplaintID", complaintID)
                command.Parameters.AddWithValue("@Name", txtName.Text)
                command.Parameters.AddWithValue("@Age", txtAge.Text)
                command.Parameters.AddWithValue("@Contact", txtContact.Text)
                command.Parameters.AddWithValue("@Location", txtLocation.Text)
                command.Parameters.AddWithValue("@ComplainType", cbComplainType.SelectedItem.ToString())
                command.Parameters.AddWithValue("@ModelName", txtmodelname.Text)
                command.Parameters.AddWithValue("@ModelID", txtmodelid.Text)
                command.Parameters.AddWithValue("@Date", dtpIncidentDate.Value)
                command.Parameters.AddWithValue("@Description", txtDescription.Text)
                command.Parameters.AddWithValue("@Status", Status)

                command.ExecuteNonQuery()
                ClearFormFields()

                MessageBox.Show($"Complaint registered successfully! Your Complaint ID: {complaintID}")
            End Using
            AddHandler PrintDocument.PrintPage, AddressOf PrintDocumentContent
            PrintDocument.Print()
        Catch ex As Exception
            MessageBox.Show($"Error registering complaint: {ex.Message}")
        End Try

    End Sub

    Private Function GenerateRandomComplaintID() As String

        Dim random As New Random()
        Return random.Next(1000, 10000)
    End Function
    Private Sub PrintDocumentContent(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim printBrush As New SolidBrush(Color.Black)
        e.Graphics.DrawString(complaintDetails, printFont, printBrush, 50, 50)
    End Sub
    Private Sub ClearFormFields()

        txtName.Clear()
        txtAge.Clear()
        txtContact.Clear()
        txtLocation.Clear()
        txtDescription.Clear()
        txtmodelname.Clear()
        txtmodelid.Clear()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        typecomplaints.Show()
        Me.Hide()
    End Sub
End Class