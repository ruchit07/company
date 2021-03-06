﻿Public Class clsCompany
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Function CheckUserName(ByVal strUserName As String, Optional intCompanyId As Integer = 0) As Boolean
        strSqlCommand = "SELECT COUNT(*) FROM company where username = N'" & strUserName & "'"

        If intCompanyId > 0 Then
            strSqlCommand &= " AND companyid <> " & intCompanyId
        End If
        Dim intCount As Integer

        intCount = ExecuteScalar(strSqlCommand, "CheckUserName")
        Dim blnUser As Boolean
        If intCount = 0 Then
            blnUser = True
        Else
            blnUser = False
        End If
        Return blnUser
    End Function

    Public Sub InsertCompany(ByVal strCompanyName As String, ByVal strAddress As String, ByVal intJilloId As Integer, ByVal intTalukoId As Integer, ByVal intRajyaId As Integer, ByVal strZipcode As String, ByVal strOwnerName As String, ByVal strMobileNumber As String, ByVal strFormNo As String, ByVal dtStartDate As Date, ByVal dtEndDate As Date, ByVal strUserName As String, ByVal strPassword As String)

        strSqlCommand = "INSERT INTO company(name,address,talukoid,jilloid,rajyaid,zipcode,ownername,mobile,formno,startdate,enddate,username,password) values(N'" & EscapeString(strCompanyName) & "',N'" & EscapeString(strAddress) & "',N'" & intTalukoId & "'," & intJilloId & "," & intRajyaId & ",'" & strZipcode & "',N'" & EscapeString(strOwnerName) & "',N'" & EscapeString(strMobileNumber) & "','" & EscapeString(strFormNo) & "','" & dtStartDate & "','" & dtEndDate & "',N'" & EscapeString(strUserName) & "',N'" & EscapeString(strPassword) & "')"

        Dim intCompanyId As Integer

        intCompanyId = ExecuteNonQuery(strSqlCommand, "InsertCompany", "Y")

    End Sub

    Public Function AuthenticateUser(ByVal strUserName As String, ByVal strPassword As String) As Integer
        strSqlCommand = "SELECT companyid from company WHERE username = N'" & EscapeString(strUserName) & "' AND password = N'" & EscapeString(strPassword) & "'"

        Dim intCompanyId As Integer

        intCompanyId = Val(ExecuteScalar(strSqlCommand, "AuthenticateUser"))
        Return intCompanyId

    End Function

    Public Function GetCompanyList(Optional ByVal strType As String = "", Optional ByVal strSearchText As String = "") As DataSet
        strSqlCommand = "SELECT companyid, name, address, ownername, mobile, formno, convert(varchar,startdate,103)startdate, convert(varchar,enddate,103)enddate FROM company"

        If strSearchText <> "" Then
            If strType = "Company Name" Then
                strSqlCommand &= " WHERE name like N'%" & EscapeString(strSearchText) & "%'"
            ElseIf strType = "Owner Name" Then
                strSqlCommand &= " WHERE ownername like N'%" & EscapeString(strSearchText) & "%'"
            ElseIf strType = "Mobile" Then
                strSqlCommand &= " WHERE mobile like N'%" & EscapeString(strSearchText) & "%'"
            ElseIf strType = "Form Number" Then
                strSqlCommand &= " WHERE formno like N'%" & EscapeString(strSearchText) & "%'"
            End If
        End If
        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData

    End Function

    Public Sub UpdateCompany(ByVal strCompanyName As String, ByVal strAddress As String, ByVal intJilloId As Integer, ByVal intTalukoId As Integer, ByVal intRajyaId As Integer, ByVal strZipcode As String, ByVal strOwnerName As String, ByVal strMobileNumber As String, ByVal strFormNo As String, ByVal dtStartDate As Date, ByVal dtEndDate As Date, ByVal intCompanyId As Integer)

        strSqlCommand = "UPDATE company SET name = N'" & EscapeString(strCompanyName) & "', address = N'" & EscapeString(strAddress) & "', talukoid=" & intTalukoId & ", jilloid=" & intJilloId & ",rajyaid=" & intRajyaId & ",zipcode=N'" & EscapeString(strZipcode) & "', ownername=N'" & EscapeString(strOwnerName) & "', mobile= N'" & EscapeString(strMobileNumber) & "', formno = N'" & EscapeString(strFormNo) & "',startdate = '" & dtStartDate & "', enddate='" & dtEndDate & "' WHERE companyid =" & intCompanyId

        ExecuteNonQuery(strSqlCommand, "", "N")

    End Sub

    Public Sub DeleteCompany(ByVal intCompanyId As Integer)

        strSqlCommand = "DELETE FROM company where companyid = " & intCompanyId

        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

    Public Function GetCompanyDetailById(ByVal intCompanyId As Integer) As DataSet
        strSqlCommand = "SELECT companyid,name,address,talukoid,jilloid,rajyaid,zipcode,ownername,mobile,formno,startdate,enddate,username,password from company where companyid = " & intCompanyId

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData

    End Function
End Class
