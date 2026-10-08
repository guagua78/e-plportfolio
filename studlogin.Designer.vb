<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studlogin
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
        Me.pnlRoleToggle = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chckShowPass = New System.Windows.Forms.CheckBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReviewerRole = New System.Windows.Forms.Button()
        Me.btnStudentRole = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnlRoleToggle
        '
        Me.pnlRoleToggle.Location = New System.Drawing.Point(554, 68)
        Me.pnlRoleToggle.Name = "pnlRoleToggle"
        Me.pnlRoleToggle.Size = New System.Drawing.Size(737, 180)
        Me.pnlRoleToggle.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(106, 449)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(181, 60)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Sign In to Student Portal"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'chckShowPass
        '
        Me.chckShowPass.AutoSize = True
        Me.chckShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckShowPass.Location = New System.Drawing.Point(363, 401)
        Me.chckShowPass.Name = "chckShowPass"
        Me.chckShowPass.Size = New System.Drawing.Size(55, 29)
        Me.chckShowPass.TabIndex = 8
        Me.chckShowPass.Text = "👁"
        Me.chckShowPass.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Location = New System.Drawing.Point(91, 407)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(266, 22)
        Me.txtPass.TabIndex = 7
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(88, 370)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(67, 16)
        Me.Password.TabIndex = 6
        Me.Password.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(91, 328)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 22)
        Me.txtEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student No. / Pasig Edu ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(840, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Access Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ⓘ Sign in to access your research submissions..."
        '
        'btnReviewerRole
        '
        Me.btnReviewerRole.Location = New System.Drawing.Point(1017, 370)
        Me.btnReviewerRole.Name = "btnReviewerRole"
        Me.btnReviewerRole.Size = New System.Drawing.Size(153, 85)
        Me.btnReviewerRole.TabIndex = 1
        Me.btnReviewerRole.Text = "Reviewer"
        Me.btnReviewerRole.UseVisualStyleBackColor = True
        '
        'btnStudentRole
        '
        Me.btnStudentRole.Location = New System.Drawing.Point(840, 370)
        Me.btnStudentRole.Name = "btnStudentRole"
        Me.btnStudentRole.Size = New System.Drawing.Size(153, 85)
        Me.btnStudentRole.TabIndex = 0
        Me.btnStudentRole.Text = "Student Login"
        Me.btnStudentRole.UseVisualStyleBackColor = True
        '
        'studlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1783, 908)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnReviewerRole)
        Me.Controls.Add(Me.btnStudentRole)
        Me.Controls.Add(Me.pnlRoleToggle)
        Me.Controls.Add(Me.chckShowPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "studlogin"
        Me.Text = "studlogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRoleToggle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReviewerRole As Button
    Friend WithEvents btnStudentRole As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chckShowPass As CheckBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents txtEmail As TextBox
End Class
