Imports Microsoft.VisualBasic
Imports System.Text
Imports System.Security.Cryptography


Public Class alipay
    Function GetMD5(ByVal s As String) As String
        Dim md5 As MD5
        md5 = New MD5CryptoServiceProvider()
        Dim t As Byte() = md5.ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(s))
        Dim sb As StringBuilder = New StringBuilder(32)
        For i As Integer = 0 To t.Length - 1
            sb.Append(t(i).ToString("x").PadLeft(2, "0"))
        Next
        GetMD5 = sb.ToString
    End Function

    Function BubbleSort(ByVal r As String()) As String()
        '交换标志
        Dim i, j As Integer
        Dim temp As String
        Dim exchange As Boolean
        For i = 0 To r.Length - 1 '最多做R.Length-1趟排序
            exchange = False '本趟排序开始前，交换标志应为假
            For j = r.Length - 2 To i Step -1
                If System.String.CompareOrdinal(r(j + 1), r(j)) < 0 Then '交换条件
                    temp = r(j + 1)
                    r(j + 1) = r(j)
                    r(j) = temp
                    exchange = True '发生了交换，故将交换标志置为真
                End If
            Next
            If Not exchange Then '本趟排序未发生交换，提前终止算法
                Exit For
            End If
        Next
        BubbleSort = r
    End Function

    Function CreateUrl( _
        ByVal gateway As String, _
        ByVal service As String, _
        ByVal partner As String, _
        ByVal sign_type As String, _
        ByVal out_trade_no As String, _
        ByVal subject As String, _
        ByVal body As String, _
        ByVal payment_type As String, _
        ByVal total_fee As String, _
        ByVal show_url As String, _
        ByVal seller_email As String, _
        ByVal paymethod As String, _
        ByVal defaultbank As String, _
        ByVal key As String, _
        ByVal return_url As String, _
        ByVal notify_url As String) As String

        '构造数组
        Dim Oristr As String() = New String() {"service=" & service, _
                "partner=" & partner, _
                "subject=" & subject, _
                "body=" & body, _
                "out_trade_no=" & out_trade_no, _
                "total_fee=" & total_fee, _
                "show_url=" & show_url, _
                "payment_type=" & payment_type, _
                "seller_email=" & seller_email, _
                "paymethod=" & paymethod, _
                "defaultbank=" & defaultbank, _
                "notify_url=" & notify_url, _
                "return_url=" & return_url}
        '进行排序
        Dim Sortedstr As String() = BubbleSort(Oristr)

        '构造待md5摘要字符串
        Dim prestr As StringBuilder = New StringBuilder()

        For i As Integer = 0 To Sortedstr.Length - 1
            If i = Sortedstr.Length - 1 Then
                prestr.Append(Sortedstr(i))
            Else
                prestr.Append(Sortedstr(i) + "&")
            End If
        Next

        prestr.Append(key)

        '生成Md5摘要
        Dim sign As String = GetMD5(prestr.ToString())

        '构造支付Url

        Dim parameter As StringBuilder = New StringBuilder
        parameter.Append(gateway)
        For i As Integer = 0 To Sortedstr.Length - 1
            parameter.Append(Sortedstr(i) & "&")
        Next
        parameter.Append("sign=" & sign & "&sign_type=" & sign_type)
        CreateUrl = parameter.ToString

    End Function
End Class
