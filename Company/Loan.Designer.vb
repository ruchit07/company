﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.loanid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loannumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loandate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.advancedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interestamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finecharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.advanceamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpaidamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalremainingamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nextemidate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interestrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerLoanDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1182, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(542, 32)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(39, 13)
        Me.lblCustomerId.TabIndex = 1
        Me.lblCustomerId.Text = "Label1"
        Me.lblCustomerId.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.loanid, Me.loannumber, Me.customer, Me.mobile, Me.loandate, Me.advancedate, Me.amount, Me.interestamount, Me.finecharge, Me.totalamount, Me.advanceamount, Me.totalpaidamount, Me.totalremainingamount, Me.nextemidate, Me.interestrate})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 352)
        Me.DataGridView1.TabIndex = 2
        '
        'loanid
        '
        Me.loanid.DataPropertyName = "loanid"
        Me.loanid.HeaderText = "loanid"
        Me.loanid.Name = "loanid"
        Me.loanid.ReadOnly = True
        Me.loanid.Visible = False
        '
        'loannumber
        '
        Me.loannumber.DataPropertyName = "loannumber"
        Me.loannumber.HeaderText = "લૉન નંબર"
        Me.loannumber.Name = "loannumber"
        Me.loannumber.ReadOnly = True
        '
        'customer
        '
        Me.customer.DataPropertyName = "customer"
        Me.customer.HeaderText = "ગ્રાહક નુ નામ"
        Me.customer.Name = "customer"
        Me.customer.ReadOnly = True
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile"
        Me.mobile.HeaderText = "મોબાઈલ નંબર​"
        Me.mobile.Name = "mobile"
        Me.mobile.ReadOnly = True
        '
        'loandate
        '
        Me.loandate.DataPropertyName = "loandate"
        Me.loandate.HeaderText = "લૉન તારીખ"
        Me.loandate.Name = "loandate"
        Me.loandate.ReadOnly = True
        '
        'advancedate
        '
        Me.advancedate.DataPropertyName = "advancedate"
        Me.advancedate.HeaderText = "એડવાન્સ તારીખ​"
        Me.advancedate.Name = "advancedate"
        Me.advancedate.ReadOnly = True
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "લોન રકમ"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'interestamount
        '
        Me.interestamount.DataPropertyName = "interestamount"
        Me.interestamount.HeaderText = "વ્યાજ રકમ​"
        Me.interestamount.Name = "interestamount"
        Me.interestamount.ReadOnly = True
        '
        'finecharge
        '
        Me.finecharge.DataPropertyName = "finecharge"
        Me.finecharge.HeaderText = "ફાઇલ ચાર્જ​"
        Me.finecharge.Name = "finecharge"
        Me.finecharge.ReadOnly = True
        '
        'totalamount
        '
        Me.totalamount.DataPropertyName = "totalamount"
        Me.totalamount.HeaderText = "આપેલ રકમ​"
        Me.totalamount.Name = "totalamount"
        Me.totalamount.ReadOnly = True
        '
        'advanceamount
        '
        Me.advanceamount.DataPropertyName = "advanceamount"
        Me.advanceamount.HeaderText = "એડવાન્સ રકમ​"
        Me.advanceamount.Name = "advanceamount"
        Me.advanceamount.ReadOnly = True
        '
        'totalpaidamount
        '
        Me.totalpaidamount.DataPropertyName = "totalpaidamount"
        Me.totalpaidamount.HeaderText = "ભરેલ રકમ​"
        Me.totalpaidamount.Name = "totalpaidamount"
        Me.totalpaidamount.ReadOnly = True
        '
        'totalremainingamount
        '
        Me.totalremainingamount.DataPropertyName = "remainingamount"
        Me.totalremainingamount.HeaderText = "બાકિ રકમ​"
        Me.totalremainingamount.Name = "totalremainingamount"
        Me.totalremainingamount.ReadOnly = True
        '
        'nextemidate
        '
        Me.nextemidate.DataPropertyName = "nextemidate"
        Me.nextemidate.HeaderText = "આગામી હપ્તાની તરીખ​"
        Me.nextemidate.Name = "nextemidate"
        Me.nextemidate.ReadOnly = True
        '
        'interestrate
        '
        Me.interestrate.DataPropertyName = "interestrate"
        Me.interestrate.HeaderText = "વ્યાજ"
        Me.interestrate.Name = "interestrate"
        Me.interestrate.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1257, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyListToolStripMenuItem, Me.NewCompanyToolStripMenuItem})
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'CompanyListToolStripMenuItem
        '
        Me.CompanyListToolStripMenuItem.Name = "CompanyListToolStripMenuItem"
        Me.CompanyListToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CompanyListToolStripMenuItem.Text = "Company List"
        '
        'NewCompanyToolStripMenuItem
        '
        Me.NewCompanyToolStripMenuItem.Name = "NewCompanyToolStripMenuItem"
        Me.NewCompanyToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewCompanyToolStripMenuItem.Text = "New Company"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerListToolStripMenuItem, Me.CustomerLoanDetailToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerListToolStripMenuItem
        '
        Me.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem"
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CustomerListToolStripMenuItem.Text = "Customer List"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeListToolStripMenuItem, Me.NewEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EmployeeListToolStripMenuItem
        '
        Me.EmployeeListToolStripMenuItem.Name = "EmployeeListToolStripMenuItem"
        Me.EmployeeListToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EmployeeListToolStripMenuItem.Text = "Employee List"
        '
        'NewEmployeeToolStripMenuItem
        '
        Me.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem"
        Me.NewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewEmployeeToolStripMenuItem.Text = "New Employee"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripMenuItem1, Me.RecoveryListToolStripMenuItem, Me.InstallmentToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'LoanToolStripMenuItem1
        '
        Me.LoanToolStripMenuItem1.Name = "LoanToolStripMenuItem1"
        Me.LoanToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.LoanToolStripMenuItem1.Text = "Loan"
        '
        'RecoveryListToolStripMenuItem
        '
        Me.RecoveryListToolStripMenuItem.Name = "RecoveryListToolStripMenuItem"
        Me.RecoveryListToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RecoveryListToolStripMenuItem.Text = "Recovery List"
        '
        'InstallmentToolStripMenuItem
        '
        Me.InstallmentToolStripMenuItem.Name = "InstallmentToolStripMenuItem"
        Me.InstallmentToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.InstallmentToolStripMenuItem.Text = "Installment"
        '
        'CustomerLoanDetailToolStripMenuItem
        '
        Me.CustomerLoanDetailToolStripMenuItem.Name = "CustomerLoanDetailToolStripMenuItem"
        Me.CustomerLoanDetailToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CustomerLoanDetailToolStripMenuItem.Text = "Customer Loan Detail"
        '
        'Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCustomerId)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Loan"
        Me.Text = "Loan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents loanid As DataGridViewTextBoxColumn
    Friend WithEvents loannumber As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents loandate As DataGridViewTextBoxColumn
    Friend WithEvents advancedate As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents interestamount As DataGridViewTextBoxColumn
    Friend WithEvents finecharge As DataGridViewTextBoxColumn
    Friend WithEvents totalamount As DataGridViewTextBoxColumn
    Friend WithEvents advanceamount As DataGridViewTextBoxColumn
    Friend WithEvents totalpaidamount As DataGridViewTextBoxColumn
    Friend WithEvents totalremainingamount As DataGridViewTextBoxColumn
    Friend WithEvents nextemidate As DataGridViewTextBoxColumn
    Friend WithEvents interestrate As DataGridViewTextBoxColumn
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerLoanDetailToolStripMenuItem As ToolStripMenuItem
End Class
