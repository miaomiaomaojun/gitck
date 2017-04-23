Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web.HttpContext
Public Class _yhdlxx
    Public Shared Function qcxx() As _yhdl
        If TypeName(Current.Session("_yhxx")) <> "_yhdl" Then
            'Current.Response.Redirect("/xmglxt/login.aspx")
            Current.Response.Redirect("login.aspx")
            Current.Response.End()
        End If
        Return Current.Session("_yhxx")
    End Function
    Public Shared Sub bcxx(ByVal rsj As DataRow)
        Dim d As New _yhdl(rsj)
        Current.Session("_yhxx") = d
    End Sub
    Public Shared Sub qk()
        Current.Session.Remove("_yhxx")
    End Sub
End Class

Public Class _yhdl
    Public sj As DataRow

    Public Sub New(ByVal rsj As DataRow)
        Me.sj = rsj
    End Sub

End Class


