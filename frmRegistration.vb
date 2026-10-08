Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports System.Runtime.InteropServices

Public Class frmRegister

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Const EM_SETCUEBANNER As Integer = &H1501

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlContainer.Left = (Me.ClientSize.Width - pnlContainer.Width) \ 2
        pnlContainer.Top = (Me.ClientSize.Height - pnlContainer.Height) \ 2
        pnlStrengthBar.Visible = False
        lblPassHint.Visible = False

        cmbProgram.Items.Clear()
        cmbProgram.Items.Add("BS Computer Science")
        cmbProgram.Items.Add("BS Information Technology")
        cmbProgram.Items.Add("BS Business Administration")
        cmbProgram.Items.Add("BS Accountancy")
        cmbProgram.Items.Add("BS Nursing")
        cmbProgram.Items.Add("BS Education")
        cmbProgram.SelectedIndex = 0

        cmbYearLevel.Items.Clear()
        cmbYearLevel.Items.Add("1st Year")
        cmbYearLevel.Items.Add("2nd Year")
        cmbYearLevel.Items.Add("3rd Year")
        cmbYearLevel.Items.Add("4th Year")
        cmbYearLevel.SelectedIndex = 0

        txtPassword.MaxLength = 20
        txtConfirmPassword.MaxLength = 20

        SendMessage(txtFirstName.Handle, EM_SETCUEBANNER, 0, " e.g., Rene")
        SendMessage(txtLastName.Handle, EM_SETCUEBANNER, 0, " e.g., Baterbonia")
        SendMessage(txtEmail.Handle, EM_SETCUEBANNER, 0, " e.g., student@plpasig.edu.ph")
        SendMessage(txtConfirmPassword.Handle, EM_SETCUEBANNER, 0, " Re-enter your password")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Extract values
        Dim studentNum As String = txtStudentNum.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim program As String = cmbProgram.SelectedItem.ToString()
        Dim yearLevel As Integer = cmbYearLevel.SelectedIndex + 1
        Dim email As String = txtEmail.Text.Trim().ToLower()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' 2. Field Validation
        If String.IsNullOrWhiteSpace(studentNum) OrElse
           String.IsNullOrWhiteSpace(firstName) OrElse
           String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(password) OrElse
           String.IsNullOrWhiteSpace(confirmPassword) Then

            MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not email.EndsWith("@plpasig.edu.ph") Then
            MessageBox.Show("Please use a valid institutional email ending with @plpasig.edu.ph", "Invalid Email Domain", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please re-enter your password.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "INSERT INTO students (student_number, first_name, last_name, email, password_hash, degree_program, year_level) " &
                                          "VALUES (@student_num, @first_name, @last_name, @email, @password_hash, @degree_program, @year_level)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@student_num", studentNum)
                        cmd.Parameters.AddWithValue("@first_name", firstName)
                        cmd.Parameters.AddWithValue("@last_name", lastName)
                        cmd.Parameters.AddWithValue("@email", email)
                        cmd.Parameters.AddWithValue("@password_hash", hashedPassword)
                        cmd.Parameters.AddWithValue("@degree_program", program)
                        cmd.Parameters.AddWithValue("@year_level", yearLevel)

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearForm()
                    End Using
                End If
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("A student with this Student Number or Email address already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        txtStudentNum.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

        If cmbProgram.Items.Count > 0 Then cmbProgram.SelectedIndex = 0
        If cmbYearLevel.Items.Count > 0 Then cmbYearLevel.SelectedIndex = 0
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword Is Nothing OrElse pnlStrengthBar Is Nothing OrElse lblPassHint Is Nothing Then Return

        Dim pwd As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(pwd) Then
            pnlStrengthBar.Visible = False
            lblPassHint.Visible = False
            Return
        End If

        ' Force visibility and strict geometry
        pnlStrengthBar.Visible = True
        lblPassHint.Visible = True

        ' Lock bar height to a thin 4px line directly under txtPassword
        pnlStrengthBar.Height = 4
        pnlStrengthBar.Left = txtPassword.Left
        pnlStrengthBar.Top = txtPassword.Bottom + 4

        ' Position hint label directly below the 4px bar
        lblPassHint.Left = txtPassword.Left
        lblPassHint.Top = pnlStrengthBar.Bottom + 2

        pnlStrengthBar.BringToFront()
        lblPassHint.BringToFront()

        ' Update strength colors & indicator text
        If pwd.Length < 6 Then
            pnlStrengthBar.BackColor = Color.Crimson
            pnlStrengthBar.Width = CInt(txtPassword.Width * 0.33)
            lblPassHint.Text = "Too short (min 6 characters)"
            lblPassHint.ForeColor = Color.Crimson
        ElseIf pwd.Length >= 6 AndAlso pwd.Length <= 10 Then
            pnlStrengthBar.BackColor = Color.Orange
            pnlStrengthBar.Width = CInt(txtPassword.Width * 0.66)
            lblPassHint.Text = "Medium strength"
            lblPassHint.ForeColor = Color.DarkOrange
        Else
            pnlStrengthBar.BackColor = Color.ForestGreen
            pnlStrengthBar.Width = txtPassword.Width
            lblPassHint.Text = "Strong password"
            lblPassHint.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        If chckShowPass.Checked Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkShowConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowConfirmPass.CheckedChanged
        If chckShowConfirmPass.Checked Then
            txtConfirmPassword.UseSystemPasswordChar = False
            txtConfirmPassword.PasswordChar = ControlChars.NullChar
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New studlogin()
        loginForm.Show()
        Me.Hide()
    End Sub
End Class