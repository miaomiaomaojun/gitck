Imports Microsoft.VisualBasic

Public Class setmail
    ''' <summary>
    ''' VB.NET邮件发送程序
    ''' 还没用在别的服务器，不晓得能不能行，慎用！
    ''' </summary>
    ''' <param name="sFrom">发件人地址</param>
    ''' <param name="sTo">收件人地址</param>
    ''' <param name="sCc">抄送人地址</param>
    ''' <param name="sBcc">密件抄送人地址</param>
    ''' <param name="sSubject">邮件主题</param>
    ''' <param name="sBody">邮件内容</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function SendMailBySmtp(ByVal sFrom As String, ByVal sTo As String(), ByVal sCc As String(), ByVal sBcc As String(), ByVal sSubject As String, ByVal sBody As String) As String
        Dim sSmtpServer As String = "192.168.1.1"   'SMTP邮件服务器地址
        Try
            '使用SMTP认证的方式寄信,才不会被当作Relay
            Dim SmtpUser As New System.Net.NetworkCredential()
            '认证账号不必与寄信人相同,在此设定某一个公用账号即可
            SmtpUser.UserName = "******"    'SMTP服务器的window验证帐号
            SmtpUser.Password = "******"    'SMTP服务器的window验证密码
            SmtpUser.Domain = "********"    'SMTP服务器的域
            Dim smtpClient As New System.Net.Mail.SmtpClient()
            smtpClient.Host = sSmtpServer
            '发件人地址
            Dim AddrMailFrom As New System.Net.Mail.MailAddress(sFrom, "", System.Text.Encoding.UTF8)
            '收件人地址
            Dim AddrMailTo As New System.Net.Mail.MailAddress(sTo(0), "", System.Text.Encoding.UTF8)
            '邮件消息对象 
            Dim mailMsg As New System.Net.Mail.MailMessage(AddrMailFrom, AddrMailTo)
            '添加多个收件人地址
            Dim i As Long
            For i = 1 To sTo.Length - 1
                If Trim(sTo(i)) <> "" Then
                    mailMsg.To.Add(Trim(sTo(i)))
                End If
            Next i
            '添加抄送收件人地址
            Dim j As Long
            If Not (sCc Is Nothing) Then    '注意是空还是nothing
                For j = 0 To sCc.Length - 1
                    If Trim(sCc(j)) <> "" Then
                        mailMsg.CC.Add(Trim(sCc(j)))
                    End If
                Next j
            End If
            '添加密件抄送地址
            Dim k As Long
            If Not (sBcc Is Nothing) Then    '注意是空还是nothing
                For k = 0 To sBcc.Length - 1
                    If Trim(sBcc(k)) <> "" Then
                        mailMsg.Bcc.Add(Trim(sBcc(k)))
                    End If
                Next k
            End If
            mailMsg.Body = sBody '邮件内容
            mailMsg.BodyEncoding = System.Text.Encoding.UTF8 '设置邮件内容编码方式
            mailMsg.IsBodyHtml = True '设置邮件内容以HTML形式发送
            mailMsg.Subject = sSubject '邮件主题
            mailMsg.BodyEncoding = System.Text.Encoding.UTF8 '设置邮件主题编码方式
            '加注回复地址
            mailMsg.ReplyTo = AddrMailFrom
            Dim client As Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(sSmtpServer)
            client.UseDefaultCredentials = False
            client.Credentials = SmtpUser
            client.Host = sSmtpServer
            client.DeliveryMethod = Net.Mail.SmtpDeliveryMethod.Network
            client.Send(mailMsg)
            ''设置用于发送电子邮件的凭据
            'smtpClient.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials     '当前安全上下文的网络凭证
            ''将指定的邮件发送到SMTP服务器以便传送
            'smtpClient.Send(mailMsg)
            'smtpClient.UseDefaultCredentials = True
            'smtpClient.EnableSsl = True
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        Finally
        End Try
        Return Nothing
    End Function
End Class
