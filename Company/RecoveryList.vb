Public Class RecoveryList


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        Dim objLoan As New clsLoan

        If e.ColumnIndex = 13 Then
            objLoan.UpdateLoanPaidAmount(DataGridView1.CurrentRow.Cells("loanid").Value, DataGridView1.CurrentRow.Cells("paidamount").Value)
            objLoan.UpdateLoanTable(DataGridView1.CurrentRow.Cells("loantableid").Value, DataGridView1.CurrentRow.Cells("paidamount").Value)
            Me.Hide()
            Dim form2 = New RecoveryList()
            AddHandler form2.Closed, Sub(s, args) Me.Close()
            form2.Show()
        End If
    End Sub

    Private Sub RecoveryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Dim objLoan As New clsLoan()
        Dim dstLoan As New DataSet
        dstLoan = objLoan.RecoveryList()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dstLoan.Tables(0)

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
End Class