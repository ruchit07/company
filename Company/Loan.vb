Public Class Loan
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim form2 = New LoanDetail()
        AddHandler form2.Closed, Sub(s, args) Me.Close()

        form2.lblCustomerId.Text = lblCustomerId.Text
        form2.Show()
    End Sub

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim objLoan As New clsLoan()
        Dim dstData As DataSet
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        DataGridView1.AutoGenerateColumns = False
        dstData = objLoan.GetLoanList(Val(lblCustomerId.Text))

        DataGridView1.DataSource = dstData.Tables(0)
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
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intLoanId As Integer

        intLoanId = Val(DataGridView1.CurrentRow.Cells("loanid").Value)

        Me.Hide()
        Dim form2 = New UpdateLoan()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.lblLoanId.Text = intLoanId
        form2.lblCustomerId.Text = lblCustomerId.Text
        form2.Show()
    End Sub
    Private Sub RecoveryListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryListToolStripMenuItem.Click
        Me.Hide()
        Dim form2 = New RecoveryList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub


End Class