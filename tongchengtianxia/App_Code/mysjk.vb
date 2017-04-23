Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data
Public Class mysjk
    Private sjkmc As String
    Public exerr As String = ""
    Public Sub New(ByVal rsjk As String)
        Me.sjkmc = rsjk
    End Sub
    '链接数据库
    Public Function GetConn() As SqlConnection
        'Dim mycon As SqlConnection = New SqlConnection("server=118.190.98.64;uid=sa;pwd=yibaoyigou720...;database=" & Me.sjkmc)
        Dim mycon As SqlConnection = New SqlConnection("server=118.190.98.64;uid=adminyibaoyigou;pwd=YibaoYigou720...#@;database=" & Me.sjkmc)
        Return mycon
    End Function
    '读取数据库
    Public Function dqb(ByVal sqlml As String) As DataTable
        Dim myt As DataTable = New DataTable
        Dim Conn As SqlConnection = GetConn()
        Try
            Conn.Open()
        Catch ex As Exception
            exerr = ex.ToString
            Return Nothing
        End Try

        Dim MyAdapter As SqlDataAdapter
        Dim ds As New DataSet
        Try
            MyAdapter = New SqlDataAdapter(sqlml, Conn)
            MyAdapter.Fill(ds, Me.sjkmc)
            myt = ds.Tables(Me.sjkmc)
            MyAdapter.Dispose()
        Catch ex As Exception
            exerr = ex.ToString
            Return Nothing
        Finally
            Conn.Close()
        End Try
        Return myt
    End Function
    Public Function zx1(ByVal strsql As String) As Integer
        Dim Conn As SqlConnection = GetConn()
        Try
            Conn.Open()
        Catch ex As Exception
            exerr = ex.ToString
            Return Nothing
        End Try

        Dim icount As Integer
        Try
            Dim command As New SqlCommand(strsql, Conn)
            icount = command.ExecuteNonQuery
        Catch ex As Exception

            exerr = ex.ToString
            icount = -1
        Finally
            Conn.Close()
        End Try
        Return icount
    End Function
    Public Function zx2(ByVal strsql As String) As Integer
        Dim Conn As SqlConnection = GetConn()
        Try
            Conn.Open()
        Catch ex As Exception
            exerr = ex.ToString
            Return -1
        End Try
        Dim icount As Integer
        Try
            Dim command As New SqlCommand(strsql, Conn)
            icount = command.ExecuteNonQuery
            If strsql.ToLower.Substring(0, 6) = "insert" Then
                Dim mySelectQuery As String = strsql & " SELECT @@IDENTITY AS LastOrderId"
                Dim myCommand As New SqlCommand(mySelectQuery, Conn)
                Dim myReader As SqlDataReader
                myReader = myCommand.ExecuteReader()
                'If myReader.Read() Then
                '    icount = myReader.GetInt32(0)
                'End If
                icount = myReader.Item("LastOrderId")
                myReader.Close()
            End If
        Catch ex As Exception
            Me.exerr = ex.ToString
            icount = -1
        Finally
            Conn.Close()
        End Try
        Return icount
    End Function


    Public Function zx3(ByVal strsql As String) As Integer
        Dim Conn As SqlConnection = GetConn()
        Try
            Conn.Open()
        Catch ex As Exception
            exerr = ex.ToString
            Return -1
        End Try
        Dim pd As Boolean = False
        If InStr(LCase(strsql), "insert ") = 1 Then
            pd = True
            strsql &= " SELECT @@IDENTITY AS Id"
        End If
        Dim icount As Integer
        Try
            Dim command As New SqlCommand(strsql, Conn)
            If pd Then
                Dim dr As SqlDataReader = command.ExecuteReader()
                dr.Read()
                icount = dr.Item("id")
                dr.Close()
            Else
                icount = command.ExecuteNonQuery
            End If
        Catch ex As Exception
            icount = -1
            Me.exerr = ex.ToString
        End Try
        Conn.Close()
        Conn.Dispose()
        Return icount
    End Function


End Class
