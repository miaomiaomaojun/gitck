Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
'Imports System.Linq
Imports System.Text
Imports System.Net
Imports System.IO
Imports Xfrog.Net
Imports System.Diagnostics
Imports System.Web
Imports System.Text.Encoding
Public Class set_phone_lz
    '发送短信
    Public Shared Function fs(ByVal dsj As String, ByVal dnr As String) As String
        Dim did As String = "3630"   '企业ID
        Dim dzh As String = "jkcs159"    '帐号
        Dim dmm As String = ""     '密码
        Dim url As String = "http://sh.ipyy.com:8888/sms.aspx?action=send&userid=" & did & "&account=" & dzh & "&password=" & dmm & "&mobile=" & dsj & "&content=" & dnr & "&sendTime=&extno="

        Dim myEncoding As Encoding = Encoding.GetEncoding("UTF-8")
        Dim postBytes() As Byte = Encoding.ASCII.GetBytes(url)
        Dim myRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        myRequest.Method = "POST"
        myRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8"
        myRequest.ContentLength = postBytes.Length
        Dim reqStream As Stream = myRequest.GetRequestStream
        reqStream.Write(postBytes, 0, postBytes.Length)
        Dim xmlDoc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim wr As WebResponse = myRequest.GetResponse
        Dim sr As StreamReader = New StreamReader(wr.GetResponseStream, System.Text.Encoding.UTF8)
        Dim xmlStreamReader As System.IO.StreamReader = sr
        xmlDoc.Load(xmlStreamReader)
        If (xmlDoc Is Nothing) Then
            Return "请求异常"
        End If

        Dim returnstatus As String = xmlDoc.GetElementsByTagName("returnstatus").Item(0).InnerText.ToString
        Dim message As String = xmlDoc.GetElementsByTagName("message").Item(0).InnerText.ToString
        If returnstatus = "Success" Then
            Return "1"
        Else
            Return "未成功：" & message
        End If

    End Function
End Class
