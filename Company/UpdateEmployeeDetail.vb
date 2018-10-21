Public Class UpdateEmployeeDetail
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim objEmployee As New clsEmployee()
        objEmployee.DeleteEmployee(Val(lblEmployeeId.Text))

        Me.Hide()
        Dim form2 = New Employee()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objEmployee As New clsEmployee()

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
        objEmployee.UpdateEmployeeDetail(txtEmployeeNo.Text, txtCustomerName.Text, txtAddress.Text, intTalukoId, intJilloId, intRajyaId, txtPincode.Text, txtAdharno.Text, txtMobileNumber.Text, dtBirthDate.Value, dtResignDate.Value, lblEmployeeId.Text, dtJoiningDate.Value)

        Me.Hide()
        Dim form2 = New Employee()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.Show()
    End Sub

    Private Sub UpdateEmployeeDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RajyaTableAdapter.Fill(Me.RajyaDataSet.rajya)
        'TODO: This line of code loads data into the 'JilloDataSet.jillo' table. You can move, or remove it, as needed.
        Me.JilloTableAdapter.Fill(Me.JilloDataSet.jillo)
        'TODO: This line of code loads data into the 'TalukoDataSet.taluko' table. You can move, or remove it, as needed.
        Me.TalukoTableAdapter.Fill(Me.TalukoDataSet.taluko)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Dim objEmployee As New clsEmployee()

        Dim dstData As DataSet
        dstData = objEmployee.GetEmployeeDetail(lblEmployeeId.Text)

        If dstData.Tables(0).Rows.Count > 0 Then
            txtEmployeeNo.Text = dstData.Tables(0).Rows(0)("employeenumber")
            txtCustomerName.Text = dstData.Tables(0).Rows(0)("name")
            txtAddress.Text = dstData.Tables(0).Rows(0)("address")
            ddlTaluko.SelectedValue = dstData.Tables(0).Rows(0)("talukoid")
            ddlJillo.SelectedValue = dstData.Tables(0).Rows(0)("jilloid")
            ddlRajya.SelectedValue = dstData.Tables(0).Rows(0)("rajyaid")
            txtPincode.Text = dstData.Tables(0).Rows(0)("pincode")
            txtMobileNumber.Text = dstData.Tables(0).Rows(0)("mobile")
            txtAdharno.Text = dstData.Tables(0).Rows(0)("adharno")
            dtBirthDate.Value = dstData.Tables(0).Rows(0)("birthdate")
            dtResignDate.Value = dstData.Tables(0).Rows(0)("resigndate")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New Employee()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.Show()
    End Sub

    Private Sub NewCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Dim form2 = New CompanyDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub CompanyListToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Dim form2 = New Login()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub EmployeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Dim form2 = New Employee()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
End Class