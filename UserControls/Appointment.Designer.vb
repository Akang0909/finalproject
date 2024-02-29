<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactDeleteBtn = New System.Windows.Forms.Button()
        Me.contactUpdateBtn = New System.Windows.Forms.Button()
        Me.contactClearBtn = New System.Windows.Forms.Button()
        Me.createContactBtn = New System.Windows.Forms.Button()
        Me.emergencyContactTxt = New System.Windows.Forms.TextBox()
        Me.appIDT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(409, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(536, 315)
        Me.DataGridView1.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Appointment ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Appointment Date"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Status"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Doctor ID"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'contactDeleteBtn
        '
        Me.contactDeleteBtn.Location = New System.Drawing.Point(433, 571)
        Me.contactDeleteBtn.Name = "contactDeleteBtn"
        Me.contactDeleteBtn.Size = New System.Drawing.Size(216, 41)
        Me.contactDeleteBtn.TabIndex = 61
        Me.contactDeleteBtn.Text = "Delete Contact"
        Me.contactDeleteBtn.UseVisualStyleBackColor = True
        '
        'contactUpdateBtn
        '
        Me.contactUpdateBtn.Location = New System.Drawing.Point(718, 509)
        Me.contactUpdateBtn.Name = "contactUpdateBtn"
        Me.contactUpdateBtn.Size = New System.Drawing.Size(216, 41)
        Me.contactUpdateBtn.TabIndex = 60
        Me.contactUpdateBtn.Text = "Update Contact"
        Me.contactUpdateBtn.UseVisualStyleBackColor = True
        '
        'contactClearBtn
        '
        Me.contactClearBtn.Location = New System.Drawing.Point(718, 571)
        Me.contactClearBtn.Name = "contactClearBtn"
        Me.contactClearBtn.Size = New System.Drawing.Size(216, 44)
        Me.contactClearBtn.TabIndex = 59
        Me.contactClearBtn.Text = "Clear"
        Me.contactClearBtn.UseVisualStyleBackColor = True
        '
        'createContactBtn
        '
        Me.createContactBtn.Location = New System.Drawing.Point(433, 509)
        Me.createContactBtn.Name = "createContactBtn"
        Me.createContactBtn.Size = New System.Drawing.Size(216, 41)
        Me.createContactBtn.TabIndex = 58
        Me.createContactBtn.Text = "Create Contact"
        Me.createContactBtn.UseVisualStyleBackColor = True
        '
        'emergencyContactTxt
        '
        Me.emergencyContactTxt.Location = New System.Drawing.Point(211, 383)
        Me.emergencyContactTxt.Name = "emergencyContactTxt"
        Me.emergencyContactTxt.Size = New System.Drawing.Size(180, 22)
        Me.emergencyContactTxt.TabIndex = 50
        '
        'appIDT
        '
        Me.appIDT.Location = New System.Drawing.Point(211, 180)
        Me.appIDT.Name = "appIDT"
        Me.appIDT.Size = New System.Drawing.Size(182, 22)
        Me.appIDT.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 17)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Appointment Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 17)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Appointment ID: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(24, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 29)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Appointment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Doctor ID:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pending", "Successful"})
        Me.ComboBox1.Location = New System.Drawing.Point(211, 332)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 24)
        Me.ComboBox1.TabIndex = 64
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(215, 261)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 22)
        Me.DateTimePicker1.TabIndex = 65
        '
        'Appointment
        '
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.contactDeleteBtn)
        Me.Controls.Add(Me.contactUpdateBtn)
        Me.Controls.Add(Me.contactClearBtn)
        Me.Controls.Add(Me.createContactBtn)
        Me.Controls.Add(Me.emergencyContactTxt)
        Me.Controls.Add(Me.appIDT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Appointment"
        Me.Size = New System.Drawing.Size(948, 751)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label4 As Label
    Friend WithEvents MySqlCommand2 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents appIDTxt As TextBox
    Friend WithEvents statusComboBox As ComboBox
    Friend WithEvents appDocTxt As TextBox
    Friend WithEvents appDTP1 As DateTimePicker
    Friend WithEvents appCreateBtn As Button
    Friend WithEvents appReschedBtn As Button
    Friend WithEvents appDeleteBtn As Button
    Friend WithEvents appClearBtn As Button
    Friend WithEvents appSearchTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents contactDeleteBtn As Button
    Friend WithEvents contactUpdateBtn As Button
    Friend WithEvents contactClearBtn As Button
    Friend WithEvents createContactBtn As Button
    Friend WithEvents emergencyContactTxt As TextBox
    Friend WithEvents appIDT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
