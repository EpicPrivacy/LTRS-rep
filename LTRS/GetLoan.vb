Imports System.Net.Mail
Imports Microsoft

Public Class GetLoan
    Private Sub GetLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OpenFileDialog1.ShowDialog()
        attach1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        Try
            Dim mail As New MailMessage()
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(txtfrom.Text)
            mail.To.Add("ltrsofficial0@gmail.com")
            mail.Subject = txtsub.Text
            mail.Body = txtbody.Text

            Dim Attach As System.Net.Mail.Attachment
            Attach = New System.Net.Mail.Attachment(attach1.Text)
            mail.Attachments.Add(Attach)

            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(txtfrom.Text, txtpassword.Text)
            smtpserver.EnableSsl = True
            smtpserver.Send(mail)
            MsgBox("Mail has been Successfully Sent! ", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try




    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Dim GetLoan As New GetLoan2
        GetLoan2.ShowDialog()
    End Sub
End Class