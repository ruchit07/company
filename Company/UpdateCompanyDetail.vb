Public Class UpdateCompanyDetail
    Private Sub UpdateCompanyDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RajyaTableAdapter.Fill(Me.RajyaDataSet.rajya)
        'TODO: This line of code loads data into the 'JilloDataSet.jillo' table. You can move, or remove it, as needed.
        Me.JilloTableAdapter.Fill(Me.JilloDataSet.jillo)
        'TODO: This line of code loads data into the 'TalukoDataSet.taluko' table. You can move, or remove it, as needed.
        Me.TalukoTableAdapter.Fill(Me.TalukoDataSet.taluko)
        Dim intYear As Integer
        Dim intMonth As Integer
        Dim dtDate As Date = DateTime.Now.Date()
        intMonth = DateTime.Now.Month()
        If intMonth > 3 Then

            dtDate = dtDate.AddYears(1)

        End If
        txtEndDate.Value = New DateTime(dtDate.Year, "03", "31")

        Dim objCompany As New clsCompany
        Dim dstDetail As DataSet
        dstDetail = objCompany.GetCompanyDetailById(Val(lblCompanyId.Text))

        If dstDetail.Tables(0).Rows.Count > 0 Then
            txtCompanyName.Text = dstDetail.Tables(0).Rows(0)("name")
            txtAddress.Text = dstDetail.Tables(0).Rows(0)("address")
            ddlTaluko.SelectedValue = dstDetail.Tables(0).Rows(0)("talukoid")
            ddlJillo.SelectedValue = dstDetail.Tables(0).Rows(0)("jilloid")
            ddlRajya.SelectedValue = dstDetail.Tables(0).Rows(0)("rajyaid")
            txtPincode.Text = dstDetail.Tables(0).Rows(0)("zipcode")
            txtOwnerName.Text = dstDetail.Tables(0).Rows(0)("ownername")

            Dim strForm(2) As String
            strForm = dstDetail.Tables(0).Rows(0)("formno").ToString().Split("-")
            txtFormPre.Text = strForm(0)
            txtFormPost.Text = strForm(1)
            txtStartDate.Value = dstDetail.Tables(0).Rows(0)("startdate")
            txtEndDate.Value = dstDetail.Tables(0).Rows(0)("enddate")

        End If
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim objCompany As New clsCompany()
        objCompany.DeleteCompany(lblCompanyId.Text)

        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objCompany As New clsCompany

        objCompany.UpdateCompany(txtCompanyName.Text, txtAddress.Text, ddlJillo.SelectedValue, ddlTaluko.SelectedValue, ddlRajya.SelectedValue, txtPincode.Text, txtOwnerName.Text, txtMobileNumber.Text, txtFormPre.Text & "-" & txtFormPost.Text, txtStartDate.Value, txtEndDate.Value, Val(lblCompanyId.Text))

        Me.Hide()
        Dim form2 = New CompanyList()
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