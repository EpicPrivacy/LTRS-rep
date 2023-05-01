Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(Username.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()
            Try
                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM login WHERE username = @user and password = @pass;"

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
                    Dim Form1 As New Home
                    Home.Show()
                    Me.Hide()

                    Username.BorderColor = System.Drawing.Color.DodgerBlue
                    Password.BorderColor = System.Drawing.Color.DodgerBlue
                    'MessageBox.Show("Login Success", "Welcome to SAN ISIDRO BLOTTER SYSTEM!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Dim Form1 As New CPass
        Form1.ShowDialog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim Form1 As New Register
        Form1.ShowDialog()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class
