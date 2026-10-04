<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblPlportfolio = New System.Windows.Forms.Label()
        Me.pnlRegisterCard = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.chckShowConfirmPass = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chckShowPass = New System.Windows.Forms.CheckBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlRegisterCard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblPlportfolio)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1893, 107)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(108, 68)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(135, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Student E-Portfolio"
        '
        'lblPlportfolio
        '
        Me.lblPlportfolio.AutoSize = True
        Me.lblPlportfolio.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlportfolio.ForeColor = System.Drawing.Color.White
        Me.lblPlportfolio.Location = New System.Drawing.Point(105, 19)
        Me.lblPlportfolio.Name = "lblPlportfolio"
        Me.lblPlportfolio.Size = New System.Drawing.Size(199, 38)
        Me.lblPlportfolio.TabIndex = 0
        Me.lblPlportfolio.Text = "PLPORTFOLIO"
        '
        'pnlRegisterCard
        '
        Me.pnlRegisterCard.BackColor = System.Drawing.Color.White
        Me.pnlRegisterCard.Controls.Add(Me.PictureBox3)
        Me.pnlRegisterCard.Controls.Add(Me.PictureBox2)
        Me.pnlRegisterCard.Controls.Add(Me.Label11)
        Me.pnlRegisterCard.Controls.Add(Me.cmbYearLevel)
        Me.pnlRegisterCard.Controls.Add(Me.chckShowConfirmPass)
        Me.pnlRegisterCard.Controls.Add(Me.Label10)
        Me.pnlRegisterCard.Controls.Add(Me.chckShowPass)
        Me.pnlRegisterCard.Controls.Add(Me.btnRegister)
        Me.pnlRegisterCard.Controls.Add(Me.cmbProgram)
        Me.pnlRegisterCard.Controls.Add(Me.Label9)
        Me.pnlRegisterCard.Controls.Add(Me.Label8)
        Me.pnlRegisterCard.Controls.Add(Me.Label7)
        Me.pnlRegisterCard.Controls.Add(Me.Label6)
        Me.pnlRegisterCard.Controls.Add(Me.Label5)
        Me.pnlRegisterCard.Controls.Add(Me.Label4)
        Me.pnlRegisterCard.Controls.Add(Me.Label3)
        Me.pnlRegisterCard.Controls.Add(Me.Label2)
        Me.pnlRegisterCard.Controls.Add(Me.Label1)
        Me.pnlRegisterCard.Controls.Add(Me.txtConfirmPassword)
        Me.pnlRegisterCard.Controls.Add(Me.txtPassword)
        Me.pnlRegisterCard.Controls.Add(Me.txtEmail)
        Me.pnlRegisterCard.Controls.Add(Me.txtLastName)
        Me.pnlRegisterCard.Controls.Add(Me.txtFirstName)
        Me.pnlRegisterCard.Controls.Add(Me.txtStudentNum)
        Me.pnlRegisterCard.ForeColor = System.Drawing.Color.DarkGreen
        Me.pnlRegisterCard.Location = New System.Drawing.Point(727, 182)
        Me.pnlRegisterCard.Name = "pnlRegisterCard"
        Me.pnlRegisterCard.Size = New System.Drawing.Size(984, 769)
        Me.pnlRegisterCard.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(365, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "e.g., 25-00123"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Location = New System.Drawing.Point(483, 376)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(406, 36)
        Me.cmbYearLevel.TabIndex = 22
        '
        'chckShowConfirmPass
        '
        Me.chckShowConfirmPass.AutoSize = True
        Me.chckShowConfirmPass.ForeColor = System.Drawing.Color.DimGray
        Me.chckShowConfirmPass.Location = New System.Drawing.Point(834, 476)
        Me.chckShowConfirmPass.Name = "chckShowConfirmPass"
        Me.chckShowConfirmPass.Size = New System.Drawing.Size(62, 20)
        Me.chckShowConfirmPass.TabIndex = 20
        Me.chckShowConfirmPass.Text = "Show"
        Me.chckShowConfirmPass.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(479, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "YEAR LEVEL"
        '
        'chckShowPass
        '
        Me.chckShowPass.AutoSize = True
        Me.chckShowPass.ForeColor = System.Drawing.Color.DimGray
        Me.chckShowPass.Location = New System.Drawing.Point(395, 474)
        Me.chckShowPass.Name = "chckShowPass"
        Me.chckShowPass.Size = New System.Drawing.Size(62, 20)
        Me.chckShowPass.TabIndex = 19
        Me.chckShowPass.Text = "Show"
        Me.chckShowPass.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(51, 612)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(845, 51)
        Me.btnRegister.TabIndex = 18
        Me.btnRegister.Text = "Register Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'cmbProgram
        '
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Location = New System.Drawing.Point(60, 376)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(395, 36)
        Me.cmbProgram.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(478, 469)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "CONFIRM PASSWORD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(479, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "EMAIL ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DEGREE PROGRAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(478, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(57, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(58, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "STUDENT NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(620, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sign up to start building your academic e-portfolio with your student profile."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(63, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Create Your Account"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(482, 499)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(406, 34)
        Me.txtConfirmPassword.TabIndex = 6
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(57, 499)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(398, 34)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(482, 187)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(406, 34)
        Me.txtEmail.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(482, 296)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(407, 34)
        Me.txtLastName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(60, 296)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(395, 34)
        Me.txtFirstName.TabIndex = 1
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.Color.White
        Me.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(61, 187)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(394, 34)
        Me.txtStudentNum.TabIndex = 0
        '
        'pnlContainer
        '
        Me.pnlContainer.Location = New System.Drawing.Point(727, 182)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1000, 733)
        Me.pnlContainer.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SeaGreen
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(394, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(335, 244)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Build your verified digital academic footprint."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SeaGreen
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(396, 661)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(333, 290)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "PLPORTFOLIO empowers Pasigueño scholars to catalog capstone works, verify curricu" &
    "lar competencies, and showcase achievements to institutional partners."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(396, 182)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 712)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(408, 193)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(841, 193)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1893, 1075)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pnlRegisterCard)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.MaximizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-PLPortfolio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlRegisterCard.ResumeLayout(False)
        Me.pnlRegisterCard.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPlportfolio As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlRegisterCard As Panel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents chckShowConfirmPass As CheckBox
    Friend WithEvents chckShowPass As CheckBox
    Friend WithEvents cmbYearLevel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
