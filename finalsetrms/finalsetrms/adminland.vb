Public Class adminland
    Private Sub btnadcompl_Click(sender As Object, e As EventArgs) Handles btnadcompl.Click
        admincomplaints.Show()
        Me.Close()
    End Sub

    Private Sub btnupStatus_Click(sender As Object, e As EventArgs) Handles btnupStatus.Click
        statuspage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class