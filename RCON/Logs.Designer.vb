<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logs
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
        Me.LogTable = New System.Windows.Forms.DataGridView()
        Me.LoadCompLog = New System.Windows.Forms.Button()
        Me.LoadBountyTable = New System.Windows.Forms.Button()
        Me.LoadGangList = New System.Windows.Forms.Button()
        CType(Me.LogTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogTable
        '
        Me.LogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogTable.Location = New System.Drawing.Point(12, 12)
        Me.LogTable.Name = "LogTable"
        Me.LogTable.Size = New System.Drawing.Size(575, 210)
        Me.LogTable.TabIndex = 1
        '
        'LoadCompLog
        '
        Me.LoadCompLog.Location = New System.Drawing.Point(593, 12)
        Me.LoadCompLog.Name = "LoadCompLog"
        Me.LoadCompLog.Size = New System.Drawing.Size(145, 23)
        Me.LoadCompLog.TabIndex = 2
        Me.LoadCompLog.Text = "Load Compensation Log"
        Me.LoadCompLog.UseVisualStyleBackColor = True
        '
        'LoadBountyTable
        '
        Me.LoadBountyTable.Location = New System.Drawing.Point(593, 41)
        Me.LoadBountyTable.Name = "LoadBountyTable"
        Me.LoadBountyTable.Size = New System.Drawing.Size(145, 23)
        Me.LoadBountyTable.TabIndex = 3
        Me.LoadBountyTable.Text = "Load Bounty List"
        Me.LoadBountyTable.UseVisualStyleBackColor = True
        '
        'LoadGangList
        '
        Me.LoadGangList.Location = New System.Drawing.Point(593, 70)
        Me.LoadGangList.Name = "LoadGangList"
        Me.LoadGangList.Size = New System.Drawing.Size(145, 23)
        Me.LoadGangList.TabIndex = 4
        Me.LoadGangList.Text = "Load Gang List"
        Me.LoadGangList.UseVisualStyleBackColor = True
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 234)
        Me.Controls.Add(Me.LoadGangList)
        Me.Controls.Add(Me.LoadBountyTable)
        Me.Controls.Add(Me.LoadCompLog)
        Me.Controls.Add(Me.LogTable)
        Me.Name = "Logs"
        Me.Text = "Logs"
        CType(Me.LogTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogTable As System.Windows.Forms.DataGridView
    Friend WithEvents LoadCompLog As System.Windows.Forms.Button
    Friend WithEvents LoadBountyTable As System.Windows.Forms.Button
    Friend WithEvents LoadGangList As System.Windows.Forms.Button
End Class
