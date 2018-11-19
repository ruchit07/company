<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetail
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
        Me.txtAdharno = New System.Windows.Forms.MaskedTextBox()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtOtherRajya = New System.Windows.Forms.TextBox()
        Me.ddlRajya = New System.Windows.Forms.ComboBox()
        Me.RajyaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RajyaDataSet = New Company.rajyaDataSet()
        Me.lblRajya = New System.Windows.Forms.Label()
        Me.txtOtherJillo = New System.Windows.Forms.TextBox()
        Me.ddlJillo = New System.Windows.Forms.ComboBox()
        Me.JilloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JilloDataSet = New Company.jilloDataSet()
        Me.lblJillo = New System.Windows.Forms.Label()
        Me.txtOtherTaluko = New System.Windows.Forms.TextBox()
        Me.ddlTaluko = New System.Windows.Forms.ComboBox()
        Me.TalukoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TalukoDataSet = New Company.talukoDataSet()
        Me.lblTaluko = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtEmployeeNo = New System.Windows.Forms.TextBox()
        Me.JilloTableAdapter = New Company.jilloDataSetTableAdapters.jilloTableAdapter()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.RajyaTableAdapter = New Company.rajyaDataSetTableAdapters.rajyaTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResignDate = New System.Windows.Forms.Label()
        Me.dtResignDate = New System.Windows.Forms.DateTimePicker()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.dtJoiningDate = New System.Windows.Forms.DateTimePicker()
        Me.lblJoiningDate = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAdharno = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.TalukoTableAdapter = New Company.talukoDataSetTableAdapters.talukoTableAdapter()
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
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAdharno
        '
        Me.txtAdharno.Location = New System.Drawing.Point(115, 425)
        Me.txtAdharno.Mask = "0000-0000-0000"
        Me.txtAdharno.Name = "txtAdharno"
        Me.txtAdharno.Size = New System.Drawing.Size(170, 20)
        Me.txtAdharno.TabIndex = 19
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(115, 346)
        Me.txtPincode.MaxLength = 6
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(170, 20)
        Me.txtPincode.TabIndex = 16
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.Location = New System.Drawing.Point(6, 349)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(42, 13)
        Me.lblPincode.TabIndex = 15
        Me.lblPincode.Text = "પીનકોડ​"
        '
        'txtOtherRajya
        '
        Me.txtOtherRajya.Location = New System.Drawing.Point(285, 308)
        Me.txtOtherRajya.Name = "txtOtherRajya"
        Me.txtOtherRajya.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherRajya.TabIndex = 14
        Me.txtOtherRajya.Visible = False
        '
        'ddlRajya
        '
        Me.ddlRajya.DataSource = Me.RajyaBindingSource
        Me.ddlRajya.DisplayMember = "name"
        Me.ddlRajya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRajya.FormattingEnabled = True
        Me.ddlRajya.Location = New System.Drawing.Point(115, 307)
        Me.ddlRajya.Name = "ddlRajya"
        Me.ddlRajya.Size = New System.Drawing.Size(121, 21)
        Me.ddlRajya.TabIndex = 13
        Me.ddlRajya.ValueMember = "rajyaid"
        '
        'RajyaBindingSource
        '
        Me.RajyaBindingSource.DataMember = "rajya"
        Me.RajyaBindingSource.DataSource = Me.RajyaDataSet
        '
        'RajyaDataSet
        '
        Me.RajyaDataSet.DataSetName = "rajyaDataSet"
        Me.RajyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblRajya
        '
        Me.lblRajya.AutoSize = True
        Me.lblRajya.Location = New System.Drawing.Point(9, 307)
        Me.lblRajya.Name = "lblRajya"
        Me.lblRajya.Size = New System.Drawing.Size(31, 13)
        Me.lblRajya.TabIndex = 12
        Me.lblRajya.Text = "રાજ્ય​"
        '
        'txtOtherJillo
        '
        Me.txtOtherJillo.Location = New System.Drawing.Point(285, 257)
        Me.txtOtherJillo.Name = "txtOtherJillo"
        Me.txtOtherJillo.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherJillo.TabIndex = 11
        Me.txtOtherJillo.Visible = False
        '
        'ddlJillo
        '
        Me.ddlJillo.DataSource = Me.JilloBindingSource
        Me.ddlJillo.DisplayMember = "name"
        Me.ddlJillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlJillo.FormattingEnabled = True
        Me.ddlJillo.Location = New System.Drawing.Point(115, 256)
        Me.ddlJillo.Name = "ddlJillo"
        Me.ddlJillo.Size = New System.Drawing.Size(121, 21)
        Me.ddlJillo.TabIndex = 10
        Me.ddlJillo.ValueMember = "jilloid"
        '
        'JilloBindingSource
        '
        Me.JilloBindingSource.DataMember = "jillo"
        Me.JilloBindingSource.DataSource = Me.JilloDataSet
        '
        'JilloDataSet
        '
        Me.JilloDataSet.DataSetName = "jilloDataSet"
        Me.JilloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblJillo
        '
        Me.lblJillo.AutoSize = True
        Me.lblJillo.Location = New System.Drawing.Point(6, 264)
        Me.lblJillo.Name = "lblJillo"
        Me.lblJillo.Size = New System.Drawing.Size(34, 13)
        Me.lblJillo.TabIndex = 9
        Me.lblJillo.Text = "જીલ્લો"
        '
        'txtOtherTaluko
        '
        Me.txtOtherTaluko.Location = New System.Drawing.Point(285, 211)
        Me.txtOtherTaluko.Name = "txtOtherTaluko"
        Me.txtOtherTaluko.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherTaluko.TabIndex = 8
        Me.txtOtherTaluko.Visible = False
        '
        'ddlTaluko
        '
        Me.ddlTaluko.DataSource = Me.TalukoBindingSource
        Me.ddlTaluko.DisplayMember = "name"
        Me.ddlTaluko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTaluko.FormattingEnabled = True
        Me.ddlTaluko.Location = New System.Drawing.Point(115, 210)
        Me.ddlTaluko.Name = "ddlTaluko"
        Me.ddlTaluko.Size = New System.Drawing.Size(121, 21)
        Me.ddlTaluko.TabIndex = 7
        Me.ddlTaluko.ValueMember = "talukoid"
        '
        'TalukoBindingSource
        '
        Me.TalukoBindingSource.DataMember = "taluko"
        Me.TalukoBindingSource.DataSource = Me.TalukoDataSet
        '
        'TalukoDataSet
        '
        Me.TalukoDataSet.DataSetName = "talukoDataSet"
        Me.TalukoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTaluko
        '
        Me.lblTaluko.AutoSize = True
        Me.lblTaluko.Location = New System.Drawing.Point(6, 213)
        Me.lblTaluko.Name = "lblTaluko"
        Me.lblTaluko.Size = New System.Drawing.Size(35, 13)
        Me.lblTaluko.TabIndex = 6
        Me.lblTaluko.Text = "તાલુકો"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 117)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(170, 68)
        Me.txtAddress.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 145)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(40, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "સરનામું"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(115, 31)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(170, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(6, 34)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(73, 13)
        Me.lblEmployeeName.TabIndex = 2
        Me.lblEmployeeName.Text = "કર્મચારીનું નામ​"
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.Location = New System.Drawing.Point(509, 17)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(170, 20)
        Me.txtEmployeeNo.TabIndex = 1
        Me.txtEmployeeNo.Visible = False
        '
        'JilloTableAdapter
        '
        Me.JilloTableAdapter.ClearBeforeFill = True
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Location = New System.Drawing.Point(400, 20)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(53, 13)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "કર્મચારી નં"
        Me.lblRegistration.Visible = False
        '
        'RajyaTableAdapter
        '
        Me.RajyaTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResignDate)
        Me.GroupBox1.Controls.Add(Me.dtResignDate)
        Me.GroupBox1.Controls.Add(Me.dtBirthDate)
        Me.GroupBox1.Controls.Add(Me.lblBirthDate)
        Me.GroupBox1.Controls.Add(Me.dtJoiningDate)
        Me.GroupBox1.Controls.Add(Me.lblJoiningDate)
        Me.GroupBox1.Controls.Add(Me.txtAdharno)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblAdharno)
        Me.GroupBox1.Controls.Add(Me.txtMobileNumber)
        Me.GroupBox1.Controls.Add(Me.lblOwnerName)
        Me.GroupBox1.Controls.Add(Me.txtPincode)
        Me.GroupBox1.Controls.Add(Me.lblPincode)
        Me.GroupBox1.Controls.Add(Me.txtOtherRajya)
        Me.GroupBox1.Controls.Add(Me.ddlRajya)
        Me.GroupBox1.Controls.Add(Me.lblRajya)
        Me.GroupBox1.Controls.Add(Me.txtOtherJillo)
        Me.GroupBox1.Controls.Add(Me.ddlJillo)
        Me.GroupBox1.Controls.Add(Me.lblJillo)
        Me.GroupBox1.Controls.Add(Me.txtOtherTaluko)
        Me.GroupBox1.Controls.Add(Me.ddlTaluko)
        Me.GroupBox1.Controls.Add(Me.lblTaluko)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.lblEmployeeName)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeNo)
        Me.GroupBox1.Controls.Add(Me.lblRegistration)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 652)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "કર્મચારી ફોર્મ​"
        '
        'lblResignDate
        '
        Me.lblResignDate.AutoSize = True
        Me.lblResignDate.Location = New System.Drawing.Point(12, 501)
        Me.lblResignDate.Name = "lblResignDate"
        Me.lblResignDate.Size = New System.Drawing.Size(54, 13)
        Me.lblResignDate.TabIndex = 44
        Me.lblResignDate.Text = "છોડયા તા."
        '
        'dtResignDate
        '
        Me.dtResignDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtResignDate.Location = New System.Drawing.Point(115, 501)
        Me.dtResignDate.Name = "dtResignDate"
        Me.dtResignDate.Size = New System.Drawing.Size(170, 20)
        Me.dtResignDate.TabIndex = 21
        '
        'dtBirthDate
        '
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(115, 463)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(170, 20)
        Me.dtBirthDate.TabIndex = 20
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(6, 463)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthDate.TabIndex = 42
        Me.lblBirthDate.Text = "જન્મ તા."
        '
        'dtJoiningDate
        '
        Me.dtJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtJoiningDate.Location = New System.Drawing.Point(115, 72)
        Me.dtJoiningDate.Name = "dtJoiningDate"
        Me.dtJoiningDate.Size = New System.Drawing.Size(170, 20)
        Me.dtJoiningDate.TabIndex = 41
        '
        'lblJoiningDate
        '
        Me.lblJoiningDate.AutoSize = True
        Me.lblJoiningDate.Location = New System.Drawing.Point(9, 72)
        Me.lblJoiningDate.Name = "lblJoiningDate"
        Me.lblJoiningDate.Size = New System.Drawing.Size(81, 13)
        Me.lblJoiningDate.TabIndex = 40
        Me.lblJoiningDate.Text = "જોઇનીંગ તારીખ​"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(210, 568)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(115, 568)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 36
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(21, 568)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblAdharno
        '
        Me.lblAdharno.AutoSize = True
        Me.lblAdharno.Location = New System.Drawing.Point(9, 425)
        Me.lblAdharno.Name = "lblAdharno"
        Me.lblAdharno.Size = New System.Drawing.Size(48, 13)
        Me.lblAdharno.TabIndex = 21
        Me.lblAdharno.Text = "આધાર નં"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(115, 385)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(170, 20)
        Me.txtMobileNumber.TabIndex = 18
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(6, 388)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(58, 13)
        Me.lblOwnerName.TabIndex = 17
        Me.lblOwnerName.Text = "મોબાઇલ નં"
        '
        'TalukoTableAdapter
        '
        Me.TalukoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
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
        'EmployeeDetail
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(800, 696)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EmployeeDetail"
        Me.Text = "EmployeeDetail"
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAdharno As MaskedTextBox
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtOtherRajya As TextBox
    Friend WithEvents ddlRajya As ComboBox
    Friend WithEvents RajyaBindingSource As BindingSource
    Friend WithEvents RajyaDataSet As rajyaDataSet
    Friend WithEvents lblRajya As Label
    Friend WithEvents txtOtherJillo As TextBox
    Friend WithEvents ddlJillo As ComboBox
    Friend WithEvents JilloBindingSource As BindingSource
    Friend WithEvents JilloDataSet As jilloDataSet
    Friend WithEvents lblJillo As Label
    Friend WithEvents txtOtherTaluko As TextBox
    Friend WithEvents ddlTaluko As ComboBox
    Friend WithEvents TalukoBindingSource As BindingSource
    Friend WithEvents TalukoDataSet As talukoDataSet
    Friend WithEvents lblTaluko As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtEmployeeNo As TextBox
    Friend WithEvents JilloTableAdapter As jilloDataSetTableAdapters.jilloTableAdapter
    Friend WithEvents lblRegistration As Label
    Friend WithEvents RajyaTableAdapter As rajyaDataSetTableAdapters.rajyaTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblAdharno As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents TalukoTableAdapter As talukoDataSetTableAdapters.talukoTableAdapter
    Friend WithEvents lblJoiningDate As Label
    Friend WithEvents dtJoiningDate As DateTimePicker
    Friend WithEvents lblResignDate As Label
    Friend WithEvents dtResignDate As DateTimePicker
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents lblBirthDate As Label
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
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerLoanDetailToolStripMenuItem As ToolStripMenuItem
End Class
