Imports System.Text.RegularExpressions
Imports System.Data
Imports ConsoleAPI
Imports System.Drawing
Partial Class cs
    Inherits System.Web.UI.Page
    Public erro As String = ""
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim r As New Random()
        'Dim n As Integer = r.Next(1000, 9999)
        'Dim n2 As Integer = r.Next(1000, 9999)
        'Dim n3 As Integer = r.Next(1000, 9999)
        ''Dim jg As String = Now.DayOfYear & n & n2 & Now.Millisecond
        'Dim jg As String = n & n2 & n3
        'Response.Write(jg & "<br/>" & jg.Length)
        'Dim key_Rd As New Random()
        'Dim key_str_left As Integer = key_Rd.Next(1000, 9999)
        'Dim key_str_mid As Integer = key_Rd.Next(1000, 9999)
        'Dim key_str_right As Integer = key_Rd.Next(1000, 9999)
        'Dim key_all As String = key_str_left & " " & key_str_mid & " " & key_str_right
        'Response.Write(key_all & "<br/>" & key_all.Length)
        'Dim i As Integer
        'Do Until i > 1
        '    Response.Write("测试结果<br/>")
        '    i = i + 1
        'Loop
        'While i < 0
        '    Response.Write("测试结果<br/>")
        '    i += 1
        'End While
        'Dim cr As Double = "1.99"
        'Dim jg As String = testfloat(cr)
        'Dim Serial_number As String = ""
        'Dim key_Rd As New Random()
        'Dim key_Serial As Integer = key_Rd.Next(10, 99)
        'Dim key_right As Integer = key_Rd.Next(10, 99)
        ''写入规则年月秒4位随机码天小时分
        'Serial_number = Now.ToString("yyyyMMss") & key_Serial & Now.ToString("ddHHmm") & key_right
        'Dim jg As String
        'jg = Serial_number
        ''Dim jg As String = Now.ToString("yyyy-MM-dd hh:mm:ss ") & Now.Millisecond
        'Response.Write(jg)
        'Dim phone As String = "19852224318"
        'Response.Write(testphone(phone))
        If Not IsPostBack Then
            'set_code()
            makeQR()
            'readQR()
        End If
    End Sub

    Public Shared Function testfloat(ByVal teststring As String) As Boolean
        If teststring = "" Then
            Return "请传入要检测的内容"
        End If
        teststring = teststring.Trim
        'Dim testreg As New Regex("(^(\d(\.\d{2})?){1}$)")
        Dim testreg As New Regex("(^[0-9]*[1-9][0-9]*$)|(^([0-9]{1,}.?[0-9]{0,2})$)")
        'Dim testreg As New Regex("^[-+]?([1-9][0-9]{0,8}/.[0-9]{1,2})$|^[-+]?([1-9][0-9]{0,8})$|^[-+]?[0]$|^[0]{1}/.[0-9]{1,2}$")
        Dim m As Boolean = testreg.IsMatch(teststring)

        Return m
        'If testreg.Match(teststring) Then
        '    Return True
        'Else
        '    Return False
        'End If


    End Function
    '检测手机号码
    Public Function testphone(ByVal sjhm As String) As Boolean
        If sjhm = "" Then
            Return "请传入要检测的内容"
        End If
        sjhm = sjhm.Trim
        Dim testreg As New Regex("^1[3|4|5|7|8][0-9]\d{4,8}$")
        Dim m As Boolean = testreg.IsMatch(sjhm)

        Return m
    End Function

    '读取数据
    'Public Sub dq_sj()
    '    Dim systemclass As New system_class
    '    Dim jg As DataTable = systemclass.read_username()
    '    If jg Is Nothing Then
    '        Response.Write(systemclass.erro)
    '        Exit Sub
    '    End If
    '    Response.Write(jg.Rows(0)("bh").ToString)
    'End Sub
    '发验证码

    Public Sub set_code()
        Program.phonenumber = "15751033393"
        Program.typeid = "30797" '聚合模板ID
        Program.code_ = "320123"

        Program.Main()
        Response.Write("短信发送完毕！")
    End Sub
    '测试生成二维码
    Public Sub makeQR()
        Dim makeqr As New make_QR
        makeqr.Generate1("http://www.qq.com")
        Response.Write("生成成功")
    End Sub
    '读取二维码
    Public Sub readQR()
        Dim makeqr As New make_QR
        Response.Write(makeqr.Read1("C:\Users\技术员\Desktop\biglogo.png"))
    End Sub
End Class
