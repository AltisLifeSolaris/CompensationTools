Imports MySql.Data.MySqlClient

Public Class Logs
    Dim MySqlConn As MySqlConnection 'MySqlConn as new connection to SQL DB
    Dim COMMAND As MySqlCommand 'This class gives the ability to query the DB
    Dim READER As MySqlDataReader
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource
    Dim SDA As New MySqlDataAdapter
    Dim ConnInfo As String = ""
    'LOAD COMP TABLE DISABLED WHILE TRYING TO FIX DUPLICATION OF ELEMNTS IN TABLE

    Private Sub loadComp() 'Load table function for Vehicle garage list based on the ID, PID, Classname Colums
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        'bSource.DataSource = ' Clears Table from any previous data that may have been
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM arma5life.CompLog"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LogTable.DataSource = bSource
            SDA.Update(dbDataSet)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub
    Private Sub LoadBounty()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT wantedID, wantedName, wantedBounty FROM arma5life.wanted"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LogTable.DataSource = bSource
            SDA.Update(dbDataSet)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub
    Private Sub LoadGangs()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT id, name, owner, bank FROM arma5life.gangs"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LogTable.DataSource = bSource
            SDA.Update(dbDataSet)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub
    Private Sub LoadCompLog_Click(sender As Object, e As EventArgs) Handles LoadCompLog.Click
        loadComp()
    End Sub

    Private Sub LoadBountyTable_Click(sender As Object, e As EventArgs) Handles LoadBountyTable.Click
        LoadBounty()
    End Sub

    Private Sub LoadGangList_Click(sender As Object, e As EventArgs) Handles LoadGangList.Click
        LoadGangs()
    End Sub

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class