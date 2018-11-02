Public Class CustomerDetail
    Dim intCompanyListId As Integer
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Hide()
        Dim form2 = New CustomerList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblCompanyId.Text = intCompanyListId
        form2.Show()

    End Sub

    Private Sub CustomerDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RajyaTableAdapter.Fill(Me.RajyaDataSet.rajya)
        'TODO: This line of code loads data into the 'JilloDataSet.jillo' table. You can move, or remove it, as needed.
        Me.JilloTableAdapter.Fill(Me.JilloDataSet.jillo)
        'TODO: This line of code loads data into the 'TalukoDataSet.taluko' table. You can move, or remove it, as needed.
        Me.TalukoTableAdapter.Fill(Me.TalukoDataSet.taluko)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        intCompanyListId = lblCompanyId.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim intTalukoId As Integer
        Dim intJilloId As Integer
        Dim intRajyaId As Integer
        Dim objCommon As New clsCommon()
        Dim objCustomr As New clsCustomer()
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
        Dim intCustomerId As Integer
        intCustomerId = objCustomr.AddCustomer(Val(lblCompanyId.Text), txtRegistrationNo.Text, txtCustomerName.Text, txtAddress.Text, intJilloId, intTalukoId, intRajyaId, txtPincode.Text, txtMobileNumber.Text, txtMobileNumber2.Text, txtAdharno.Text)

        Dim intJaminId As Integer
        intJaminId = objCustomr.InsertJamin(intCustomerId, txtUserName.Text, txtJaminMobile.Text, txtJaminAddress.Text)

        Me.Hide()
        Dim form2 = New CustomerList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblCompanyId.Text = intCompanyListId
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
End Class