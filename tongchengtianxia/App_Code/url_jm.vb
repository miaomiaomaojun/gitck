Imports Microsoft.VisualBasic
Imports System.Security.Cryptography
Imports System.IO

Public Class url_jm
    ''' <summary>
    ''' 加密
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="key"></param>
    ''' <returns></returns>
    ''' 
    Public Overloads Shared Function Encode(ByVal str As String, ByVal key As String) As String
        Dim provider As DESCryptoServiceProvider = New DESCryptoServiceProvider
        provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8))
        provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8))
        Dim bytes() As Byte = Encoding.GetEncoding("GB2312").GetBytes(str)
        Dim stream As MemoryStream = New MemoryStream
        Dim stream2 As CryptoStream = New CryptoStream(stream, provider.CreateEncryptor, CryptoStreamMode.Write)
        stream2.Write(bytes, 0, bytes.Length)
        stream2.FlushFinalBlock()
        Dim builder As StringBuilder = New StringBuilder
        For Each num As Byte In stream.ToArray
            builder.AppendFormat("{0:X2}", num)
        Next
        stream.Close()
        Return builder.ToString
    End Function

    ''' <summary>
    ''' Des 解密 GB2312 
    ''' </summary>
    ''' <param name="str">Desc string</param>
    ''' <param name="key">Key ,必须为8位 </param>
    ''' <returns></returns>
    Public Overloads Shared Function Decode(ByVal str As String, ByVal key As String) As String
        Dim provider As DESCryptoServiceProvider = New DESCryptoServiceProvider
        provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8))
        provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8))
        Dim buffer() As Byte = New Byte(((str.Length / 2)) - 1) {}
        Dim i As Integer = 0
        Do While (i < (str.Length / 2))
            Dim num2 As Integer = Convert.ToInt32(str.Substring((i * 2), 2), 16)
            buffer(i) = CType(num2, Byte)
            i = (i + 1)
        Loop

        Dim stream As MemoryStream = New MemoryStream
        Dim stream2 As CryptoStream = New CryptoStream(stream, provider.CreateDecryptor, CryptoStreamMode.Write)
        stream2.Write(buffer, 0, buffer.Length)
        stream2.FlushFinalBlock()
        stream.Close()
        Return Encoding.GetEncoding("GB2312").GetString(stream.ToArray)
    End Function

    ''' <summary>
    ''' If don't input key , Use default key
    ''' Des 加密 GB2312 :
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Public Overloads Shared Function Encode(ByVal str As String) As String
        Return Encode(str, "Rainight")
    End Function

    ''' <summary>
    ''' 解密
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Public Overloads Shared Function Decode(ByVal str As String) As String
        Return Decode(str, "Rainight")
    End Function
End Class
