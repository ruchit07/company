Public Class CompanyDetail
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CompanyDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RajyaDataSet.rajya' table. You can move, or remove it, as needed.
        Me.RajyaTableAdapter.Fill(Me.RajyaDataSet.rajya)
        'TODO: This line of code loads data into the 'JilloDataSet.jillo' table. You can move, or remove it, as needed.
        Me.JilloTableAdapter.Fill(Me.JilloDataSet.jillo)
        'TODO: This line of code loads data into the 'TalukoDataSet.taluko' table. You can move, or remove it, as needed.
        Me.TalukoTableAdapter.Fill(Me.TalukoDataSet.taluko)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Dim intYear As Integer
        Dim intMonth As Integer
        Dim dtDate As Date = DateTime.Now.Date()
        intMonth = DateTime.Now.Month()
        If intMonth > 3 Then

            dtDate = dtDate.AddYears(1)

        End If
        txtEndDate.Value = New DateTime(dtDate.Year, "03", "31")
    End Sub

    Private Sub ddlTaluko_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTaluko.SelectedIndexChanged
        If ddlTaluko.SelectedValue = 999999 Then
            txtOtherTaluko.Visible = True
        Else
            txtOtherTaluko.Visible = False
        End If
    End Sub

    Private Sub txtPincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPincode.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ddlJillo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlJillo.SelectedIndexChanged
        If ddlJillo.SelectedValue = 999999 Then
            txtOtherJillo.Visible = True
        Else
            txtOtherJillo.Visible = False
        End If
    End Sub

    Private Sub ddlRajya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlRajya.SelectedIndexChanged
        If ddlRajya.SelectedValue = 999999 Then
            txtOtherRajya.Visible = True
        Else
            txtOtherRajya.Visible = False
        End If
    End Sub

    Private Sub txtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        Dim dtStartDate As Date = txtStartDate.Value
        Dim dtEndDate As Date
        If dtStartDate.Month <= 3 Then
            dtEndDate = dtStartDate
        Else
            dtEndDate = dtStartDate.AddYears(1)
        End If


        txtEndDate.Value = New DateTime(dtEndDate.Year, "03", "31")
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
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not (txtPassword.Text = txtConfirmPassword.Text) Then
            MessageBox.Show("Password and Confirm Password are not same.")
            Return
        End If

        Dim objCompany As New clsCompany()
        Dim objCommon As New clsCommon()
        Dim blnUser As Boolean
        blnUser = objCompany.CheckUserName(txtUserName.Text)

        If blnUser = False Then
            MessageBox.Show("Username is already Exists")
            Return
        End If

        Dim intTalukoId As Integer
        Dim intRajyaId As Integer
        Dim intJilloId As Integer

        If ddlTaluko.SelectedValue = 999999 Then
            intTalukoId = objCommon.InsertTaluko(txtOtherTaluko.Text)
        Else
            intTalukoId = ddlTaluko.SelectedValue
        End If

        If ddlJillo.SelectedValue = 999999 Then
            intJilloId = objCommon.InsertJillo(txtOtherJillo.Text)
        Else
            intJilloId = ddlJillo.SelectedValue
        End If

        If ddlRajya.SelectedValue = 999999 Then
            intRajyaId = objCommon.InsertRajya(txtOtherRajya.Text)
        Else
            intRajyaId = ddlRajya.SelectedValue
        End If

        objCompany.InsertCompany(txtCompanyName.Text, txtAddress.Text, intJilloId, intTalukoId, intRajyaId, txtPincode.Text, txtOwnerName.Text, txtMobileNumber.Text, txtFormPre.Text & " - " & txtFormPost.Text, txtStartDate.Value, txtEndDate.Value, txtUserName.Text, txtPassword.Text)
        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
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