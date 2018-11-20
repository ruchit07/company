<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerLoanDetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.txtLoanNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.regno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectcustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.loanid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loannumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loandate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectcolumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLoanNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInstallments = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPaidAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInstalmentDone = New System.Windows.Forms.TextBox()
        Me.txtPendingInstallment = New System.Windows.Forms.TextBox()
        Me.txtPendingAmount = New System.Windows.Forms.TextBox()
        Me.txtLoanDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAdvanceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmi = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerLoanDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eminumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emidate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emiamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receivedamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remainingamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.installmentreceiveddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ગ્રાહક ની લોન વિગત​"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ગ્રાહક નં"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ગ્રાહકનો લોન નં"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ગ્રાહકનું નામ​"
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Location = New System.Drawing.Point(124, 61)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.Size = New System.Drawing.Size(141, 20)
        Me.txtCustomerNo.TabIndex = 1
        '
        'txtLoanNo
        '
        Me.txtLoanNo.Location = New System.Drawing.Point(124, 95)
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(141, 20)
        Me.txtLoanNo.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(124, 129)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(141, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ગ્રાહકનો મોબાઇલ નં"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(125, 165)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(141, 20)
        Me.txtMobileNumber.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.regno, Me.customername, Me.customerid, Me.mobile, Me.selectcustomer})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(501, 150)
        Me.DataGridView1.TabIndex = 30
        '
        'regno
        '
        Me.regno.DataPropertyName = "regno"
        Me.regno.HeaderText = "ગ્રાહક નંબર"
        Me.regno.Name = "regno"
        Me.regno.ReadOnly = True
        '
        'customername
        '
        Me.customername.DataPropertyName = "name"
        Me.customername.HeaderText = "ગ્રાહકનું નામ​"
        Me.customername.Name = "customername"
        Me.customername.ReadOnly = True
        '
        'customerid
        '
        Me.customerid.DataPropertyName = "customerid"
        Me.customerid.HeaderText = "customerid"
        Me.customerid.Name = "customerid"
        Me.customerid.ReadOnly = True
        Me.customerid.Visible = False
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile1"
        Me.mobile.HeaderText = "મોબાઈલ​"
        Me.mobile.Name = "mobile"
        Me.mobile.ReadOnly = True
        '
        'selectcustomer
        '
        Me.selectcustomer.HeaderText = "Select"
        Me.selectcustomer.Name = "selectcustomer"
        Me.selectcustomer.ReadOnly = True
        Me.selectcustomer.Text = "Select"
        Me.selectcustomer.UseColumnTextForButtonValue = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.loanid, Me.loannumber, Me.amount, Me.loandate, Me.enddate, Me.selectcolumn})
        Me.DataGridView2.Location = New System.Drawing.Point(16, 407)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(588, 150)
        Me.DataGridView2.TabIndex = 31
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
        Me.loannumber.HeaderText = "લોન નં"
        Me.loannumber.Name = "loannumber"
        Me.loannumber.ReadOnly = True
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "લોનની રકમ"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'loandate
        '
        Me.loandate.DataPropertyName = "loandate"
        Me.loandate.HeaderText = "લોનની તારીખ"
        Me.loandate.Name = "loandate"
        Me.loandate.ReadOnly = True
        '
        'enddate
        '
        Me.enddate.DataPropertyName = "enddate"
        Me.enddate.HeaderText = "લોનની અંતીમ તારીખ​"
        Me.enddate.Name = "enddate"
        Me.enddate.ReadOnly = True
        '
        'selectcolumn
        '
        Me.selectcolumn.HeaderText = "Select"
        Me.selectcolumn.Name = "selectcolumn"
        Me.selectcolumn.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(679, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "લોન નં"
        '
        'txtLoanNumber
        '
        Me.txtLoanNumber.Location = New System.Drawing.Point(757, 37)
        Me.txtLoanNumber.Name = "txtLoanNumber"
        Me.txtLoanNumber.Size = New System.Drawing.Size(97, 20)
        Me.txtLoanNumber.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(679, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "લોન ની રકમ​"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.Location = New System.Drawing.Point(757, 77)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(97, 20)
        Me.txtLoanAmount.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(679, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "લોન ના હપ્તા"
        '
        'txtInstallments
        '
        Me.txtInstallments.Enabled = False
        Me.txtInstallments.Location = New System.Drawing.Point(757, 121)
        Me.txtInstallments.Name = "txtInstallments"
        Me.txtInstallments.Size = New System.Drawing.Size(97, 20)
        Me.txtInstallments.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(679, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "ઓફીસ તારીખ​"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(947, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "આવેલ કુલ રકમ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(947, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "આવેલ કુલ હપ્તા"
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.Enabled = False
        Me.txtPaidAmount.Location = New System.Drawing.Point(1040, 37)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(97, 20)
        Me.txtPaidAmount.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(947, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "કુલ બાકી હપ્તા"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(947, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "કુલ બાકી રકમ​"
        '
        'txtInstalmentDone
        '
        Me.txtInstalmentDone.Enabled = False
        Me.txtInstalmentDone.Location = New System.Drawing.Point(1040, 78)
        Me.txtInstalmentDone.Name = "txtInstalmentDone"
        Me.txtInstalmentDone.Size = New System.Drawing.Size(97, 20)
        Me.txtInstalmentDone.TabIndex = 33
        '
        'txtPendingInstallment
        '
        Me.txtPendingInstallment.Enabled = False
        Me.txtPendingInstallment.Location = New System.Drawing.Point(1040, 121)
        Me.txtPendingInstallment.Name = "txtPendingInstallment"
        Me.txtPendingInstallment.Size = New System.Drawing.Size(97, 20)
        Me.txtPendingInstallment.TabIndex = 33
        '
        'txtPendingAmount
        '
        Me.txtPendingAmount.Enabled = False
        Me.txtPendingAmount.Location = New System.Drawing.Point(1040, 160)
        Me.txtPendingAmount.Name = "txtPendingAmount"
        Me.txtPendingAmount.Size = New System.Drawing.Size(97, 20)
        Me.txtPendingAmount.TabIndex = 33
        '
        'txtLoanDate
        '
        Me.txtLoanDate.Enabled = False
        Me.txtLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtLoanDate.Location = New System.Drawing.Point(757, 157)
        Me.txtLoanDate.Name = "txtLoanDate"
        Me.txtLoanDate.Size = New System.Drawing.Size(97, 20)
        Me.txtLoanDate.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(679, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "એડ​વાન્સ તારીખ"
        '
        'txtAdvanceDate
        '
        Me.txtAdvanceDate.Enabled = False
        Me.txtAdvanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtAdvanceDate.Location = New System.Drawing.Point(757, 194)
        Me.txtAdvanceDate.Name = "txtAdvanceDate"
        Me.txtAdvanceDate.Size = New System.Drawing.Size(97, 20)
        Me.txtAdvanceDate.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(679, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "ઓફીસ તારીખ​"
        '
        'txtEndDate
        '
        Me.txtEndDate.Enabled = False
        Me.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEndDate.Location = New System.Drawing.Point(757, 230)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(97, 20)
        Me.txtEndDate.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(679, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "હપ્તાની રકમ​"
        '
        'txtEmi
        '
        Me.txtEmi.Enabled = False
        Me.txtEmi.Location = New System.Drawing.Point(757, 268)
        Me.txtEmi.Name = "txtEmi"
        Me.txtEmi.Size = New System.Drawing.Size(97, 20)
        Me.txtEmi.TabIndex = 33
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eminumber, Me.emidate, Me.emiamount, Me.receivedamount, Me.remainingamount, Me.installmentreceiveddate})
        Me.DataGridView3.Location = New System.Drawing.Point(682, 323)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(682, 150)
        Me.DataGridView3.TabIndex = 35
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1406, 24)
        Me.MenuStrip1.TabIndex = 36
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
        'CustomerLoanDetailToolStripMenuItem
        '
        Me.CustomerLoanDetailToolStripMenuItem.Name = "CustomerLoanDetailToolStripMenuItem"
        Me.CustomerLoanDetailToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CustomerLoanDetailToolStripMenuItem.Text = "Customer Loan Detail"
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
        'eminumber
        '
        Me.eminumber.DataPropertyName = "emino"
        Me.eminumber.HeaderText = "હપ્તા"
        Me.eminumber.Name = "eminumber"
        Me.eminumber.ReadOnly = True
        '
        'emidate
        '
        Me.emidate.DataPropertyName = "installmentdate"
        Me.emidate.HeaderText = "હપ્તાની તારીખ​"
        Me.emidate.Name = "emidate"
        Me.emidate.ReadOnly = True
        '
        'emiamount
        '
        Me.emiamount.DataPropertyName = "emi"
        Me.emiamount.HeaderText = "હપ્તાની રકમ​"
        Me.emiamount.Name = "emiamount"
        Me.emiamount.ReadOnly = True
        '
        'receivedamount
        '
        Me.receivedamount.DataPropertyName = "receivedamount"
        Me.receivedamount.HeaderText = "કુલ આવેલ રકમ​"
        Me.receivedamount.Name = "receivedamount"
        Me.receivedamount.ReadOnly = True
        '
        'remainingamount
        '
        Me.remainingamount.DataPropertyName = "remainingamount"
        Me.remainingamount.HeaderText = "કુલ બાકી રકમ​"
        Me.remainingamount.Name = "remainingamount"
        Me.remainingamount.ReadOnly = True
        '
        'installmentreceiveddate
        '
        Me.installmentreceiveddate.DataPropertyName = "installmentreceiveddate"
        Me.installmentreceiveddate.HeaderText = "હપ્તો લિધેલ તરીખ​"
        Me.installmentreceiveddate.Name = "installmentreceiveddate"
        Me.installmentreceiveddate.ReadOnly = True
        '
        'CustomerLoanDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 644)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtAdvanceDate)
        Me.Controls.Add(Me.txtLoanDate)
        Me.Controls.Add(Me.txtPendingAmount)
        Me.Controls.Add(Me.txtPendingInstallment)
        Me.Controls.Add(Me.txtInstalmentDone)
        Me.Controls.Add(Me.txtEmi)
        Me.Controls.Add(Me.txtInstallments)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPaidAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLoanNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtLoanNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustomerNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerLoanDetail"
        Me.Text = "CustomerLoanDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerNo As TextBox
    Friend WithEvents txtLoanNo As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents regno As DataGridViewTextBoxColumn
    Friend WithEvents customername As DataGridViewTextBoxColumn
    Friend WithEvents customerid As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents selectcustomer As DataGridViewButtonColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents loanid As DataGridViewTextBoxColumn
    Friend WithEvents loannumber As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents loandate As DataGridViewTextBoxColumn
    Friend WithEvents enddate As DataGridViewTextBoxColumn
    Friend WithEvents selectcolumn As DataGridViewButtonColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLoanNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInstallments As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPaidAmount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtInstalmentDone As TextBox
    Friend WithEvents txtPendingInstallment As TextBox
    Friend WithEvents txtPendingAmount As TextBox
    Friend WithEvents txtLoanDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAdvanceDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEndDate As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmi As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerLoanDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecoveryListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents eminumber As DataGridViewTextBoxColumn
    Friend WithEvents emidate As DataGridViewTextBoxColumn
    Friend WithEvents emiamount As DataGridViewTextBoxColumn
    Friend WithEvents receivedamount As DataGridViewTextBoxColumn
    Friend WithEvents remainingamount As DataGridViewTextBoxColumn
    Friend WithEvents installmentreceiveddate As DataGridViewTextBoxColumn
End Class
