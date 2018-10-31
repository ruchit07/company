Public Class clsCommon
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Function InsertJillo(ByVal strName As String) As Integer

        strSqlCommand = "INSERT INTO jillo(name) VALUES (N'" & EscapeString(strName) & "')"

        Dim intJilloId As Integer

        intJilloId = ExecuteNonQuery(strSqlCommand, "InsertJillo", "Y")

        Return intJilloId

    End Function

    Public Function InsertTaluko(ByVal strName As String) As Integer

        strSqlCommand = "INSERT INTO taluko(name) VALUES (N'" & EscapeString(strName) & "')"
        Dim intTaluko As Integer
        intTaluko = ExecuteNonQuery(strSqlCommand, "InsertTaluko", "Y")
        Return intTaluko
    End Function

    Public Function InsertRajya(ByVal strName As String) As Integer
        Dim intRajyaId As Integer
        strSqlCommand = "INSERT INTO rajya(name) VALUES( N'" & EscapeString(strName) & "')"
        intRajyaId = ExecuteNonQuery(strSqlCommand, "InsertRajya", "Y")
        Return intRajyaId
    End Function
End Class
