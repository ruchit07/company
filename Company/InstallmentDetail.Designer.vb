<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallmentDetail
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblEmpNumber = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.lblLoanType = New System.Windows.Forms.Label()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.lblLoanDate = New System.Windows.Forms.Label()
        Me.lblLoanLastDate = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblReceivedEmi = New System.Windows.Forms.Label()
        Me.txtReceivedEmi = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblPendingEmi = New System.Windows.Forms.Label()
        Me.txtPendingEmi = New System.Windows.Forms.TextBox()
        Me.txtRemainingAmount = New System.Windows.Forms.TextBox()
        Me.lblPendingAmount = New System.Windows.Forms.Label()
        Me.lblReceivingEmiAmount = New System.Windows.Forms.Label()
        Me.txtRecevingEmi = New System.Windows.Forms.TextBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.loanid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loannumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectcustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalReceiving = New System.Windows.Forms.Label()
        Me.IntallMentMaster = New System.Windows.Forms.GroupBox()
        Me.txtLoanEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLoanDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IntallMentMaster.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(25, 38)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "તારીખ​"
        '
        'lblEmpNumber
        '
        Me.lblEmpNumber.AutoSize = True
        Me.lblEmpNumber.Location = New System.Drawing.Point(25, 75)
        Me.lblEmpNumber.Name = "lblEmpNumber"
        Me.lblEmpNumber.Size = New System.Drawing.Size(72, 13)
        Me.lblEmpNumber.TabIndex = 2
        Me.lblEmpNumber.Text = "ગ્રાહક નો નંબર"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(132, 75)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(200, 20)
        Me.txtEmpNo.TabIndex = 1
        '
        'lblLoanType
        '
        Me.lblLoanType.AutoSize = True
        Me.lblLoanType.Location = New System.Drawing.Point(25, 142)
        Me.lblLoanType.Name = "lblLoanType"
        Me.lblLoanType.Size = New System.Drawing.Size(55, 13)
        Me.lblLoanType.TabIndex = 4
        Me.lblLoanType.Text = "લોન ટાઇપ"
        '
        'txtLoanType
        '
        Me.txtLoanType.Enabled = False
        Me.txtLoanType.Location = New System.Drawing.Point(132, 142)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanType.TabIndex = 5
        '
        'lblLoanDate
        '
        Me.lblLoanDate.AutoSize = True
        Me.lblLoanDate.Location = New System.Drawing.Point(25, 178)
        Me.lblLoanDate.Name = "lblLoanDate"
        Me.lblLoanDate.Size = New System.Drawing.Size(59, 13)
        Me.lblLoanDate.TabIndex = 6
        Me.lblLoanDate.Text = "લોન તારીખ​"
        '
        'lblLoanLastDate
        '
        Me.lblLoanLastDate.AutoSize = True
        Me.lblLoanLastDate.Location = New System.Drawing.Point(25, 216)
        Me.lblLoanLastDate.Name = "lblLoanLastDate"
        Me.lblLoanLastDate.Size = New System.Drawing.Size(87, 13)
        Me.lblLoanLastDate.TabIndex = 8
        Me.lblLoanLastDate.Text = "લોન અંતીમ તરીખ​"
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Location = New System.Drawing.Point(25, 255)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(48, 13)
        Me.lblLoanAmount.TabIndex = 10
        Me.lblLoanAmount.Text = "લોન રકમ​"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.Location = New System.Drawing.Point(132, 255)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanAmount.TabIndex = 11
        '
        'lblReceivedEmi
        '
        Me.lblReceivedEmi.AutoSize = True
        Me.lblReceivedEmi.Location = New System.Drawing.Point(335, 255)
        Me.lblReceivedEmi.Name = "lblReceivedEmi"
        Me.lblReceivedEmi.Size = New System.Drawing.Size(57, 13)
        Me.lblReceivedEmi.TabIndex = 12
        Me.lblReceivedEmi.Text = "આવેલ હપ્તા"
        '
        'txtReceivedEmi
        '
        Me.txtReceivedEmi.Enabled = False
        Me.txtReceivedEmi.Location = New System.Drawing.Point(418, 255)
        Me.txtReceivedEmi.Name = "txtReceivedEmi"
        Me.txtReceivedEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtReceivedEmi.TabIndex = 13
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(25, 296)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalAmount.TabIndex = 14
        Me.lblTotalAmount.Text = "ભર​વાની રકમ​"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(132, 296)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 15
        '
        'lblPendingEmi
        '
        Me.lblPendingEmi.AutoSize = True
        Me.lblPendingEmi.Location = New System.Drawing.Point(335, 296)
        Me.lblPendingEmi.Name = "lblPendingEmi"
        Me.lblPendingEmi.Size = New System.Drawing.Size(52, 13)
        Me.lblPendingEmi.TabIndex = 16
        Me.lblPendingEmi.Text = "બાકી હપ્તા"
        '
        'txtPendingEmi
        '
        Me.txtPendingEmi.Enabled = False
        Me.txtPendingEmi.Location = New System.Drawing.Point(418, 296)
        Me.txtPendingEmi.Name = "txtPendingEmi"
        Me.txtPendingEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtPendingEmi.TabIndex = 17
        '
        'txtRemainingAmount
        '
        Me.txtRemainingAmount.Enabled = False
        Me.txtRemainingAmount.Location = New System.Drawing.Point(132, 342)
        Me.txtRemainingAmount.Name = "txtRemainingAmount"
        Me.txtRemainingAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtRemainingAmount.TabIndex = 18
        '
        'lblPendingAmount
        '
        Me.lblPendingAmount.AutoSize = True
        Me.lblPendingAmount.Location = New System.Drawing.Point(25, 342)
        Me.lblPendingAmount.Name = "lblPendingAmount"
        Me.lblPendingAmount.Size = New System.Drawing.Size(52, 13)
        Me.lblPendingAmount.TabIndex = 19
        Me.lblPendingAmount.Text = "બાકી રકમ​"
        '
        'lblReceivingEmiAmount
        '
        Me.lblReceivingEmiAmount.AutoSize = True
        Me.lblReceivingEmiAmount.Location = New System.Drawing.Point(25, 402)
        Me.lblReceivingEmiAmount.Name = "lblReceivingEmiAmount"
        Me.lblReceivingEmiAmount.Size = New System.Drawing.Size(94, 13)
        Me.lblReceivingEmiAmount.TabIndex = 20
        Me.lblReceivingEmiAmount.Text = "આવેલ હપ્તા ની રકમ​"
        '
        'txtRecevingEmi
        '
        Me.txtRecevingEmi.Enabled = False
        Me.txtRecevingEmi.Location = New System.Drawing.Point(132, 399)
        Me.txtRecevingEmi.Name = "txtRecevingEmi"
        Me.txtRecevingEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtRecevingEmi.TabIndex = 21
        '
        'txtPenalty
        '
        Me.txtPenalty.Location = New System.Drawing.Point(338, 399)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(100, 20)
        Me.txtPenalty.TabIndex = 23
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.Location = New System.Drawing.Point(283, 402)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(38, 13)
        Me.lblPenalty.TabIndex = 24
        Me.lblPenalty.Text = "પૅનલ્ટી"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(28, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(109, 464)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(190, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(132, 38)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(92, 20)
        Me.dtDate.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.loanid, Me.customername, Me.loannumber, Me.mobile, Me.selectcustomer})
        Me.DataGridView1.Location = New System.Drawing.Point(418, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(452, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'loanid
        '
        Me.loanid.DataPropertyName = "loanid"
        Me.loanid.HeaderText = "loanid"
        Me.loanid.Name = "loanid"
        Me.loanid.ReadOnly = True
        Me.loanid.Visible = False
        '
        'customername
        '
        Me.customername.DataPropertyName = "customername"
        Me.customername.HeaderText = "ગ્રાહકનું નામ​"
        Me.customername.Name = "customername"
        Me.customername.ReadOnly = True
        '
        'loannumber
        '
        Me.loannumber.DataPropertyName = "loannumber"
        Me.loannumber.HeaderText = "લોન નંબર​"
        Me.loannumber.Name = "loannumber"
        Me.loannumber.ReadOnly = True
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "="
        '
        'lblTotalReceiving
        '
        Me.lblTotalReceiving.AutoSize = True
        Me.lblTotalReceiving.Location = New System.Drawing.Point(497, 402)
        Me.lblTotalReceiving.Name = "lblTotalReceiving"
        Me.lblTotalReceiving.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalReceiving.TabIndex = 31
        '
        'IntallMentMaster
        '
        Me.IntallMentMaster.Controls.Add(Me.btnCancel)
        Me.IntallMentMaster.Controls.Add(Me.lblTotalReceiving)
        Me.IntallMentMaster.Controls.Add(Me.btnReset)
        Me.IntallMentMaster.Controls.Add(Me.Label1)
        Me.IntallMentMaster.Controls.Add(Me.btnSave)
        Me.IntallMentMaster.Controls.Add(Me.DataGridView1)
        Me.IntallMentMaster.Controls.Add(Me.lblDate)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanEndDate)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanDate)
        Me.IntallMentMaster.Controls.Add(Me.dtDate)
        Me.IntallMentMaster.Controls.Add(Me.Label2)
        Me.IntallMentMaster.Controls.Add(Me.lblEmpNumber)
        Me.IntallMentMaster.Controls.Add(Me.lblPenalty)
        Me.IntallMentMaster.Controls.Add(Me.txtCustomerName)
        Me.IntallMentMaster.Controls.Add(Me.txtEmpNo)
        Me.IntallMentMaster.Controls.Add(Me.txtPenalty)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanType)
        Me.IntallMentMaster.Controls.Add(Me.txtRecevingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanType)
        Me.IntallMentMaster.Controls.Add(Me.lblReceivingEmiAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanDate)
        Me.IntallMentMaster.Controls.Add(Me.lblPendingAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanLastDate)
        Me.IntallMentMaster.Controls.Add(Me.txtRemainingAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanAmount)
        Me.IntallMentMaster.Controls.Add(Me.txtPendingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblPendingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtTotalAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblTotalAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblReceivedEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtReceivedEmi)
        Me.IntallMentMaster.Location = New System.Drawing.Point(12, 44)
        Me.IntallMentMaster.Name = "IntallMentMaster"
        Me.IntallMentMaster.Size = New System.Drawing.Size(945, 556)
        Me.IntallMentMaster.TabIndex = 32
        Me.IntallMentMaster.TabStop = False
        Me.IntallMentMaster.Text = "ઇન્સ્ટોલમેન્ટ માસ્ટર​"
        '
        'txtLoanEndDate
        '
        Me.txtLoanEndDate.Enabled = False
        Me.txtLoanEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtLoanEndDate.Location = New System.Drawing.Point(132, 215)
        Me.txtLoanEndDate.Name = "txtLoanEndDate"
        Me.txtLoanEndDate.Size = New System.Drawing.Size(92, 20)
        Me.txtLoanEndDate.TabIndex = 28
        '
        'txtLoanDate
        '
        Me.txtLoanDate.Enabled = False
        Me.txtLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtLoanDate.Location = New System.Drawing.Point(132, 178)
        Me.txtLoanDate.Name = "txtLoanDate"
        Me.txtLoanDate.Size = New System.Drawing.Size(92, 20)
        Me.txtLoanDate.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ગ્રાહકનું નામ​"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(132, 109)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(200, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1222, 24)
        Me.MenuStrip1.TabIndex = 33
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
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerListToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerListToolStripMenuItem
        '
        Me.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem"
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
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
        'InstallmentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 624)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.IntallMentMaster)
        Me.Name = "InstallmentDetail"
        Me.Text = "InstallmentDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IntallMentMaster.ResumeLayout(False)
        Me.IntallMentMaster.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblEmpNumber As Label
    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents lblLoanType As Label
    Friend WithEvents txtLoanType As TextBox
    Friend WithEvents lblLoanDate As Label
    Friend WithEvents lblLoanLastDate As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents lblReceivedEmi As Label
    Friend WithEvents txtReceivedEmi As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblPendingEmi As Label
    Friend WithEvents txtPendingEmi As TextBox
    Friend WithEvents txtRemainingAmount As TextBox
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblReceivingEmiAmount As Label
    Friend WithEvents txtRecevingEmi As TextBox
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents lblPenalty As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalReceiving As Label
    Friend WithEvents IntallMentMaster As GroupBox
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
    Friend WithEvents LoanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecoveryListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtLoanEndDate As DateTimePicker
    Friend WithEvents txtLoanDate As DateTimePicker
    Friend WithEvents loanid As DataGridViewTextBoxColumn
    Friend WithEvents customername As DataGridViewTextBoxColumn
    Friend WithEvents loannumber As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents selectcustomer As DataGridViewButtonColumn
End Class
