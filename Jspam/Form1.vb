
Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim mymailmessage As New MailMessage()
        mymailmessage.From = New MailAddress(usernamebox.Text)
        mymailmessage.To.Add(Tobox.Text)
        mymailmessage.Subject = (subjectbox.Text)
        mymailmessage.Body = messagebox.Text
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        SMTPServer.Port = 587
        SMTPServer.Credentials = New System.Net.NetworkCredential(usernamebox.Text, passwordbox.Text)
        SMTPServer.EnableSsl = True
        sent.Text = Val(sent.Text + 1)
        SMTPServer.Send(mymailmessage)

    End Sub
End Class
