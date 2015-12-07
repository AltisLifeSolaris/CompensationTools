Imports MySql.Data.MySqlClient

Public Class Compensation
    Dim MySqlConn As MySqlConnection 'MySqlConn as new connection to SQL DB
    Dim COMMAND As MySqlCommand 'This class gives the ability to query the DB
    Dim READER As MySqlDataReader
    Dim rn As New Random
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource
    Dim SDA As New MySqlDataAdapter

    Private Sub Compensation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(RCON_SELECTION.Width)

        'TextBox1.Visible = False
        'TextBox2.Visible = False

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "" 'Server=167.114.28.196;userid=PGC_Tools;password=InputPasswordHere;port=3306;database=arma5life

    End Sub

    Private Sub load_Table() 'Load table function for Vehicle garage list based on the ID, PID, Classname Colums

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "" 'Default Port is 3306 so make sure to add the port= whatever the port is


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT id, pid, classname FROM arma5life.vehicles"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub

    Private Sub load_Comp_Table() 'Load table function for Vehicle garage list based on the ID, PID, Classname Colums

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "" 'Default Port is 3306 so make sure to add the port= whatever the port is
        'Dim SDA As New MySqlDataAdapter

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM arma5life.CompLog"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub


    Private Sub save_Comp_log() ' Save Comp Log Function for saving which admin has done what
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "" 'Default Port is 3306 so make sure to add the port= whatever the port is

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO arma5life.complog (adminname, recievingplayer, CompensationAmount ) VALUES ('" & New_Form.AdminName.Text & "', '" & New_Form.pName.Text & "', '" & New_Form.CompAmount.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "update arma5life.players set cash='" & CashOnHandTextBox.Text & "',bankacc='" & BankAccountTextBox.Text & "',mediclevel='" & MedicLevelComboBox.Text & "',coplevel='" & CopLevelComboBox.Text & "',donatorlvl='" & DonatorLevelComboBox.Text & "',adminlevel='" & AdminLevelComboBox.Text & "' where playerid='" & PlayerIDTextBox.Text & "'" ' ; INSERT INTO arma5life.complog (CompensationAmount, RecievingPlayer) VALUES ('" & BankAccountTextBox.Text & "', '" & PlayerIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            New_Form.newCashAmt.Text = CashOnHandTextBox.Text
            New_Form.NewBankAmt.Text = BankAccountTextBox.Text

            New_Form.CashTotal.Text = Convert.ToInt32(New_Form.newCashAmt.Text) - Convert.ToInt32(New_Form.pastCashAmt.Text)
            New_Form.BankTotal.Text = Convert.ToInt32(New_Form.NewBankAmt.Text) - Convert.ToInt32(New_Form.PastBankAmt.Text)

            New_Form.CompAmount.Text = Convert.ToInt32(New_Form.CashTotal.Text) + Convert.ToInt32(New_Form.BankTotal.Text)

            MessageBox.Show("Player Information Saved!")

            save_Comp_log()
            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub


    Private Sub PlayerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlayerIDTextBox.TextChanged
        'Player Compensation
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "select * FROM arma5life.players where playerid='" & PlayerIDTextBox.Text & "'"
            'name
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                PlayerUserName.Text = READER.GetString("name")
                PlayerGUID.Text = READER.GetString("guid")
                CashOnHandTextBox.Text = READER.GetString("cash")
                New_Form.pastCashAmt.Text = READER.GetString("cash") 'Calculation form for comp
                BankAccountTextBox.Text = READER.GetString("bankacc")
                New_Form.PastBankAmt.Text = READER.GetString("bankacc") 'Calculation form for comp
                MedicLevelComboBox.Text = READER.GetString("mediclevel")
                CopLevelComboBox.Text = READER.GetString("coplevel")
                DonatorLevelComboBox.Text = READER.GetString("donatorlvl")
                AdminLevelComboBox.Text = READER.GetString("adminlevel")
            End While

            New_Form.pName.Text = PlayerUserName.Text ' Add the playername to the log
            load_Comp_Table()
            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection
        End Try
    End Sub

    Private Sub pIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles pIDTextBox.TextChanged
        'Vehicle Compensation PID
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            'Dim Query2 As String
            Query = "select * FROM arma5life.players where playerid='" & pIDTextBox.Text & "'"
            'Query2 = "select * FROM arma5life.vehicles"

            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            load_Table() ' Loads the Table of Vehicles into the Datagrid view
            bSource.Filter = "[pid] = '" & pIDTextBox.Text & "'"
            DataGridView1.Refresh()

            While READER.Read
                TextBox4.Text = READER.GetString("name")
                TextBox3.Text = READER.GetString("guid")
            End While

            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection
        End Try
    End Sub

    Private Sub AddVehicle_Click(sender As Object, e As EventArgs) Handles AddVehicle.Click
        ' Add a value to the database (Database adds a new row everytime a user purchases a vehicle)
        ' Remove text from text boxes when vehicle has been added and when add button pressed
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "insert into arma5life.vehicles (side, classname, type, pid, plate) values ('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & TextBox5.Text & "', '" & pIDTextBox.Text & "', '" & TextBox6.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Vehicle Added!")
            DataGridView1.Refresh()
            MySqlConn.Close()

        Catch ex As Exception

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub RemoveVehicle_Click(sender As Object, e As EventArgs) Handles RemoveVehicle.Click
        'Remove a Value from the database (Database adds a new row everytime a user purchases a vehicle)
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM arma5life.vehicles WHERE id='" & TextBox5.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Vehicle Removed!")
            MySqlConn.Close()

        Catch ex As Exception

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub VehicleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VehicleList.SelectedIndexChanged

        If VehicleList.Text = "Ifrit Unarmed" Then
            TextBox1.Text = "O_MRAP_02_F" ' Classname
            TextBox2.Text = "Civ" ' Side
            TextBox5.Text = "Car" ' Type
            TextBox6.Text = (rn.Next(100000, 999999)) ' Plate

        ElseIf VehicleList.Text = "Strider Unarmed" Then
            TextBox1.Text = "I_MRAP_03_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "HEMTT" Then
            TextBox1.Text = "B_Truck_01_covered_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "Hunter Unarmed" Then
            TextBox1.Text = "B_MRAP_01_F"
            TextBox2.Text = "Cop"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "SUV" Then
            TextBox1.Text = "C_SUV_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "Tempest" Then
            TextBox1.Text = "O_Truck_03_transport_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "Offroad" Then
            TextBox1.Text = "B_G_Offroad_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "Zamak" Then
            TextBox1.Text = "O_Truck_02_transport_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf VehicleList.Text = "Quadbike" Then
            TextBox1.Text = "C_Quadbike_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Car"
            TextBox6.Text = (rn.Next(100000, 999999))

        End If
    End Sub

    Private Sub AircraftList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AircraftList.SelectedIndexChanged
        If AircraftList.Text = "CH-49 Mohawk" Then
            TextBox1.Text = "I_Heli_Transport_02_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Air"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf AircraftList.Text = "MH-9 Hummingbird" Then
            TextBox1.Text = "B_Heli_Light_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Air"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf AircraftList.Text = "PO-30 Orca (Unarmed)" Then
            TextBox1.Text = "O_Heli_Light_02_unarmed_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Air"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf AircraftList.Text = "UH-80 Ghost Hawk" Then
            TextBox1.Text = "B_Heli_Transport_01_F"
            TextBox2.Text = "Cop"
            TextBox5.Text = "Air"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf AircraftList.Text = "WY-55 Hellcat (Unarmed)" Then
            TextBox1.Text = "I_Heli_Light_03_unarmed_F"
            TextBox2.Text = "Cop"
            TextBox5.Text = "Air"
            TextBox6.Text = (rn.Next(100000, 999999))
        End If

    End Sub

    Private Sub WaterVehicleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WaterVehicleList.SelectedIndexChanged
        If WaterVehicleList.Text = "Assault Boat" Then
            TextBox1.Text = "O_Boat_Transport_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Ship"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf WaterVehicleList.Text = "Motor Boat" Then
            TextBox1.Text = "C_Boat_Civil_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Ship"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf WaterVehicleList.Text = "Swimmer Delivery Vehicle (SDV)" Then
            TextBox1.Text = "I_SDV_01_F"
            TextBox2.Text = "Civ"
            TextBox5.Text = "Ship"
            TextBox6.Text = (rn.Next(100000, 999999))

        ElseIf WaterVehicleList.Text = "Speed Boat Minigun" Then
            TextBox1.Text = "I_Boat_Armed_01_Minigun_F"
            TextBox2.Text = "Cop"
            TextBox5.Text = "Ship"
            TextBox6.Text = (rn.Next(100000, 999999))
        End If

    End Sub

    'This code will allow vehicles to be deleted from the garage list when the row is selected
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox5.Text = row.Cells("id").Value.ToString ' TextBox5.text gets the row 'ID'
        End If
    End Sub
End Class