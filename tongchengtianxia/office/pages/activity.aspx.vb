Imports System.Data

Partial Class office_pages_active
    Inherits System.Web.UI.Page
    'Public city_ As New StringBuilder '城市   
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then

        End If
    End Sub
    'Public Sub read_city()
    '    Dim sysc As New system_class
    '    Dim tb As DataTable = sysc.read_city(0)
    '    If tb Is Nothing Then
    '        Response.Write("读取城市出错！")
    '        Exit Sub
    '    End If
    '    If tb.Rows.Count = 0 Then
    '        city.Items.Add("无数据")
    '    End If
    '    city.Items.Clear()
    '    For Each dr As DataRow In tb.Rows
    '        ' city.Items.Add()
    '    Next
    'End Sub

    'Protected Sub city_SelectedIndexChanged(sender As Object, e As EventArgs)

    'End Sub
End Class
