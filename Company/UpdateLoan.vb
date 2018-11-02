Public Class UpdateLoan
    Private Sub CalculateInterest()

        Dim dblLoanAmount As Double
        Dim dblInterestRate As Double
        Dim dblInterestAmount As Double
        Dim dblTotalPayable As Double
        dblLoanAmount = Val(txtLoanAmount.Text)
        dblInterestRate = Val(txtInterestRate.Text)
        dblInterestAmount = (dblLoanAmount * dblInterestRate) / 100
        dblTotalPayable = dblLoanAmount - dblInterestAmount
        txtInterestAmount.Text = Math.Round(dblInterestAmount, 2)
        txtAdvanceAmount.Text = Math.Round(dblInterestAmount, 2)
        txtFinalAmount.Text = Math.Round(dblTotalPayable, 2)
    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged

        Me.CalculateInterest()

    End Sub

    Private Sub txtInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtInterestRate.TextChanged
        Me.CalculateInterest()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = lblCustomerId.Text
        form2.Show()
    End Sub

    Private Sub NewCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCompanyToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New CompanyDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub CompanyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyListToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerListToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New Login()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub EmployeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeListToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New Employee()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New EmployeeDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub RecoveryListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryListToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New RecoveryList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim objLoan As New clsLoan()
        objLoan.DeleteLoan(lblLoanId.Text)

        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = lblCustomerId.Text
        form2.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objLoan As New clsLoan()

        Dim strType As String
        Dim intDuration As Integer

        If ddlType.SelectedIndex = 0 Then
            strType = "D"
            intDuration = 100
        ElseIf ddlType.SelectedIndex = 1 Then
            strType = "M"
            intDuration = 1
        Else
            strType = "Y"
            intDuration = 1
        End If

        'objLoan.UpdateLoan(strType, intDuration, lblFinalDate.Text, txtLoanNumber.Text, dtAdvanceDate.Value, Val(txtLoanAmount.Text), Val(txtInterestRate.Text), txtInterestAmount.Text, Val(txtFineCharge.Text), txtAdvanceAmount.Text, txtFinalAmount.Text, ddlEmployee.SelectedValue, lblCustomerId.Text, lblLoanId.Text)
        objLoan.UpdateCustomerLoanPaidAmount(Val(txtFinalAmount.Text), lblLoanId.Text)
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = lblCustomerId.Text
        form2.Show()
    End Sub

    Private Sub UploadLoan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.employee)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Dim objLoan As New clsLoan()
        ddlType.SelectedIndex = 0
        lblFinalDate.Text = DateAdd(DateInterval.Day, 100, Date.Now().AddDays(-1)).Date

        Dim dstData As DataSet

        dstData = objLoan.GetLoanDetail(Val(lblLoanId.Text))

        If dstData.Tables(0).Rows.Count > 0 Then
            If dstData.Tables(0).Rows(0)("type") = "D" Then
                ddlType.SelectedIndex = 0
            ElseIf dstData.Tables(0).Rows(0)("type") = "M" Then
                ddlType.SelectedIndex = 1
            End If
            txtDuration.Text = Val(dstData.Tables(0).Rows(0)("duration"))
            lblFinalDate.Text = dstData.Tables(0).Rows(0)("enddate")
            txtLoanNumber.Text = dstData.Tables(0).Rows(0)("loannumber")
            dtAdvanceDate.Value = dstData.Tables(0).Rows(0)("advancedate")
            txtLoanAmount.Text = dstData.Tables(0).Rows(0)("amount")
            txtInterestRate.Text = dstData.Tables(0).Rows(0)("interestrate")
            txtInterestAmount.Text = dstData.Tables(0).Rows(0)("interestamount")
            txtFineCharge.Text = dstData.Tables(0).Rows(0)("finecharge")
            txtAdvanceAmount.Text = dstData.Tables(0).Rows(0)("advanceamount")
            txtFinalAmount.Text = dstData.Tables(0).Rows(0)("totalamount")
            ddlEmployee.SelectedValue = dstData.Tables(0).Rows(0)("employeeid")
        End If
    End Sub

    Private Sub LoanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem1.Click
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub InstallmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallmentToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New InstallmentDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub
End Class