Imports Microsoft.VisualBasic
Imports System.Web.HttpContext

Public Class ym
    Public Shared Function G(ByVal mc As String) As String
        If Current.Request.QueryString(mc) Is Nothing Then Return ""
        Return Current.Request.QueryString(mc)
    End Function
    Public Shared Function Gf(ByVal mc As String) As String
        If Current.Request.Form(mc) Is Nothing Then Return ""
        Return Current.Server.UrlDecode(Current.Request.Form(mc))
    End Function

    Public Shared Sub sc(ByVal lx As sclx, ByVal s1 As String)
        sc(lx, s1, False)
    End Sub

    Public Shared Sub sc(ByVal lx As sclx, ByVal s1 As String, ByVal hcpd As Boolean)
        '0出错,1正确,2返回值为js代码,直接运行

        '管理员操作不能缓存
        If hcpd = False Then
            Current.Response.Buffer = True
            Current.Response.ExpiresAbsolute = DateTime.Now.AddDays(-1)
            Current.Response.Expires = 0
            Current.Response.CacheControl = "no-cache"
        End If
        If lx = sclx.Err Then
            Current.Response.StatusCode = 208
        ElseIf lx = sclx.Dm Then
            Current.Response.StatusCode = 209
        End If

        Current.Response.Write(s1)
        Current.Response.End()
    End Sub

    '检测特殊字符
    Public Shared Function aqjc(ByVal x As String) As String
        Dim y As String = "/,\,',<,>,&"
        Dim z() As String = Split(y, ",")
        Dim i As Integer
        For i = 0 To z.Length - 1
            If x.IndexOf(z(i)) >= 0 Then Return z(i)
        Next
        Return ""
    End Function

    ''' <summary>
    ''' 判断输入的是否是float 字符
    ''' </summary>
    ''' <param name="teststring">检测的变量</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function testfloat(ByVal teststring As String) As Boolean
        If teststring = "" Then
            Return "请传入要检测的内容"
        End If
        teststring = teststring.Trim
        Dim test_float As New Regex("(^[0-9]*[1-9][0-9]*$)|(^([0-9]{1,}.?[0-9]{0,2})$)") '检测带两位数的浮点型字符 

        If test_float.IsMatch(teststring) Then
            Return True
        Else
            Return False
        End If


    End Function
    '18位流水号生成，流水号与订单ID 是一样的

    Public Shared Function create_number() As String
        Dim Serial_number As String = ""
        Dim key_Rd As New Random()
        Dim key_Serial As Integer = key_Rd.Next(10, 99)
        Dim key_right As Integer = key_Rd.Next(10, 99)
        '写入规则年月秒4位随机码天小时分
        Serial_number = Now.ToString("yyyyMMss") & key_Serial & Now.ToString("ddHHmm") & key_right
        Return Serial_number
    End Function
    '防止sql 数据库注入
