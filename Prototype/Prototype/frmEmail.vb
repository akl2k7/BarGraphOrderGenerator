Imports System.Net.Mail

Public Class frmEmail
    Private Sub MailSend(sender As Object) '(sender As Object, PDFLocation As String)
        Dim CustomerEmailAddress As String = txtbxCustomerEmailAddress.Text 'this can be fetched from a database
        Dim EmployeeEmail As String = txtbxEmployeeEmail.Text
        If Len(CustomerEmailAddress) > 6 And Not String.IsNullOrWhiteSpace(CustomerEmailAddress) Then
            Try
                Dim SmtpClient As New SmtpClient("172.16.1.102")
                Dim Message As New MailMessage()
                ' Dim AttachmentFile As Net.Mail.Attachment = New Net.Mail.Attachment(PDFLocation) ''incase you want to send an attachment
                With Message
                    .From = New MailAddress(EmployeeEmail)
                    .To.Add(CustomerEmailAddress)
                    .Subject = txtbxEmailSubject.Text
                    .Body = rtxtbxEmailBody.Text
                    '.Attachments.Add(AttachmentFile) 'incase you want to send an attachment
                End With
                SmtpClient.Send(Message)
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            If Not CustomerEmailAddress.ToString = "" Then
                MsgBox("The email was not sent because " + CustomerEmailAddress + " is not a valid email address.", "Email Not Sent!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("The email was not sent because no email address was entered.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Dim msg As String = "Send This Email to " + txtbxCustomerEmailAddress.Text + "?"
        Dim result As Integer = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo)
        If Not result = DialogResult.Yes Then
            Exit Sub
        Else 
            MailSend(sender)
        End If
    End Sub

    Private Sub btnCancelEmail_Click(sender As Object, e As EventArgs) Handles btnCancelEmail.Click
        txtbxEmailSubject.Text = "Ametek Bargraph Quote"
        'If Not sender = "" Then
        rtxtbxEmailBody.Text = "Dear Customer," + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + "Sincerely," + vbLf
        Home.Size = Me.Size
        Home.Location = Me.Location
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Home.Location
        txtbxEmailSubject.Text = "Ametek Bargraph Quote"
        'If Not sender = "" Then
        rtxtbxEmailBody.Text = "Dear Customer," + vbLf + vbLf + vbLf + vbLf + vbLf + Home.SerialToPass + vbLf + vbLf + vbLf + vbLf + vbLf + "Sincerely," + vbLf
        'Else
        'more info for email
        'End If
    End Sub

    Private Sub frmEmail_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Size = Me.Size
        Home.Location = Me.Location
        Home.Show()
        Me.Dispose()
    End Sub

    Private Sub LastFiveDigitsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmArtwork.Location = Me.Location
        frmArtwork.Size = Me.Size
        frmArtwork.Show()
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        frmSearch.Size = Me.Size
        frmSearch.Location = Me.Location
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Application.Exit()
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Size = Me.Size
        Home.Location = Me.Location
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.Size = Me.Size
        frmSearch.Location = Me.Location
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbxCustomerEmailAddress.Text = ""
        txtbxEmployeeEmail.Text = ""
        txtbxEmailSubject.Text = "Ametek Bargraph Quote"
        rtxtbxEmailBody.Text = "Dear Customer," + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + "Sincerely," + vbLf
    End Sub

    Private Sub CopyPartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPartNumberToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(Home.getSerial())
    End Sub
End Class