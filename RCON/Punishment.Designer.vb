<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Punishment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Punishment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BansTab = New System.Windows.Forms.TabPage()
        Me.Kick = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OffenseNum = New System.Windows.Forms.TextBox()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.AdminName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PunishmentTime1 = New System.Windows.Forms.ComboBox()
        Me.Ban = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OffenseType = New System.Windows.Forms.ComboBox()
        Me.PunishmentTime2 = New System.Windows.Forms.ComboBox()
        Me.PlayerName = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BansTab.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Administrative Guidelines:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(403, 34)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(344, 396)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'BansTab
        '
        Me.BansTab.Controls.Add(Me.Kick)
        Me.BansTab.Controls.Add(Me.ListBox2)
        Me.BansTab.Controls.Add(Me.Label10)
        Me.BansTab.Controls.Add(Me.OffenseNum)
        Me.BansTab.Controls.Add(Me.OutputText)
        Me.BansTab.Controls.Add(Me.AdminName)
        Me.BansTab.Controls.Add(Me.Label8)
        Me.BansTab.Controls.Add(Me.Label3)
        Me.BansTab.Controls.Add(Me.PunishmentTime1)
        Me.BansTab.Controls.Add(Me.Ban)
        Me.BansTab.Controls.Add(Me.Label7)
        Me.BansTab.Controls.Add(Me.Label6)
        Me.BansTab.Controls.Add(Me.Label5)
        Me.BansTab.Controls.Add(Me.Label4)
        Me.BansTab.Controls.Add(Me.Label2)
        Me.BansTab.Controls.Add(Me.OffenseType)
        Me.BansTab.Controls.Add(Me.PunishmentTime2)
        Me.BansTab.Controls.Add(Me.PlayerName)
        Me.BansTab.Location = New System.Drawing.Point(4, 22)
        Me.BansTab.Name = "BansTab"
        Me.BansTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BansTab.Size = New System.Drawing.Size(373, 392)
        Me.BansTab.TabIndex = 0
        Me.BansTab.Text = "Bans"
        Me.BansTab.UseVisualStyleBackColor = True
        '
        'Kick
        '
        Me.Kick.Location = New System.Drawing.Point(292, 120)
        Me.Kick.Name = "Kick"
        Me.Kick.Size = New System.Drawing.Size(75, 23)
        Me.Kick.TabIndex = 20
        Me.Kick.Text = "Kick"
        Me.Kick.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Test1", "Test2", "Test3"})
        Me.ListBox2.Location = New System.Drawing.Point(179, 175)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(125, 43)
        Me.ListBox2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Offenses are in these Catagories:"
        '
        'OffenseNum
        '
        Me.OffenseNum.Location = New System.Drawing.Point(93, 150)
        Me.OffenseNum.Name = "OffenseNum"
        Me.OffenseNum.Size = New System.Drawing.Size(32, 20)
        Me.OffenseNum.TabIndex = 17
        '
        'OutputText
        '
        Me.OutputText.Location = New System.Drawing.Point(54, 366)
        Me.OutputText.Name = "OutputText"
        Me.OutputText.Size = New System.Drawing.Size(313, 20)
        Me.OutputText.TabIndex = 11
        '
        'AdminName
        '
        Me.AdminName.Location = New System.Drawing.Point(101, 86)
        Me.AdminName.Name = "AdminName"
        Me.AdminName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AdminName.Size = New System.Drawing.Size(203, 20)
        Me.AdminName.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Previous Offenses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "This player has"
        '
        'PunishmentTime1
        '
        Me.PunishmentTime1.FormattingEnabled = True
        Me.PunishmentTime1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.PunishmentTime1.Location = New System.Drawing.Point(101, 32)
        Me.PunishmentTime1.Name = "PunishmentTime1"
        Me.PunishmentTime1.Size = New System.Drawing.Size(203, 21)
        Me.PunishmentTime1.TabIndex = 14
        '
        'Ban
        '
        Me.Ban.Location = New System.Drawing.Point(211, 120)
        Me.Ban.Name = "Ban"
        Me.Ban.Size = New System.Drawing.Size(75, 23)
        Me.Ban.TabIndex = 13
        Me.Ban.Text = "Ban"
        Me.Ban.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Output:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Admin Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Offense:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Punishment Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Player Name:"
        '
        'OffenseType
        '
        Me.OffenseType.FormattingEnabled = True
        Me.OffenseType.Items.AddRange(New Object() {"Bug Abuse", "Combat Logging", "Disconnecting to Avoid Punishment", "Fail RP", "Hacking", "Harrasment", "Racial Slurs", "RDM", "Sexual Harrasment", "Staff Disrespect", "Suspected Hacking", "Threatening to Hack/DDoS", "VDM", "Other"})
        Me.OffenseType.Location = New System.Drawing.Point(101, 59)
        Me.OffenseType.Name = "OffenseType"
        Me.OffenseType.Size = New System.Drawing.Size(203, 21)
        Me.OffenseType.TabIndex = 3
        '
        'PunishmentTime2
        '
        Me.PunishmentTime2.FormattingEnabled = True
        Me.PunishmentTime2.Items.AddRange(New Object() {"Hours", "Days", "Perm"})
        Me.PunishmentTime2.Location = New System.Drawing.Point(310, 33)
        Me.PunishmentTime2.Name = "PunishmentTime2"
        Me.PunishmentTime2.Size = New System.Drawing.Size(57, 21)
        Me.PunishmentTime2.TabIndex = 2
        Me.PunishmentTime2.Text = "Hours"
        '
        'PlayerName
        '
        Me.PlayerName.FormattingEnabled = True
        Me.PlayerName.Location = New System.Drawing.Point(101, 6)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(203, 21)
        Me.PlayerName.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BansTab)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(381, 418)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.Tag = "fds"
        '
        'Punishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 442)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Punishment"
        Me.Text = "Punishment"
        Me.BansTab.ResumeLayout(False)
        Me.BansTab.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BansTab As System.Windows.Forms.TabPage
    Friend WithEvents Kick As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OffenseNum As System.Windows.Forms.TextBox
    Friend WithEvents OutputText As System.Windows.Forms.TextBox
    Friend WithEvents AdminName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PunishmentTime1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ban As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OffenseType As System.Windows.Forms.ComboBox
    Friend WithEvents PunishmentTime2 As System.Windows.Forms.ComboBox
    Friend WithEvents PlayerName As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
