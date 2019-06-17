Imports System.IO
Imports System.Text
Imports System.Data.MySqlClient
Public Class CheckingUpdates
    'Dim MySqlConn As MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim reader As MySqlDataReader


    Dim neuerthread As System.Threading.Thread = New System.Threading.Thread(AddressOf Me.CheckForUpdate) 'Multithread für ScanServer()
    Private Sub CheckingUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        neuerthread = New System.Threading.Thread(AddressOf Me.CheckForUpdate)
        neuerthread.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = "Checking for updates." Then
            Label1.Text = "Checking for updates.."
            Exit Sub
        ElseIf Label1.Text = "Checking for updates.." Then
            Label1.Text = "Checking for updates..."
            Exit Sub
        ElseIf Label1.Text = "Checking for updates..." Then
            Label1.Text = "Checking for updates."
            Exit Sub
        End If
    End Sub

    Private Sub CheckForUpdate()
        Dim response As MsgBoxResult
        'MySqlConn = New MySqlConnection
        'cmd = New MySqlCommand

        'MySqlConn.ConnectionString = "server=sql4.freemysqlhosting.net;" _
        ' & "uid=sql4102189;" _
        ' & "pwd=UqwKrKqF4c;" _
        '& "database=sql4102189;"

        Try
            'MySqlConn.Open()
            'cmd.Connection = MySqlConn
            'cmd.CommandText = "Select username from user where username = '" & "1.0.0.0" & "'"
            'reader = cmd.ExecuteReader
            If 0 = 0 Then 'reader.HasRows Then
            Else
                response = MsgBox("Es ist eine neuere Version verfügbar!" & vbNewLine & "Möchten Sie diese herunterladen?", MsgBoxStyle.OkCancel, "Update verfügbar")
                If response = Microsoft.VisualBasic.MsgBoxResult.Ok Then
                    Process.Start("http://www.google.de")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Try
                'MySqlConn.Dispose()
                'reader.Dispose()
                'cmd.Dispose()
            Catch ex As Exception
            End Try
        End Try
    End Sub


End Class