Imports System.IO

Public Class Punishment

    Private Sub Punishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.Location = New Point(RCON_SELECTION.Top, RCON_SELECTION.Bottom)
        OutputText.Enabled = False
        OffenseNum.Enabled = False
        RichTextBox1.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}}{\*\generator Riched20 6.3.9600}\viewkind4\uc1 \pard\sa200\sl276\slmult1\b\f0\fs22\lang9 Random Deathmatch \b0 - Also know as \b RDM \b0 - 3 day ban. If they are a new player, talk to them before you do anything and let them know what they did before you kick them. After you speak to a new player, send them a link to the rules so they may read over them.                        \par\b Vehicle Deathmatch \b0 - Also know as \b VDM\b0 - 3 day ban. If they are a new player, talk to them before you do anything and let them know what they did before you kick them. After you speak to a new player, send them a link to the rules so they may read over them.         \par\b Fail Roleplay \b0 also know as \b FailRP \b0 - 2 hour ban. If they are a new player, talk to them before you do anything and let tem know what they did before you kick them. After you speak to a new player, send them a link to the rules so they may read over them.      \par\b Combat logging -\b0  24 hour ban if they are a new player talk to them before you do anything let them know what they did before you kick them and send them a link to the rules only for new player\rquote s!!!!!\par\b Disconnecting  to avoid punishment \b0 - 3 day ban  If they are a new player talk to them before you do anything let them know what they did before you kick them and send them a link to the rules only for new player\rquote s!!!!! \par\b Threat\rquote s to hack/Ddos \b0 - Permban and teamspeak not welcome here\par\b Suspected Hacking \b0 - If a player is Suspected Hacking perm ban them If they appeal It\rquote s up to the head admins to accept or decline the appeal.\par\b Hacking \b0 - perm ban Not welcome here.\par\b Bug abuse \b0 - Perm ban If they are a new player talk to them before you do anything let them know what they did before you kick (ONLY KICK THEM) and send them a link to the rules only for new players.\par\b Disrespect to staff \b0 - 3 day ban in game and from teamspeak. (Before YOU BAN THEM) If they\rquote re not on, talk to a TS Admin. Make sure to link them the Rules on this subject, before you ban them.\par\b Racial slurs -\b0  6 day ban in game and Teamspeak. Make sure to link them the Rules on this subject.\par\pard\sa200\sl276\slmult1\b Harassment \b0 - 3 day ban in game as well as teamspeak.Make sure to link them the Rules on this subject.\par\pard\sa200\sl276\slmult1\b Sexual harassment \b0 - 3 day ban in game as well as teamspeak.Make sure to link them the Rules on this subject. \par\b Religion \b0 - You are free to believe in what ever you want to but keep it out of the game/Teamspeak we're here to play games not learn about religion.\par\b Evidence \b0 - is needed for player\rquote s Video Proof/Screenshot, Admin word is as good as video as well as a Helpers word.\par}"
    End Sub

    Private Sub Ban_Click(sender As Object, e As EventArgs) Handles Ban.Click

        If (PlayerName.Text = "") Then
            MessageBox.Show("You need to select a player!")
            Exit Sub
        ElseIf (OffenseType.Text = "") Then
            MessageBox.Show("You need to select a type of offense!")
            Exit Sub
        ElseIf (PunishmentTime1.Text = "") Then
            MessageBox.Show("You need to select the amount of time to punish this person for!")
            Exit Sub
        ElseIf (AdminName.Text = "") Then
            MessageBox.Show("You need to enter the Admins name (Your name)!") 'Program should pull name of currently logged on user and input as admin name
            Exit Sub
        End If

        Dim OutputText As String
        If (PunishmentTime2.Text.Contains("Perm")) Then
            OutputText = PlayerName.Text & " | " & PunishmentTime2.Text & " | " & OffenseType.Text & " | " & AdminName.Text
            MessageBox.Show(PlayerName.Text & " | " & PunishmentTime2.Text & " | " & OffenseType.Text & " | " & AdminName.Text)
        Else
            OutputText = PlayerName.Text & " | " & PunishmentTime1.Text & PunishmentTime2.Text & " | " & OffenseType.Text & " | " & AdminName.Text
            MessageBox.Show(PlayerName.Text & " | " & PunishmentTime1.Text & " " & PunishmentTime2.Text & " | " & OffenseType.Text & " | " & AdminName.Text)
        End If

    End Sub


    Private Sub Kick_Click(sender As Object, e As EventArgs) Handles Kick.Click

        If (PlayerName.Text = "") Then
            MessageBox.Show("You need to select a player!")
            Exit Sub
        ElseIf (AdminName.Text = "") Then
            MessageBox.Show("You need to enter the Admins name (Your name)!") 'Program should pull name of currently logged on user and input as admin name
            Exit Sub
        End If

        Dim OutputText As String
        OutputText = PlayerName.Text & "|" & AdminName.Text
        MessageBox.Show(PlayerName.Text & " | " & AdminName.Text)

    End Sub
End Class