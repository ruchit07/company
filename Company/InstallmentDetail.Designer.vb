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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblPendingAmount = New System.Windows.Forms.Label()
        Me.lblReceivingEmiAmount = New System.Windows.Forms.Label()
        Me.txtRecevingEmi = New System.Windows.Forms.TextBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtLoanDate = New System.Windows.Forms.TextBox()
        Me.txtLoanLastDate = New System.Windows.Forms.TextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.selectcustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalReceiving = New System.Windows.Forms.Label()
        Me.IntallMentMaster = New System.Windows.Forms.GroupBox()
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
        Me.txtEmpNo.TabIndex = 3
        '
        'lblLoanType
        '
        Me.lblLoanType.AutoSize = True
        Me.lblLoanType.Location = New System.Drawing.Point(25, 110)
        Me.lblLoanType.Name = "lblLoanType"
        Me.lblLoanType.Size = New System.Drawing.Size(55, 13)
        Me.lblLoanType.TabIndex = 4
        Me.lblLoanType.Text = "લોન ટાઇપ"
        '
        'txtLoanType
        '
        Me.txtLoanType.Location = New System.Drawing.Point(132, 110)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(200, 20)
        Me.txtLoanType.TabIndex = 5
        '
        'lblLoanDate
        '
        Me.lblLoanDate.AutoSize = True
        Me.lblLoanDate.Location = New System.Drawing.Point(25, 146)
        Me.lblLoanDate.Name = "lblLoanDate"
        Me.lblLoanDate.Size = New System.Drawing.Size(59, 13)
        Me.lblLoanDate.TabIndex = 6
        Me.lblLoanDate.Text = "લોન તારીખ​"
        '
        'lblLoanLastDate
        '
        Me.lblLoanLastDate.AutoSize = True
        Me.lblLoanLastDate.Location = New System.Drawing.Point(25, 184)
        Me.lblLoanLastDate.Name = "lblLoanLastDate"
        Me.lblLoanLastDate.Size = New System.Drawing.Size(87, 13)
        Me.lblLoanLastDate.TabIndex = 8
        Me.lblLoanLastDate.Text = "લોન અંતીમ તરીખ​"
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Location = New System.Drawing.Point(25, 223)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(48, 13)
        Me.lblLoanAmount.TabIndex = 10
        Me.lblLoanAmount.Text = "લોન રકમ​"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Location = New System.Drawing.Point(132, 223)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanAmount.TabIndex = 11
        '
        'lblReceivedEmi
        '
        Me.lblReceivedEmi.AutoSize = True
        Me.lblReceivedEmi.Location = New System.Drawing.Point(335, 223)
        Me.lblReceivedEmi.Name = "lblReceivedEmi"
        Me.lblReceivedEmi.Size = New System.Drawing.Size(57, 13)
        Me.lblReceivedEmi.TabIndex = 12
        Me.lblReceivedEmi.Text = "આવેલ હપ્તા"
        '
        'txtReceivedEmi
        '
        Me.txtReceivedEmi.Location = New System.Drawing.Point(418, 223)
        Me.txtReceivedEmi.Name = "txtReceivedEmi"
        Me.txtReceivedEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtReceivedEmi.TabIndex = 13
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(25, 264)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalAmount.TabIndex = 14
        Me.lblTotalAmount.Text = "ભર​વાની રકમ​"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(132, 264)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 15
        '
        'lblPendingEmi
        '
        Me.lblPendingEmi.AutoSize = True
        Me.lblPendingEmi.Location = New System.Drawing.Point(335, 264)
        Me.lblPendingEmi.Name = "lblPendingEmi"
        Me.lblPendingEmi.Size = New System.Drawing.Size(52, 13)
        Me.lblPendingEmi.TabIndex = 16
        Me.lblPendingEmi.Text = "બાકી હપ્તા"
        '
        'txtPendingEmi
        '
        Me.txtPendingEmi.Location = New System.Drawing.Point(418, 264)
        Me.txtPendingEmi.Name = "txtPendingEmi"
        Me.txtPendingEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtPendingEmi.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(132, 310)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 18
        '
        'lblPendingAmount
        '
        Me.lblPendingAmount.AutoSize = True
        Me.lblPendingAmount.Location = New System.Drawing.Point(25, 310)
        Me.lblPendingAmount.Name = "lblPendingAmount"
        Me.lblPendingAmount.Size = New System.Drawing.Size(52, 13)
        Me.lblPendingAmount.TabIndex = 19
        Me.lblPendingAmount.Text = "બાકી રકમ​"
        '
        'lblReceivingEmiAmount
        '
        Me.lblReceivingEmiAmount.AutoSize = True
        Me.lblReceivingEmiAmount.Location = New System.Drawing.Point(25, 370)
        Me.lblReceivingEmiAmount.Name = "lblReceivingEmiAmount"
        Me.lblReceivingEmiAmount.Size = New System.Drawing.Size(94, 13)
        Me.lblReceivingEmiAmount.TabIndex = 20
        Me.lblReceivingEmiAmount.Text = "આવેલ હપ્તા ની રકમ​"
        '
        'txtRecevingEmi
        '
        Me.txtRecevingEmi.Location = New System.Drawing.Point(132, 367)
        Me.txtRecevingEmi.Name = "txtRecevingEmi"
        Me.txtRecevingEmi.Size = New System.Drawing.Size(100, 20)
        Me.txtRecevingEmi.TabIndex = 21
        '
        'txtPenalty
        '
        Me.txtPenalty.Location = New System.Drawing.Point(338, 367)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(100, 20)
        Me.txtPenalty.TabIndex = 23
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.Location = New System.Drawing.Point(283, 370)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(38, 13)
        Me.lblPenalty.TabIndex = 24
        Me.lblPenalty.Text = "પૅનલ્ટી"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(28, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(109, 432)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(190, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtLoanDate
        '
        Me.txtLoanDate.Location = New System.Drawing.Point(132, 146)
        Me.txtLoanDate.Name = "txtLoanDate"
        Me.txtLoanDate.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanDate.TabIndex = 11
        '
        'txtLoanLastDate
        '
        Me.txtLoanLastDate.Location = New System.Drawing.Point(132, 184)
        Me.txtLoanLastDate.Name = "txtLoanLastDate"
        Me.txtLoanLastDate.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanLastDate.TabIndex = 11
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectcustomer})
        Me.DataGridView1.Location = New System.Drawing.Point(418, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(452, 150)
        Me.DataGridView1.TabIndex = 29
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
        Me.Label1.Location = New System.Drawing.Point(458, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "="
        '
        'lblTotalReceiving
        '
        Me.lblTotalReceiving.AutoSize = True
        Me.lblTotalReceiving.Location = New System.Drawing.Point(497, 370)
        Me.lblTotalReceiving.Name = "lblTotalReceiving"
        Me.lblTotalReceiving.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalReceiving.TabIndex = 31
        Me.lblTotalReceiving.Text = "Label2"
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
        Me.IntallMentMaster.Controls.Add(Me.dtDate)
        Me.IntallMentMaster.Controls.Add(Me.lblEmpNumber)
        Me.IntallMentMaster.Controls.Add(Me.lblPenalty)
        Me.IntallMentMaster.Controls.Add(Me.txtEmpNo)
        Me.IntallMentMaster.Controls.Add(Me.txtPenalty)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanType)
        Me.IntallMentMaster.Controls.Add(Me.txtRecevingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanType)
        Me.IntallMentMaster.Controls.Add(Me.lblReceivingEmiAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanDate)
        Me.IntallMentMaster.Controls.Add(Me.lblPendingAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanLastDate)
        Me.IntallMentMaster.Controls.Add(Me.TextBox5)
        Me.IntallMentMaster.Controls.Add(Me.lblLoanAmount)
        Me.IntallMentMaster.Controls.Add(Me.txtPendingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblPendingEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanLastDate)
        Me.IntallMentMaster.Controls.Add(Me.txtTotalAmount)
        Me.IntallMentMaster.Controls.Add(Me.txtLoanDate)
        Me.IntallMentMaster.Controls.Add(Me.lblTotalAmount)
        Me.IntallMentMaster.Controls.Add(Me.lblReceivedEmi)
        Me.IntallMentMaster.Controls.Add(Me.txtReceivedEmi)
        Me.IntallMentMaster.Location = New System.Drawing.Point(12, 44)
        Me.IntallMentMaster.Name = "IntallMentMaster"
        Me.IntallMentMaster.Size = New System.Drawing.Size(945, 513)
        Me.IntallMentMaster.TabIndex = 32
        Me.IntallMentMaster.TabStop = False
        Me.IntallMentMaster.Text = "ઇન્સ્ટોલમેન્ટ માસ્ટર​"
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
        Me.ClientSize = New System.Drawing.Size(1222, 569)
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
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblReceivingEmiAmount As Label
    Friend WithEvents txtRecevingEmi As TextBox
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents lblPenalty As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtLoanDate As TextBox
    Friend WithEvents txtLoanLastDate As TextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents selectcustomer As DataGridViewButtonColumn
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
End Class
