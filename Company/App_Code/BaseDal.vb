Imports System.Data.SqlClient

Public Class BaseDal

    Dim objConnect As New Connection()

    Public Sub New()

        objConnect.SetConnection()

    End Sub

    Public Function FillDataSet(ByVal strSqlCommand As String) As DataSet


        objConnect.DBConn.Open()
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(strSqlCommand, objConnect.DBConn)

        Dim dsResult As New DataSet("Result")


        ' Fill data into dataset

        da.Fill(ds)
        objConnect.DBConn.Close()

        Return ds

    End Function

    Public Function ExecuteNonQuery(ByVal strSqlCommand As String, ByVal strFunctionName As String, Optional ByVal strLastid As String = "Y") As Integer


        'objConnect.DBCommand.ExecuteNonQuery()


        Dim intNewId As Integer
        If strLastid = "Y" Then
            strSqlCommand = strSqlCommand & " ;SELECT CAST(scope_identity() AS int);"
        End If
        objConnect.DBCommand = New SqlCommand(strSqlCommand, objConnect.DBConn)
        objConnect.DBConn.Open()
        intNewId = Convert.ToInt32(objConnect.DBCommand.ExecuteScalar())
        objConnect.DBConn.Close()
        Return intNewId

    End Function

    Public Function ExecuteScalar(ByVal strSqlCommand As String, ByVal strFunctionName As String) As String

        objConnect.DBCommand = New SqlCommand(strSqlCommand, objConnect.DBConn)
        objConnect.DBConn.Open()
        'objConnect.DBCommand.ExecuteNonQuery()


        Dim strValue As String


        strValue = objConnect.DBCommand.ExecuteScalar()
        objConnect.DBConn.Close()
        Return strValue
    End Function

    Function EscapeString(ByVal strQuery As String) As String

        strQuery = strQuery.Replace("'", "''")
        Return strQuery

    End Function


End Class
