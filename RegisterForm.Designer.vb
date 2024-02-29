<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.user_name = New System.Windows.Forms.Label()
        Me.user_firstname = New System.Windows.Forms.Label()
        Me.user_lastname = New System.Windows.Forms.Label()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.birthDatePck = New System.Windows.Forms.DateTimePicker()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.userpass = New System.Windows.Forms.Label()
        Me.phoneNumberTxt = New System.Windows.Forms.TextBox()
        Me.user_phonenumber = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addressTxt = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 754)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(699, 761)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Georgia", 36.0!)
        Me.Label4.Location = New System.Drawing.Point(211, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(472, 94)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "and peace"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(437, 82)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Flexibility"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MaternityClinicApp.My.Resources.Resources.pregnancy
        Me.PictureBox1.Location = New System.Drawing.Point(161, 135)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 295)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.user_name.Location = New System.Drawing.Point(805, 478)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(81, 21)
        Me.user_name.TabIndex = 9
        Me.user_name.Text = "Username"
        '
        'user_firstname
        '
        Me.user_firstname.AutoSize = True
        Me.user_firstname.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.user_firstname.Location = New System.Drawing.Point(802, 29)
        Me.user_firstname.Name = "user_firstname"
        Me.user_firstname.Size = New System.Drawing.Size(52, 21)
        Me.user_firstname.TabIndex = 10
        Me.user_firstname.Text = "Name"
        '
        'user_lastname
        '
        Me.user_lastname.AutoSize = True
        Me.user_lastname.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.user_lastname.Location = New System.Drawing.Point(799, 193)
        Me.user_lastname.Name = "user_lastname"
        Me.user_lastname.Size = New System.Drawing.Size(48, 21)
        Me.user_lastname.TabIndex = 11
        Me.user_lastname.Text = "Email"
        '
        'usernameTxt
        '
        Me.usernameTxt.Location = New System.Drawing.Point(803, 501)
        Me.usernameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usernameTxt.Multiline = True
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.Size = New System.Drawing.Size(376, 42)
        Me.usernameTxt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.Label1.Location = New System.Drawing.Point(805, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date of  Birth"
        '
        'birthDatePck
        '
        Me.birthDatePck.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthDatePck.Location = New System.Drawing.Point(800, 152)
        Me.birthDatePck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.birthDatePck.Name = "birthDatePck"
        Me.birthDatePck.Size = New System.Drawing.Size(376, 22)
        Me.birthDatePck.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(800, 54)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(376, 42)
        Me.txt_name.TabIndex = 15
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(800, 217)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.emailTxt.Multiline = True
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(376, 42)
        Me.emailTxt.TabIndex = 16
        '
        'registerBtn
        '
        Me.registerBtn.Location = New System.Drawing.Point(919, 665)
        Me.registerBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(144, 54)
        Me.registerBtn.TabIndex = 17
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = True
        '
        'passwordTxt
        '
        Me.passwordTxt.Location = New System.Drawing.Point(803, 586)
        Me.passwordTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordTxt.Multiline = True
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.Size = New System.Drawing.Size(376, 42)
        Me.passwordTxt.TabIndex = 22
        '
        'userpass
        '
        Me.userpass.AutoSize = True
        Me.userpass.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.userpass.Location = New System.Drawing.Point(801, 562)
        Me.userpass.Name = "userpass"
        Me.userpass.Size = New System.Drawing.Size(77, 21)
        Me.userpass.TabIndex = 21
        Me.userpass.Text = "Password"
        '
        'phoneNumberTxt
        '
        Me.phoneNumberTxt.Location = New System.Drawing.Point(802, 313)
        Me.phoneNumberTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.phoneNumberTxt.Multiline = True
        Me.phoneNumberTxt.Name = "phoneNumberTxt"
        Me.phoneNumberTxt.Size = New System.Drawing.Size(376, 42)
        Me.phoneNumberTxt.TabIndex = 24
        '
        'user_phonenumber
        '
        Me.user_phonenumber.AutoSize = True
        Me.user_phonenumber.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.user_phonenumber.Location = New System.Drawing.Point(801, 289)
        Me.user_phonenumber.Name = "user_phonenumber"
        Me.user_phonenumber.Size = New System.Drawing.Size(116, 21)
        Me.user_phonenumber.TabIndex = 23
        Me.user_phonenumber.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!)
        Me.Label5.Location = New System.Drawing.Point(802, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Address"
        '
        'addressTxt
        '
        Me.addressTxt.Location = New System.Drawing.Point(806, 410)
        Me.addressTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addressTxt.Multiline = True
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.Size = New System.Drawing.Size(376, 42)
        Me.addressTxt.TabIndex = 27
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1265, 751)
        Me.Controls.Add(Me.addressTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.phoneNumberTxt)
        Me.Controls.Add(Me.user_phonenumber)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.userpass)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.birthDatePck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usernameTxt)
        Me.Controls.Add(Me.user_lastname)
        Me.Controls.Add(Me.user_firstname)
        Me.Controls.Add(Me.user_name)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents user_name As Label
    Friend WithEvents user_firstname As Label
    Friend WithEvents user_lastname As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents birthDatePck As DateTimePicker
    Friend WithEvents txt_name As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents userpass As Label
    Friend WithEvents phoneNumberTxt As TextBox
    Friend WithEvents user_phonenumber As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addressTxt As TextBox
End Class
