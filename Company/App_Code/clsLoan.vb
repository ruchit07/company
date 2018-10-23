Public Class clsLoan
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Function InsertLoan(ByVal strType As String, ByVal strDuration As Integer, ByVal dtEndDate As Date, ByVal strLoanNumber As String, ByVal dtAdvanceDate As Date, ByVal dblLoanAmount As Double, ByVal dblInterestRate As Double, ByVal dblInterestAmount As Double, ByVal dblFineCharge As Double, ByVal dblAdvanceAmount As Double, ByVal dblTotalAmount As Double, ByVal intEmployeeId As Integer, ByVal intCustomerId As Integer, ByVal dblEmi As Integer) As Integer

        Dim intMaxLoanId As Integer

        strSqlCommand = "SELECT MAX(loanid) FROM loan "
        intMaxLoanId = Val(ExecuteScalar(strSqlCommand, "InsertLoan"))
        intMaxLoanId = intMaxLoanId + 1
        strLoanNumber = strType & intMaxLoanId
        strSqlCommand = "INSERT INTO loan(type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,employeeid,customerid,emi) VALUES ('" & strType & "','" & strDuration & "',GETDATE(),'" & dtEndDate & "',N'" & strLoanNumber & "','" & dtAdvanceDate & "','" & dblLoanAmount & "','" & dblInterestRate & "','" & dblInterestAmount & "','" & dblFineCharge & "','" & dblAdvanceAmount & "','" & dblTotalAmount & "','" & intEmployeeId & "','" & intCustomerId & "'," & dblEmi & ")"

        Dim intLoanId As Integer
        intLoanId = ExecuteNonQuery(strSqlCommand, "", "Y")

        Return intLoanId
    End Function

    Public Sub UpdateLoan(ByVal strType As String, ByVal strDuration As Integer, ByVal dtEndDate As Date, ByVal strLoanNumber As String, ByVal dtAdvanceDate As Date, ByVal dblLoanAmount As Double, ByVal dblInterestRate As Double, ByVal dblInterestAmount As Double, ByVal dblFineCharge As Double, ByVal dblAdvanceAmount As Double, ByVal dblTotalAmount As Double, ByVal intEmployeeId As Integer, ByVal intCustomerId As Integer, ByVal LoanId As Integer)
        strSqlCommand = "UPDATE loan set type ='" & strType & "', duration ='" & strDuration & "', enddate = '" & dtEndDate & "', advancedate ='" & dtAdvanceDate & "', amount='" & dblLoanAmount & "', interestrate='" & dblInterestRate & "',interestamount='" & dblInterestAmount & "', finecharge='" & dblFineCharge & "', advanceamount='" & dblAdvanceAmount & "', totalamount ='" & dblTotalAmount & "'employeeid = " & intEmployeeId & " WHERE loanid=" & LoanId

        ExecuteNonQuery(strSqlCommand, "", "N")

    End Sub

    Public Sub InsertLoanTable(ByVal intLoanId As Integer, ByVal dtDate As DateTime, ByVal dblInterestAmount As Double)
        strSqlCommand = "INSERT INTO loantable(loanid,loandate,interestamount,paidamount) VALUES(" & intLoanId & ",'" & dtDate & "'," & dblInterestAmount & ",0)"
        Dim intLoanTableId As Integer

        intLoanTableId = ExecuteNonQuery(strSqlCommand, "", "Y")

    End Sub

    Public Sub UpdateLoanTable(ByVal intLoanTableId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loantable SET paidamount =" & dblPaidAmount & " WHERE loantableid = " & intLoanTableId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub
    Public Function GetLoanDetail(ByVal intLoanId As Integer) As DataSet
        strSqlCommand = "SELECT type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,employeeid,customerid FROM loan WHERE loanid = " & intLoanId

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function

    Public Sub UpdateLoanPaidAmount(ByVal intLoanId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loan SET totalamount = totalamount - " & dblPaidAmount & " WHERE loanid = " & intLoanId
    End Sub

    Public Sub UpdateCustomerLoanPaidAmount(ByVal intLoanId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loan SET totalamount = " & dblPaidAmount & " WHERE loanid = " & intLoanId
    End Sub
    Public Function GetLoanList(Optional ByVal intCustomerId As Integer = 0) As DataSet
        strSqlCommand = "select l.loanid,CASE type WHEN 'D' THEN 'Day' WHEN 'M' THEN 'Month' WHEN 'Y' THEN 'Year' END type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,e.name employee,c.name customer,c.mobile1 mobile from loan l left join employee e on e.employeeid = l.employeeid left join customer c on c.customerid = l.customerid "

        If intCustomerId > 0 Then
            strSqlCommand &= " WHERE l.customerid = " & intCustomerId
        End If
        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function
    Public Function RecoveryList(Optional ByVal intCustomerId As Integer = 0) As DataSet
        strSqlCommand = "select l.loanid,ln.loantableid,CASE type WHEN 'D' THEN 'Day' WHEN 'M' THEN 'Month' WHEN 'Y' THEN 'Year' END type,duration,ln.loandate,enddate,loannumber,advancedate,amount,interestrate,ln.interestamount,finecharge,advanceamount,totalamount,e.name employee,c.name customer,c.mobile1 mobile, ISNULL(ln.paidamount, 0) paidamount from loan l left join employee e on e.employeeid = l.employeeid left join customer c on c.customerid = l.customerid left join loantable ln on l.loanid = ln.loanid WHERE ((DATEADD(dd, 0, DATEDIFF(dd, 0, ln.loandate)) =  DATEADD(dd, 0, DATEDIFF(dd, 0, getdate()))))"

        If intCustomerId > 0 Then
            strSqlCommand &= " AND l.customerid = " & intCustomerId
        End If
        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function
    Public Sub DeleteLoan(ByVal intLoanId As Integer)
        strSqlCommand = "DELETE FROM loan where loanid = " & intLoanId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

End Class
