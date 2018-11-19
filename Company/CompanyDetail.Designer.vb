<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompanyDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RajyaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RajyaDataSet = New Company.rajyaDataSet()
        Me.JilloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JilloDataSet = New Company.jilloDataSet()
        Me.TalukoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TalukoDataSet = New Company.talukoDataSet()
        Me.TalukoTableAdapter = New Company.talukoDataSetTableAdapters.talukoTableAdapter()
        Me.JilloTableAdapter = New Company.jilloDataSetTableAdapters.jilloTableAdapter()
        Me.RajyaTableAdapter = New Company.rajyaDataSetTableAdapters.rajyaTableAdapter()
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
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblTaluko = New System.Windows.Forms.Label()
        Me.ddlTaluko = New System.Windows.Forms.ComboBox()
        Me.txtOtherTaluko = New System.Windows.Forms.TextBox()
        Me.lblJillo = New System.Windows.Forms.Label()
        Me.ddlJillo = New System.Windows.Forms.ComboBox()
        Me.txtOtherJillo = New System.Windows.Forms.TextBox()
        Me.lblRajya = New System.Windows.Forms.Label()
        Me.ddlRajya = New System.Windows.Forms.ComboBox()
        Me.txtOtherRajya = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.lblFormNo = New System.Windows.Forms.Label()
        Me.txtFormPre = New System.Windows.Forms.TextBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.txtFormPost = New System.Windows.Forms.TextBox()
        Me.lblAccountStartDate = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerLoanDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'TalukoTableAdapter
        '
        Me.TalukoTableAdapter.ClearBeforeFill = True
        '
        'JilloTableAdapter
        '
        Me.JilloTableAdapter.ClearBeforeFill = True
        '
        'RajyaTableAdapter
        '
        Me.RajyaTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 3
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
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(6, 37)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(63, 13)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "કંપનીનું નામ​"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(115, 34)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(170, 20)
        Me.txtCompanyName.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 94)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(40, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "સરનામું"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 66)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(170, 68)
        Me.txtAddress.TabIndex = 5
        '
        'lblTaluko
        '
        Me.lblTaluko.AutoSize = True
        Me.lblTaluko.Location = New System.Drawing.Point(6, 162)
        Me.lblTaluko.Name = "lblTaluko"
        Me.lblTaluko.Size = New System.Drawing.Size(35, 13)
        Me.lblTaluko.TabIndex = 6
        Me.lblTaluko.Text = "તાલુકો"
        '
        'ddlTaluko
        '
        Me.ddlTaluko.DataSource = Me.TalukoBindingSource
        Me.ddlTaluko.DisplayMember = "name"
        Me.ddlTaluko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTaluko.FormattingEnabled = True
        Me.ddlTaluko.Location = New System.Drawing.Point(115, 159)
        Me.ddlTaluko.Name = "ddlTaluko"
        Me.ddlTaluko.Size = New System.Drawing.Size(121, 21)
        Me.ddlTaluko.TabIndex = 7
        Me.ddlTaluko.ValueMember = "talukoid"
        '
        'txtOtherTaluko
        '
        Me.txtOtherTaluko.Location = New System.Drawing.Point(285, 160)
        Me.txtOtherTaluko.Name = "txtOtherTaluko"
        Me.txtOtherTaluko.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherTaluko.TabIndex = 8
        Me.txtOtherTaluko.Visible = False
        '
        'lblJillo
        '
        Me.lblJillo.AutoSize = True
        Me.lblJillo.Location = New System.Drawing.Point(6, 213)
        Me.lblJillo.Name = "lblJillo"
        Me.lblJillo.Size = New System.Drawing.Size(34, 13)
        Me.lblJillo.TabIndex = 9
        Me.lblJillo.Text = "જીલ્લો"
        '
        'ddlJillo
        '
        Me.ddlJillo.DataSource = Me.JilloBindingSource
        Me.ddlJillo.DisplayMember = "name"
        Me.ddlJillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlJillo.FormattingEnabled = True
        Me.ddlJillo.Location = New System.Drawing.Point(115, 205)
        Me.ddlJillo.Name = "ddlJillo"
        Me.ddlJillo.Size = New System.Drawing.Size(121, 21)
        Me.ddlJillo.TabIndex = 10
        Me.ddlJillo.ValueMember = "jilloid"
        '
        'txtOtherJillo
        '
        Me.txtOtherJillo.Location = New System.Drawing.Point(285, 206)
        Me.txtOtherJillo.Name = "txtOtherJillo"
        Me.txtOtherJillo.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherJillo.TabIndex = 11
        Me.txtOtherJillo.Visible = False
        '
        'lblRajya
        '
        Me.lblRajya.AutoSize = True
        Me.lblRajya.Location = New System.Drawing.Point(9, 256)
        Me.lblRajya.Name = "lblRajya"
        Me.lblRajya.Size = New System.Drawing.Size(31, 13)
        Me.lblRajya.TabIndex = 12
        Me.lblRajya.Text = "રાજ્ય​"
        '
        'ddlRajya
        '
        Me.ddlRajya.DataSource = Me.RajyaBindingSource
        Me.ddlRajya.DisplayMember = "name"
        Me.ddlRajya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRajya.FormattingEnabled = True
        Me.ddlRajya.Location = New System.Drawing.Point(115, 256)
        Me.ddlRajya.Name = "ddlRajya"
        Me.ddlRajya.Size = New System.Drawing.Size(121, 21)
        Me.ddlRajya.TabIndex = 13
        Me.ddlRajya.ValueMember = "rajyaid"
        '
        'txtOtherRajya
        '
        Me.txtOtherRajya.Location = New System.Drawing.Point(285, 257)
        Me.txtOtherRajya.Name = "txtOtherRajya"
        Me.txtOtherRajya.Size = New System.Drawing.Size(160, 20)
        Me.txtOtherRajya.TabIndex = 14
        Me.txtOtherRajya.Visible = False
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.Location = New System.Drawing.Point(6, 298)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(42, 13)
        Me.lblPincode.TabIndex = 15
        Me.lblPincode.Text = "પીનકોડ​"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(115, 295)
        Me.txtPincode.MaxLength = 6
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(170, 20)
        Me.txtPincode.TabIndex = 16
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(6, 337)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(67, 13)
        Me.lblOwnerName.TabIndex = 17
        Me.lblOwnerName.Text = "માલીકનું નામ​"
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Location = New System.Drawing.Point(115, 334)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(170, 20)
        Me.txtOwnerName.TabIndex = 18
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(568, 44)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(58, 13)
        Me.lblMobile.TabIndex = 19
        Me.lblMobile.Text = "મોબાઇલ નં"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(677, 37)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(170, 20)
        Me.txtMobileNumber.TabIndex = 20
        '
        'lblFormNo
        '
        Me.lblFormNo.AutoSize = True
        Me.lblFormNo.Location = New System.Drawing.Point(571, 78)
        Me.lblFormNo.Name = "lblFormNo"
        Me.lblFormNo.Size = New System.Drawing.Size(36, 13)
        Me.lblFormNo.TabIndex = 21
        Me.lblFormNo.Text = "ફોન નં"
        '
        'txtFormPre
        '
        Me.txtFormPre.Location = New System.Drawing.Point(677, 75)
        Me.txtFormPre.Name = "txtFormPre"
        Me.txtFormPre.Size = New System.Drawing.Size(89, 20)
        Me.txtFormPre.TabIndex = 22
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(772, 78)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 23
        Me.lblDash.Text = "-"
        '
        'txtFormPost
        '
        Me.txtFormPost.Location = New System.Drawing.Point(788, 75)
        Me.txtFormPost.Name = "txtFormPost"
        Me.txtFormPost.Size = New System.Drawing.Size(80, 20)
        Me.txtFormPost.TabIndex = 24
        '
        'lblAccountStartDate
        '
        Me.lblAccountStartDate.AutoSize = True
        Me.lblAccountStartDate.Location = New System.Drawing.Point(568, 120)
        Me.lblAccountStartDate.Name = "lblAccountStartDate"
        Me.lblAccountStartDate.Size = New System.Drawing.Size(76, 13)
        Me.lblAccountStartDate.TabIndex = 25
        Me.lblAccountStartDate.Text = "એકાઉન્ટ વર્ષ તા"
        '
        'txtStartDate
        '
        Me.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtStartDate.Location = New System.Drawing.Point(677, 114)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(89, 20)
        Me.txtStartDate.TabIndex = 26
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(568, 162)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(69, 13)
        Me.lblEndDate.TabIndex = 27
        Me.lblEndDate.Text = "અંતીમ તારીખ​"
        '
        'txtEndDate
        '
        Me.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEndDate.Location = New System.Drawing.Point(677, 156)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(89, 20)
        Me.txtEndDate.TabIndex = 28
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(568, 197)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(51, 13)
        Me.lblUserName.TabIndex = 29
        Me.lblUserName.Text = "યુઝર નામ​"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(677, 194)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(146, 20)
        Me.txtUserName.TabIndex = 30
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(568, 236)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(39, 13)
        Me.lblPassword.TabIndex = 31
        Me.lblPassword.Text = "પાસવર્ડ​"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(677, 233)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(146, 20)
        Me.txtPassword.TabIndex = 32
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(568, 277)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(51, 13)
        Me.lblConfirmPassword.TabIndex = 33
        Me.lblConfirmPassword.Text = "રી પાસ​વર્ડ​"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(677, 270)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(146, 20)
        Me.txtConfirmPassword.TabIndex = 34
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(103, 408)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 36
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(198, 408)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.lblConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.txtEndDate)
        Me.GroupBox1.Controls.Add(Me.lblEndDate)
        Me.GroupBox1.Controls.Add(Me.txtStartDate)
        Me.GroupBox1.Controls.Add(Me.lblAccountStartDate)
        Me.GroupBox1.Controls.Add(Me.txtFormPost)
        Me.GroupBox1.Controls.Add(Me.lblDash)
        Me.GroupBox1.Controls.Add(Me.txtFormPre)
        Me.GroupBox1.Controls.Add(Me.lblFormNo)
        Me.GroupBox1.Controls.Add(Me.txtMobileNumber)
        Me.GroupBox1.Controls.Add(Me.lblMobile)
        Me.GroupBox1.Controls.Add(Me.txtOwnerName)
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
        Me.GroupBox1.Controls.Add(Me.txtCompanyName)
        Me.GroupBox1.Controls.Add(Me.lblCompanyName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 448)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ન​વી કંપની બનાવ​વી"
        '
        'CustomerLoanDetailToolStripMenuItem
        '
        Me.CustomerLoanDetailToolStripMenuItem.Name = "CustomerLoanDetailToolStripMenuItem"
        Me.CustomerLoanDetailToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CustomerLoanDetailToolStripMenuItem.Text = "Customer Loan Detail"
        '
        'CompanyDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 485)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CompanyDetail"
        Me.Text = "CompanyDetail"
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TalukoDataSet As talukoDataSet
    Friend WithEvents TalukoBindingSource As BindingSource
    Friend WithEvents TalukoTableAdapter As talukoDataSetTableAdapters.talukoTableAdapter
    Friend WithEvents JilloDataSet As jilloDataSet
    Friend WithEvents JilloBindingSource As BindingSource
    Friend WithEvents JilloTableAdapter As jilloDataSetTableAdapters.jilloTableAdapter
    Friend WithEvents RajyaDataSet As rajyaDataSet
    Friend WithEvents RajyaBindingSource As BindingSource
    Friend WithEvents RajyaTableAdapter As rajyaDataSetTableAdapters.rajyaTableAdapter
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
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblTaluko As Label
    Friend WithEvents ddlTaluko As ComboBox
    Friend WithEvents txtOtherTaluko As TextBox
    Friend WithEvents lblJillo As Label
    Friend WithEvents ddlJillo As ComboBox
    Friend WithEvents txtOtherJillo As TextBox
    Friend WithEvents lblRajya As Label
    Friend WithEvents ddlRajya As ComboBox
    Friend WithEvents txtOtherRajya As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents lblFormNo As Label
    Friend WithEvents txtFormPre As TextBox
    Friend WithEvents lblDash As Label
    Friend WithEvents txtFormPost As TextBox
    Friend WithEvents lblAccountStartDate As Label
    Friend WithEvents txtStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents txtEndDate As DateTimePicker
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerLoanDetailToolStripMenuItem As ToolStripMenuItem
End Class
