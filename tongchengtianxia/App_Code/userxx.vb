Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web.HttpContext
Public Class userxx
    Public Shared Function qcxx() As _userdl
        If TypeName(Current.Session("_userxx")) <> "_userdl" Then
            Current.Response.Redirect("/i/loginpage.aspx")
            Current.Response.End()
        End If
        Return Current.Session("_userxx")
    End Function
    Public Shared Sub bcxx(ByVal rsj As DataRow)
        Dim d As New _userdl(rsj)
        Current.Session("_userxx") = d
    End Sub
    Public Shared Sub qk()
        Current.Session.Remove("_yhxx")
    End Sub
End Class

Public Class _userdl
    Public sj As DataRow

    Public Sub New(ByVal rsj As DataRow)
        Me.sj = rsj
    End Sub
End Class
