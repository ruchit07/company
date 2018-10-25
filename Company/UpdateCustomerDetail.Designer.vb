<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustomerDetail
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
        Me.lblCompanyId = New System.Windows.Forms.Label()
        Me.RajyaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RajyaDataSet = New Company.rajyaDataSet()
        Me.txtAdharno = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtJaminAddress = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.jaminid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.txtJaminMobile = New System.Windows.Forms.TextBox()
        Me.lblJaminMobile = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblJaminName = New System.Windows.Forms.Label()
        Me.lblAdharno = New System.Windows.Forms.Label()
        Me.txtMobileNumber2 = New System.Windows.Forms.TextBox()
        Me.lblMobile2 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtOtherRajya = New System.Windows.Forms.TextBox()
        Me.ddlRajya = New System.Windows.Forms.ComboBox()
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
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtRegistrationNo = New System.Windows.Forms.TextBox()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.JilloTableAdapter = New Company.jilloDataSetTableAdapters.jilloTableAdapter()
        Me.RajyaTableAdapter = New Company.rajyaDataSetTableAdapters.rajyaTableAdapter()
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
        Me.RecoveryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCompanyId
        '
        Me.lblCompanyId.AutoSize = True
        Me.lblCompanyId.Location = New System.Drawing.Point(541, 95)
        Me.lblCompanyId.Name = "lblCompanyId"
        Me.lblCompanyId.Size = New System.Drawing.Size(39, 13)
        Me.lblCompanyId.TabIndex = 39
        Me.lblCompanyId.Text = "Label1"
        Me.lblCompanyId.Visible = False
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
        'txtAdharno
        '
        Me.txtAdharno.Location = New System.Drawing.Point(115, 370)
        Me.txtAdharno.Mask = "0000-0000-0000"
        Me.txtAdharno.Name = "txtAdharno"
        Me.txtAdharno.Size = New System.Drawing.Size(170, 20)
        Me.txtAdharno.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(189, 670)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(108, 670)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 670)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtJaminAddress
        '
        Me.txtJaminAddress.Location = New System.Drawing.Point(118, 488)
        Me.txtJaminAddress.Multiline = True
        Me.txtJaminAddress.Name = "txtJaminAddress"
        Me.txtJaminAddress.Size = New System.Drawing.Size(146, 40)
        Me.txtJaminAddress.TabIndex = 34
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(9, 503)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(40, 13)
        Me.lblConfirmPassword.TabIndex = 33
        Me.lblConfirmPassword.Text = "સરનામું"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblCustomerId)
        Me.GroupBox1.Controls.Add(Me.lblCompanyId)
        Me.GroupBox1.Controls.Add(Me.txtAdharno)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtJaminAddress)
        Me.GroupBox1.Controls.Add(Me.lblConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.txtJaminMobile)
        Me.GroupBox1.Controls.Add(Me.lblJaminMobile)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.lblJaminName)
        Me.GroupBox1.Controls.Add(Me.lblAdharno)
        Me.GroupBox1.Controls.Add(Me.txtMobileNumber2)
        Me.GroupBox1.Controls.Add(Me.lblMobile2)
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
        Me.GroupBox1.Controls.Add(Me.lblCompanyName)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationNo)
        Me.GroupBox1.Controls.Add(Me.lblRegistration)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 714)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ગ્રાહક રજીસ્ટ્રેશન ફોર્મ​"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jaminid, Me.name, Me.mobile, Me.Address, Me.btnUpdate, Me.Delete})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 566)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(568, 76)
        Me.DataGridView1.TabIndex = 42
        '
        'jaminid
        '
        Me.jaminid.DataPropertyName = "jaminid"
        Me.jaminid.HeaderText = "jaminid"
        Me.jaminid.Name = "jaminid"
        Me.jaminid.Visible = False
        '
        'name
        '
        Me.name.DataPropertyName = "name"
        Me.name.HeaderText = "જામીનનું નામ​"
        Me.name.Name = "name"
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile"
        Me.mobile.HeaderText = "જામીનનો મોબાઇલ નં"
        Me.mobile.Name = "mobile"
        '
        'Address
        '
        Me.Address.DataPropertyName = "address"
        Me.Address.HeaderText = "જામીનનું સરનામું"
        Me.Address.Name = "Address"
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = "Update"
        Me.btnUpdate.Name = "btnUpdate"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(294, 505)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(648, 95)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(39, 13)
        Me.lblCustomerId.TabIndex = 40
        Me.lblCustomerId.Text = "Label1"
        Me.lblCustomerId.Visible = False
        '
        'txtJaminMobile
        '
        Me.txtJaminMobile.Location = New System.Drawing.Point(118, 451)
        Me.txtJaminMobile.Name = "txtJaminMobile"
        Me.txtJaminMobile.Size = New System.Drawing.Size(146, 20)
        Me.txtJaminMobile.TabIndex = 32
        '
        'lblJaminMobile
        '
        Me.lblJaminMobile.AutoSize = True
        Me.lblJaminMobile.Location = New System.Drawing.Point(9, 462)
        Me.lblJaminMobile.Name = "lblJaminMobile"
        Me.lblJaminMobile.Size = New System.Drawing.Size(104, 13)
        Me.lblJaminMobile.TabIndex = 31
        Me.lblJaminMobile.Text = "જામીનનો મોબાઇલ નં"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(118, 412)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(146, 20)
        Me.txtUserName.TabIndex = 30
        '
        'lblJaminName
        '
        Me.lblJaminName.AutoSize = True
        Me.lblJaminName.Location = New System.Drawing.Point(9, 423)
        Me.lblJaminName.Name = "lblJaminName"
        Me.lblJaminName.Size = New System.Drawing.Size(69, 13)
        Me.lblJaminName.TabIndex = 29
        Me.lblJaminName.Text = "જામીનનું નામ​"
        '
        'lblAdharno
        '
        Me.lblAdharno.AutoSize = True
        Me.lblAdharno.Location = New System.Drawing.Point(9, 378)
        Me.lblAdharno.Name = "lblAdharno"
        Me.lblAdharno.Size = New System.Drawing.Size(48, 13)
        Me.lblAdharno.TabIndex = 21
        Me.lblAdharno.Text = "આધાર નં"
        '
        'txtMobileNumber2
        '
        Me.txtMobileNumber2.Location = New System.Drawing.Point(115, 333)
        Me.txtMobileNumber2.Name = "txtMobileNumber2"
        Me.txtMobileNumber2.Size = New System.Drawing.Size(170, 20)
        Me.txtMobileNumber2.TabIndex = 20
        '
        'lblMobile2
        '
        Me.lblMobile2.AutoSize = True
        Me.lblMobile2.Location = New System.Drawing.Point(6, 348)
        Me.lblMobile2.Name = "lblMobile2"
        Me.lblMobile2.Size = New System.Drawing.Size(67, 13)
        Me.lblMobile2.TabIndex = 19
        Me.lblMobile2.Text = "મોબાઇલ નં 2"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(115, 293)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(170, 20)
        Me.txtMobileNumber.TabIndex = 18
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(6, 304)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(67, 13)
        Me.lblOwnerName.TabIndex = 17
        Me.lblOwnerName.Text = "મોબાઇલ નં 1"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(115, 257)
        Me.txtPincode.MaxLength = 6
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(170, 20)
        Me.txtPincode.TabIndex = 16
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.Location = New System.Drawing.Point(6, 268)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(42, 13)
        Me.lblPincode.TabIndex = 15
        Me.lblPincode.Text = "પીનકોડ​"
        '
        'txtOtherRajya
        '
        Me.txtOtherRajya.Location = New System.Drawing.Point(285, 219)
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
        Me.ddlRajya.Location = New System.Drawing.Point(115, 218)
        Me.ddlRajya.Name = "ddlRajya"
        Me.ddlRajya.Size = New System.Drawing.Size(121, 21)
        Me.ddlRajya.TabIndex = 13
        Me.ddlRajya.ValueMember = "rajyaid"
        '
        'lblRajya
        '
        Me.lblRajya.AutoSize = True
        Me.lblRajya.Location = New System.Drawing.Point(9, 226)
        Me.lblRajya.Name = "lblRajya"
        Me.lblRajya.Size = New System.Drawing.Size(31, 13)
        Me.lblRajya.TabIndex = 12
        Me.lblRajya.Text = "રાજ્ય​"
        '
        'txtOtherJillo
        '
        Me.txtOtherJillo.Location = New System.Drawing.Point(285, 172)
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
        Me.ddlJillo.Location = New System.Drawing.Point(115, 171)
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
        Me.lblJillo.Location = New System.Drawing.Point(6, 187)
        Me.lblJillo.Name = "lblJillo"
        Me.lblJillo.Size = New System.Drawing.Size(34, 13)
        Me.lblJillo.TabIndex = 9
        Me.lblJillo.Text = "જીલ્લો"
        '
        'txtOtherTaluko
        '
        Me.txtOtherTaluko.Location = New System.Drawing.Point(285, 126)
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
        Me.ddlTaluko.Location = New System.Drawing.Point(115, 125)
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
        Me.lblTaluko.Location = New System.Drawing.Point(6, 136)
        Me.lblTaluko.Name = "lblTaluko"
        Me.lblTaluko.Size = New System.Drawing.Size(35, 13)
        Me.lblTaluko.TabIndex = 6
        Me.lblTaluko.Text = "તાલુકો"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 61)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(170, 54)
        Me.txtAddress.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 93)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(40, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "સરનામું"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(115, 28)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(170, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(6, 31)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(63, 13)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "ગ્રાહકનું નામ​"
        '
        'txtRegistrationNo
        '
        Me.txtRegistrationNo.Location = New System.Drawing.Point(559, 63)
        Me.txtRegistrationNo.Name = "txtRegistrationNo"
        Me.txtRegistrationNo.Size = New System.Drawing.Size(170, 20)
        Me.txtRegistrationNo.TabIndex = 1
        Me.txtRegistrationNo.Visible = False
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Location = New System.Drawing.Point(517, 35)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(63, 13)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "રજીસ્ટ્રેશન નં"
        Me.lblRegistration.Visible = False
        '
        'JilloTableAdapter
        '
        Me.JilloTableAdapter.ClearBeforeFill = True
        '
        'RajyaTableAdapter
        '
        Me.RajyaTableAdapter.ClearBeforeFill = True
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
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripMenuItem1, Me.RecoveryListToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'RecoveryListToolStripMenuItem
        '
        Me.RecoveryListToolStripMenuItem.Name = "RecoveryListToolStripMenuItem"
        Me.RecoveryListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecoveryListToolStripMenuItem.Text = "Recovery List"
        '
        'LoanToolStripMenuItem1
        '
        Me.LoanToolStripMenuItem1.Name = "LoanToolStripMenuItem1"
        Me.LoanToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.LoanToolStripMenuItem1.Text = "Loan"
        '
        'UpdateCustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 753)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.name = "UpdateCustomerDetail"
        Me.Text = "UpdateCustomerDetail"
        CType(Me.RajyaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RajyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TalukoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompanyId As Label
    Friend WithEvents RajyaBindingSource As BindingSource
    Friend WithEvents RajyaDataSet As rajyaDataSet
    Friend WithEvents txtAdharno As MaskedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtJaminAddress As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJaminMobile As TextBox
    Friend WithEvents lblJaminMobile As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblJaminName As Label
    Friend WithEvents lblAdharno As Label
    Friend WithEvents txtMobileNumber2 As TextBox
    Friend WithEvents lblMobile2 As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtOtherRajya As TextBox
    Friend WithEvents ddlRajya As ComboBox
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
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtRegistrationNo As TextBox
    Friend WithEvents lblRegistration As Label
    Friend WithEvents JilloTableAdapter As jilloDataSetTableAdapters.jilloTableAdapter
    Friend WithEvents RajyaTableAdapter As rajyaDataSetTableAdapters.rajyaTableAdapter
    Friend WithEvents TalukoTableAdapter As talukoDataSetTableAdapters.talukoTableAdapter
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents jaminid As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
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
End Class
