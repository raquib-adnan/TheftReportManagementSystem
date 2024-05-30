Public Class userlanding

    Private Sub RegisterComplaint_Click(sender As Object, e As EventArgs) Handles RegisterComplaint.Click
        typecomplaints.Show()
        Me.Hide()
    End Sub

    Private Sub btnStatusinvest_Click(sender As Object, e As EventArgs) Handles btnStatusinvest.Click
        userstatus.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaws_Click(sender As Object, e As EventArgs) Handles btnLaws.Click
        laws.Show()
        Me.Hide()
    End Sub
End Class