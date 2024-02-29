<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.logInBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.rememberMeChk = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logInBtn
        '
        Me.logInBtn.ForeColor = System.Drawing.Color.Black
        Me.logInBtn.Location = New System.Drawing.Point(834, 629)
        Me.logInBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.logInBtn.Name = "logInBtn"
        Me.logInBtn.Size = New System.Drawing.Size(144, 54)
        Me.logInBtn.TabIndex = 2
        Me.logInBtn.Text = "Login"
        Me.logInBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 767)
        Me.Panel1.TabIndex = 7
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
        Me.Label3.Size = New System.Drawing.Size(437, 83)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Flexibility"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MaternityClinicApp.My.Resources.Resources.pregnancy
        Me.PictureBox1.Location = New System.Drawing.Point(161, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 296)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 36.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(868, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 69)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lifeline"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(780, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(418, 49)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Welcome to Lifeline"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(808, 338)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 21)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Username"
        '
        'usernameTxt
        '
        Me.usernameTxt.Location = New System.Drawing.Point(812, 362)
        Me.usernameTxt.Multiline = True
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.Size = New System.Drawing.Size(376, 57)
        Me.usernameTxt.TabIndex = 10
        '
        'passwordTxt
        '
        Me.passwordTxt.Location = New System.Drawing.Point(812, 463)
        Me.passwordTxt.Multiline = True
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.Size = New System.Drawing.Size(376, 57)
        Me.passwordTxt.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(808, 440)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 20)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Password"
        '
        'registerBtn
        '
        Me.registerBtn.ForeColor = System.Drawing.Color.Black
        Me.registerBtn.Location = New System.Drawing.Point(1022, 629)
        Me.registerBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(144, 54)
        Me.registerBtn.TabIndex = 13
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = True
        '
        'rememberMeChk
        '
        Me.rememberMeChk.AutoSize = True
        Me.rememberMeChk.Location = New System.Drawing.Point(810, 545)
        Me.rememberMeChk.Margin = New System.Windows.Forms.Padding(4)
        Me.rememberMeChk.Name = "rememberMeChk"
        Me.rememberMeChk.Size = New System.Drawing.Size(122, 21)
        Me.rememberMeChk.TabIndex = 0
        Me.rememberMeChk.Text = "Remember me"
        Me.rememberMeChk.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1265, 754)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.usernameTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.logInBtn)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.rememberMeChk)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMP Clinic"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logInBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents registerBtn As Button
    Friend WithEvents rememberMeChk As CheckBox
End Class
