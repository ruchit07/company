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
        lblTotalReceiving.Text = txtRecevingEmi.Text

        Dim dstInstallmentDetail As DataSet
        dstInstallmentDetail = objLoan.GetInstallment(intLoanId)
        DataGridView2.AutoGenerateColumns = False
        If dstInstallmentDetail.Tables(0).Rows.Count = 0 Then
            DataGridView2.Visible = False
        Else
            DataGridView2.Visible = True
            DataGridView2.DataSource = dstInstallmentDetail.Tables(0)

        End If

        lblLoanId.Text = intLoanId
    End Sub

    Private Sub txtPenalty_TextChanged(sender As Object, e As EventArgs) Handles txtPenalty.TextChanged
        lblTotalReceiving.Text = Val(txtRecevingEmi.Text) + Val(txtPenalty.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearControls(Me)
    End Sub

    Private Sub ClearControls(ByVal frm As Form)
        Dim ctrl As Control
        For Each ctrl In frm.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = ""
            ElseIf ctrl.GetType Is GetType(RadioButton) Then
                Dim radbut As RadioButton = ctrl
                radbut.Checked = False
            ElseIf ctrl.GetType Is GetType(DateTimePicker) Then
                Dim datetimepicker1 As DateTimePicker = ctrl
                datetimepicker1.ResetText()

            ElseIf ctrl.GetType Is GetType(GroupBox) Then
                ClearGroupedControls(ctrl)
            ElseIf ctrl.GetType Is GetType(MaskedTextBox) Then
                Dim cmb1 As MaskedTextBox = ctrl
                cmb1.Text = ""
            End If
        Next
    End Sub

    Private Sub ClearGroupedControls(ByVal gctrl As GroupBox)
        For Each ctrl In gctrl.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = ""
            ElseIf ctrl.GetType Is GetType(RadioButton) Then
                Dim radbut As RadioButton = ctrl
                radbut.Checked = False
            ElseIf ctrl.GetType Is GetType(DateTimePicker) Then
                Dim datetimepicker1 As DateTimePicker = ctrl
                datetimepicker1.ResetText()

            ElseIf ctrl.GetType Is GetType(GroupBox) Then
                ClearGroupedControls(ctrl)

            ElseIf ctrl.GetType Is GetType(ComboBox) Then
                Dim cmb1 As ComboBox = ctrl
                cmb1.SelectedIndex = 0

            ElseIf ctrl.GetType Is GetType(MaskedTextBox) Then
                Dim cmb1 As MaskedTextBox = ctrl
                cmb1.Text = ""
            End If
        Next
    End Sub

    Private Sub txtEmpNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpNo.KeyPress
        Dim objLoan As New clsLoan()
        Dim dstDetail As DataSet
        dstDetail = objLoan.GetLoadDetailByLoanNumber(txtEmpNo.Text)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstDetail.Tables(0)
        DataGridView1.Refresh()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objLoan As New clsLoan
        Dim dstLoan As DataSet
        dstLoan = objLoan.GetLoanDetail(Val(lblLoanId.Text))

        If dstLoan.Tables(0).Rows.Count > 0 Then
            objLoan.InsertInstallment(Val(lblLoanId.Text), dtDate.Value, Val(txtLoanAmount.Text), Val(txtRemainingAmount.Text), Val(txtRecevingEmi.Text), dstLoan.Tables(0).Rows(0)("emi"), Val(txtPenalty.Text))
        End If

        Dim dstInstallmentDetail As DataSet
        dstInstallmentDetail = objLoan.GetInstallment(Val(lblLoanId.Text))
        DataGridView2.AutoGenerateColumns = False
        If dstInstallmentDetail.Tables(0).Rows.Count = 0 Then
            DataGridView2.Visible = False
        Else
            DataGridView2.Visible = True
            DataGridView2.DataSource = dstInstallmentDetail.Tables(0)

        End If
    End Sub
End Class