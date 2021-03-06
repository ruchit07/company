﻿Public Class Employee
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.employee)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Dim objEmployee As New clsEmployee()

        Dim dstData As DataSet
        DataGridView1.AutoGenerateColumns = False
        dstData = objEmployee.GetEmployeeList()
        DataGridView1.DataSource = dstData.Tables(0)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim form2 = New EmployeeDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim intEmployeeId As Integer

        intEmployeeId = DataGridView1.CurrentRow.Cells("employeeid").Value

        Me.Hide()
        Dim form2 = New UpdateEmployeeDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblEmployeeId.Text = intEmployeeId
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim dstData As DataSet
        Dim objEmployee As New clsEmployee
        DataGridView1.AutoGenerateColumns = False
        dstData = objEmployee.GetEmployeeList(ddlSearch.Text, txtSearch.Text)
        DataGridView1.DataSource = dstData.Tables(0)
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