Imports Microsoft.VisualBasic
Imports ZXing
Imports ZXing.QrCode
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.HttpContext

Public Class make_QR
    '/ <summary>
    '/ 生成二维码,保存成图片
    '/ </summary>
    Public Sub Generate1(ByVal text As String)
        Dim writer As BarcodeWriter = New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As QrCodeEncodingOptions = New QrCodeEncodingOptions()
        options.DisableECI = True
        '设置内容编码
        options.CharacterSet = "UTF-8"
        '设置二维码的宽度和高度
        options.Width = 500
        options.Height = 500
        '设置二维码的边距,单位不是固定像素
        options.Margin = 1
        writer.Options = options
        Dim map As Bitmap = writer.Write(text)
        'Dim filename As String = "\QRcode\Example\Example.png"
        Dim filename As String = Current.Server.MapPath("~") & "\QRcode\shop\2.png"
        map.Save(filename, ImageFormat.Png)
        map.Dispose()
    End Sub
    '/ <summary>
    '/ 读取二维码
    '/ 读取失败，返回空字符串
    '/ </summary>
    '/ <param name="filename">指定二维码图片位置</param>
    Public Function Read1(ByVal filename As String) As String
        Dim reader As BarcodeReader = New BarcodeReader()
        reader.Options.CharacterSet = "UTF-8"
        Dim map As Bitmap = New Bitmap(filename)
        Dim result As Result = reader.Decode(map)
        Return IIf(result Is Nothing, "", result.Text)
    End Function
End Class
