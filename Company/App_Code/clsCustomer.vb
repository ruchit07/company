Public Class clsCustomer
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Function GetCustomerList(ByVal intCompanyId As Integer, Optional ByVal strType As String = "", Optional ByVal strSearchText As String = "") As DataSet

        strSqlCommand = "SELECT c.customerid, c.companyid, c.regno, c.name, c.address, j.name jillo, t.name taliko, r.name rajya,mobile1,mobile2,c.adharno,'loan' AS loan FROM customer c INNER JOIN jillo j on j.jilloid = c.jilloid INNER JOIN taluko t ON t.talukoid = c.talukoid INNER JOIN rajya r ON r.rajyaid = c.rajyaid  WHERE companyid = " & intCompanyId

        If strSearchText <> "" Then
            If strType = "Name" Then
                strSqlCommand &= " AND c.name like N'%" & EscapeString(strSearchText) & "%'"
            ElseIf strType = "Registration Number" Then
                strSqlCommand &= " AND c.regno like N'%" & EscapeString(strSearchText) & "%'"
            ElseIf strType = "Mobile" Then
                strSqlCommand &= " AND c.mobile like N'%" & EscapeString(strSearchText) & "%'"
            End If
        End If
        Dim dstCustomer As DataSet
        dstCustomer = FillDataSet(strSqlCommand)

        Return dstCustomer
    End Function

    Public Function AddCustomer(ByVal intCompanyId As Integer, ByVal strRegNo As String, ByVal strName As String, ByVal strAddress As String, ByVal intJilloId As Integer, ByVal intTalukoId As Integer, ByRef intRajyaId As Integer, ByVal strZipCode As String, ByVal strmobile1 As String, ByVal strMobile2 As String, ByVal strAdharNo As String) As Integer


        Dim intMaxCustomerId As Integer
        strSqlCommand = "SELECT MAX(customerid) FROM customer"
        intMaxCustomerId = Val(ExecuteScalar(strSqlCommand, ""))

        intMaxCustomerId = intMaxCustomerId + 1

        strRegNo = "CUS" & intMaxCustomerId
        strSqlCommand = "INSERT INTO customer(companyid, regno, name, address, jilloid, talukoid, rajyaid, pincode, mobile1, mobile2, adharno) VALUES (N'" & EscapeString(intCompanyId) & "',N'" & EscapeString(strRegNo) & "',N'" & EscapeString(strName) & "',N'" & EscapeString(strAddress) & "',N'" & intJilloId & "','" & intTalukoId & "',N'" & intRajyaId & "',N'" & EscapeString(strZipCode) & "',N'" & EscapeString(strmobile1) & "',N'" & EscapeString(strMobile2) & "',N'" & EscapeString(strAdharNo) & "')"

        Dim intCustomerId As Integer
        intCustomerId = ExecuteNonQuery(strSqlCommand, "AddCustomer", "Y")

        Return intCustomerId
    End Function

    Public Function InsertJamin(ByVal intCustomerid As Integer, ByVal strName As String, ByVal strMobile As String, ByVal strAddress As String) As Integer

        strSqlCommand = "INSERT INTO jamin(customerid,name,mobile,address) VALUES ('" & intCustomerid & "',N'" & EscapeString(strName) & "',N'" & EscapeString(strMobile) & "',N'" & EscapeString(strAddress) & "')"

        Dim intJaminId As Integer

        intJaminId = ExecuteNonQuery(strSqlCommand, "InsertJamin", "Y")

        Return intJaminId

    End Function

    Public Sub UpdateCustomer(ByVal intCustomerId As Integer, ByVal strRegNo As String, ByVal strName As String, ByVal strAddress As String, ByVal intJilloId As Integer, ByVal intTalukoId As Integer, ByRef intRajyaId As Integer, ByVal strZipCode As String, ByVal strmobile1 As String, ByVal strMobile2 As String, ByVal strAdharNo As String)

        strSqlCommand = "UPDATE customer SET name=N'" & EscapeString(strName) & "', address=N'" & EscapeString(strAddress) & "', jilloid=" & intJilloId & ", talukoid=" & intTalukoId & ",rajyaid=" & intRajyaId & ", pincode=N'" & EscapeString(strZipCode) & "', mobile1=N'" & EscapeString(strmobile1) & "', mobile2=N'" & EscapeString(strMobile2) & "', adharno=N'" & EscapeString(strAdharNo) & "' WHERE customerid =" & intCustomerId

        ExecuteNonQuery(strSqlCommand, "UpdateCustomer", "N")


    End Sub

    Public Function GetCustomerById(ByVal intCustomerId) As DataSet
        strSqlCommand = "SELECT customerid, companyid, regno, name, address, jilloid, talukoid, rajyaid, pincode, mobile1, mobile2, adharno FROM customer where customerid = " & intCustomerId

        Dim dstData As DataSet

        dstData = FillDataSet(strSqlCommand)
        Return dstData

    End Function

    Public Sub DeleteCustomer(ByVal intCustomerId As Integer)

        strSqlCommand = "DELETE FROM customer where customerid =" & intCustomerId

        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

    Public Function GetJaminListByCustomerId(ByVal intCustomerId As Integer) As DataSet

        strSqlCommand = "select jaminid, customerid, name, mobile, address from jamin where customerid  = " & intCustomerId

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)

        Return dstData
    End Function

    Public Sub UpdateJamin(ByVal intJaminid As Integer, ByVal strName As String, ByVal strMobile As String, ByVal strAddress As String)

        strSqlCommand = "UPDATE jamin SET name =N'" & EscapeString(strName) & "', mobile=N'" & EscapeString(strMobile) & "', address=N'" & EscapeString(strAddress) & "' WHERE jaminid=" & intJaminid

        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub
    Public Sub DeleteJamin(ByVal intJaminid As Integer)

        strSqlCommand = "DELETE FROM jamin WHERE jaminid=" & intJaminid

        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

End Class