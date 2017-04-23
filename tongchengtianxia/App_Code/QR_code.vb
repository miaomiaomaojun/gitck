Imports Microsoft.VisualBasic
Imports System.Drawing
'暂时不能用
Public Class QR_code
    ''' <summary>
    ''' 
    ''' 
    ''' </summary>
    ''' <param name="qrtext"></param>
    ''' <param name="width">宽度</param>
    ''' <param name="height">高度</param>
    ''' <param name="margin">边距，貌似不是像素格式，因此不宜设置过大</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MakeQR(ByVal qrtext As String, Optional ByVal width As Integer = 800, Optional ByVal height As Integer = 800, Optional ByVal margin As Integer = 1) As Bitmap
        Dim writer As New ZXing.BarcodeWriter
        writer.Format = ZXing.BarcodeFormat.QR_CODE

        Dim opt As New ZXing.QrCode.QrCodeEncodingOptions
        opt.DisableECI = True '设置为True才可以调整编码
        opt.CharacterSet = "UTF-8" '文本编码，建议设置为UTF-8
        opt.Width = width    '宽度
        opt.Height = height    '高度
        opt.Margin = margin    '边距，貌似不是像素格式，因此不宜设置过大

        writer.Options = opt
        Return writer.Write(qrtext)
        'Return writer.Write(bmp)
    End Function

    Public Function Make_logo_QR(ByVal qrtext As String, ByVal logo As Bitmap, Optional ByVal width As Integer = 800, Optional ByVal height As Integer = 800, Optional ByVal margin As Integer = 1) As Bitmap
        If logo Is Nothing Then
            Return MakeQR(qrtext, width, height, margin)
        End If

        Dim writer As New ZXing.MultiFormatWriter
        Dim hint As New Dictionary(Of ZXing.EncodeHintType, Object)()
        hint.Add(ZXing.EncodeHintType.CHARACTER_SET, "UTF-8")
        hint.Add(ZXing.EncodeHintType.MARGIN, margin)
        hint.Add(ZXing.EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H)

        ' 生成二维码
        Dim bm As ZXing.Common.BitMatrix = writer.encode(qrtext, ZXing.BarcodeFormat.QR_CODE, width, height, hint)
        Dim barcodeWriter = New ZXing.BarcodeWriter()
        Dim bmp As Bitmap = barcodeWriter.Write(bm)

        '获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
        Dim rectangle As Integer() = bm.getEnclosingRectangle()

        '计算插入图片的大小和位置
        Dim middleW As Integer = Math.Min((rectangle(2) / 3.5), logo.Width)
        Dim middleH As Integer = Math.Min((rectangle(3) / 3.5), logo.Height)
        Dim middleL As Integer = (bmp.Width - middleW) / 2
        Dim middleT As Integer = (bmp.Height - middleH) / 2

        '将img转换成bmp格式，否则后面无法创建Graphics对象
        Dim bmpimg As New Bitmap(bmp.Width, bmp.Height, Imaging.PixelFormat.Format32bppArgb)

        Using g As Graphics = Graphics.FromImage(bmpimg)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.DrawImage(bmp, 0, 0)
        End Using

        '将二维码插入图片
        Using myGraphic As Graphics = Graphics.FromImage(bmpimg)
            '白底
            myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH)
            myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH)
        End Using

        bmp.Dispose()

        Return bmpimg

    End Function

    Public Function ReadQR(ByVal bmp As Bitmap) As String
        Dim reader As New ZXing.BarcodeReader
        reader.Options.CharacterSet = "UTF-8"

        Dim ret As ZXing.Result = reader.Decode(bmp)
        If ret Is Nothing Then
            Return Nothing
        Else
            Return ret.Text
        End If
    End Function
End Class
