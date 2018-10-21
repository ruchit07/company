﻿Public Class clsEmployee
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Sub InsertEmployee(ByVal strEmployeeNo As String, ByVal strName As String, ByVal strAddress As String, ByVal intTalukoid As Integer, ByVal intJilloId As Integer, ByVal intRajyaId As Integer, ByVal pincode As String, ByVal adharno As String, ByVal strMobile As String, ByVal dtBirthDate As DateTime, ByVal dtResignDate As DateTime, ByVal dtJoiningDate As DateTime)

        strSqlCommand = "INSERT INTO employee(employeenumber,name,address,talukoid,rajyaid,jilloid,pincode,mobile,adharno,birthdate,resigndate,joiningdate) VALUES (N'" & EscapeString(strEmployeeNo) & "',N'" & EscapeString(strName) & "',N'" & EscapeString(strAddress) & "','" & intTalukoid & "','" & intRajyaId & "','" & intJilloId & "',N'" & EscapeString(pincode) & "',N'" & EscapeString(strMobile) & "',N'" & EscapeString(adharno) & "','" & dtBirthDate & "','" & dtResignDate & "','" & dtJoiningDate & "')"

        Dim intEmployeeId As Integer

        intEmployeeId = ExecuteNonQuery(strSqlCommand, "", "N")

    End Sub

    Public Function GetEmployeeList() As DataSet

        strSqlCommand = "SELECT e.employeenumber,e.name,e.address,t.name taluko,r.name rajya,j.name jillo,pincode,mobile,adharno,birthdate,resigndate from employee e LEFT JOIN taluko t on e.talukoid = t.talukoid LEFT JOIN jillo j on j.jilloid = e.jilloid left join rajya r on r.rajyaid = e.rajyaid "

        Dim dstEmployee As DataSet

        dstEmployee = FillDataSet(strSqlCommand)

        Return dstEmployee

    End Function

    Public Function GetEmployeeDetail(ByVal intEmployeeId As Integer) As DataSet
        strSqlCommand = "SELECT employeenumber,name,address,talukoid,rajyaid,jilloid,pincode,mobile,adharno,birthdate,resigndate,joiningdate FROM employee WHERE employeeid = " & intEmployeeId

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)

        Return dstData

    End Function

    Public Sub UpdateEmployeeDetail(ByVal strEmployeeNo As String, ByVal strName As String, ByVal strAddress As String, ByVal intTalukoid As Integer, ByVal intJilloId As Integer, ByVal intRajyaId As Integer, ByVal pincode As String, ByVal adharno As String, ByVal strMobile As String, ByVal dtBirthDate As DateTime, ByVal dtResignDate As DateTime, ByVal intEmployeeId As Integer, ByVal dtJoininigDate As DateTime)


        strSqlCommand = "UPDATE employee SET employeenumber = N'" & EscapeString(strEmployeeNo) & "', name=N'" & EscapeString(strName) & "', address =N'" & EscapeString(strAddress) & "', talukoid = " & intTalukoid & ",jilloid = '" & intJilloId & "', rajyaid = '" & intRajyaId & "', pincode= N'" & EscapeString(pincode) & "', adharno=N'" & EscapeString(adharno) & "', mobile=N'" & EscapeString(strMobile) & "', birthdate='" & dtBirthDate & "', resigndate ='" & dtResignDate & "', joiningdate ='" & dtJoininigDate & "' WHERE employeeid = " & intEmployeeId

        ExecuteNonQuery(strSqlCommand, "", "N")

    End Sub

    Public Sub DeleteEmployee(ByVal intEmployeeId As Integer)
        strSqlCommand = "DELETE from employee WHERE employeeid = " & intEmployeeId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub
End Class
