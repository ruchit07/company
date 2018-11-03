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

    Private Sub LoanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem1.Click
        Me.Hide()
        Dim form2 = New Loan()
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
                lblDays.Visible = True
                txtDays.Visible = True

            ElseIf strType = "M" Then
                txtLoanType.Text = "Monthly(EMI)"
                lblDays.Visible = False
                txtDays.Visible = False

            ElseIf strType = "T" Then
                txtLoanType.Text = "Monthly"
                lblDays.Visible = False
                txtDays.Visible = False
            End If
            txtLoanDate.Value = dstLoan.Tables(0).Rows(0)("loandate")
            txtLoanEndDate.Value = dstLoan.Tables(0).Rows(0)("enddate")
            txtLoanAmount.Text = dstLoan.Tables(0).Rows(0)("amount")
            txtTotalAmount.Text = dstLoan.Tables(0).Rows(0)("totalamount")
            txtRemainingAmount.Text = dstLoan.Tables(0).Rows(0)("remainingamount")
            txtRecevingEmi.Text = dstLoan.Tables(0).Rows(0)("totalpaidamount")
            txtEmi.Text = dstLoan.Tables(0).Rows(0)("emi")
            txtInterest.Text = dstLoan.Tables(0).Rows(0)("interestamount")
            txtFileCharge.Text = dstLoan.Tables(0).Rows(0)("finecharge")
            txtDays.Text = 1

            Dim dstCustomer As DataSet
            Dim objCustomer As New clsCustomer
            dstCustomer = objCustomer.GetCustomerById(dstLoan.Tables(0).Rows(0)("customerid"))
            If dstCustomer.Tables(0).Rows.Count > 0 Then
                txtCustomerName.Text = dstCustomer.Tables(0).Rows(0)("name")
            End If

        End If

        txtReceivedEmi.Text = Val(objLoan.GetPaidEMIInstallmentByLoanId(intLoanId))
        txtPendingEmi.Text = Val(objLoan.GetPendingEMIInstallment(intLoanId))
        lblTotalReceiving.Text = Val(txtEmi.Text) + Val(txtPenalty.Text)

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
        lblTotalReceiving.Text = Val(txtEmi.Text) + Val(txtPenalty.Text)
    End Sub

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged
        If Val(txtPendingEmi.Text) < Val(txtDays.Text) Then
            txtDays.Text = Val(txtPendingEmi.Text)
        End If
        lblTotalReceiving.Text = Val(txtEmi.Text) * Val(txtDays.Text)
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
        Dim strType As String
        strType = dstLoan.Tables(0).Rows(0)("type")

        If dstLoan.Tables(0).Rows.Count > 0 And Val(txtRemainingAmount.Text) > 0 Then
            Dim remainingAmount = (Val(txtLoanAmount.Text) - (Val(txtReceivedEmi.Text) * dstLoan.Tables(0).Rows(0)("emi")) - dstLoan.Tables(0).Rows(0)("emi"))
            txtDays.Text = IIf(Val(txtDays.Text) <= 0, "1", Val(txtDays.Text))
            Dim receivingEmi = Val(txtRecevingEmi.Text) / IIf(Val(txtDays.Text) >= 1, Val(txtDays.Text), 1)

            If strType = "D" Then
                For intI = 1 To Val(txtDays.Text)
                    Dim dtEMIDate As Date = objLoan.GetMaxInstallmentDate(Val(lblLoanId.Text))
                    dtDate.Value = DateAdd(DateInterval.Day, 0, dtDate.Value).Date
                    dtEMIDate = IIf(dtEMIDate = DateTime.MinValue, dtDate.Value, dtEMIDate)
                    dtEMIDate = DateAdd(DateInterval.Day, 1, dtEMIDate).Date

                    objLoan.InsertInstallment(Val(lblLoanId.Text), dtEMIDate, Val(txtLoanAmount.Text), remainingAmount, receivingEmi, dstLoan.Tables(0).Rows(0)("emi"), Val(txtPenalty.Text))
                    objLoan.UpdateLoanPaidAmount(Val(lblLoanId.Text), dstLoan.Tables(0).Rows(0)("emi"))
                    remainingAmount -= dstLoan.Tables(0).Rows(0)("emi")
                    receivingEmi += dstLoan.Tables(0).Rows(0)("emi")
                Next
            Else
                objLoan.InsertInstallment(Val(lblLoanId.Text), dtDate.Value, Val(txtLoanAmount.Text), remainingAmount, receivingEmi, dstLoan.Tables(0).Rows(0)("emi"), Val(txtPenalty.Text))
                objLoan.UpdateLoanPaidAmount(Val(lblLoanId.Text), dstLoan.Tables(0).Rows(0)("emi"))
            End If

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

        ClearControls(Me)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.Show()
    End Sub
End Class