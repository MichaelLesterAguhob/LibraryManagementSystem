Imports MySql.Data.MySqlClient


Module connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter


    Private ReadOnly server As String = "localhost"
    Private ReadOnly username As String = "root"
    Private ReadOnly password As String = ""
    Private ReadOnly database As String = "libraryManagementSystem"

    Public Sub ConOpen()

        If con.State = System.Data.ConnectionState.Open Then con.Close()

        Try
            con.ConnectionString = "server=" & server & ";user=" & username & ";password=" & password & ";database=" & database
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Environment.NewLine & "Please open XAMPP and start the APACHE AND MYSQL", "Connection Problem Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



End Module
