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

        chckShowPass.Checked = False
        chckShowConfirmPass.Checked = False

        If cmbProgram.Items.Count > 0 Then cmbProgram.SelectedIndex = 0
        If cmbYearLevel.Items.Count > 0 Then cmbYearLevel.SelectedIndex = 0
    End Sub

    Private Sub chckShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chckShowPass.Checked
    End Sub

    Private Sub chckShowConfirmPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowConfirmPass.CheckedChanged
        txtConfirmPassword.UseSystemPasswordChar = Not chckShowConfirmPass.Checked
    End Sub

    Private Sub frmRegister_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlContainer IsNot Nothing Then
            pnlContainer.Left = (Me.ClientSize.Width - pnlContainer.Width) \ 2
            pnlContainer.Top = (Me.ClientSize.Height - pnlContainer.Height) \ 2
        End If
    End Sub



End Class