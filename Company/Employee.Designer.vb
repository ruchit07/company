<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.employeeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taluko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jillo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rajya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pincode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adharno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResigndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoiningdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSet = New Company.employeeDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
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
        Me.LoanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeid, Me.name, Me.address, Me.taluko, Me.jillo, Me.rajya, Me.pincode, Me.mobile, Me.adharno, Me.birthdate, Me.EmployeenumberDataGridViewTextBoxColumn, Me.ResigndateDataGridViewTextBoxColumn, Me.JoiningdateDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 294)
        Me.DataGridView1.TabIndex = 0
        '
        'employeeid
        '
        Me.employeeid.DataPropertyName = "employeeid"
        Me.employeeid.HeaderText = "Employee ID"
        Me.employeeid.Name = "employeeid"
        Me.employeeid.ReadOnly = True
        Me.employeeid.Visible = False
        '
        'name
        '
        Me.name.DataPropertyName = "name"
        Me.name.HeaderText = "Name"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'taluko
        '
        Me.taluko.DataPropertyName = "taluko"
        Me.taluko.HeaderText = "Taluko"
        Me.taluko.Name = "taluko"
        Me.taluko.ReadOnly = True
        '
        'jillo
        '
        Me.jillo.DataPropertyName = "jillo"
        Me.jillo.HeaderText = "Jillo"
        Me.jillo.Name = "jillo"
        Me.jillo.ReadOnly = True
        '
        'rajya
        '
        Me.rajya.DataPropertyName = "rajya"
        Me.rajya.HeaderText = "Rajya"
        Me.rajya.Name = "rajya"
        Me.rajya.ReadOnly = True
        '
        'pincode
        '
        Me.pincode.DataPropertyName = "pincode"
        Me.pincode.HeaderText = "Pincode"
        Me.pincode.Name = "pincode"
        Me.pincode.ReadOnly = True
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile"
        Me.mobile.HeaderText = "Mobile"
        Me.mobile.Name = "mobile"
        Me.mobile.ReadOnly = True
        '
        'adharno
        '
        Me.adharno.DataPropertyName = "adharno"
        Me.adharno.HeaderText = "Adhar No"
        Me.adharno.Name = "adharno"
        Me.adharno.ReadOnly = True
        '
        'birthdate
        '
        Me.birthdate.DataPropertyName = "birthdate"
        Me.birthdate.HeaderText = "Birth Date"
        Me.birthdate.Name = "birthdate"
        Me.birthdate.ReadOnly = True
        '
        'EmployeenumberDataGridViewTextBoxColumn
        '
        Me.EmployeenumberDataGridViewTextBoxColumn.DataPropertyName = "employeenumber"
        Me.EmployeenumberDataGridViewTextBoxColumn.HeaderText = "Employee Number"
        Me.EmployeenumberDataGridViewTextBoxColumn.Name = "EmployeenumberDataGridViewTextBoxColumn"
        Me.EmployeenumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResigndateDataGridViewTextBoxColumn
        '
        Me.ResigndateDataGridViewTextBoxColumn.DataPropertyName = "resigndate"
        Me.ResigndateDataGridViewTextBoxColumn.HeaderText = "Resign Date"
        Me.ResigndateDataGridViewTextBoxColumn.Name = "ResigndateDataGridViewTextBoxColumn"
        Me.ResigndateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JoiningdateDataGridViewTextBoxColumn
        '
        Me.JoiningdateDataGridViewTextBoxColumn.DataPropertyName = "joiningdate"
        Me.JoiningdateDataGridViewTextBoxColumn.HeaderText = "Joining Date"
        Me.JoiningdateDataGridViewTextBoxColumn.Name = "JoiningdateDataGridViewTextBoxColumn"
        Me.JoiningdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employeeid"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employeeid"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
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
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1182, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1299, 24)
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
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.name = "Employee"
        Me.Text = "Employee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents EmployeeDataSet As employeeDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As employeeDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TalukoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RajyaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JilloidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents employeeid As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents taluko As DataGridViewTextBoxColumn
    Friend WithEvents jillo As DataGridViewTextBoxColumn
    Friend WithEvents rajya As DataGridViewTextBoxColumn
    Friend WithEvents pincode As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents adharno As DataGridViewTextBoxColumn
    Friend WithEvents birthdate As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResigndateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoiningdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanToolStripMenuItem1 As ToolStripMenuItem
End Class
