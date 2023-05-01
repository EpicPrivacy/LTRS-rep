Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class CPass
    Private Sub Guna2ControlBox3_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox3.Click

        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(NPassword.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else

            reloadData("SELECT * FROM login WHERE password = '" & Password.Text & "'")
            If dt.Rows.Count = 0 Then
                Password.BorderColor = System.Drawing.Color.Tomato
                MsgBox("Wrong Old Password!")

            Else

                Try
                    updates("UPDATE login SET Password = '" & NPassword.Text & "' WHERE Password = '" & Password.Text & "'")
                    MessageBox.Show("Change Password Successfully!")

                    Dim CPass As New Form1
                    CPass.Show()
                    Password.BorderColor = System.Drawing.Color.DodgerBlue
                    Password.Text = ""
                    NPassword.Text = ""

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                Finally

                End Try
            End If

        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim CPass As New Form1
        CPass.ShowDialog()
    End Sub
End Class