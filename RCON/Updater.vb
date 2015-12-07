Public Class Updater
    Private _client As tcp_client
    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("") 'Distro link for example https://www.dropbox.com/s/wmajhmg9evj7ooe/Version.txt?dl=0
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Button1.Text = ("You are up todate!")
                Button2.Visible = True

            Else
                Button1.Text = ("Downloading update!")
                WebBrowser1.Navigate("") 'Distro Link
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("") ' More distro link
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Button1.Text = ("You are up todate!")
                    Button2.Visible = True
                Else
                    Button1.Text = ("Downloading update!")
                    WebBrowser1.Navigate("") 'And some more..
                End If
            End If
        End If
    End Sub

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPage.Show()
        Me.MaximizeBox = False
        Button1.Enabled = False
        Button2.Visible = False
        Button1.Text = "Checking for updates..."
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
        RichTextBox1.Rtf = "" 'Some rich text formatting of changelogs ;)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PGC_RCON_LOGIN.Show()
        Me.Close()

    End Sub
End Class
