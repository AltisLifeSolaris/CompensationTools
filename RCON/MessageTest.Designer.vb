<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageTest
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
        Me.lvBEPlayersOn = New System.Windows.Forms.ListView()
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPing = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGUID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RefreshListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvBEPlayersOn
        '
        Me.lvBEPlayersOn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chID, Me.chName, Me.chPing, Me.chGUID})
        Me.lvBEPlayersOn.Location = New System.Drawing.Point(13, 43)
        Me.lvBEPlayersOn.Name = "lvBEPlayersOn"
        Me.lvBEPlayersOn.Size = New System.Drawing.Size(457, 440)
        Me.lvBEPlayersOn.TabIndex = 1
        Me.lvBEPlayersOn.UseCompatibleStateImageBehavior = False
        Me.lvBEPlayersOn.View = System.Windows.Forms.View.Details
        '
        'chID
        '
        Me.chID.Text = "ID"
        Me.chID.Width = 24
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 131
        '
        'chPing
        '
        Me.chPing.Text = "Ping"
        Me.chPing.Width = 33
        '
        'chGUID
        '
        Me.chGUID.Text = "GUID"
        Me.chGUID.Width = 273
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RefreshListToolStripMenuItem
        '
        Me.RefreshListToolStripMenuItem.Name = "RefreshListToolStripMenuItem"
        Me.RefreshListToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.RefreshListToolStripMenuItem.Text = "Refresh List"
        '
        'MessageTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 495)
        Me.Controls.Add(Me.lvBEPlayersOn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MessageTest"
        Me.Text = "MessageTest"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvBEPlayersOn As System.Windows.Forms.ListView
    Friend WithEvents chID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPing As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGUID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RefreshListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