#Region "过滤 Sql 语句字符串中的注入脚本"
    ''' <summary>
    ''' 过滤 Sql 语句字符串中的注入脚本
    ''' </summary>
    ''' <param name="source">传入的字符串</param>
    ''' <returns>过滤后的字符串</returns>
    ''' <remarks></remarks>
    Public Shared Function SqlFilter(ByVal source As String) As String
        '’单引号替换成两个单引号
        source = source.Replace("'", "''")

        '’半角封号替换为全角封号，防止多语句执行
        source = source.Replace("", "；")
        '’半角括号替换为全角括号
        source = source.Replace("(", "（")
        source = source.Replace(")", "）")
        '’‘’‘’‘’‘’‘’‘’/要用正则表达式替换，防止字母大小写得情况‘’‘’‘’‘’‘’‘’‘’‘’‘’‘’
        '’去除执行存储过程的命令关键字
        source = source.Replace("Exec", "")
        source = source.Replace("Execute", "")
        '’去除系统存储过程或扩展存储过程关键字
        source = source.Replace("xp_", "x p_")
        source = source.Replace("sp_", "s p_")
        '’防止16进制注入
        source = source.Replace("0x", "0 x")

        Return source
    End Function

    ''' <summary>
    '''   过滤不安全的字符串
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Shared Function FilteSQLStr(ByVal str As String) As String
        str = str.Replace("'", "")
        str = str.Replace("\", "")
        str = str.Replace("&", "&amp")
        str = str.Replace("<", "&lt")
        str = str.Replace(">", "&gt")
        str = str.Replace("delete", "")
        str = str.Replace("update", "")
        str = str.Replace("insert", "")
        Return str

    End Function
    ''' <summary>
    ''' 要过滤SQL字符的字符串。
    ''' </summary>
    ''' <param name="str">要过滤SQL字符的字符串。</param>
    ''' <returns>已过滤掉SQL字符的字符串。</returns>
    ''' <remarks></remarks>
    Public Shared Function ReplaceSQLChar(ByVal str As String) As String
        If str = String.Empty Then
            Return String.Empty
        End If
        str = str.Replace("'", "‘")
        str = str.Replace(";", "；")
        str = str.Replace(",", ",")
        str = str.Replace("?", "?")
        str = str.Replace("<", "＜")
        str = str.Replace(">", "＞")
        str = str.Replace("(", "(")
        str = str.Replace(")", ")")
        str = str.Replace("@", "＠")
        str = str.Replace("=", "＝")
        str = str.Replace("+", "＋")
        str = str.Replace("*", "＊")
        str = str.Replace("&", "＆")
        str = str.Replace("#", "＃")
        str = str.Replace("%", "％")
        str = str.Replace("$", "￥")
        Return str

    End Function
    ''' <summary>
    ''' 包括HTML，脚本，数据库关键字，特殊字符的源码
    ''' </summary>
    ''' <param name=str>包括HTML，脚本，数据库关键字，特殊字符的源码</param>
    ''' <returns>已经去除标记后的文字</returns>
    ''' <remarks></remarks>
    Public Shared Function NoHtml(ByVal Htmlstring As String) As String
        If Htmlstring = Nothing Then
            Return ""
        Else
            ''删除脚本
            Htmlstring = Regex.Replace(Htmlstring, "<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase)
            '’删除HTML
            Htmlstring = Regex.Replace(Htmlstring, "<(.[^>]*)>", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "([\r\n])[\s]+", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "-->", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "<!--.*", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(quot|#34);", "\", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(amp|#38);", "&", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(lt|#60);", "<", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(gt|#62);", ">", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(nbsp|#160);", " ", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(cent|#162);", "\xa2", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(pound|#163);", "\xa3", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&(copy|#169);", "\xa9", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "&#(\d+);", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "xp_cmdshell", "", RegexOptions.IgnoreCase)
            ''删除与数据库相关的词
            Htmlstring = Regex.Replace(Htmlstring, "select", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "insert", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "delete from", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "count''", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "drop table", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "truncate", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "asc", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "mid", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "char", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "xp_cmdshell", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "exec master", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "net localgroup administrators", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "and", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "net user", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "or", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "net", "", RegexOptions.IgnoreCase)
            ''Htmlstring = Regex.Replace(Htmlstring, "*", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "-", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "delete", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "drop", "", RegexOptions.IgnoreCase)
            Htmlstring = Regex.Replace(Htmlstring, "script", "", RegexOptions.IgnoreCase)

            ''特殊的字符
            Htmlstring = Htmlstring.Replace("<", "")
            Htmlstring = Htmlstring.Replace(">", "")
            Htmlstring = Htmlstring.Replace("*", "")
            Htmlstring = Htmlstring.Replace("-", "")
            Htmlstring = Htmlstring.Replace("?", "")
            Htmlstring = Htmlstring.Replace("'", "''")
            Htmlstring = Htmlstring.Replace(",", "")
            Htmlstring = Htmlstring.Replace("/", "")
            Htmlstring = Htmlstring.Replace(";", "")
            Htmlstring = Htmlstring.Replace("*/", "")
            Htmlstring = Htmlstring.Replace("\r\n", "")
            Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim()

            Return Htmlstring

        End If
    End Function

    ''' <summary>
    ''' 正则表达式检查是否有过敏字符
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns>返回boolen 字符</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckBardWord(ByVal str As String) As Boolean
        Dim pattern As String = "select|insert|delete|from|count\(|drop table|update|truncate|asc\(|mid\(|char\(|xp_cmdshell|exec   master|netlocalgroup administrators|net user|or|and"
        If Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' 替换过敏字符位空
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns>空值</returns>
    ''' <remarks></remarks>
    Public Shared Function Filter(ByVal str As String) As String
        Dim patterm() As String = {"select", "insert", "delete", "from", "count\\(", "drop table", "update", "truncate", "asc\\(", "mid\\(", "char\\(", "xp_cmdshell", "exec   master", "netlocalgroup administrators", "net user", "or", "and"}

        For i As Integer = 0 To patterm.Length Step 1
            str = str.Replace(patterm(i).ToString, "")
        Next
        Return str
    End Function

#End Region


End Class
Public Enum sclx As Byte
    Err = 0
    Jg = 1
    Dm = 2
End Enum