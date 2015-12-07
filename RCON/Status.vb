Imports MySql.Data.MySqlClient
Public Class Status
    Dim MySqlConn As MySqlConnection
    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        ConnStatus.Text = "Checking Connection..."
        ConnStatus.TextAlign = HorizontalAlignment.Center
        If My.Computer.Network.Ping("") Then 'Server IP
            ConnStatus.Text = "Server is Online!"
            ConnStatus.BackColor = ColorTranslator.FromHtml("#CCFFCC")
            Me.BackColor = ColorTranslator.FromHtml("#CCFFCC")
        Else
            ConnStatus.Text = "Server is Offline :("
            ConnStatus.BackColor = ColorTranslator.FromHtml("#FF6666")
            Me.BackColor = ColorTranslator.FromHtml("#FF6666")
        End If
    End Sub
End Class