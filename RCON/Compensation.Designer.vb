<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compensation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compensation))
        Me.PlayerComp = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Save = New System.Windows.Forms.Button()
        Me.MedicLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AdminLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.DonatorLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.CopLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BankAccountTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CashOnHandTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PlayerGUID = New System.Windows.Forms.TextBox()
        Me.PlayerUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PlayerIDTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleComp = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RemoveVehicle = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pIDTextBox = New System.Windows.Forms.TextBox()
        Me.WaterVehicleList = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.AircraftList = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VehicleList = New System.Windows.Forms.ComboBox()
        Me.AddVehicle = New System.Windows.Forms.Button()
        Me.PlayerComp.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehicleComp.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerComp
        '
        Me.PlayerComp.Controls.Add(Me.TabPage1)
        Me.PlayerComp.Controls.Add(Me.VehicleComp)
        Me.PlayerComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlayerComp.Location = New System.Drawing.Point(12, 9)
        Me.PlayerComp.Name = "PlayerComp"
        Me.PlayerComp.SelectedIndex = 0
        Me.PlayerComp.Size = New System.Drawing.Size(390, 386)
        Me.PlayerComp.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.Save)
        Me.TabPage1.Controls.Add(Me.MedicLevelComboBox)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.AdminLevelComboBox)
        Me.TabPage1.Controls.Add(Me.DonatorLevelComboBox)
        Me.TabPage1.Controls.Add(Me.CopLevelComboBox)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.BankAccountTextBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CashOnHandTextBox)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.PlayerGUID)
        Me.TabPage1.Controls.Add(Me.PlayerUserName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PlayerIDTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Players"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Compensation Log"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 253)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(356, 90)
        Me.DataGridView2.TabIndex = 39
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(279, 224)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(89, 23)
        Me.Save.TabIndex = 38
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'MedicLevelComboBox
        '
        Me.MedicLevelComboBox.Enabled = False
        Me.MedicLevelComboBox.FormattingEnabled = True
        Me.MedicLevelComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.MedicLevelComboBox.Location = New System.Drawing.Point(90, 197)
        Me.MedicLevelComboBox.Name = "MedicLevelComboBox"
        Me.MedicLevelComboBox.Size = New System.Drawing.Size(91, 21)
        Me.MedicLevelComboBox.TabIndex = 36
        Me.MedicLevelComboBox.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Medic Level"
        '
        'AdminLevelComboBox
        '
        Me.AdminLevelComboBox.Enabled = False
        Me.AdminLevelComboBox.FormattingEnabled = True
        Me.AdminLevelComboBox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.AdminLevelComboBox.Location = New System.Drawing.Point(279, 197)
        Me.AdminLevelComboBox.Name = "AdminLevelComboBox"
        Me.AdminLevelComboBox.Size = New System.Drawing.Size(91, 21)
        Me.AdminLevelComboBox.TabIndex = 34
        Me.AdminLevelComboBox.Text = "0"
        '
        'DonatorLevelComboBox
        '
        Me.DonatorLevelComboBox.Enabled = False
        Me.DonatorLevelComboBox.FormattingEnabled = True
        Me.DonatorLevelComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.DonatorLevelComboBox.Location = New System.Drawing.Point(279, 170)
        Me.DonatorLevelComboBox.Name = "DonatorLevelComboBox"
        Me.DonatorLevelComboBox.Size = New System.Drawing.Size(91, 21)
        Me.DonatorLevelComboBox.TabIndex = 33
        Me.DonatorLevelComboBox.Text = "0"
        '
        'CopLevelComboBox
        '
        Me.CopLevelComboBox.Enabled = False
        Me.CopLevelComboBox.FormattingEnabled = True
        Me.CopLevelComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.CopLevelComboBox.Location = New System.Drawing.Point(279, 145)
        Me.CopLevelComboBox.Name = "CopLevelComboBox"
        Me.CopLevelComboBox.Size = New System.Drawing.Size(91, 21)
        Me.CopLevelComboBox.TabIndex = 31
        Me.CopLevelComboBox.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Admin Level:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Donator Level:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Cop Level:"
        '
        'BankAccountTextBox
        '
        Me.BankAccountTextBox.Location = New System.Drawing.Point(90, 171)
        Me.BankAccountTextBox.Name = "BankAccountTextBox"
        Me.BankAccountTextBox.Size = New System.Drawing.Size(91, 20)
        Me.BankAccountTextBox.TabIndex = 25
        Me.BankAccountTextBox.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Bank Account:"
        '
        'CashOnHandTextBox
        '
        Me.CashOnHandTextBox.Location = New System.Drawing.Point(90, 145)
        Me.CashOnHandTextBox.Name = "CashOnHandTextBox"
        Me.CashOnHandTextBox.Size = New System.Drawing.Size(91, 20)
        Me.CashOnHandTextBox.TabIndex = 23
        Me.CashOnHandTextBox.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cash on Hand:"
        '
        'PlayerGUID
        '
        Me.PlayerGUID.Location = New System.Drawing.Point(12, 119)
        Me.PlayerGUID.Name = "PlayerGUID"
        Me.PlayerGUID.Size = New System.Drawing.Size(358, 20)
        Me.PlayerGUID.TabIndex = 20
        Me.PlayerGUID.Text = "Player GUID"
        '
        'PlayerUserName
        '
        Me.PlayerUserName.Location = New System.Drawing.Point(12, 93)
        Me.PlayerUserName.Name = "PlayerUserName"
        Me.PlayerUserName.Size = New System.Drawing.Size(358, 20)
        Me.PlayerUserName.TabIndex = 19
        Me.PlayerUserName.Text = "Player username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Player Information:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Enter Player ID to edit:"
        '
        'PlayerIDTextBox
        '
        Me.PlayerIDTextBox.Location = New System.Drawing.Point(128, 7)
        Me.PlayerIDTextBox.Name = "PlayerIDTextBox"
        Me.PlayerIDTextBox.Size = New System.Drawing.Size(242, 20)
        Me.PlayerIDTextBox.TabIndex = 16
        '
        'VehicleComp
        '
        Me.VehicleComp.Controls.Add(Me.Label11)
        Me.VehicleComp.Controls.Add(Me.DataGridView1)
        Me.VehicleComp.Controls.Add(Me.RemoveVehicle)
        Me.VehicleComp.Controls.Add(Me.TextBox6)
        Me.VehicleComp.Controls.Add(Me.TextBox5)
        Me.VehicleComp.Controls.Add(Me.TextBox2)
        Me.VehicleComp.Controls.Add(Me.TextBox1)
        Me.VehicleComp.Controls.Add(Me.TextBox3)
        Me.VehicleComp.Controls.Add(Me.TextBox4)
        Me.VehicleComp.Controls.Add(Me.Label2)
        Me.VehicleComp.Controls.Add(Me.Label1)
        Me.VehicleComp.Controls.Add(Me.pIDTextBox)
        Me.VehicleComp.Controls.Add(Me.WaterVehicleList)
        Me.VehicleComp.Controls.Add(Me.Label16)
        Me.VehicleComp.Controls.Add(Me.AircraftList)
        Me.VehicleComp.Controls.Add(Me.Label15)
        Me.VehicleComp.Controls.Add(Me.Label13)
        Me.VehicleComp.Controls.Add(Me.VehicleList)
        Me.VehicleComp.Controls.Add(Me.AddVehicle)
        Me.VehicleComp.Location = New System.Drawing.Point(4, 22)
        Me.VehicleComp.Name = "VehicleComp"
        Me.VehicleComp.Padding = New System.Windows.Forms.Padding(3)
        Me.VehicleComp.Size = New System.Drawing.Size(382, 360)
        Me.VehicleComp.TabIndex = 1
        Me.VehicleComp.Text = "Vehicles"
        Me.VehicleComp.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Vehicle Garage List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(162, 175)
        Me.DataGridView1.TabIndex = 30
        '
        'RemoveVehicle
        '
        Me.RemoveVehicle.Location = New System.Drawing.Point(181, 306)
        Me.RemoveVehicle.Name = "RemoveVehicle"
        Me.RemoveVehicle.Size = New System.Drawing.Size(189, 23)
        Me.RemoveVehicle.TabIndex = 29
        Me.RemoveVehicle.Text = "Remove Vehicle"
        Me.RemoveVehicle.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(165, 56)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(147, 20)
        Me.TextBox6.TabIndex = 28
        Me.TextBox6.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(165, 30)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(147, 20)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(358, 20)
        Me.TextBox3.TabIndex = 24
        Me.TextBox3.Text = "Player GUID"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(358, 20)
        Me.TextBox4.TabIndex = 23
        Me.TextBox4.Text = "Player username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Player Information:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter Player ID to edit:"
        '
        'pIDTextBox
        '
        Me.pIDTextBox.Location = New System.Drawing.Point(128, 7)
        Me.pIDTextBox.Name = "pIDTextBox"
        Me.pIDTextBox.Size = New System.Drawing.Size(242, 20)
        Me.pIDTextBox.TabIndex = 10
        '
        'WaterVehicleList
        '
        Me.WaterVehicleList.FormattingEnabled = True
        Me.WaterVehicleList.Items.AddRange(New Object() {"Assault Boat", "Motor Boat", "Swimmer Delivery Vehicle (SDV)", "Speed Boat Minigun"})
        Me.WaterVehicleList.Location = New System.Drawing.Point(181, 250)
        Me.WaterVehicleList.Name = "WaterVehicleList"
        Me.WaterVehicleList.Size = New System.Drawing.Size(184, 21)
        Me.WaterVehicleList.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(181, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Watercraft"
        '
        'AircraftList
        '
        Me.AircraftList.FormattingEnabled = True
        Me.AircraftList.Items.AddRange(New Object() {"CH-49 Mohawk", "MH-9 Hummingbird", "PO-30 Orca (Unarmed)", "UH-80 Ghost Hawk", "WY-55 Hellcat (Unarmed)"})
        Me.AircraftList.Location = New System.Drawing.Point(180, 210)
        Me.AircraftList.Name = "AircraftList"
        Me.AircraftList.Size = New System.Drawing.Size(185, 21)
        Me.AircraftList.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(181, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Aircraft"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(181, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Wheeled Vehicles"
        '
        'VehicleList
        '
        Me.VehicleList.FormattingEnabled = True
        Me.VehicleList.Items.AddRange(New Object() {"Ifrit Unarmed", "Strider Unarmed", "HEMTT", "Hunter Unarmed", "SUV", "Tempest", "Offroad", "Zamak", "Quadbike"})
        Me.VehicleList.Location = New System.Drawing.Point(180, 170)
        Me.VehicleList.Name = "VehicleList"
        Me.VehicleList.Size = New System.Drawing.Size(185, 21)
        Me.VehicleList.TabIndex = 3
        '
        'AddVehicle
        '
        Me.AddVehicle.Location = New System.Drawing.Point(181, 277)
        Me.AddVehicle.Name = "AddVehicle"
        Me.AddVehicle.Size = New System.Drawing.Size(189, 23)
        Me.AddVehicle.TabIndex = 1
        Me.AddVehicle.Text = "Add Vehicle"
        Me.AddVehicle.UseVisualStyleBackColor = True
        '
        'Compensation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 407)
        Me.Controls.Add(Me.PlayerComp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compensation"
        Me.Text = "Compensation"
        Me.PlayerComp.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehicleComp.ResumeLayout(False)
        Me.VehicleComp.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerComp As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents VehicleComp As System.Windows.Forms.TabPage
    Friend WithEvents AddVehicle As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents VehicleList As System.Windows.Forms.ComboBox
    Friend WithEvents AircraftList As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents WaterVehicleList As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayerGUID As System.Windows.Forms.TextBox
    Friend WithEvents PlayerUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PlayerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CopLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BankAccountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CashOnHandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdminLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DonatorLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MedicLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents RemoveVehicle As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
