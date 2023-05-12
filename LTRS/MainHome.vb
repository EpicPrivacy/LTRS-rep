Imports MySql.Data.MySqlClient

Public Class MainHome
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(Username.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()
            Try
                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM admin WHERE username = @user and password = @pass;"

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = Username.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                strcon.Close()
                da.Dispose()

                If dt.Rows.Count = 0 Then
                    Username.BorderColor = System.Drawing.Color.Tomato
                    Password.BorderColor = System.Drawing.Color.Tomato
                    MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim MainHome As New Admin_Panel
                    MainHome.Show()
                    Me.Hide()

                    Username.BorderColor = System.Drawing.Color.DodgerBlue
                    Password.BorderColor = System.Drawing.Color.DodgerBlue
                    Username.Clear()
                    Password.Clear()

                End If
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
            End Try

        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class