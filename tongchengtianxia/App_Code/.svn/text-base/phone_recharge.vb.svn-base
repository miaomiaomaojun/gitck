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
'------------------------------
'手机话费充值
'------------------------------
Namespace PhoneRechargeAPI

    Public Class phone_recharge
        Shared Sub Main(ByVal args() As String)
            Dim appkey As String = "3a40d8cbe73033acfb2ad595eca27653" '配置您申请的appkey


            '1.账户余额查询
            Dim url1 As String = "http://op.juhe.cn/ofpay/mobile/yue"

            Dim parameters1 As New Dictionary(Of String, String)()
            parameters1.Add("timestamp", "") '当前时间戳，如：1432788379
            parameters1.Add("key", appkey) '你申请的key
            parameters1.Add("sign", "") '校验值，md5(&lt;b&gt;OpenID&lt;/b&gt;+key+timestamp)，OpenID在个人中心查询

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


            '2.订单状态查询
            Dim url2 As String = "http://op.juhe.cn/ofpay/mobile/ordersta"
            'var parameters2 = New Dictionary<string, string>()
            Dim parameters2 As New Dictionary(Of String, String)()
            parameters2.Add("orderid", "") '商家订单号，8-32位字母数字组合
            parameters2.Add("key", appkey) '你申请的key
            Dim result2 As String = sendPost(url2, parameters2, "get")
            Dim NewObj2 As New JsonObject(result2)
            Dim errorCode2 As String = NewObj2("error_code").Value
            If errorCode2 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj2)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj2("error_code").Value + ":" + NewObj2("reason").Value)
            End If


            '3.历史订单列表检索
            Dim url3 As String = "http://op.juhe.cn/ofpay/mobile/orderlist"

            Dim parameters3 As New Dictionary(Of String, String)()

            parameters3.Add("page", "") '当前页数，默认1
            parameters3.Add("pagesize", "") '每页显示条数，默认50，最大100 
            parameters3.Add("mobilephone", "") '检索指定手机号码
            parameters3.Add("orderid", "") '需要检索的商户订单号
            parameters3.Add("key", appkey) '你申请的key

            Dim result3 As String = sendPost(url3, parameters3, "get")

            Dim NewObj3 As New JsonObject(result3)
            Dim errorCode3 As String = NewObj3("error_code").Value

            If errorCode3 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj3)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj3("error_code").Value + ":" + NewObj3("reason").Value)
            End If


            '4.状态回调配置
            Dim url4 As String = "充值接口测试完毕，联系在线客服进行回调配置"

            Dim parameters4 As New Dictionary(Of String, String)()


            Dim result4 As String = sendPost(url4, parameters4, "post")

            Dim NewObj4 As New JsonObject(result4)
            Dim errorCode4 As String = NewObj4("error_code").Value

            If errorCode4 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj4)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj4("error_code").Value + ":" + NewObj4("reason").Value)
            End If


            '5.检测手机号码是否能充值
            Dim url5 As String = "http://op.juhe.cn/ofpay/mobile/telcheck"

            Dim parameters5 As New Dictionary(Of String, String)()

            parameters5.Add("phoneno", "") '手机号码
            parameters5.Add("cardnum", "") '充值金额,目前可选：5、10、20、30、50、100、300
            parameters5.Add("key", appkey) '你申请的key

            Dim result5 As String = sendPost(url5, parameters5, "get")

            Dim NewObj5 As New JsonObject(result5)
            Dim errorCode5 As String = NewObj5("error_code").Value

            If errorCode5 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj5)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj5("error_code").Value + ":" + NewObj5("reason").Value)
            End If


            '6.根据手机号和面值查询商品信息
            Dim url6 As String = "http://op.juhe.cn/ofpay/mobile/telquery"

            Dim parameters6 As New Dictionary(Of String, String)()

            parameters6.Add("phoneno", "") '手机号码
            parameters6.Add("cardnum", "") '充值金额,目前可选：5、10、20、30、50、100、300
            parameters6.Add("key", appkey) '你申请的key

            Dim result6 As String = sendPost(url6, parameters6, "get")

            Dim NewObj6 As New JsonObject(result6)
            Dim errorCode6 As String = NewObj6("error_code").Value

            If errorCode6 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj6)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj6("error_code").Value + ":" + NewObj6("reason").Value)
            End If


            '7.手机直充接口
            Dim url7 As String = "http://op.juhe.cn/ofpay/mobile/onlineorder"

            Dim parameters7 As New Dictionary(Of String, String)()

            parameters7.Add("phoneno", "") '手机号码
            parameters7.Add("cardnum", "") '充值金额,目前可选：5、10、20、30、50、100、300
            parameters7.Add("orderid", "") '商家订单号，8-32位字母数字组合
            parameters7.Add("key", appkey) '你申请的key
            parameters7.Add("sign", "") '校验值，md5(&lt;b&gt;OpenID&lt;/b&gt;+key+phoneno+cardnum+orderid)，OpenID在个人中心查询

            Dim result7 As String = sendPost(url7, parameters7, "get")

            Dim NewObj7 As New JsonObject(result7)
            Dim errorCode7 As String = NewObj7("error_code").Value

            If errorCode7 = "0" Then
                Debug.WriteLine("成功")
                Debug.WriteLine(NewObj7)
            Else
                'Debug.WriteLine("失败");
                Debug.WriteLine(NewObj7("error_code").Value + ":" + NewObj7("reason").Value)
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
                    Dim postData As Byte() = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"))
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
            Dim postData As New StringBuilder()
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
            Dim Stream As System.IO.Stream = Nothing
            Dim reader As StreamReader = Nothing
            Try
                ' 以字符流的方式读取HTTP响应
                Stream = rsp.GetResponseStream()
                reader = New StreamReader(Stream, encoding)
                Return reader.ReadToEnd()
            Finally
                ' 释放资源
                If Not reader Is Nothing Then
                    reader.Close()
                End If
                If Not Stream Is Nothing Then
                    Stream.Close()
                End If
                If Not rsp Is Nothing Then
                    rsp.Close()
                End If
            End Try
        End Function
    End Class
End Namespace

