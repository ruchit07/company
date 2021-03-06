﻿Public Class CompanyList
    Private Sub CompanyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.company)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Dim objCompany As New clsCompany
        Dim dstCompany As New DataSet
        dstCompany = objCompany.GetCompanyList()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstCompany.Tables(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        If e.ColumnIndex = 8 Then
            Me.Hide()
            Dim form2 = New Login()
            AddHandler form2.Closed, Sub(s, args) Me.Close()
            form2.Show()
        Else
            Me.Hide()
            Dim form2 = New UpdateCompanyDetail()
            form2.lblCompanyId.Text = DataGridView1.CurrentRow.Cells("companyid").Value
            AddHandler form2.Closed, Sub(s, args) Me.Close()
            form2.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.Hide()
        Dim form2 = New CompanyDetail()
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim objCompany As New clsCompany
        Dim dstCompany As New DataSet
        dstCompany = objCompany.GetCompanyList(ddlSearch.SelectedText, txtSearch.Text)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstCompany.Tables(0)
        DataGridView1.Refresh()
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