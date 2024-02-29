<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.aboutUsBtn = New System.Windows.Forms.Button()
        Me.appointmentsBtn = New System.Windows.Forms.Button()
        Me.medicalRecordsBtn = New System.Windows.Forms.Button()
        Me.dashboardBtn = New System.Windows.Forms.Button()
        Me.pagePnl = New System.Windows.Forms.Panel()
        Me.contactInfoBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.contactInfoBtn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.aboutUsBtn)
        Me.Panel1.Controls.Add(Me.appointmentsBtn)
        Me.Panel1.Controls.Add(Me.medicalRecordsBtn)
        Me.Panel1.Controls.Add(Me.dashboardBtn)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 751)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(99, 356)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 69)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Consultation"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MaternityClinicApp.My.Resources.Resources.file_user
        Me.PictureBox3.Location = New System.Drawing.Point(12, 621)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MaternityClinicApp.My.Resources.Resources.booking
        Me.PictureBox4.Location = New System.Drawing.Point(12, 267)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MaternityClinicApp.My.Resources.Resources.dollar__1_
        Me.PictureBox2.Location = New System.Drawing.Point(12, 442)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MaternityClinicApp.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(12, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 69)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.Red
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.Location = New System.Drawing.Point(99, 700)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(102, 39)
        Me.logoutBtn.TabIndex = 10
        Me.logoutBtn.Text = "Sign Out"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MaternityClinicApp.My.Resources.Resources.girl
        Me.PictureBox5.Location = New System.Drawing.Point(110, 23)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'aboutUsBtn
        '
        Me.aboutUsBtn.BackColor = System.Drawing.Color.SpringGreen
        Me.aboutUsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.aboutUsBtn.Location = New System.Drawing.Point(99, 621)
        Me.aboutUsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.aboutUsBtn.Name = "aboutUsBtn"
        Me.aboutUsBtn.Size = New System.Drawing.Size(203, 69)
        Me.aboutUsBtn.TabIndex = 9
        Me.aboutUsBtn.Text = "About Us"
        Me.aboutUsBtn.UseVisualStyleBackColor = False
        '
        'appointmentsBtn
        '
        Me.appointmentsBtn.BackColor = System.Drawing.Color.SpringGreen
        Me.appointmentsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.appointmentsBtn.Location = New System.Drawing.Point(99, 267)
        Me.appointmentsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.appointmentsBtn.Name = "appointmentsBtn"
        Me.appointmentsBtn.Size = New System.Drawing.Size(203, 69)
        Me.appointmentsBtn.TabIndex = 7
        Me.appointmentsBtn.Text = "Appointments"
        Me.appointmentsBtn.UseVisualStyleBackColor = False
        '
        'medicalRecordsBtn
        '
        Me.medicalRecordsBtn.BackColor = System.Drawing.Color.SpringGreen
        Me.medicalRecordsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.medicalRecordsBtn.Location = New System.Drawing.Point(99, 442)
        Me.medicalRecordsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.medicalRecordsBtn.Name = "medicalRecordsBtn"
        Me.medicalRecordsBtn.Size = New System.Drawing.Size(203, 69)
        Me.medicalRecordsBtn.TabIndex = 5
        Me.medicalRecordsBtn.Text = "Billing"
        Me.medicalRecordsBtn.UseVisualStyleBackColor = False
        '
        'dashboardBtn
        '
        Me.dashboardBtn.BackColor = System.Drawing.Color.SpringGreen
        Me.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBtn.Location = New System.Drawing.Point(99, 168)
        Me.dashboardBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(203, 69)
        Me.dashboardBtn.TabIndex = 0
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.UseVisualStyleBackColor = False
        '
        'pagePnl
        '
        Me.pagePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pagePnl.Location = New System.Drawing.Point(317, 0)
        Me.pagePnl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pagePnl.Name = "pagePnl"
        Me.pagePnl.Size = New System.Drawing.Size(948, 751)
        Me.pagePnl.TabIndex = 1
        '
        'contactInfoBtn
        '
        Me.contactInfoBtn.BackColor = System.Drawing.Color.SpringGreen
        Me.contactInfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.contactInfoBtn.Location = New System.Drawing.Point(99, 528)
        Me.contactInfoBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contactInfoBtn.Name = "contactInfoBtn"
        Me.contactInfoBtn.Size = New System.Drawing.Size(203, 69)
        Me.contactInfoBtn.TabIndex = 16
        Me.contactInfoBtn.Text = "Contact Info"
        Me.contactInfoBtn.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 751)
        Me.Controls.Add(Me.pagePnl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents aboutUsBtn As Button
    Friend WithEvents appointmentsBtn As Button
    Friend WithEvents medicalRecordsBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pagePnl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoutBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents contactInfoBtn As Button
End Class
