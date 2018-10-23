<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanDetail
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ddlEmployee = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSet = New Company.employeeDataSet()
        Me.dtAdvanceDate = New System.Windows.Forms.DateTimePicker()
        Me.txtEMI = New System.Windows.Forms.TextBox()
        Me.txtFinalAmount = New System.Windows.Forms.TextBox()
        Me.txtAdvanceAmount = New System.Windows.Forms.TextBox()
        Me.txtFineCharge = New System.Windows.Forms.TextBox()
        Me.txtInterestAmount = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtLoanNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ddlType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFinalDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastDate = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New Company.employeeDataSetTableAdapters.employeeTableAdapter()
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
        Me.RecoveryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ddlCustomer = New System.Windows.Forms.ComboBox()
        Me.CustomerDataSet = New Company.customerDataSet()
        Me.CustomerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Company.customerDataSetTableAdapters.customerTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddlCustomer)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.ddlEmployee)
        Me.GroupBox1.Controls.Add(Me.dtAdvanceDate)
        Me.GroupBox1.Controls.Add(Me.txtEMI)
        Me.GroupBox1.Controls.Add(Me.txtFinalAmount)
        Me.GroupBox1.Controls.Add(Me.txtAdvanceAmount)
        Me.GroupBox1.Controls.Add(Me.txtFineCharge)
        Me.GroupBox1.Controls.Add(Me.txtInterestAmount)
        Me.GroupBox1.Controls.Add(Me.txtInterestRate)
        Me.GroupBox1.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox1.Controls.Add(Me.txtDuration)
        Me.GroupBox1.Controls.Add(Me.txtLoanNumber)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblCustomerId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ddlType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblFinalDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblLastDate)
        Me.GroupBox1.Controls.Add(Me.lblType)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 546)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "લોન માસ્ટર​"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(109, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(20, 507)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ddlEmployee
        '
        Me.ddlEmployee.DataSource = Me.EmployeeBindingSource
        Me.ddlEmployee.DisplayMember = "name"
        Me.ddlEmployee.FormattingEnabled = True
        Me.ddlEmployee.Location = New System.Drawing.Point(109, 460)
        Me.ddlEmployee.Name = "ddlEmployee"
        Me.ddlEmployee.Size = New System.Drawing.Size(249, 21)
        Me.ddlEmployee.TabIndex = 11
        Me.ddlEmployee.ValueMember = "employeeid"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.EmployeeDataSet
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "employeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtAdvanceDate
        '
        Me.dtAdvanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtAdvanceDate.Location = New System.Drawing.Point(109, 158)
        Me.dtAdvanceDate.Name = "dtAdvanceDate"
        Me.dtAdvanceDate.Size = New System.Drawing.Size(121, 20)
        Me.dtAdvanceDate.TabIndex = 4
        '
        'txtEMI
        '
        Me.txtEMI.Enabled = False
        Me.txtEMI.Location = New System.Drawing.Point(109, 414)
        Me.txtEMI.Name = "txtEMI"
        Me.txtEMI.ReadOnly = True
        Me.txtEMI.Size = New System.Drawing.Size(121, 20)
        Me.txtEMI.TabIndex = 10
        '
        'txtFinalAmount
        '
        Me.txtFinalAmount.Enabled = False
        Me.txtFinalAmount.Location = New System.Drawing.Point(109, 372)
        Me.txtFinalAmount.Name = "txtFinalAmount"
        Me.txtFinalAmount.ReadOnly = True
        Me.txtFinalAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtFinalAmount.TabIndex = 10
        '
        'txtAdvanceAmount
        '
        Me.txtAdvanceAmount.Enabled = False
        Me.txtAdvanceAmount.Location = New System.Drawing.Point(109, 338)
        Me.txtAdvanceAmount.Name = "txtAdvanceAmount"
        Me.txtAdvanceAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAdvanceAmount.TabIndex = 9
        '
        'txtFineCharge
        '
        Me.txtFineCharge.Location = New System.Drawing.Point(109, 305)
        Me.txtFineCharge.Name = "txtFineCharge"
        Me.txtFineCharge.Size = New System.Drawing.Size(121, 20)
        Me.txtFineCharge.TabIndex = 8
        '
        'txtInterestAmount
        '
        Me.txtInterestAmount.Enabled = False
        Me.txtInterestAmount.Location = New System.Drawing.Point(109, 269)
        Me.txtInterestAmount.Name = "txtInterestAmount"
        Me.txtInterestAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtInterestAmount.TabIndex = 7
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(109, 230)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(121, 20)
        Me.txtInterestRate.TabIndex = 6
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Location = New System.Drawing.Point(109, 194)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtLoanAmount.TabIndex = 5
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(109, 91)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(121, 20)
        Me.txtDuration.TabIndex = 3
        '
        'txtLoanNumber
        '
        Me.txtLoanNumber.Location = New System.Drawing.Point(503, 91)
        Me.txtLoanNumber.Name = "txtLoanNumber"
        Me.txtLoanNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtLoanNumber.TabIndex = 3
        Me.txtLoanNumber.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 417)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "હપ્તો"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "કર્મચારી નામ​"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "કુલ આપ​વાની " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "થતી રકમ​"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "એડ​વાન્સ હપ્તો"
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(500, 31)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(39, 13)
        Me.lblCustomerId.TabIndex = 2
        Me.lblCustomerId.Text = "Label1"
        Me.lblCustomerId.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ફાઇન ચાર્જ​"
        '
        'ddlType
        '
        Me.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlType.FormattingEnabled = True
        Me.ddlType.Items.AddRange(New Object() {"દૈનીક​", "માસીક​(હપ્તા)", "માસીક"})
        Me.ddlType.Location = New System.Drawing.Point(109, 60)
        Me.ddlType.Name = "ddlType"
        Me.ddlType.Size = New System.Drawing.Size(121, 21)
        Me.ddlType.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "વ્યાજની રકમ​"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "એડ​વાન્સ તારીખ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "વ્યાજનો દર​"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "લોનની રકમ​"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "સમય​"
        '
        'lblFinalDate
        '
        Me.lblFinalDate.AutoSize = True
        Me.lblFinalDate.Location = New System.Drawing.Point(106, 128)
        Me.lblFinalDate.Name = "lblFinalDate"
        Me.lblFinalDate.Size = New System.Drawing.Size(69, 13)
        Me.lblFinalDate.TabIndex = 0
        Me.lblFinalDate.Text = "અંતીમ તારીખ​"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "લોન નં"
        Me.Label1.Visible = False
        '
        'lblLastDate
        '
        Me.lblLastDate.AutoSize = True
        Me.lblLastDate.Location = New System.Drawing.Point(17, 128)
        Me.lblLastDate.Name = "lblLastDate"
        Me.lblLastDate.Size = New System.Drawing.Size(69, 13)
        Me.lblLastDate.TabIndex = 0
        Me.lblLastDate.Text = "અંતીમ તારીખ​"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(17, 68)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(55, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "લોન ટાઈપ​"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
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
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoveryListToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'RecoveryListToolStripMenuItem
        '
        Me.RecoveryListToolStripMenuItem.Name = "RecoveryListToolStripMenuItem"
        Me.RecoveryListToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RecoveryListToolStripMenuItem.Text = "Recovery List"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "ગ્રાહક "
        '
        'ddlCustomer
        '
        Me.ddlCustomer.DataSource = Me.CustomerBindingSource
        Me.ddlCustomer.DisplayMember = "name"
        Me.ddlCustomer.FormattingEnabled = True
        Me.ddlCustomer.Location = New System.Drawing.Point(109, 27)
        Me.ddlCustomer.Name = "ddlCustomer"
        Me.ddlCustomer.Size = New System.Drawing.Size(121, 21)
        Me.ddlCustomer.TabIndex = 16
        Me.ddlCustomer.ValueMember = "customerid"
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "customerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataSetBindingSource
        '
        Me.CustomerDataSetBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerDataSetBindingSource.Position = 0
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSetBindingSource
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'LoanDetail
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(800, 602)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoanDetail"
        Me.Text = "LoadDetail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ddlType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblFinalDate As Label
    Friend WithEvents lblLastDate As Label
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoanNumber As TextBox
    Friend WithEvents dtAdvanceDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInterestAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdvanceAmount As TextBox
    Friend WithEvents txtFineCharge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFinalAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ddlEmployee As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmployeeDataSet As employeeDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As employeeDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEMI As TextBox
    Friend WithEvents Label11 As Label
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
    Friend WithEvents ddlCustomer As ComboBox
    Friend WithEvents CustomerDataSetBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As customerDataSet
    Friend WithEvents Label12 As Label
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As customerDataSetTableAdapters.customerTableAdapter
End Class
