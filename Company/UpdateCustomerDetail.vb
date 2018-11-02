Public Class UpdateCustomerDetail
    Dim intCompanyListId As Integer
    Dim intCustomerListId As Integer
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New CustomerList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblCompanyId.Text = intCompanyListId
        form2.Show()

    End Sub

    Private Sub UpdateCustomerDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RajyaTableAdapter.Fill(Me.RajyaDataSet.rajya)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'TODO: This line of code loads data into the 'JilloDataSet.jillo' table. You can move, or remove it, as needed.
        Me.JilloTableAdapter.Fill(Me.JilloDataSet.jillo)
        'TODO: This line of code loads data into the 'TalukoDataSet.taluko' table. You can move, or remove it, as needed.
        Me.TalukoTableAdapter.Fill(Me.TalukoDataSet.taluko)

        intCompanyListId = lblCompanyId.Text
        intCustomerListId = lblCustomerId.Text

        Dim objCustomer As New clsCustomer()

        Dim dstData As DataSet
        dstData = objCustomer.GetCustomerById(intCustomerListId)

        If dstData.Tables(0).Rows.Count > 0 Then
            txtRegistrationNo.Text = dstData.Tables(0).Rows(0)("regno")
            txtCustomerName.Text = dstData.Tables(0).Rows(0)("name")
            txtAddress.Text = dstData.Tables(0).Rows(0)("address")
            txtPincode.Text = dstData.Tables(0).Rows(0)("pincode")
            txtMobileNumber.Text = dstData.Tables(0).Rows(0)("mobile1")
            txtMobileNumber2.Text = dstData.Tables(0).Rows(0)("mobile2")
            txtAdharno.Text = dstData.Tables(0).Rows(0)("adharno")
            ddlTaluko.SelectedValue = dstData.Tables(0).Rows(0)("talukoid")
            ddlRajya.SelectedValue = dstData.Tables(0).Rows(0)("rajyaid")
            ddlJillo.SelectedValue = dstData.Tables(0).Rows(0)("jilloid")
        End If

        Dim DstJamin As DataSet
        DataGridView1.AutoGenerateColumns = False
        DstJamin = objCustomer.GetJaminListByCustomerId(intCustomerListId)
        DataGridView1.DataSource = DstJamin.Tables(0)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim objCustomer As New clsCustomer()

        objCustomer.InsertJamin(intCustomerListId, txtUserName.Text, txtJaminMobile.Text, txtJaminAddress.Text)

        Dim dstJaminDetail As DataSet
        dstJaminDetail = objCustomer.GetJaminListByCustomerId(intCustomerListId)

        DataGridView1.DataSource = dstJaminDetail.Tables(0)

        txtUserName.Text = ""
        txtJaminAddress.Text = ""
        txtJaminMobile.Text = ""

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim objCustomer As New clsCustomer()

        objCustomer.DeleteCustomer(intCustomerListId)

        Me.Hide()
        Dim form2 = New CustomerList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblCompanyId.Text = intCompanyListId
        form2.Show()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objCustomer As New clsCustomer()
        Dim intTalukoId As Integer
        Dim intJilloId As Integer
        Dim intRajyaId As Integer
        Dim objCommon As New clsCommon()

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

        objCustomer.UpdateCustomer(intCustomerListId, txtRegistrationNo.Text, txtCustomerName.Text, txtAddress.Text, intJilloId, intTalukoId, intRajyaId, txtPincode.Text, txtMobileNumber.Text, txtMobileNumber2.Text, txtAdharno.Text)

        Me.Hide()
        Dim form2 = New CustomerList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblCompanyId.Text = intCompanyListId
        form2.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim objCustomer As New clsCustomer()
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here

            If e.ColumnIndex = 4 Then
                objCustomer.UpdateJamin(DataGridView1.CurrentRow.Cells("jaminid").Value, DataGridView1.CurrentRow.Cells("name").Value, DataGridView1.CurrentRow.Cells("mobile").Value, DataGridView1.CurrentRow.Cells("address").Value)

            ElseIf e.ColumnIndex = 5 Then

                objCustomer.DeleteJamin(DataGridView1.CurrentRow.Cells("jaminid").Value)
            End If
            Me.Hide()
            Dim form2 = New UpdateCustomerDetail()
            AddHandler form2.Closed, Sub(s, args) Me.Close()
            form2.lblCompanyId.Text = intCompanyListId
            form2.lblCustomerId.Text = intCustomerListId
            form2.Show()
        End If

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick


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