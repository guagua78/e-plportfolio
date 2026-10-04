Imports MySql.Data.MySqlClient

Module dbmodule
    ' Define connection parameters
    Private Const Server As String = "localhost"
    Private Const Database As String = "plportfoliodb"
    Private Const UserID As String = "root"
    Private Const Password As String = ""
    Private Const Port As String = "3306"

    ' Connection String
    Private ConnectionString As String = $"Server={Server};Port={Port};Database={Database};Uid={UserID};Pwd={Password};"

    ' Function to get an open connection
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(ConnectionString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Database Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Module
