Public Class Admin_Panel
    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        Me.Hide()
        Dim Admin_Panel As New ClientForm
        ClientForm.ShowDialog()
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        Me.Hide()
        Dim Admin_Panel As New LoansForm
        LoansForm.ShowDialog()
    End Sub
End Class