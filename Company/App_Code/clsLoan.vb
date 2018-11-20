Public Class clsLoan
    Inherits BaseDal

    Dim strSqlCommand As String

    Public Function InsertLoan(ByVal strType As String, ByVal strDuration As Integer, ByVal dtLoanDate As Date, ByVal dtEndDate As Date, ByVal strLoanNumber As String, ByVal dtAdvanceDate As Date, ByVal dblLoanAmount As Double, ByVal dblInterestRate As Double, ByVal dblInterestAmount As Double, ByVal dblFineCharge As Double, ByVal dblAdvanceAmount As Double, ByVal dblTotalAmount As Double, ByVal intEmployeeId As Integer, ByVal intCustomerId As Integer, ByVal dblEmi As Integer) As Integer

        Dim intMaxLoanId As Integer

        strSqlCommand = "SELECT ISNULL(MAX(loanid), 0) FROM loan "
        intMaxLoanId = Val(ExecuteScalar(strSqlCommand, "InsertLoan"))
        intMaxLoanId = intMaxLoanId + 1

        If String.IsNullOrEmpty(strLoanNumber) Then
            strLoanNumber = strType & intMaxLoanId
        End If

        strSqlCommand = "INSERT INTO loan(type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,employeeid,customerid,emi,remainingamount,totalpaidamount) VALUES ('" & strType & "','" & strDuration & "','" & dtLoanDate & "','" & dtEndDate & "',N'" & strLoanNumber & "','" & dtAdvanceDate & "','" & dblLoanAmount & "','" & dblInterestRate & "','" & dblInterestAmount & "','" & dblFineCharge & "','" & dblAdvanceAmount & "','" & dblTotalAmount & "','" & intEmployeeId & "','" & intCustomerId & "'," & dblEmi & "," & IIf(strType = "M", dblLoanAmount + dblInterestAmount, dblLoanAmount) & ",0)"

        Dim intLoanId As Integer
        intLoanId = ExecuteNonQuery(strSqlCommand, "", "Y")

        Return intLoanId
    End Function
    Public Function GetLoanByNo(ByVal strLoanNumber As String) As DataSet

        strSqlCommand = "SELECT l.loanid FROM loan l WHERE loannumber = N'" & strLoanNumber & "'"


        Dim dstCustomer As DataSet
        dstCustomer = FillDataSet(strSqlCommand)

        Return dstCustomer
    End Function

    Public Sub UpdateLoan(ByVal strType As String, ByVal strDuration As Integer, ByVal dtEndDate As Date, ByVal strLoanNumber As String, ByVal dtAdvanceDate As Date, ByVal dblLoanAmount As Double, ByVal dblInterestRate As Double, ByVal dblInterestAmount As Double, ByVal dblFineCharge As Double, ByVal dblAdvanceAmount As Double, ByVal dblTotalAmount As Double, ByVal intEmployeeId As Integer, ByVal intCustomerId As Integer, ByVal LoanId As Integer)
        strSqlCommand = "UPDATE loan set type ='" & strType & "', duration ='" & strDuration & "', enddate = '" & dtEndDate & "', advancedate ='" & dtAdvanceDate & "', amount='" & dblLoanAmount & "', interestrate='" & dblInterestRate & "',interestamount='" & dblInterestAmount & "', finecharge='" & dblFineCharge & "', advanceamount='" & dblAdvanceAmount & "', totalamount ='" & dblTotalAmount & "'employeeid = " & intEmployeeId & " WHERE loanid=" & LoanId

        ExecuteNonQuery(strSqlCommand, "", "N")

    End Sub

    Public Function InsertLoanTable(ByVal intLoanId As Integer, ByVal dtDate As DateTime, ByVal dblInterestAmount As Double, Optional ByVal dblPaidAmount As Double = 0) As Integer
        strSqlCommand = "INSERT INTO loantable(loanid,loandate,interestamount,paidamount) VALUES(" & intLoanId & ",'" & dtDate & "'," & dblInterestAmount & "," & dblPaidAmount & ")"
        Dim intLoanTableId As Integer

        intLoanTableId = ExecuteNonQuery(strSqlCommand, "", "Y")
        Return intLoanTableId
    End Function

    Public Sub UpdateLoanTable(ByVal intLoanTableId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loantable SET paidamount =" & dblPaidAmount & " WHERE loantableid = " & intLoanTableId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub
    Public Function GetLoanDetail(ByVal intLoanId As Integer) As DataSet
        strSqlCommand = "SELECT loanid,type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,employeeid,customerid,emi,ISNULL(remainingamount,0)remainingamount,isnull(totalpaidamount,0)totalpaidamount FROM loan WHERE loanid = " & intLoanId

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function

    Public Sub UpdateLoanPaidAmount(ByVal intLoanId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loan SET remainingamount = remainingamount - " & dblPaidAmount & ",totalpaidamount = totalpaidamount + " & dblPaidAmount & " WHERE loanid = " & intLoanId

        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

    Public Sub UpdateCustomerLoanPaidAmount(ByVal intLoanId As Integer, ByVal dblPaidAmount As Double)
        strSqlCommand = "UPDATE loan SET totalamount = " & dblPaidAmount & " WHERE loanid = " & intLoanId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub
    Public Function GetLoanList(Optional ByVal intCustomerId As Integer = 0) As DataSet
        strSqlCommand = "select l.loanid,CASE type WHEN 'D' THEN 'Day' WHEN 'M' THEN 'Month(EMI)' WHEN 'T' THEN 'Month' END type,duration,convert(varchar,loandate,103)loandate,enddate,loannumber,convert(varchar,advancedate,103)advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,e.name employee,c.name customer,c.mobile1 mobile,isnull(totalpaidamount,0)totalpaidamount,ISNULL(remainingamount,0)remainingamount,l.emi,ISNULL((SELECT CONVERT(varchar(20),MIN(loandate),103) FROM loantable ln WHERE ln.loanid = l.loanid and ISNULL(ln.paidamount,0) = 0),'N/A')  nextemidate from loan l left join employee e on e.employeeid = l.employeeid left join customer c on c.customerid = l.customerid "

        If intCustomerId > 0 Then
            strSqlCommand &= " WHERE l.customerid = " & intCustomerId
        End If
        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function
    Public Function RecoveryList(ByVal dtStartDate As DateTime, ByVal dtEndDate As DateTime, Optional ByVal intCustomerId As Integer = 0, Optional ByVal intLoanId As Integer = 0) As DataSet
        strSqlCommand = "select l.loanid,ln.loantableid,CASE type WHEN 'D' THEN 'Day' WHEN 'M' THEN 'Month(EMI)' WHEN 'T' THEN 'Month' END type,duration,ln.loandate,enddate,loannumber,advancedate,amount,interestrate,ln.interestamount,finecharge,advanceamount,totalamount,e.name employee,c.name customer,c.mobile1 mobile, ISNULL(ln.paidamount, 0) paidamount,isnull(l.totalpaidamount,0)totalpaidamount,ISNULL(l.remainingamount,0)remainingamount from loan l left join employee e on e.employeeid = l.employeeid left join customer c on c.customerid = l.customerid left join loantable ln on l.loanid = ln.loanid WHERE ((DATEADD(dd, 0, DATEDIFF(dd, 0, ln.loandate)) >=  DATEADD(dd, 0, DATEDIFF(dd, 0, '" & dtStartDate & "'))) AND (DATEADD(dd, 0, DATEDIFF(dd, 0, ln.loandate)) <=  DATEADD(dd, 0, DATEDIFF(dd, 0, '" & dtEndDate & "'))))"

        If intCustomerId > 0 Then
            strSqlCommand &= " AND l.customerid = " & intCustomerId
        End If

        If intLoanId > 0 Then
            strSqlCommand &= " AND l.loanid =" & intLoanId
        End If
        Dim dstData As DataSet
            dstData = FillDataSet(strSqlCommand)
            Return dstData
    End Function
    Public Sub DeleteLoan(ByVal intLoanId As Integer)
        strSqlCommand = "DELETE FROM loan where loanid = " & intLoanId
        ExecuteNonQuery(strSqlCommand, "", "N")

        strSqlCommand = "DELETE FROM loantable where loanid = " & intLoanId
        ExecuteNonQuery(strSqlCommand, "", "N")
    End Sub

    Public Function GetLoanList() As DataSet
        Dim dstData As DataSet
        strSqlCommand = "select 0 loanid, 'All' loannumber UNION ALL SELECT loanid,loannumber from loan "
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function

    Public Function GetLoadDetailByLoanNumber(ByVal strSearchText As String) As DataSet
        strSqlCommand = "SELECT l.loanid,type,duration,loandate,enddate,loannumber,advancedate,amount,interestrate,interestamount,finecharge,advanceamount,totalamount,employeeid,c.customerid, c.name customername, c.mobile1 mobile, c.regno FROM loan l inner join customer c on l.customerid = c.customerid WHERE loannumber like N'%" & EscapeString(strSearchText) & "%' OR c.mobile1 like N'%" & EscapeString(strSearchText) & "%' or c.regno like '%" & EscapeString(strSearchText) & "%'"

        Dim dstData As DataSet
        dstData = FillDataSet(strSqlCommand)
        Return dstData
    End Function

    Public Function GetPaidEMIByLoanId(ByVal intLoanId As Integer) As Integer
        Dim intPaidEMI As Integer
        strSqlCommand = "SELECT ISNULL(COUNT(*),0) FROM loantable WHERE loanid = " & intLoanId & " AND ISNULL(paidamount,0) > 0"

        intPaidEMI = Val(ExecuteScalar(strSqlCommand, ""))
        Return intPaidEMI

    End Function

    Public Function GetPaidEMIInstallmentByLoanId(ByVal intLoanId As Integer) As Integer
        Dim intPaidEMI As Integer
        strSqlCommand = "SELECT ISNULL(COUNT(*),0) FROM installment WHERE loanid = " & intLoanId & ""

        intPaidEMI = Val(ExecuteScalar(strSqlCommand, ""))
        Return intPaidEMI

    End Function
    Public Function GetPendingEMI(ByVal intLoanId As Integer) As Integer
        Dim intPaidEMI As Integer
        strSqlCommand = "SELECT ISNULL(COUNT(*),0) FROM loantable WHERE loanid = " & intLoanId & " AND ISNULL(paidamount,0) = 0"

        intPaidEMI = Val(ExecuteScalar(strSqlCommand, ""))
        Return intPaidEMI

    End Function

    Public Function GetPendingEMIInstallment(ByVal intLoanId As Integer) As Integer
        Dim intPaidEMI As Integer
        strSqlCommand = "SELECT l.duration - ISNULL(MAX(emino),0) FROM installment i INNER JOIN loan l on l.loanid = i.loanid WHERE i.loanid = " & intLoanId & " GROUP BY l.duration"

        intPaidEMI = Val(ExecuteScalar(strSqlCommand, ""))
        Return intPaidEMI

    End Function

    Public Sub InsertInstallment(ByVal intLoanId As Integer, ByVal installmentDate As DateTime, ByVal dblLoanAmount As Double, ByVal dblRemainingAmount As Double, ByVal dblPaidAmount As Double, ByVal dblEMI As Double, ByVal dblPenlty As Double, ByVal installmentReceivedDate As DateTime)
        Dim intEMINo As Integer
        strSqlCommand = "SELECT ISNULL(MAX(emino),0) FROM installment WHERE loanid = " & intLoanId
        intEMINo = Val(ExecuteScalar(strSqlCommand, ""))

        strSqlCommand = "INSERT INTO installment(emino,loanid,installmentdate,loanamount,receivedamount,remainingamount,emi,penlty, installmentreceiveddate) VALUES(" & intEMINo + 1 & "," & intLoanId & ",'" & installmentDate & "'," & dblLoanAmount & "," & dblEMI & "," & dblRemainingAmount & "," & dblEMI & "," & dblPenlty & ",'" & installmentReceivedDate & "')"

        Dim intInstallmentId As Integer
        intInstallmentId = ExecuteNonQuery(strSqlCommand, "", "Y")

    End Sub

    Public Function GetInstallment(ByVal intLoanId As Integer) As DataSet
        strSqlCommand = "SELECT emino,loanid,installmentdate,loanamount,(ISNULL(emino, 1) * emi) receivedamount,remainingamount,emi,penlty,installmentreceiveddate FROM installment WHERE loanid =" & intLoanId

        Dim dstDetail As DataSet
        dstDetail = FillDataSet(strSqlCommand)
        Return dstDetail

    End Function

    Public Function GetMaxInstallmentDate(ByVal intLoanId As Integer) As DateTime
        Dim dtInstallmentDate As DateTime
        strSqlCommand = "SELECT ISNULL(MAX(installmentdate),'')installmentdate FROM installment WHERE loanid =  " & intLoanId & ""

        dtInstallmentDate = ExecuteScalar(strSqlCommand, "")
        Return dtInstallmentDate

    End Function
End Class
