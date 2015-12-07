Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.IO

Public Class PGC_RCON_LOGIN
    Dim MySqlConn As MySqlConnection 'MySqlConn as new connection to SQL DB
    Dim COMMAND As MySqlCommand 'This class gives the ability to query the DB
    Private client As tcp_client
    Private passmd5 As String

    ' MD5 Encryption Function
    Public Function Md5FromString(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If
        Bytes = Encoding.Default.GetBytes(Source)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString()
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MinimizeBox = False
        Me.MaximizeBox = False

        'Temporary Update Show

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "" 'Default Port is 3306 so make sure to add the port= whatever the port is. Also 'SSL MODE=required;'
        'No spaces allowed in the connection string otherwise there are errors

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim READER As MySqlDataReader


        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "select * from arma5life.phantom_tools where username='" & Username.Text & "' and password='" & Password.Text & "' "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            New_Form.AdminName.Text = Username.Text
            While READER.Read
                count = count + 1

                If READER.GetString("mediclevel") = 1 Then
                    Compensation.MedicLevelComboBox.Enabled = True ' Allow Medics to Whitelist

                ElseIf READER.GetString("coplevel") = 1 Then
                    Compensation.CopLevelComboBox.Enabled = True ' Allow Chief of Police to Whitelist

                End If
            End While

            If (count = 1) Then
                MainPage.Show()
                If (MainPage.Visible) Then
                    Me.Close()
                End If
            ElseIf (Username.Text = "") Then
                MessageBox.Show("Please Enter a Username!")
            ElseIf (Password.Text = "") Then
                MessageBox.Show("Please Enter a Password!")
            ElseIf (count > 1) Then
                MessageBox.Show("Username And Password are Duplicate!") 'In database there are more then 1 username and databases with same info
            Else
                MessageBox.Show("Username And Password are Incorrect!")
            End If

            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("", vbQuestion)
    End Sub

End Class
