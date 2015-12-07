Imports MySql.Data.MySqlClient

Public Class MainPage
    Dim MySqlConn As MySqlConnection 'MySqlConn as new connection to SQL DB
    Dim COMMAND As MySqlCommand 'This class gives the ability to query the DB
    Dim READER As MySqlDataReader
    Dim rn As New Random
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource
    Dim SDA As New MySqlDataAdapter
    Dim ConnInfo As String = ""


    Public Structure players

        Public id As Integer
        Public ip As String
        Public ping As Integer
        Public guid As String
        Public name As String

    End Structure


    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Future design version make buttons + form design with rounded corners for nicer design look. Also add Splash screen (possibly with animation?)
        ' Lastly add difrent color skins instead of plain white (FormBorderControl)
        Me.MaximizeBox = False ' Turns off Maximize Box

        ' Player Tab Player Information
        pInfoTextBoxInfo.ReadOnly = True
        pIDTextBoxInfo.ReadOnly = True
        pGUIDTextBoxInfo.ReadOnly = True

        ' MySqlConnection String
        ' Every function that trys to connect to the db to create a new query needs to have its own connection string
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is

    End Sub
    Private Sub MainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Punishment.Close()
        Compensation.Close()
        Status.Close()
        Logs.Close()
        New_Form.Close()
    End Sub
    'FUNCTIONS:
    Private Sub adminLvl()
        If aLvlComboBox.Text = "0 - Non-Admin" Then
            New_Form.aLvlTextBox.Text = "0"
        ElseIf aLvlComboBox.Text = "1 - Altis Admin" Then
            New_Form.aLvlTextBox.Text = "1"
        ElseIf aLvlComboBox.Text = "2 - Altis Head-Admin" Then
            New_Form.aLvlTextBox.Text = "2"
        ElseIf aLvlComboBox.Text = "3 - Developer" Then
            New_Form.aLvlTextBox.Text = "3"
        End If
    End Sub

    Private Sub donatorLvl()
        If dLvlComboBox.Text = "0 - Non-Donator" Then
            New_Form.dLvlTextBox.Text = "0"
        ElseIf dLvlComboBox.Text = "1 - Tier 1" Then
            New_Form.dLvlTextBox.Text = "1"
        ElseIf dLvlComboBox.Text = "2 - Tier 2" Then
            New_Form.dLvlTextBox.Text = "2"
        ElseIf dLvlComboBox.Text = "3 - Tier 3" Then
            New_Form.dLvlTextBox.Text = "3"
        ElseIf dLvlComboBox.Text = "4 - Tier 4" Then
            New_Form.dLvlTextBox.Text = "4"
        ElseIf dLvlComboBox.Text = "5 - Tier 5" Then
            New_Form.dLvlTextBox.Text = "5"
        ElseIf dLvlComboBox.Text = "6 - Tier 6" Then
            New_Form.dLvlTextBox.Text = "6"
        ElseIf dLvlComboBox.Text = "7 - Tier 7" Then
            New_Form.dLvlTextBox.Text = "7"
        ElseIf dLvlComboBox.Text = "8 - Tier 8" Then
            New_Form.dLvlTextBox.Text = "8"
        End If
    End Sub

    Private Sub medicLvl()
        If mLvlComboBox.Text = "0 - Not Whitelisted" Then
            New_Form.mLvlTextBox.Text = "0"
        ElseIf mLvlComboBox.Text = "1 - EMT" Then
            New_Form.mLvlTextBox.Text = "1"
        ElseIf mLvlComboBox.Text = "2 - Paramedic" Then
            New_Form.mLvlTextBox.Text = "2"
        ElseIf mLvlComboBox.Text = "3 - Critical Care Responder" Then
            New_Form.mLvlTextBox.Text = "3"
        ElseIf mLvlComboBox.Text = "4 - Medical Logistics Officer" Then
            New_Form.mLvlTextBox.Text = "4"
        ElseIf mLvlComboBox.Text = "5 - Corpsman" Then
            New_Form.mLvlTextBox.Text = "5"
        ElseIf mLvlComboBox.Text = "BlackListed" Then
            New_Form.blacklistMedicTextBox.Text = "1" ' 0 For not black listed, 1 for black listed, cop and medic black list share the same blacklist
            New_Form.mLvlTextBox.Text = "0" ' Sets the Medic Level back to 0

        End If
    End Sub

    Private Sub copLvl()
        If cLvlComboBox.Text = "0 - Not Whitelisted" Then
            New_Form.cLvlTextBox.Text = "0"
        ElseIf cLvlComboBox.Text = "1 - Cadet" Then
            New_Form.cLvlTextBox.Text = "1"
        ElseIf cLvlComboBox.Text = "2 - Patrol Officer" Then
            New_Form.cLvlTextBox.Text = "2"
        ElseIf cLvlComboBox.Text = "3 - Sergeant" Then
            New_Form.cLvlTextBox.Text = "3"
        ElseIf cLvlComboBox.Text = "4 - Staff Sergeant" Then
            New_Form.cLvlTextBox.Text = "4"
        ElseIf cLvlComboBox.Text = "5 - Lieutenant" Then
            New_Form.cLvlTextBox.Text = "5"
        ElseIf cLvlComboBox.Text = "6 - Captain" Then
            New_Form.cLvlTextBox.Text = "6"
        ElseIf cLvlComboBox.Text = "7 - Deputy Chief" Then
            New_Form.cLvlTextBox.Text = "7"
        ElseIf cLvlComboBox.Text = "BlackListed" Then
            New_Form.blacklistCopTextBox.Text = "1" ' 0 For not black listed, 1 for black listed, cop and medic black list share the same blacklist
            New_Form.cLvlTextBox.Text = "0" ' Sets the Cop Level back to 0
        End If
    End Sub
    Private Sub loadVehicleTable() 'Load table function for Vehicle garage list based on the ID, PID, Classname Colums
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT id, pid, classname FROM arma5life.vehicles"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            VehicleCompTable.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub

    Private Sub saveComplog() ' Save Comp Log Function for saving which admin has done what
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
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
    Private Sub SearchpID() ' Search by pID Function
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM arma5life.players WHERE playerid='" & pSearchIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                pInfoTextBoxInfo.Text = READER.GetString("name")
                pIDTextBoxInfo.Text = READER.GetString("playerid")
                pGUIDTextBoxInfo.Text = READER.GetString("guid")
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub SearchGUID() ' Search by GUID Function
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = ConnInfo 'Default Port is 3306 so make sure to add the port= whatever the port is
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM arma5life.players WHERE guid='" & pSearchGUIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                pInfoTextBoxInfo.Text = READER.GetString("name")
                pIDTextBoxInfo.Text = READER.GetString("playerid")
                pGUIDTextBoxInfo.Text = READER.GetString("guid")
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
    ' PLAYERS TAB PAGE STUFF:
    Private Sub pSearchIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles pSearchIDTextBox.TextChanged
        ' Player Compensation - pID Search
        ' Bug: If user goes to give player comp when you are saving information will reset the users cop/medic/admin/donator level!!!
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "select * FROM arma5life.players where playerid='" & pSearchIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            'SearchpID()
            While READER.Read
                pInfoTextBoxInfo.Text = READER.GetString("name")
                pIDTextBoxInfo.Text = READER.GetString("playerid")
                pGUIDTextBoxInfo.Text = READER.GetString("guid")
                cashTextBox.Text = READER.GetString("cash")
                New_Form.pastCashAmt.Text = READER.GetString("cash") 'Calculation form for comp
                bankTextBox.Text = READER.GetString("bankacc")
                New_Form.PastBankAmt.Text = READER.GetString("bankacc") 'Calculation form for comp
                mLvlComboBox.Text = READER.GetString("mediclevel")
                cLvlComboBox.Text = READER.GetString("coplevel")
                dLvlComboBox.Text = READER.GetString("donatorlvl")
                aLvlComboBox.Text = READER.GetString("adminlevel")
            End While

            New_Form.pName.Text = pInfoTextBoxInfo.Text ' Add the playername to the log
            'loadCompTable()
            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection
        End Try
    End Sub
    Private Sub pSearchGUIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles pSearchGUIDTextBox.TextChanged
        'Player Compensation - GUID Search
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "SELECT * from arma5life.players where guid='" & pSearchGUIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            'SearchGUID()

            While READER.Read
                pInfoTextBoxInfo.Text = READER.GetString("name")
                pIDTextBoxInfo.Text = READER.GetString("playerid")
                pGUIDTextBoxInfo.Text = READER.GetString("guid")
                cashTextBox.Text = READER.GetString("cash")
                New_Form.pastCashAmt.Text = READER.GetString("cash") 'Calculation form for comp
                bankTextBox.Text = READER.GetString("bankacc")
                New_Form.PastBankAmt.Text = READER.GetString("bankacc") 'Calculation form for comp
                mLvlComboBox.Text = READER.GetString("mediclevel")
                cLvlComboBox.Text = READER.GetString("coplevel")
                dLvlComboBox.Text = READER.GetString("donatorlvl")
                aLvlComboBox.Text = READER.GetString("adminlevel")
            End While

            New_Form.pName.Text = pInfoTextBoxInfo.Text ' Add the playername to the log
            'loadCompTable()
            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection
        End Try
    End Sub
    Private Sub saveInfoTextBox_Click(sender As Object, e As EventArgs) Handles saveInfoTextBox.Click
        Try 'If there is some sort of error trying to connect to the database, the try catch will catch it and display error message

            MySqlConn.Open() 'Attemps to open a connection
            Dim Query As String
            Query = "update arma5life.players set cash='" & cashTextBox.Text & "',bankacc='" & bankTextBox.Text & "',mediclevel='" & New_Form.mLvlTextBox.Text & "',coplevel='" & New_Form.cLvlTextBox.Text & "',donatorlvl='" & New_Form.dLvlTextBox.Text & "',adminlevel='" & New_Form.aLvlTextBox.Text & "' where playerid='" & pIDTextBoxInfo.Text & "'" ' ; INSERT INTO arma5life.complog (CompensationAmount, RecievingPlayer) VALUES ('" & BankAccountTextBox.Text & "', '" & PlayerIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            New_Form.newCashAmt.Text = cashTextBox.Text
            New_Form.NewBankAmt.Text = bankTextBox.Text

            New_Form.CashTotal.Text = Convert.ToInt32(New_Form.newCashAmt.Text) - Convert.ToInt32(New_Form.pastCashAmt.Text)
            New_Form.BankTotal.Text = Convert.ToInt32(New_Form.NewBankAmt.Text) - Convert.ToInt32(New_Form.PastBankAmt.Text)

            New_Form.CompAmount.Text = Convert.ToInt32(New_Form.CashTotal.Text) + Convert.ToInt32(New_Form.BankTotal.Text)

            MessageBox.Show("Player Information Saved!")

            saveComplog()
            MySqlConn.Close() 'Attempts to close connection

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose() 'Dispose of the connection

        End Try
    End Sub

    ' PLAYER WOMBO COMBO BOX STUFF: 
    Private Sub cLvlComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLvlComboBox.SelectedIndexChanged
        copLvl()
    End Sub

    Private Sub mLvlComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mLvlComboBox.SelectedIndexChanged
        medicLvl()
    End Sub

    Private Sub dLvlComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dLvlComboBox.SelectedIndexChanged
        donatorLvl()
    End Sub

    Private Sub aLvlComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles aLvlComboBox.SelectedIndexChanged
        adminLvl()
    End Sub
    Private Sub addVehicleButton_Click(sender As Object, e As EventArgs) Handles addVehicleButton.Click
        ' Add a value to the database (Database adds a new row everytime a user purchases a vehicle)
        ' Remove text from text boxes when vehicle has been added and when add button pressed
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "insert into arma5life.vehicles (side, classname, type, plate, pid) values ('" & New_Form.vSideTextBox.Text & "', '" & New_Form.vClassNameTextBox.Text & "', '" & New_Form.vTypeTextBox.Text & "', '" & New_Form.vPlateNumTextBox.Text & "', '" & pIDTextBoxInfo.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Vehicle Added!")
            VehicleCompTable.Refresh()
            MySqlConn.Close()

        Catch ex As Exception

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
    Private Sub removeVehicleButton_Click(sender As Object, e As EventArgs) Handles removeVehicleButton.Click
        ' Remove a Value from the database (Database adds a new row everytime a user purchases a vehicle)
        ' Deletes based on the Vehicles ID
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM arma5life.vehicles WHERE id='" & New_Form.vIDTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Vehicle Removed!")
            MySqlConn.Close()

        Catch ex As Exception

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
    ' VEHICLE TABLE GETS LOADED INTO NEW_FORM.VIDTEXTBOX
    ' CONSIDER USING LIST VIEW FOR VEHICLE GARAGE INSTEAD OF DATAGRIDVIEW
    Private Sub VehicleCompTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VehicleCompTable.CellContentClick
        If e.RowIndex > 0 Then
            Dim Row As DataGridViewRow
            Row = Me.VehicleCompTable.Rows(e.RowIndex)
            New_Form.vIDTextBox.Text = Row.Cells("id").Value.ToString ' vIDTextBox.text gets the Row pID
        End If
    End Sub
    ' VEHICLE SELECTION OPTIONS:
    Private Sub vWheeledVehiclesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vWheeledVehiclesComboBox.SelectedIndexChanged
        ' CIVLIAN VEHICLES
        If vWheeledVehiclesComboBox.Text = "Ifrit Unarmed" Then
            New_Form.vClassNameTextBox.Text = "O_MRAP_02_F" ' Classname
            New_Form.vSideTextBox.Text = "Civ" ' Side
            New_Form.vTypeTextBox.Text = "Car" ' Type
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999)) ' Plate - Random number generator between 100,000 and 999,999 for plate number

        ElseIf vWheeledVehiclesComboBox.Text = "Strider Unarmed" Then
            New_Form.vClassNameTextBox.Text = "I_MRAP_03_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Hunter Unarmed" Then
            New_Form.vClassNameTextBox.Text = "B_MRAP_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "SUV" Then
            New_Form.vClassNameTextBox.Text = "C_SUV_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Tempest Covered" Then
            New_Form.vClassNameTextBox.Text = "O_Truck_03_covered_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Tempest Device" Then
            New_Form.vClassNameTextBox.Text = "O_Truck_03_device_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Offroad" Then
            New_Form.vClassNameTextBox.Text = "C_Offroad_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Zamak" Then
            New_Form.vClassNameTextBox.Text = "O_Truck_transport_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Quadbike" Then
            New_Form.vClassNameTextBox.Text = "B_Quadbike_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

            ' POLICE VEHICLES 
        ElseIf vWheeledVehiclesComboBox.Text = "Quadbike (Cop)" Then
            New_Form.vClassNameTextBox.Text = "C_Quadbike_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Hatchback Sport (Cop)" Then
            New_Form.vClassNameTextBox.Text = "C_Hatchback_01_sport_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "SUV (Cop)" Then
            New_Form.vClassNameTextBox.Text = "C_SUV_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Offroad (Cop)" Then
            New_Form.vClassNameTextBox.Text = "C_Offroad_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Hunter (Cop)" Then
            New_Form.vClassNameTextBox.Text = "B_MRAP_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

            ' MEDICAL VEHICLES
        ElseIf vWheeledVehiclesComboBox.Text = "Offroad (Medical)" Then
            New_Form.vClassNameTextBox.Text = "C_Offroad_01_F"
            New_Form.vSideTextBox.Text = "Med"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "SUV (Medical)" Then
            New_Form.vClassNameTextBox.Text = "C_SUV_01_F"
            New_Form.vSideTextBox.Text = "Med"
            New_Form.vTypeTextBox.Text = "Car"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))
        End If
    End Sub

    Private Sub vAircraftComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vAircraftComboBox.SelectedIndexChanged
        'CIVILIAN AIRCRAFT
        If vWheeledVehiclesComboBox.Text = "CH-49 Mohawk" Then
            New_Form.vClassNameTextBox.Text = "I_Heli_Transport_02_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "MH-9 Hummingbird" Then
            New_Form.vClassNameTextBox.Text = "B_Heli_Light_02_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "PO-30 Orca " Then
            New_Form.vClassNameTextBox.Text = "O_Heli_Light_02_unarmed_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

            ' POLICE AIRCRAFT
        ElseIf vWheeledVehiclesComboBox.Text = "MH-9 Hummingbird (Cop)" Then
            New_Form.vClassNameTextBox.Text = "B_Heli_Light_02_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "UH-80 Ghost Hawk (Cop)" Then
            New_Form.vClassNameTextBox.Text = "B_Heli_Transport_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "WY-55 Hellcat (Cop)" Then
            New_Form.vClassNameTextBox.Text = "I_Heli_Light_03_unarmed_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

            ' MEDICAL AIRCRAFT
        ElseIf vWheeledVehiclesComboBox.Text = "PO-30 Orca (Medical)" Then
            New_Form.vClassNameTextBox.Text = "O_Heli_Light_02_unarmed_F"
            New_Form.vSideTextBox.Text = "Med"
            New_Form.vTypeTextBox.Text = "Air"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))
        End If

    End Sub

    Private Sub vWaterCraftComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vWaterCraftComboBox.SelectedIndexChanged
        'CIVILIAN WATERCRAFT
        If vWheeledVehiclesComboBox.Text = "Assult Boat" Then
            New_Form.vClassNameTextBox.Text = "B_Boat_Transport_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Motor Boat" Then
            New_Form.vClassNameTextBox.Text = "C_Boat_Civil_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Swimmer Delivery Vehivle (SDV)" Then
            New_Form.vClassNameTextBox.Text = "B_SDV_01_F"
            New_Form.vSideTextBox.Text = "Civ"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

            ' POLICE WATERCRAFT
        ElseIf vWheeledVehiclesComboBox.Text = "Motor Boat (Cop)" Then
            New_Form.vClassNameTextBox.Text = "C_Boat_Civil_01_Police_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Speed Boat HMG (Cop)" Then
            New_Form.vClassNameTextBox.Text = "O_Boat_Armed_01_HMG_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))

        ElseIf vWheeledVehiclesComboBox.Text = "Swimmer Delivery Vehicle (SDV - Cop)" Then
            New_Form.vClassNameTextBox.Text = "B_SDV_01_F"
            New_Form.vSideTextBox.Text = "Cop"
            New_Form.vTypeTextBox.Text = "Ship"
            New_Form.vPlateNumTextBox.Text = (rn.Next(100000, 999999))
        End If
    End Sub

    'MENU STIP STUFF:
    Private Sub WebsiteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Dim PGC As String = "http://phantomgamingcommunity.com/"
        Process.Start(PGC)
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("This Program was made by RussianVolk for Phantom Gaming Community -- http://PhantomGamingCommunity.com", vbQuestion)
    End Sub

    Private Sub TutorialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialsToolStripMenuItem.Click
        Dim PGCTuts As String = "http://phantomgamingcommunity.com/forums/forumdisplay.php?fid=71"
        Process.Start(PGCTuts)
    End Sub
    Private Sub TroubleshootingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click
        MsgBox("Troubleshooting information coming soon!", vbQuestion)
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Phantom Tools was Developed by RussianVolk for Phantom Gaming Community. Special Thanks to ProjectVelocity for help with vehicle list classifcations", vbQuestion)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LoadBarTicker_Tick(sender As Object, e As EventArgs) Handles LoadBarTicker.Tick
        ' Work on this later - Need to make it so that the progress bar is synced with the application load time -- Similar to Auto-Updater
        LoadBar.Increment(2)
        Label1.Text = LoadBar.Value
    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        Logs.Show()
    End Sub

    Private Sub ServerStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerStatusToolStripMenuItem.Click
        Status.Show()
    End Sub

    Private Sub ProcessingFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessingFormsToolStripMenuItem.Click
        New_Form.Show()
    End Sub

    Private Sub TestForm1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestForm1ToolStripMenuItem.Click
        MessageTest.Show()
    End Sub
End Class