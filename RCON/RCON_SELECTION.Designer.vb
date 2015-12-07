<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RCON_SELECTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RCON_SELECTION))
        Me.Compensation_Tab = New System.Windows.Forms.CheckBox()
        Me.Settings_Tab = New System.Windows.Forms.CheckBox()
        Me.Logs_Tab = New System.Windows.Forms.CheckBox()
        Me.PGC_Logo = New System.Windows.Forms.PictureBox()
        CType(Me.PGC_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Compensation_Tab
        '
        Me.Compensation_Tab.AutoSize = True
        Me.Compensation_Tab.Location = New System.Drawing.Point(12, 331)
        Me.Compensation_Tab.Name = "Compensation_Tab"
        Me.Compensation_Tab.Size = New System.Drawing.Size(93, 17)
        Me.Compensation_Tab.TabIndex = 8
        Me.Compensation_Tab.Text = "Compensation"
        Me.Compensation_Tab.UseVisualStyleBackColor = True
        '
        'Settings_Tab
        '
        Me.Settings_Tab.AutoSize = True
        Me.Settings_Tab.Enabled = False
        Me.Settings_Tab.Location = New System.Drawing.Point(233, 331)
        Me.Settings_Tab.Name = "Settings_Tab"
        Me.Settings_Tab.Size = New System.Drawing.Size(79, 17)
        Me.Settings_Tab.TabIndex = 9
        Me.Settings_Tab.Text = "Beta-Forms"
        Me.Settings_Tab.UseVisualStyleBackColor = True
        '
        'Logs_Tab
        '
        Me.Logs_Tab.AutoSize = True
        Me.Logs_Tab.Enabled = False
        Me.Logs_Tab.Location = New System.Drawing.Point(132, 331)
        Me.Logs_Tab.Name = "Logs_Tab"
        Me.Logs_Tab.Size = New System.Drawing.Size(49, 17)
        Me.Logs_Tab.TabIndex = 10
        Me.Logs_Tab.Text = "Logs"
        Me.Logs_Tab.UseVisualStyleBackColor = True
        '
        'PGC_Logo
        '
        Me.PGC_Logo.Image = CType(resources.GetObject("PGC_Logo.Image"), System.Drawing.Image)
        Me.PGC_Logo.Location = New System.Drawing.Point(12, 12)
        Me.PGC_Logo.Name = "PGC_Logo"
        Me.PGC_Logo.Size = New System.Drawing.Size(300, 300)
        Me.PGC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PGC_Logo.TabIndex = 5
        Me.PGC_Logo.TabStop = False
        '
        'RCON_SELECTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(329, 386)
        Me.Controls.Add(Me.Logs_Tab)
        Me.Controls.Add(Me.Settings_Tab)
        Me.Controls.Add(Me.Compensation_Tab)
        Me.Controls.Add(Me.PGC_Logo)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.MaximizeBox = False
        Me.Name = "RCON_SELECTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Phantom Menu"
        CType(Me.PGC_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Compensation_Tab As System.Windows.Forms.CheckBox
    Friend WithEvents Settings_Tab As System.Windows.Forms.CheckBox
    Friend WithEvents Logs_Tab As System.Windows.Forms.CheckBox
    Friend WithEvents PGC_Logo As System.Windows.Forms.PictureBox
End Class
