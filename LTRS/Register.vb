Public Class Register
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Username.Text) Or String.IsNullOrWhiteSpace(Email.Text) Or String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(ConPassword.Text) Then


            MessageBox.Show("Enter complete data first!")

        Else
            Try
                create("INSERT INTO login (`Username`, `Email`, `Password`, `ConPassword`)VALUES('" & Username.Text & "', '" & Email.Text & "', '" & Password.Text & "', '" & ConPassword.Text & "')")

                Dim msg As String = "Registered Successfully"
                Dim title As String = "Registration"
                Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                If result = DialogResult.OK Then
                    Me.Hide()

                    Dim Register As New Form1
                    Register.ShowDialog()

                End If

            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

            End Try
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim Register As New Form1
        Register.ShowDialog()
    End Sub
End Class