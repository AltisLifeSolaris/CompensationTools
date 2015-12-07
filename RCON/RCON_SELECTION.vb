Public Class RCON_SELECTION

    'All Checkboxes have had their states switched from Enabled to Disabled (True > False)
    Private Sub PGC_Logo_Click(sender As Object, e As EventArgs) Handles PGC_Logo.Click
    End Sub

    Private Sub CompSys_CheckedChanged(sender As Object, e As EventArgs) Handles Compensation_Tab.CheckedChanged
        If (Compensation_Tab.Checked = True) Then
            Compensation.Show()
        ElseIf (Compensation_Tab.Checked = False) Then
            Compensation.Close()
        End If
    End Sub
    Private Sub Settings_Tab_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_Tab.CheckedChanged
        If (Settings_Tab.Checked = True) Then
            New_Form.Show()
        ElseIf (Settings_Tab.Checked = False) Then
            New_Form.Close()
        End If
    End Sub

    Private Sub RCON_SELECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.Location = New Point(0, 0)

    End Sub

    Private Sub RCON_SELECTION_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Punishment.Close()
        Compensation.Close()
        Status.Close()
        Logs.Close()
        New_Form.Close()
    End Sub

    Private Sub Logs_CheckedChanged(sender As Object, e As EventArgs) Handles Logs_Tab.CheckedChanged
        If (Logs_Tab.Checked = True) Then
            Logs.Show()
        ElseIf (Logs_Tab.Checked = False) Then
            Logs.Close()
        End If
    End Sub
End Class
