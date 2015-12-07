Imports System.Net, System.IO
Imports System.Net.Sockets

Public Class tcp_client

    Public Event msgRecived(msg As String)

    Private stream As NetworkStream
    Private streamwrite As StreamWriter
    Private streamread As StreamReader
    Private client As New TcpClient
    Private t As Threading.Thread
    Private Server As String = "" 'Server IP
    Private _port As Integer = 3307
    Private _user As String
    Private _password As String
    Private _isRunning As Boolean = False

    Public Sub init_client()
        Dim Thread = New Threading.Thread(Sub()
                                              Try
                                                  client.Connect(Server, _port)
                                                  If client.Connected Then
                                                      stream = client.GetStream
                                                      streamwrite = New StreamWriter(stream)
                                                      streamread = New StreamReader(stream)

                                                      streamwrite.Flush()
                                                      t = New Threading.Thread(AddressOf Listen)
                                                      t.Start()
                                                      _isRunning = True
                                                  Else
                                                      MessageBox.Show("Connection not avalible! Check Server or contact Server Admin")
                                                      End
                                                  End If
                                              Catch ex As Exception
                                                  MessageBox.Show("Connection not avalible! Error:" & vbNewLine & ex.ToString)
                                                  client.Close()
                                                  End
                                              End Try
                                          End Sub)
        Thread.Start()

    End Sub

    Public Sub send(msg As String)
        Try
            If Not String.IsNullOrEmpty(msg) Then
                streamwrite.WriteLine(msg)
                streamwrite.Flush()
            End If
        Catch ex As Exception
            MessageBox.Show("Server currently not Avalible!" & vbNewLine & "Please try again Later!" & vbNewLine)
            close()
        End Try
    End Sub

    Private Sub Listen()
        While client.Connected
            Try

                Dim temp = streamread.ReadLine
                RaiseEvent msgRecived(temp)
                If String.IsNullOrEmpty(temp) Then
                    MessageBox.Show("Connection Lost!")
                    stream.Close()
                    client.Close()
                    End
                End If
            Catch ex As IOException
                Exit While
            Catch ex1 As Exception
                MessageBox.Show("Server Shutdown" & vbNewLine & ex1.ToString)
                client.Close()
                stream.Close()
                Exit While
                End
            End Try
        End While

    End Sub

    Public Sub close()
        client.Close()
        stream.Close()
        streamwrite.Close()
        streamread.Close()
        _isRunning = False
        End
    End Sub

    Public Property isRunning As Boolean
        Get
            Return _isRunning
        End Get
        Set(value As Boolean)
            _isRunning = value
        End Set
    End Property

End Class
