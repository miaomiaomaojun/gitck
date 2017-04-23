Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web.HttpContext
'Imports _ggk
Public Class _dbdq
    Public erro As String = ""
    Public tj As String = ""
    Public xm_zd As Hashtable = Nothing
    Dim sjbmc_ As String
    Public zdfw As String = "*"
    Public P_dx As Integer = 20
    Public g_ys As Integer = 0 '总页数
    Public pn0 As Integer = 0 '初始最小编号
    Public pn1 As Integer = 0 '初始最大编号   
    Public p_dq As Integer = 1 '当前页
    Public z_gs As Integer
    Public _b1, _b2, _b3, _b4 As Boolean '按钮控制
    Public is_sql As Boolean = True
    Public sjkmc_ As String

    Public Sub New(ByVal sjkmc As String, ByVal bmc As String)
        sjkmc_ = sjkmc
        sjbmc_ = bmc
    End Sub

    Public Function tb_() As DataTable
        Dim tb As DataTable = Nothing
        If tj <> "" Then
            tj = " where 1=1 " & tj
        End If
        Dim str As String = ""
        Dim sql_zd As String = ""
        str = "select " & zdfw & " from " & sjbmc_ & tj & " order by bh desc"
        Return r_tab(str)
    End Function
    Public Function tb_gs() As String
        Dim tb As DataTable = Nothing
        tb = tb_()
        If erro <> "" Then
            Return erro
        End If
        Dim lm As String = ""
        For k As Integer = 0 To tb.Columns.Count - 1
            lm &= "<td>" & zhzd(tb.Columns(k).ColumnName) & "</td>"
        Next
        Dim jg As New StringBuilder
        jg.Append("<table><tr>" & lm & "</tr>")
        For Each dr In tb.Rows
            Dim k_dr As String = ""
            For i As Integer = 0 To tb.Columns.Count - 1
                k_dr &= "<td>" & dr(i) & "</td>"
            Next
            jg.Append("<tr>" & k_dr & "</tr>")
        Next
        jg.Append("</table>")
        Return jg.ToString
    End Function
    '共用读取
    Public Function r_tab(ByVal sql As String) As DataTable
        Dim tb As DataTable = Nothing
        Dim str As String = sql
        If is_sql = True Then
            Dim db1 As New mysjk(sjkmc_)
            tb = db1.dqb(str)
            If db1.exerr <> "" Then
                erro = db1.exerr
            End If
            Return tb
            'Else
            'Dim db1 As New mydb(sjkmc_)
            'tb = db1.dqb(str)
            'If db1.exerr <> "" Then
            '    erro = db1.exerr
            'End If
            'Return tb
        End If
    End Function
    '字段名称转换成汉字
    Public Function zhzd(ByVal str As String) As String
        If xm_zd Is Nothing Then
            Return str
        End If
        Return xm_zd(str)
    End Function
    '统计条数
    Public Function jl_count() As Integer
        Dim str As String = ""
        If tj <> "" Then
            tj = " where 1=1 " & tj
        End If
        str = "select count(bh) as zs from " & sjbmc_ & tj
        Dim tb As DataTable = r_tab(str)
        If erro <> "" Then
            Return "-1"
        End If
        If tb.Rows.Count = 0 Then
            Return "0"
        End If
        Return tb.Rows(0)("zs")
    End Function
    '不带标题名称，返回dataview
    Public Function fy(ByVal n As Integer) As DataView
        z_gs = jl_count()
        Dim qm As Integer = z_gs Mod P_dx
        If qm = 0 Then
            g_ys = z_gs \ P_dx
        Else
            g_ys = (z_gs \ P_dx) + 1
        End If
        Dim str As String = ""
        _b1 = True
        _b2 = True
        _b3 = True
        _b4 = True
        Select Case n
            Case 1
                If tj = "" Then
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & " order by bh desc"
                Else
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & tj & " order by bh desc"
                End If
                p_dq = 1
            Case 2
                If tj = "" Then
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & " where bh >" & pn1 & " order by bh "
                Else
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & tj & " and bh >" & pn1 & " order by bh "
                End If

                If p_dq > 1 Then
                    p_dq -= 1
                End If
            Case 3
                If tj = "" Then
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & " where bh <" & pn0 & " order by bh desc"
                Else
                    str = "select top " & P_dx & " " & zdfw & " from " & sjbmc_ & tj & " and bh <" & pn0 & " order by bh desc"
                End If

                If p_dq < g_ys Then
                    p_dq += 1
                End If

            Case 4
                str = "select top " & IIf(qm = 0, P_dx, qm) & " " & zdfw & " from " & sjbmc_ & tj & " order by bh "
                p_dq = g_ys
        End Select
        Dim tb As DataTable = r_tab(str)
        If erro <> "" Then
            Return Nothing
        End If
        If tb.Rows.Count = 0 Or g_ys = 1 Then
            _b2 = False
            _b3 = False
            _b4 = False
            Return tb.DefaultView
        Else
            If p_dq <= 1 Then
                _b2 = False
            Else
                If p_dq >= g_ys Then
                    _b3 = False
                    _b4 = False
                End If
            End If
        End If
        Dim i As Integer = 0
        If n = 2 Or n = 4 Then
            tb.DefaultView.Sort = "bh desc"
        End If
        pn1 = tb.DefaultView(0)("bh")
        pn0 = tb.DefaultView(tb.DefaultView.Count - 1)("bh")
        Return tb.DefaultView
    End Function
    '返回信息-页数，条数，当前页，共几页
    Public Function jlsxx() As String
        Return "共<span>" & z_gs & "</span>条数据, 第<span>" & Me.p_dq & "/" & Me.g_ys & "</span>页 "
    End Function
    '带名称
    Public Function fy_gs(ByVal n As Integer) As String
        Dim datav As DataView = fy(n)
        Dim lm As String = ""
        For k As Integer = 0 To datav.Table.Columns.Count - 1
            lm &= "<th>" & zhzd(datav.Table.Columns(k).ColumnName) & "</th>"
        Next
        Dim jg As New StringBuilder
        jg.Append("<table class='table'><tr>" & lm & "</tr>")
        For Each dv As DataRowView In datav
            Dim k_dr As String = ""
            For i As Integer = 0 To datav.Table.Columns.Count - 1
                k_dr &= "<td>" & dv(i) & "</td>"
            Next
            jg.Append("<tr>" & k_dr & "</tr>")
        Next
        jg.Append("</table>")
        Return jg.ToString
    End Function
End Class



