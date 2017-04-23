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
'----------------------------------
'短信发送功能
'----------------------------------

Namespace ConsoleAPI
    Public Class Program
        Public Shared phonenumber As String = ""
        Public Shared typeid As String = ""
        Public Shared code_ As String = ""
        Public Sub New(ByVal phone As String, ByVal rid As String, ByVal rcode As String)
            phonenumber = phone
            typeid = rid
            code_ = rcode
        End Sub
        Shared Sub Main()
            Dim appkey As String = "6d1343a31030443ecd3bd5d973378118" '配置您申请的appkey
            '1.屏蔽词检查测
            Dim url1 As String = "http://v.juhe.cn/sms/black"
            Dim parameters1 As New Dictionary(Of String, String)()
            parameters1.Add("word", "") '需要检测的短信内容，需要UTF8 URLENCODE
            parameters1.Add("key", appkey) '你申请的key
            Dim result1 As String = sendPost(url1, parameters1, "get")
            Dim NewObj1 As New JsonObject(result1)
            Dim errorCode1 As String = NewObj1("error_code").Value
            If errorCode1 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj1)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj1("error_code").Value + ":" + NewObj1("reason").Value)
            End If


            '2.发送短信
            Dim url2 As String = "http://v.juhe.cn/sms/send"

            Dim parameters2 As New Dictionary(Of String, String)()

            parameters2.Add("mobile", phonenumber) '接收短信的手机号码
            parameters2.Add("tpl_id", typeid) '短信模板ID，请参考个人中心短信模板设置
            parameters2.Add("tpl_value", "#code#=" & code_) '变量名和变量值对。如果你的变量名或者变量值中带有#&amp;=中的任意一个特殊符号，请先分别进行urlencode编码后再传递，&lt;a href=&quot;http://www.juhe.cn/news/index/id/50&quot; target=&quot;_blank&quot;&gt;详细说明&gt;&lt;/a&gt;
            parameters2.Add("key", appkey) '你申请的key
            parameters2.Add("dtype", "") '返回数据的格式,xml或json，默认json

            Dim result2 As String = sendPost(url2, parameters2, "get")

            Dim NewObj2 As JsonObject = New JsonObject(result2)
            Dim errorCode2 As String = NewObj2("error_code").Value

            If errorCode2 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj2)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj2("error_code").Value + ":" + NewObj2("reason").Value)
            End If


        End Sub

        '/ <summary>
        '/ Http (GET/POST)
        '/ </summary>
        '/ <param name="url">请求URL</param>
        '/ <param name="parameters">请求参数</param>
        '/ <param name="method">请求方法</param>
        '/ <returns>响应内容</returns>
        Shared Function sendPost(ByVal url As String, parameters As IDictionary(Of String, String), ByVal method As String) As String
            If method.ToLower() = "post" Then
                Dim req As HttpWebRequest = Nothing
                Dim rsp As HttpWebResponse = Nothing
                Dim reqStream As System.IO.Stream = Nothing
                Try
                    req = CType(WebRequest.Create(url), HttpWebRequest)
                    req.Method = method
                    req.KeepAlive = False
                    req.ProtocolVersion = HttpVersion.Version10
                    req.Timeout = 5000
                    req.ContentType = "application/x-www-form-urlencoded;charset=utf-8"
                    'Dim postData As String = ""  Byte()postData

                    Dim postData As Byte() = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"))
                    'Byte() postData = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"))
                    reqStream = req.GetRequestStream()
                    reqStream.Write(postData, 0, postData.Length)
                    rsp = CType(req.GetResponse(), HttpWebResponse)
                    Dim myEncoding As Encoding = Encoding.GetEncoding(rsp.CharacterSet)
                    Return GetResponseAsString(rsp, myEncoding)
                Catch ex As Exception
                    Return ex.Message
                Finally
                    If Not reqStream Is Nothing Then
                        reqStream.Close()
                    End If
                    If Not rsp Is Nothing Then
                        rsp.Close()
                    End If
                End Try
            Else
                '创建请求
                Dim request As HttpWebRequest = CType(WebRequest.Create(url + "?" + BuildQuery(parameters, "utf8")), HttpWebRequest)

                'GET请求
                request.Method = "GET"
                request.ReadWriteTimeout = 5000
                request.ContentType = "text/html;charset=UTF-8"
                Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim myResponseStream As Stream = response.GetResponseStream()
                Dim myStreamReader As StreamReader = New StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"))

                '返回内容
                Dim retString As String = myStreamReader.ReadToEnd()
                Return retString
            End If
        End Function

        '/ <summary>
        '/ 组装普通文本请求参数。
        '/ </summary>
        '/ <param name="parameters">Key-Value形式请求参数字典</param>
        '/ <returns>URL编码后的请求数据</returns>
        Shared Function BuildQuery(parameters As IDictionary(Of String, String), ByVal encode As String) As String
            Dim postData As StringBuilder = New StringBuilder()
            Dim hasParam As Boolean = False
            'IEnumerator<KeyValuePair<string, string> dem = parameters.GetEnumerator()
            Dim dem As IEnumerator(Of KeyValuePair(Of String, String)) = parameters.GetEnumerator()

            While dem.MoveNext()
                Dim name As String = dem.Current.Key
                Dim value As String = dem.Current.Value
                ' 忽略参数名或参数值为空的参数
                If Not String.IsNullOrEmpty(name) Then
                    If hasParam Then
                        postData.Append("&")
                    End If
                    postData.Append(name)
                    postData.Append("=")
                    If encode = "gb2312" Then
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.GetEncoding("gb2312")))
                    ElseIf encode = "utf8" Then
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.UTF8))
                    Else
                        postData.Append(value)
                    End If
                    hasParam = True
                End If
            End While
            Return postData.ToString()
        End Function

        '/ <summary>
        '/ 把响应流转换为文本。
        '/ </summary>
        '/ <param name="rsp">响应流对象</param>
        '/ <param name="encoding">编码方式</param>
        '/ <returns>响应文本</returns>
        Shared Function GetResponseAsString(ByVal rsp As HttpWebResponse, ByVal encoding As Encoding) As String
            Dim stream As System.IO.Stream = Nothing
            Dim reader As StreamReader = Nothing
            Try
                ' 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream()
                reader = New StreamReader(stream, encoding)
                Return reader.ReadToEnd()
            Finally
                ' 释放资源
                If Not reader Is Nothing Then
                    reader.Close()
                End If
                If Not stream Is Nothing Then
                    stream.Close()
                End If
                If Not rsp Is Nothing Then
                    rsp.Close()
                End If
            End Try
        End Function
    End Class
End Namespace
