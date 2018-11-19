Public Class CustomerLoanDetail


    Public Sub SearchCustomer()
        Dim dstCustomer As DataSet
        Dim objCustomer As New clsCustomer
        dstCustomer = objCustomer.SearchCustomer(txtCustomerNo.Text, txtCustomerName.Text, txtMobileNumber.Text, txtLoanNo.Text)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstCustomer.Tables(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub txtCustomerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerName.KeyPress
        Me.SearchCustomer()
    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        Me.SearchCustomer()
    End Sub

    Private Sub txtCustomerNo_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerNo.TextChanged
        Me.SearchCustomer()
    End Sub

    Private Sub txtCustomerNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerNo.KeyPress
        Me.SearchCustomer()
    End Sub

    Private Sub txtLoanNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoanNo.KeyPress
        Me.SearchCustomer()
    End Sub

    Private Sub txtLoanNo_TextChanged(sender As Object, e As EventArgs) Handles txtLoanNo.TextChanged
        Me.SearchCustomer()
    End Sub

    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged
        Me.SearchCustomer()
    End Sub

    Private Sub txtMobileNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        Me.SearchCustomer()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intCustomerId As Integer
        intCustomerId = DataGridView1.CurrentRow.Cells("customerid").Value
        DataGridView2.AutoGenerateColumns = False

        Dim objLoan As New clsLoan()

        Dim dstLoan As DataSet

        dstLoan = objLoan.GetLoanList(intCustomerId)
        DataGridView2.DataSource = dstLoan.Tables(0)
        DataGridView2.Refresh()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim intLoanId As Integer
        intLoanId = DataGridView2.CurrentRow.Cells("loanid").Value

        Dim objLoan As New clsLoan()
        Dim dstLoan As DataSet
        dstLoan = objLoan.GetLoanDetail(intLoanId)
        If dstLoan.Tables(0).Rows.Count > 0 Then
            txtLoanNumber.Text = dstLoan.Tables(0).Rows(0)("loannumber")
            txtLoanAmount.Text = dstLoan.Tables(0).Rows(0)("amount")
            txtLoanDate.Value = dstLoan.Tables(0).Rows(0)("loandate")
            txtAdvanceDate.Value = dstLoan.Tables(0).Rows(0)("advancedate")
            txtEndDate.Value = dstLoan.Tables(0).Rows(0)("enddate")
            txtEmi.Text = dstLoan.Tables(0).Rows(0)("emi")
            txtPaidAmount.Text = dstLoan.Tables(0).Rows(0)("totalpaidamount")
            txtPendingAmount.Text = dstLoan.Tables(0).Rows(0)("remainingamount")
            txtInstalmentDone.Text = Val(objLoan.GetPaidEMIByLoanId(intLoanId))
            txtPendingInstallment.Text = Val(objLoan.GetPendingEMI(intLoanId))
            txtInstallments.Text = Val(txtInstalmentDone.Text) + Val(txtPendingInstallment.Text)

        End If

        DataGridView3.AutoGenerateColumns = False
        Dim dstInstallment As DataSet
        dstInstallment = objLoan.GetInstallment(intLoanId)
        DataGridView3.DataSource = dstInstallment.Tables(0)
        DataGridView3.Refresh()

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
    Private Sub CustomerLoanDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerLoanDetailToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New CustomerLoanDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub
End Class