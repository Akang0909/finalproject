<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contact
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nameEmergencyTxt = New System.Windows.Forms.TextBox()
        Me.relationshipTxt = New System.Windows.Forms.TextBox()
        Me.emergencyContactTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.physicianNameTxt = New System.Windows.Forms.TextBox()
        Me.contactPhysicianTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.reasonAppointmentTxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.createContactBtn = New System.Windows.Forms.Button()
        Me.contactDeleteBtn = New System.Windows.Forms.Button()
        Me.contactClearBtn = New System.Windows.Forms.Button()
        Me.contactUpdateBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contacts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(25, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Contact info"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Name of Emergency Contact"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Relationship"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Emergency Contact Phone Number"
        '
        'nameEmergencyTxt
        '
        Me.nameEmergencyTxt.Location = New System.Drawing.Point(23, 179)
        Me.nameEmergencyTxt.Name = "nameEmergencyTxt"
        Me.nameEmergencyTxt.Size = New System.Drawing.Size(254, 22)
        Me.nameEmergencyTxt.TabIndex = 18
        '
        'relationshipTxt
        '
        Me.relationshipTxt.Location = New System.Drawing.Point(26, 234)
        Me.relationshipTxt.Name = "relationshipTxt"
        Me.relationshipTxt.Size = New System.Drawing.Size(251, 22)
        Me.relationshipTxt.TabIndex = 19
        '
        'emergencyContactTxt
        '
        Me.emergencyContactTxt.Location = New System.Drawing.Point(26, 297)
        Me.emergencyContactTxt.Name = "emergencyContactTxt"
        Me.emergencyContactTxt.Size = New System.Drawing.Size(251, 22)
        Me.emergencyContactTxt.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(21, 375)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 29)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Referring Doctor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Name"
        '
        'physicianNameTxt
        '
        Me.physicianNameTxt.Location = New System.Drawing.Point(93, 424)
        Me.physicianNameTxt.Name = "physicianNameTxt"
        Me.physicianNameTxt.Size = New System.Drawing.Size(254, 22)
        Me.physicianNameTxt.TabIndex = 23
        '
        'contactPhysicianTxt
        '
        Me.contactPhysicianTxt.Location = New System.Drawing.Point(93, 464)
        Me.contactPhysicianTxt.Name = "contactPhysicianTxt"
        Me.contactPhysicianTxt.Size = New System.Drawing.Size(254, 22)
        Me.contactPhysicianTxt.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Contact"
        '
        'reasonAppointmentTxt
        '
        Me.reasonAppointmentTxt.Location = New System.Drawing.Point(93, 548)
        Me.reasonAppointmentTxt.Multiline = True
        Me.reasonAppointmentTxt.Name = "reasonAppointmentTxt"
        Me.reasonAppointmentTxt.Size = New System.Drawing.Size(254, 67)
        Me.reasonAppointmentTxt.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 512)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(161, 17)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Reason for Appointment"
        '
        'createContactBtn
        '
        Me.createContactBtn.Location = New System.Drawing.Point(430, 506)
        Me.createContactBtn.Name = "createContactBtn"
        Me.createContactBtn.Size = New System.Drawing.Size(216, 41)
        Me.createContactBtn.TabIndex = 35
        Me.createContactBtn.Text = "Create Contact"
        Me.createContactBtn.UseVisualStyleBackColor = True
        '
        'contactDeleteBtn
        '
        Me.contactDeleteBtn.Location = New System.Drawing.Point(430, 568)
        Me.contactDeleteBtn.Name = "contactDeleteBtn"
        Me.contactDeleteBtn.Size = New System.Drawing.Size(216, 41)
        Me.contactDeleteBtn.TabIndex = 42
        Me.contactDeleteBtn.Text = "Delete Contact"
        Me.contactDeleteBtn.UseVisualStyleBackColor = True
        '
        'contactClearBtn
        '
        Me.contactClearBtn.Location = New System.Drawing.Point(715, 568)
        Me.contactClearBtn.Name = "contactClearBtn"
        Me.contactClearBtn.Size = New System.Drawing.Size(216, 44)
        Me.contactClearBtn.TabIndex = 40
        Me.contactClearBtn.Text = "Clear"
        Me.contactClearBtn.UseVisualStyleBackColor = True
        '
        'contactUpdateBtn
        '
        Me.contactUpdateBtn.Location = New System.Drawing.Point(715, 506)
        Me.contactUpdateBtn.Name = "contactUpdateBtn"
        Me.contactUpdateBtn.Size = New System.Drawing.Size(216, 41)
        Me.contactUpdateBtn.TabIndex = 41
        Me.contactUpdateBtn.Text = "Update Contact"
        Me.contactUpdateBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(394, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(536, 315)
        Me.DataGridView1.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "emergency_id"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "emergency_name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "relationship"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "emergency_contact"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.contactDeleteBtn)
        Me.Controls.Add(Me.contactUpdateBtn)
        Me.Controls.Add(Me.contactClearBtn)
        Me.Controls.Add(Me.createContactBtn)
        Me.Controls.Add(Me.reasonAppointmentTxt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.contactPhysicianTxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.physicianNameTxt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.emergencyContactTxt)
        Me.Controls.Add(Me.relationshipTxt)
        Me.Controls.Add(Me.nameEmergencyTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Contact"
        Me.Size = New System.Drawing.Size(948, 751)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents nameEmergencyTxt As TextBox
    Friend WithEvents relationshipTxt As TextBox
    Friend WithEvents emergencyContactTxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents physicianNameTxt As TextBox
    Friend WithEvents contactPhysicianTxt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents reasonAppointmentTxt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents createContactBtn As Button
    Friend WithEvents contactDeleteBtn As Button
    Friend WithEvents contactClearBtn As Button
    Friend WithEvents contactUpdateBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
