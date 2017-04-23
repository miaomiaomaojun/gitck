Imports Microsoft.VisualBasic
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class md5jm
    'MD5加密
    Public Shared Function Encrypt(ByVal Text As String, ByVal sKey As String) As String
        Dim provider As New DESCryptoServiceProvider()
        Dim bytes As Byte() = Encoding.[Default].GetBytes(Text)
        provider.Key = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8))
        provider.IV = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8))
        Dim stream As New MemoryStream()
        Dim stream2 As New CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write)
        stream2.Write(bytes, 0, bytes.Length)
        stream2.FlushFinalBlock()
        Dim builder As New StringBuilder()
        For Each num As Byte In stream.ToArray()
            builder.AppendFormat("{0:X2}", num)
        Next
        Return builder.ToString()
    End Function
    '特殊字符验证
    Function aqjc(ByVal x As String) As String
        Dim y As String = "/,\,',<,>,&"
        Dim z() As String = Split(y, ",")
        Dim i As Integer
        For i = 0 To z.Length - 1
            If x.IndexOf(z(i)) >= 0 Then Return z(i)
        Next
        Return ""
    End Function



End Class
