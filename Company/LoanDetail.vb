Public Class LoanDetail
    Private Sub ddlType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlType.SelectedIndexChanged

        If Val(txtDuration.Text) > 0 Then
            If ddlType.SelectedIndex = 0 Then
                lblFinalDate.Text = DateAdd(DateInterval.Day, Val(txtDuration.Text), Date.Now().AddDays(-1)).Date
            ElseIf ddlType.SelectedIndex = 1 Then
                lblFinalDate.Text = DateAdd(DateInterval.Month, Val(txtDuration.Text), Date.Now()).Date
            Else
                lblFinalDate.Text = DateAdd(DateInterval.Month, Val(txtDuration.Text), Date.Now().AddDays(-1)).Date
            End If
        Else
            lblFinalDate.Text = ""
        End If
        Me.CalculateInterest()
    End Sub

    Private Sub LoanDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.customer)
        'TODO: This line of code loads data into the 'EmployeeDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.employee)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        ddlType.SelectedIndex = 0
        lblFinalDate.Text = ""
        ddlCustomer.SelectedValue = lblCustomerId.Text
    End Sub

    Private Sub CalculateInterest()

        Dim dblLoanAmount As Double
        Dim dblInterestRate As Double
        Dim dblInterestAmount As Double
        Dim dblTotalPayable As Double
        Dim intDuration As Integer
        If Val(txtDuration.Text) = 0 Then
            intDuration = 1
        Else
            intDuration = Val(txtDuration.Text)
        End If
        dblLoanAmount = Val(txtLoanAmount.Text)
        dblInterestRate = Val(txtInterestRate.Text)
        If ddlType.SelectedIndex = 1 Then

            dblInterestAmount = (dblLoanAmount * dblInterestRate * intDuration) / 100
            dblTotalPayable = dblLoanAmount + dblInterestAmount
            txtEMI.Text = Math.Round(dblTotalPayable / (intDuration), 2)
            dblTotalPayable = dblTotalPayable - Val(txtEMI.Text)
            txtInterestAmount.Text = Math.Round(dblInterestAmount, 2)
            txtAdvanceAmount.Text = Math.Round(Val(txtEMI.Text), 2)
            txtFinalAmount.Text = Math.Round(dblLoanAmount - Val(txtEMI.Text) - Val(txtFineCharge.Text), 2)
            'txtEMI.Text = Math.Round(dblTotalPayable / intDuration, 2)

        ElseIf ddlType.SelectedIndex = 0 Then

            dblInterestAmount = ((dblLoanAmount * dblInterestRate * intDuration) / 100) / 30
            dblTotalPayable = dblLoanAmount + dblInterestAmount + Val(txtFineCharge.Text)
            txtEMI.Text = Math.Round(dblLoanAmount / (intDuration), 2)
            dblTotalPayable = dblTotalPayable - Val(txtEMI.Text)
            txtInterestAmount.Text = Math.Round(dblInterestAmount, 2)
            txtAdvanceAmount.Text = Math.Round(Val(txtEMI.Text), 2)
            txtFinalAmount.Text = Math.Round(dblLoanAmount - Val(txtEMI.Text) - Val(txtFineCharge.Text), 2)

        ElseIf ddlType.SelectedIndex = 2 Then
            dblInterestAmount = ((dblLoanAmount * dblInterestRate * intDuration) / 100)
            dblTotalPayable = dblLoanAmount + dblInterestAmount + Val(txtFineCharge.Text)
            txtInterestAmount.Text = Math.Round(dblInterestAmount, 2)
            txtAdvanceAmount.Text = 0
            Dim bdlTempEmi = Math.Round(dblInterestAmount, 2)
            txtFinalAmount.Text = Math.Round(dblLoanAmount - Val(bdlTempEmi) - Val(txtFineCharge.Text), 2)
            txtEMI.Text = Math.Round(dblLoanAmount, 2)
        End If

    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged

        Me.CalculateInterest()

    End Sub

    Private Sub txtInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtInterestRate.TextChanged
        Me.CalculateInterest()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objLoan As New clsLoan()

        Dim strType As String
        Dim intDuration As Integer

        If ddlType.SelectedIndex = 0 Then
            strType = "D"

        ElseIf ddlType.SelectedIndex = 1 Then
            strType = "M"

        Else
            strType = "T"

        End If
        intDuration = Val(txtDuration.Text)
        Dim intLoanId As Integer


        intLoanId = objLoan.InsertLoan(strType, intDuration, lblFinalDate.Text, txtLoanNumber.Text, dtAdvanceDate.Value, Val(txtLoanAmount.Text), Val(txtInterestRate.Text), txtInterestAmount.Text, Val(txtFineCharge.Text), txtAdvanceAmount.Text, txtFinalAmount.Text, ddlEmployee.SelectedValue, ddlCustomer.SelectedValue, Val(txtEMI.Text))

        If strType <> "T" Then

            For intI As Integer = 0 To intDuration
                Dim dtEMIDate As Date
                If strType = "D" Then

                    dtEMIDate = DateAdd(DateInterval.Day, Val(intI), Date.Now()).Date

                ElseIf strType = "M" Then
                    dtEMIDate = DateAdd(DateInterval.Month, intI, Date.Now()).Date
                End If
                objLoan.InsertLoanTable(intLoanId, dtEMIDate, Val(txtEMI.Text))
            Next
        Else
            objLoan.InsertLoanTable(intLoanId, lblFinalDate.Text, Val(txtFinalAmount.Text))
        End If
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = ddlCustomer.SelectedValue
        form2.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New Loan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = ddlCustomer.SelectedValue
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

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        If Val(txtDuration.Text) > 0 Then
            If ddlType.SelectedIndex = 0 Then
                lblFinalDate.Text = DateAdd(DateInterval.Day, Val(txtDuration.Text), Date.Now().AddDays(-1)).Date
            ElseIf ddlType.SelectedIndex = 1 Then
                lblFinalDate.Text = DateAdd(DateInterval.Month, Val(txtDuration.Text), Date.Now()).Date
            Else
                lblFinalDate.Text = DateAdd(DateInterval.Month, Val(txtDuration.Text), Date.Now().AddDays(-1)).Date
            End If
        Else
            lblFinalDate.Text = ""
        End If
        Me.CalculateInterest()
    End Sub

    Private Sub txtFineCharge_TextChanged(sender As Object, e As EventArgs) Handles txtFineCharge.TextChanged
        CalculateInterest()
    End Sub

End Class