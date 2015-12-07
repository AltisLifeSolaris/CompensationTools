Imports BattleNET

Public Class MessageTest
    Private tc As tcp_client
    Dim ConnInfo As String = ""


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        lvBEPlayersOn.Items.Clear()
    End Sub

    Private Sub MessageTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

