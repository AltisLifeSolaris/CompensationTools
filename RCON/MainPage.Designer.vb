<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshootingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessingFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestForm1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadBarTicker = New System.Windows.Forms.Timer(Me.components)
        Me.TimeElapsed = New System.Windows.Forms.Timer(Me.components)
        Me.removeVehicleButton = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.VehicleCompTable = New System.Windows.Forms.DataGridView()
        Me.addVehicleButton = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.vWaterCraftComboBox = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.vWheeledVehiclesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.vAircraftComboBox = New System.Windows.Forms.ComboBox()
        Me.LoadBar = New System.Windows.Forms.ProgressBar()
        Me.saveInfoTextBox = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bankTextBox = New System.Windows.Forms.TextBox()
        Me.aLvlComboBox = New System.Windows.Forms.ComboBox()
        Me.cashTextBox = New System.Windows.Forms.TextBox()
        Me.mLvlComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cLvlComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dLvlComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pGUIDTextBoxInfo = New System.Windows.Forms.TextBox()
        Me.pInfoTextBoxInfo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pIDTextBoxInfo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pSearchIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pSearchGUIDTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.VehicleCompTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.WebsiteToolStripMenuItem, Me.LogsToolStripMenuItem, Me.ServerStatusToolStripMenuItem, Me.ProcessingFormsToolStripMenuItem, Me.TestForm1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorialsToolStripMenuItem, Me.TroubleshootingToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TutorialsToolStripMenuItem
        '
        Me.TutorialsToolStripMenuItem.Name = "TutorialsToolStripMenuItem"
        Me.TutorialsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TutorialsToolStripMenuItem.Text = "Tutorials"
        '
        'TroubleshootingToolStripMenuItem
        '
        Me.TroubleshootingToolStripMenuItem.Name = "TroubleshootingToolStripMenuItem"
        Me.TroubleshootingToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TroubleshootingToolStripMenuItem.Text = "Troubleshooting"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'ServerStatusToolStripMenuItem
        '
        Me.ServerStatusToolStripMenuItem.Name = "ServerStatusToolStripMenuItem"
        Me.ServerStatusToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ServerStatusToolStripMenuItem.Text = "Server Status"
        '
        'ProcessingFormsToolStripMenuItem
        '
        Me.ProcessingFormsToolStripMenuItem.Name = "ProcessingFormsToolStripMenuItem"
        Me.ProcessingFormsToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.ProcessingFormsToolStripMenuItem.Text = "Processing Forms"
        '
        'TestForm1ToolStripMenuItem
        '
        Me.TestForm1ToolStripMenuItem.Name = "TestForm1ToolStripMenuItem"
        Me.TestForm1ToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.TestForm1ToolStripMenuItem.Text = "Test Form1"
        '
        'LoadBarTicker
        '
        '
        'removeVehicleButton
        '
        Me.removeVehicleButton.Location = New System.Drawing.Point(161, 323)
        Me.removeVehicleButton.Name = "removeVehicleButton"
        Me.removeVehicleButton.Size = New System.Drawing.Size(125, 23)
        Me.removeVehicleButton.TabIndex = 50
        Me.removeVehicleButton.Text = "Remove Vehicle"
        Me.removeVehicleButton.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.VehicleCompTable)
        Me.GroupBox7.Location = New System.Drawing.Point(295, 259)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(471, 116)
        Me.GroupBox7.TabIndex = 51
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Vehicle Garage"
        '
        'VehicleCompTable
        '
        Me.VehicleCompTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleCompTable.Location = New System.Drawing.Point(6, 19)
        Me.VehicleCompTable.Name = "VehicleCompTable"
        Me.VehicleCompTable.Size = New System.Drawing.Size(459, 91)
        Me.VehicleCompTable.TabIndex = 33
        '
        'addVehicleButton
        '
        Me.addVehicleButton.Location = New System.Drawing.Point(161, 294)
        Me.addVehicleButton.Name = "addVehicleButton"
        Me.addVehicleButton.Size = New System.Drawing.Size(125, 23)
        Me.addVehicleButton.TabIndex = 49
        Me.addVehicleButton.Text = "Add Vehicle"
        Me.addVehicleButton.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.vWaterCraftComboBox)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.vWheeledVehiclesComboBox)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.vAircraftComboBox)
        Me.GroupBox6.Location = New System.Drawing.Point(292, 137)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(471, 116)
        Me.GroupBox6.TabIndex = 53
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Vehicle Selection"
        '
        'vWaterCraftComboBox
        '
        Me.vWaterCraftComboBox.FormattingEnabled = True
        Me.vWaterCraftComboBox.Items.AddRange(New Object() {"----- Civilian Vehicles -----", "Assault Boat", "Motor Boat", "Swimmer Delivery Vehicle (SDV)", "----- Police Vehicles -----", "Motor Boat (Cop)", "Speed Boat HMG (Cop)", "Swimmer Delivery Vehicle (SDV - Cop)"})
        Me.vWaterCraftComboBox.Location = New System.Drawing.Point(117, 72)
        Me.vWaterCraftComboBox.Name = "vWaterCraftComboBox"
        Me.vWaterCraftComboBox.Size = New System.Drawing.Size(333, 21)
        Me.vWaterCraftComboBox.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Wheeled Vehicles:"
        '
        'vWheeledVehiclesComboBox
        '
        Me.vWheeledVehiclesComboBox.FormattingEnabled = True
        Me.vWheeledVehiclesComboBox.Items.AddRange(New Object() {"----- Civilian Vehicles -----", "Ifrit Unarmed", "Strider Unarmed", "HEMTT", "Hunter Unarmed", "SUV", "Tempest", "Offroad", "Zamak", "Quadbike", "----- Police Vehicles -----", "Quadbike (Cop)", "Hatchback Sport (Cop)", "SUV (Cop)", "Offroad (Cop)", "Hunter (Cop)", "----- Medical Vehicles -----", "Offroad (Medical)", "SUV (Medical)"})
        Me.vWheeledVehiclesComboBox.Location = New System.Drawing.Point(117, 18)
        Me.vWheeledVehiclesComboBox.Name = "vWheeledVehiclesComboBox"
        Me.vWheeledVehiclesComboBox.Size = New System.Drawing.Size(333, 21)
        Me.vWheeledVehiclesComboBox.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Aircraft:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Watercraft:"
        '
        'vAircraftComboBox
        '
        Me.vAircraftComboBox.FormattingEnabled = True
        Me.vAircraftComboBox.Items.AddRange(New Object() {"----- Civilian Aircraft-----", "CH-49 Mohawk", "MH-9 Hummingbird", "PO-30 Orca (Unarmed)", "----- Police Aircraft-----", "MH-9 Hummingbird (Cop)", "UH-80 Ghost Hawk (Cop)", "WY-55 Hellcat (Cop)", "----- Medical Aircraft -----", "PO-30 Orca (Medical)"})
        Me.vAircraftComboBox.Location = New System.Drawing.Point(117, 45)
        Me.vAircraftComboBox.Name = "vAircraftComboBox"
        Me.vAircraftComboBox.Size = New System.Drawing.Size(333, 21)
        Me.vAircraftComboBox.TabIndex = 35
        '
        'LoadBar
        '
        Me.LoadBar.BackColor = System.Drawing.Color.DarkRed
        Me.LoadBar.Location = New System.Drawing.Point(12, 352)
        Me.LoadBar.Name = "LoadBar"
        Me.LoadBar.Size = New System.Drawing.Size(274, 23)
        Me.LoadBar.TabIndex = 45
        '
        'saveInfoTextBox
        '
        Me.saveInfoTextBox.Location = New System.Drawing.Point(161, 265)
        Me.saveInfoTextBox.Name = "saveInfoTextBox"
        Me.saveInfoTextBox.Size = New System.Drawing.Size(125, 23)
        Me.saveInfoTextBox.TabIndex = 52
        Me.saveInfoTextBox.Text = "Save Information"
        Me.saveInfoTextBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.bankTextBox)
        Me.GroupBox3.Controls.Add(Me.aLvlComboBox)
        Me.GroupBox3.Controls.Add(Me.cashTextBox)
        Me.GroupBox3.Controls.Add(Me.mLvlComboBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cLvlComboBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dLvlComboBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(292, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 104)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cash On Hand:"
        '
        'bankTextBox
        '
        Me.bankTextBox.Location = New System.Drawing.Point(92, 45)
        Me.bankTextBox.Name = "bankTextBox"
        Me.bankTextBox.Size = New System.Drawing.Size(128, 20)
        Me.bankTextBox.TabIndex = 3
        Me.bankTextBox.Text = "0"
        '
        'aLvlComboBox
        '
        Me.aLvlComboBox.FormattingEnabled = True
        Me.aLvlComboBox.Items.AddRange(New Object() {"0 - Non-Admin", "1 - Altis Admin", "2 - Altis Head-Admin", "3 - Developer"})
        Me.aLvlComboBox.Location = New System.Drawing.Point(309, 72)
        Me.aLvlComboBox.Name = "aLvlComboBox"
        Me.aLvlComboBox.Size = New System.Drawing.Size(157, 21)
        Me.aLvlComboBox.TabIndex = 13
        Me.aLvlComboBox.Text = "0 - Non-Admin"
        '
        'cashTextBox
        '
        Me.cashTextBox.Location = New System.Drawing.Point(92, 19)
        Me.cashTextBox.Name = "cashTextBox"
        Me.cashTextBox.Size = New System.Drawing.Size(128, 20)
        Me.cashTextBox.TabIndex = 4
        Me.cashTextBox.Text = "0"
        '
        'mLvlComboBox
        '
        Me.mLvlComboBox.FormattingEnabled = True
        Me.mLvlComboBox.Items.AddRange(New Object() {"0 - Not Whitelisted", "1 - EMT", "2 - Paramedic", "3 - Critical Care Responder", "4 - Medical Logistics Officer", "5 - Corpsman", "BlackListed"})
        Me.mLvlComboBox.Location = New System.Drawing.Point(309, 18)
        Me.mLvlComboBox.Name = "mLvlComboBox"
        Me.mLvlComboBox.Size = New System.Drawing.Size(157, 21)
        Me.mLvlComboBox.TabIndex = 14
        Me.mLvlComboBox.Text = "0 - Not Whitelisted"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Admin Level:"
        '
        'cLvlComboBox
        '
        Me.cLvlComboBox.FormattingEnabled = True
        Me.cLvlComboBox.Items.AddRange(New Object() {"0 - Not Whitelisted", "1 - Cadet", "2 - Patrol Officer", "3 - Sergeant", "4 - Staff Sergeant", "5 - Lieutenant", "6 - Captain", "7 - Deputy Chief", "BlackListed"})
        Me.cLvlComboBox.Location = New System.Drawing.Point(92, 71)
        Me.cLvlComboBox.Name = "cLvlComboBox"
        Me.cLvlComboBox.Size = New System.Drawing.Size(128, 21)
        Me.cLvlComboBox.TabIndex = 12
        Me.cLvlComboBox.Text = "0 - Not Whitelisted"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bank Account:"
        '
        'dLvlComboBox
        '
        Me.dLvlComboBox.FormattingEnabled = True
        Me.dLvlComboBox.Items.AddRange(New Object() {"0 - Non-Donator", "1 - Tier 1", "2 - Tier 2", "3 - Tier 3", "4 - Tier 4", "5 - Tier 5", "6 - Tier 6", "7 - Tier 7", "8 - Tier 8"})
        Me.dLvlComboBox.Location = New System.Drawing.Point(309, 45)
        Me.dLvlComboBox.Name = "dLvlComboBox"
        Me.dLvlComboBox.Size = New System.Drawing.Size(157, 21)
        Me.dLvlComboBox.TabIndex = 15
        Me.dLvlComboBox.Text = "0 - Non-Donator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Donator Level:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Medic Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cop Level:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pGUIDTextBoxInfo)
        Me.GroupBox2.Controls.Add(Me.pInfoTextBoxInfo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.pIDTextBoxInfo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 116)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player Information"
        '
        'pGUIDTextBoxInfo
        '
        Me.pGUIDTextBoxInfo.Location = New System.Drawing.Point(82, 77)
        Me.pGUIDTextBoxInfo.Name = "pGUIDTextBoxInfo"
        Me.pGUIDTextBoxInfo.Size = New System.Drawing.Size(184, 20)
        Me.pGUIDTextBoxInfo.TabIndex = 28
        '
        'pInfoTextBoxInfo
        '
        Me.pInfoTextBoxInfo.Location = New System.Drawing.Point(82, 25)
        Me.pInfoTextBoxInfo.Name = "pInfoTextBoxInfo"
        Me.pInfoTextBoxInfo.Size = New System.Drawing.Size(184, 20)
        Me.pInfoTextBoxInfo.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Player GUID:"
        '
        'pIDTextBoxInfo
        '
        Me.pIDTextBoxInfo.Location = New System.Drawing.Point(82, 51)
        Me.pIDTextBoxInfo.Name = "pIDTextBoxInfo"
        Me.pIDTextBoxInfo.Size = New System.Drawing.Size(184, 20)
        Me.pIDTextBoxInfo.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Player ID: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Player Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pSearchIDTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pSearchGUIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 104)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search by PlayerID: "
        '
        'pSearchIDTextBox
        '
        Me.pSearchIDTextBox.Location = New System.Drawing.Point(116, 24)
        Me.pSearchIDTextBox.Name = "pSearchIDTextBox"
        Me.pSearchIDTextBox.Size = New System.Drawing.Size(150, 20)
        Me.pSearchIDTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search by GUID: "
        '
        'pSearchGUIDTextBox
        '
        Me.pSearchGUIDTextBox.Location = New System.Drawing.Point(116, 50)
        Me.pSearchGUIDTextBox.Name = "pSearchGUIDTextBox"
        Me.pSearchGUIDTextBox.Size = New System.Drawing.Size(150, 20)
        Me.pSearchGUIDTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 384)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.removeVehicleButton)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.addVehicleButton)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.LoadBar)
        Me.Controls.Add(Me.saveInfoTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compensation -- V2.0 Design Test 1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.VehicleCompTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TroubleshootingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadBarTicker As System.Windows.Forms.Timer
    Friend WithEvents TimeElapsed As System.Windows.Forms.Timer
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents removeVehicleButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents VehicleCompTable As System.Windows.Forms.DataGridView
    Friend WithEvents addVehicleButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents vWaterCraftComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents vWheeledVehiclesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents vAircraftComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LoadBar As System.Windows.Forms.ProgressBar
    Friend WithEvents saveInfoTextBox As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bankTextBox As System.Windows.Forms.TextBox
    Friend WithEvents aLvlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents cashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents mLvlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cLvlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dLvlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pGUIDTextBoxInfo As System.Windows.Forms.TextBox
    Friend WithEvents pInfoTextBoxInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pIDTextBoxInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pSearchIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pSearchGUIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProcessingFormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestForm1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
