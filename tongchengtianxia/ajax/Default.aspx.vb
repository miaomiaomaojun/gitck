Imports System.Data
Partial Class ajax_Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case ym.G("sc")
            Case ""

            Case Else
                ym.sc(sclx.Err, "未知cz=" & ym.G("sc"))
        End Select
    End Sub

End Class
