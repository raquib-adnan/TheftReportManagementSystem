Public Class typecomplaints
    Private Sub btnbelong_Click(sender As Object, e As EventArgs) Handles btnbelong.Click
        complaintregis.Show()
        Me.Hide()
    End Sub

    Private Sub btngadget_Click(sender As Object, e As EventArgs) Handles btngadget.Click
        complaintgadget.Show()
        Me.Hide()
    End Sub

    Private Sub btnidentify_Click(sender As Object, e As EventArgs) Handles btnidentify.Click
        complaintidentify.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        userlanding.Show()
        Me.Hide()
    End Sub
End Class