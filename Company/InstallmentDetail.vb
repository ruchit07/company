Public Class InstallmentDetail
    Private Sub InstallmentDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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

    Private Sub InstallmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallmentToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New InstallmentDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        Dim objLoan As New clsLoan()
        Dim dstDetail As DataSet
        dstDetail = objLoan.GetLoadDetailByLoanNumber(txtEmpNo.Text)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstDetail.Tables(0)
        DataGridView1.Refresh()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intLoanId As Integer
        intLoanId = DataGridView1.CurrentRow.Cells("loanid").Value

        Dim dstLoan As DataSet
        Dim objLoan As New clsLoan
        dstLoan = objLoan.GetLoanDetail(intLoanId)

        If dstLoan.Tables(0).Rows.Count > 0 Then
            Dim strType As String
            strType = dstLoan.Tables(0).Rows(0)("type")

            If strType = "D" Then
                txtLoanType.Text = "Daily"
            ElseIf strType = "M" Then
                txtLoanType.Text = "Monthly(EMI)"

            ElseIf strType = "T" Then
                txtLoanType.Text = "Monthly"
            End If
            txtLoanDate.Value = dstLoan.Tables(0).Rows(0)("loandate")
            txtLoanEndDate.Value = dstLoan.Tables(0).Rows(0)("enddate")
            txtLoanAmount.Text = dstLoan.Tables(0).Rows(0)("amount")
            txtTotalAmount.Text = dstLoan.Tables(0).Rows(0)("totalamount")
            txtRemainingAmount.Text = dstLoan.Tables(0).Rows(0)("remainingamount")
            txtRecevingEmi.Text = dstLoan.Tables(0).Rows(0)("totalpaidamount")

            Dim dstCustomer As DataSet
            Dim objCustomer As New clsCustomer
            dstCustomer = objCustomer.GetCustomerById(dstLoan.Tables(0).Rows(0)("customerid"))
            If dstCustomer.Tables(0).Rows.Count > 0 Then
                txtCustomerName.Text = dstCustomer.Tables(0).Rows(0)("name")
            End If

        End If

        txtReceivedEmi.Text = Val(objLoan.GetPaidEMIByLoanId(intLoanId))
        txtPendingEmi.Text = Val(objLoan.GetPendingEMI(intLoanId))
    End Sub
End Class