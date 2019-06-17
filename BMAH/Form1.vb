Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Dim aProp As System.Reflection.PropertyInfo = GetType(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance) 'ListView1 flackern entfernt durch DoubleBuffered
    Dim neuerthread As System.Threading.Thread = New System.Threading.Thread(AddressOf Me.ScanServer) 'Multithread für ScanServer()
    Public Shared wc As New Net.WebClient
    Public Shared WebAddress As String
    Public Shared Servername As String
    Public Shared ServernameAnzeige As String
    Public Shared LastUpdatedAt As String

#Region "UI"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start Scan" Then
            neuerthread = New System.Threading.Thread(AddressOf Me.ScanServer)
            If ComboBox1.SelectedIndex = 0 Then
                ToolStripProgressBar1.Maximum = ComboBox2.Items.Count
            Else
                ToolStripProgressBar1.Maximum = ComboBox3.Items.Count
            End If
            ToolStripProgressBar1.Value = 0
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            ListView3.Items.Clear()
            'ScanServer()
            neuerthread.Start()
            Button1.Text = "Stop Scan"
            Button_Filter.Enabled = False
            Button_ClearFilter.Enabled = False
            TextBox1.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            Exit Sub
        End If

        If Button1.Text = "Stop Scan" Then
            neuerthread.Abort()
            ToolStripStatusLabel1.Text = "Scan stopped!"
            Button_Filter.Enabled = True
            DisplayStart()
        End If
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Process.Start("http://www.wowhead.com/item=" & ListView1.FocusedItem.SubItems(10).Text)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then 'Wenn EU
            WebAddress = "http://www.tradeskillmaster.com/black-market?realm=EU-"
            ToolStripProgressBar1.Maximum = ComboBox2.Items.Count
            ToolStripProgressBar1.Value = 0
            ComboBox3.SelectedIndex = 0
            ComboBox2.Visible = True
            ComboBox2.Enabled = True
            ComboBox3.Visible = False
            ComboBox3.Enabled = False
        ElseIf ComboBox1.SelectedIndex = 1 Then 'Wenn US
            WebAddress = "https://www.tradeskillmaster.com/black-market?realm=US-"
            ToolStripProgressBar1.Maximum = ComboBox3.Items.Count
            ToolStripProgressBar1.Value = 0
            ComboBox2.SelectedIndex = 0
            ComboBox2.Visible = False
            ComboBox2.Enabled = False
            ComboBox3.Visible = True
            ComboBox3.Enabled = True
        End If
        Button1.Enabled = True
    End Sub
    Private Sub DisplayStart()
        Button1.Text = "Start Scan"
        TextBox1.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
    End Sub
#End Region


#Region "Menu"
    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        Me.Enabled = False
        Settings.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Enabled = False
        About.Show()
    End Sub
    Private Sub TotxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotxtToolStripMenuItem.Click
        ExportToTxt()
    End Sub
    Private Sub TocsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TocsvToolStripMenuItem.Click
        ExportToCSV()
    End Sub
    Private Sub ToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToExcelToolStripMenuItem.Click
        ExportTOExcel()
    End Sub
#End Region


#Region "ScanData"
    Private Sub ScanServer()

        If ComboBox1.SelectedIndex = 0 Then 'Wenn EU
            If ComboBox2.Text = "" Then 'Wenn alle Server
                For Each items In ComboBox2.Items
                    Try
                        ToolStripProgressBar1.Value += 1
                        Servername = items
                        ServernameAnzeige = Servername.Replace("-", " ")
                        ToolStripStatusLabel1.Text = "Scanning " & ServernameAnzeige & "..."
Test:
                        Dim httpRequest As HttpWebRequest = CType(HttpWebRequest.Create(WebAddress & Servername), HttpWebRequest)
                        'httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36"
                        httpRequest.UserAgent = "Googlebot/2.1 (+http://www.google.com/bot.html)"
                        Dim httpResponse As HttpWebResponse = CType(httpRequest.GetResponse(), HttpWebResponse)
                        Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
                        Dim httpContent As String = reader.ReadToEnd
                        TextBox2.Text = httpContent

                        If checkerr() = False Then
                            'MsgBox(ServernameAnzeige)
                            httpRequest = Nothing
                            httpResponse = Nothing
                            GoTo Test
                        End If
                        ScanItems()

                        httpRequest = Nothing
                        httpResponse = Nothing
                    Catch ex As Exception
                        'MsgBox(ex.Message + Servername)
                    End Try
                Next
                ToolStripStatusLabel1.Text = "Scan complete! Scanned " & ComboBox2.Items.Count & " Servers (" & LastUpdatedAt & ")"
                Button_Filter.Enabled = True
                DisplayStart()

            ElseIf ComboBox2.Text <> "" Then 'Wenn ein Server
                Try
                    ToolStripProgressBar1.Maximum = 100
                    Servername = ComboBox2.SelectedItem
                    ServernameAnzeige = Servername.Replace("-", " ")
                    ToolStripStatusLabel1.Text = "Scanning " & ServernameAnzeige & "..."

                    Dim httpRequest As HttpWebRequest = CType(HttpWebRequest.Create(WebAddress & Servername), HttpWebRequest)
                    'httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36"
                    httpRequest.UserAgent = "Googlebot/2.1 (+http://www.google.com/bot.html)"
                    Dim httpResponse As HttpWebResponse = CType(httpRequest.GetResponse(), HttpWebResponse)
                    Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
                    Dim httpContent As String = reader.ReadToEnd
                    TextBox2.Text = httpContent





                    ToolStripProgressBar1.Value += 50
                    ScanItems()
                    ToolStripProgressBar1.Value += 50
                Catch ex As Exception
                    MsgBox(ex.Message + Servername)
                End Try
                ToolStripStatusLabel1.Text = "Scan complete! (" & LastUpdatedAt & ")"
                Button_Filter.Enabled = True
                DisplayStart()

            End If

        ElseIf ComboBox1.SelectedIndex = 1 Then 'Wenn US
            If ComboBox3.Text = "" Then 'Wenn alle Server
                For Each items In ComboBox3.Items
                    Try
                        ToolStripProgressBar1.Value += 1
                        Servername = items
                        ServernameAnzeige = Servername.Replace("-", " ")
                        ToolStripStatusLabel1.Text = "Scanning " & ServernameAnzeige & "..."

                        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create(WebAddress & Servername)
                        'httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36"
                        httpRequest.UserAgent = "Googlebot/2.1 (+http://www.google.com/bot.html)"
                        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
                        Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
                        Dim httpContent As String = reader.ReadToEnd
                        TextBox2.Text = httpContent

                        ScanItems()
                    Catch ex As Exception
                        'MsgBox(ex.Message + Servername)
                    End Try
                Next
                ToolStripStatusLabel1.Text = "Scan complete! Scanned " & ComboBox3.Items.Count & " Servers (" & LastUpdatedAt & ")"
                Button_Filter.Enabled = True
                DisplayStart()

            ElseIf ComboBox3.Text <> "" Then 'Wenn ein Server
                Try
                    ToolStripProgressBar1.Maximum = 100
                    Servername = ComboBox3.SelectedItem
                    ServernameAnzeige = Servername.Replace("-", " ")
                    ToolStripStatusLabel1.Text = "Scanning " & ServernameAnzeige & "..."

                    Dim httpRequest As HttpWebRequest = HttpWebRequest.Create(WebAddress & Servername)
                    'httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36"
                    httpRequest.UserAgent = "Googlebot/2.1 (+http://www.google.com/bot.html)"
                    Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
                    Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
                    Dim httpContent As String = reader.ReadToEnd

                    TextBox2.Text = httpContent

                    ToolStripProgressBar1.Value += 50
                    ScanItems()
                    ToolStripProgressBar1.Value += 50
                Catch ex As Exception
                    'MsgBox(ex.Message + Servername)
                End Try
                ToolStripStatusLabel1.Text = "Scan complete! (" & LastUpdatedAt & ")"
                Button_Filter.Enabled = True
                DisplayStart()
            End If
        End If
    End Sub
    Private Sub ScanItems()
        For Each zeile In TextBox2.Lines
            If zeile.Contains("<tr data-key=""0"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""1"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""2"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""3"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""4"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""5"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""6"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""7"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""8"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""9"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<tr data-key=""10"">") Then
                InsertItem(zeile)
            End If
            If zeile.Contains("<p style=""float:left"">Last Updated: ") Then
                zeile = zeile.Replace("<p style=""float:left"">", ";")
                zeile = zeile.Replace("</p>", ";")
                Dim b() As String = zeile.Split(";")
                zeile = b(1)
                zeile = zeile.Replace(":", "")
                LastUpdatedAt = zeile
            End If
        Next
    End Sub
    Private Function checkerr()
        For Each zeile In TextBox2.Lines
            If zeile.Contains("The above error occurred while the Web server was processing your request.") Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#End Region


#Region "InsertData"
    Private Sub InsertItem(zeile As String)
        Dim Itemname As String = zeile
        Dim CurrentBid As String = zeile
        Dim MinBid As String = zeile
        Dim TimeLeft As String = zeile
        Dim Bids As String = zeile
        Dim RealmPrice As String = zeile
        Dim GlobalPrice As String = zeile
        Dim ServerQty As String = zeile
        'Dim LastUpdated As String = zeile
        Dim ItemID As String = zeile

        Itemname = GetItemName(Itemname)
        CurrentBid = GetCurrBid(CurrentBid)
        MinBid = GetMinBid(MinBid)
        TimeLeft = GetTimeLeft(TimeLeft)
        Bids = GetBids(Bids)
        RealmPrice = GetRealmPrice(RealmPrice)
        GlobalPrice = GetGlobalPrice(GlobalPrice)
        ServerQty = GetServerQty(ServerQty)
        'LastUpdated = GetLastUpdated(LastUpdated)
        ItemID = GetItemID(ItemID)
        Servername = Servername.Replace("-", " ")


        ListView1.Items.Add(New ListViewItem(New String() {Servername, Itemname, CurrentBid, MinBid, TimeLeft, Bids, RealmPrice, GlobalPrice, ServerQty, "", ItemID}))
        ListView2.Items.Add(New ListViewItem(New String() {Servername, Itemname, CurrentBid, MinBid, TimeLeft, Bids, RealmPrice, GlobalPrice, ServerQty, "", ItemID}))
    End Sub
#End Region


#Region "GetData"
    Private Function GetItemName(text As String)
        text = text.Replace("title=""", ",")
        text = text.Replace("""></a>", ",")
        Dim b() As String = text.Split(",")
        text = b(1)
        Return text
    End Function
    Private Function GetCurrBid(text As String)
        'text = text.Replace("<td data-col-seq=""1""><span class=""moneygold"">", ",")
        'text = text.Replace("</span></td><td data-col-seq=""2"">", ",")
        text = text.Replace("</td><td data-col-seq=""1"">", ";")
        text = text.Replace("<strong style=""color:#CAAA00"">g</strong></td><td data-col-seq=""2"">", ";")
        Dim b() As String = text.Split(";")
        text = b(1)

        If My.Settings.Normal = True Then
            text = text.Replace(",", "")
        ElseIf My.Settings.Thausand = True Then
            text = text.Replace(",", ".")
        ElseIf My.Settings.K = True Then
            text = text.Replace(",", ".")
            text = String.Format("{0:0,.0}K", CInt(text))
        End If
        Return text
    End Function
    Private Function GetMinBid(text As String)
        'text = text.Replace("<td data-col-seq=""2""><span class=""moneygold"">", ",")
        'text = text.Replace("</span></td><td data-col-seq=""3"">", ",")
        text = text.Replace("</td><td data-col-seq=""2"">", ";")
        text = text.Replace("<strong style=""color:#CAAA00"">g</strong></td><td data-col-seq=""3"">", ";")
        Dim b() As String = text.Split(";")
        text = b(1)

        If My.Settings.Normal = True Then
            text = text.Replace(",", "")
        ElseIf My.Settings.Thausand = True Then
            text = text.Replace(",", ".")
        ElseIf My.Settings.K = True Then
            text = text.Replace(",", ".")
            text = String.Format("{0:0,.0}K", CInt(text))
        End If
        Return text
    End Function
    Private Function GetTimeLeft(text As String)
        text = text.Replace("<td data-col-seq=""3"">", ";")
        text = text.Replace("</td><td data-col-seq=""4"">", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        Return text
    End Function
    Private Function GetBids(text As String)
        text = text.Replace("<td data-col-seq=""4"">", ";")
        text = text.Replace("</td><td data-col-seq=""5"">", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        Return text
    End Function
    Private Function GetRealmPrice(text As String)
        text = text.Replace("<td data-col-seq=""5"">", ";")
        text = text.Replace("</td><td data-col-seq=""6"">", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        Return text
    End Function
    Private Function GetGlobalPrice(text As String)
        text = text.Replace("<td data-col-seq=""6"">", ";")
        text = text.Replace("</td><td data-col-seq=""7"">", ";")
        text = text.Replace("<strong style=""color:#CAAA00"">g</strong> ", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        If text <> "0g" Then
            'text = text.Replace("<span class=""moneygold"">", ",")
            'text = text.Replace("</span>", ",")
            text = text.Replace("<td data-col-seq=""6"">", ";")
            text = text.Replace("<strong style=""color:#CAAA00"">g", ";")
            Dim c() As String = text.Split(";")
            'text = c(1)

            If My.Settings.Normal = True Then
                text = text.Replace(",", "")
            ElseIf My.Settings.Thausand = True Then
                text = text.Replace(",", ".")
            ElseIf My.Settings.K = True Then
                text = text.Replace(",", ".")
                text = String.Format("{0:0,.0}K", CInt(text))
            End If
        Else
            text = ""
        End If
        Return text
    End Function
    Private Function GetServerQty(text As String)
        text = text.Replace("</td><td data-col-seq=""7"">", ";")
        text = text.Replace("</td></tr>", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        Return text
    End Function
    Private Function GetLastUpdated(text As String)
        Return text
    End Function
    Private Function GetItemID(text As String)
        text = text.Replace("data-item=""", ";")
        text = text.Replace(""" data-icon=", ";")
        Dim b() As String = text.Split(";")
        text = b(1)
        Return text
    End Function
#End Region


#Region "Filter"
    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles Button_Filter.Click
        Filter()
        Button_ClearFilter.Enabled = True
    End Sub
    Private Sub ButtonClearFilter_Click(sender As Object, e As EventArgs) Handles Button_ClearFilter.Click
        ClearFilter()
        Button_ClearFilter.Enabled = False
    End Sub
    Private Sub Filter()
        Dim x As Integer = 0

        For Each ListViewItem In ListView1.Items
            If ListView1.Items(x).SubItems(1).Text.Contains(TextBox1.Text) Then
                ListView3.Items.Add(ListView1.Items(x).Clone)
            End If
            x += 1
        Next

        ListView1.Items.Clear()
        x = 0

        For Each ListViewItem In ListView3.Items
            ListView1.Items.Add(ListView3.Items(x).Clone)
            x += 1
        Next
        ListView3.Items.Clear()
    End Sub
    Private Sub ClearFilter()
        Dim x As Integer = 0

        ListView1.Items.Clear()
        For Each ListViewItem In ListView2.Items
            ListView1.Items.Add(ListView2.Items(x).Clone)
            x += 1
        Next
    End Sub
#End Region


#Region "Export"
    Public Sub ExportToTxt()
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("Server - Item - Current Bid - Minimum Bid - Time Left - No. Bids - Global Price")
        For Each Item As ListViewItem In ListView1.Items
            Dim txt As String = Item.Text & " - " & Item.SubItems(1).Text & " - " & Item.SubItems(2).Text & " - " & Item.SubItems(3).Text & " - " & Item.SubItems(4).Text & " - " & Item.SubItems(5).Text & " - " & Item.SubItems(7).Text
            sb.AppendLine(txt)
        Next

        If ComboBox1.SelectedIndex = 0 Then
            If ComboBox2.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt")
            End If
        End If

        If ComboBox1.SelectedIndex = 1 Then
            If ComboBox3.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".txt")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.txt")
            End If
        End If

    End Sub
    Public Sub ExportToCSV()
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("Server;Item;Current Bid;Minimum Bid;Time Left;No. Bids;Global Price")
        For Each Item As ListViewItem In ListView1.Items
            Dim txt As String = Item.Text & ";" & Item.SubItems(1).Text & ";" & Item.SubItems(2).Text & ";" & Item.SubItems(3).Text & ";" & Item.SubItems(4).Text & ";" & Item.SubItems(5).Text & ";" & Item.SubItems(7).Text
            sb.AppendLine(txt)
        Next

        If ComboBox1.SelectedIndex = 0 Then
            If ComboBox2.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv", sb.ToString())
                Process.Start("notepad.exe", My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & "Export.csv", sb.ToString())
                Process.Start("notepad.exe", My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")
            End If
        End If

        If ComboBox1.SelectedIndex = 1 Then
            If ComboBox3.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv", sb.ToString())
                Process.Start("notepad.exe", My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & "Export.csv", sb.ToString())
                Process.Start("notepad.exe", My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")
                System.Threading.Thread.Sleep(500)
                File.Delete(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")
            End If
        End If

    End Sub
    Public Sub ExportTOExcel()
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("Server;Item;Current Bid;Minimum Bid;Time Left;No. Bids;Global Price")
        For Each Item As ListViewItem In ListView1.Items
            Dim txt As String = Item.Text & ";" & Item.SubItems(1).Text & ";" & Item.SubItems(2).Text & ";" & Item.SubItems(3).Text & ";" & Item.SubItems(4).Text & ";" & Item.SubItems(5).Text & ";" & Item.SubItems(7).Text
            sb.AppendLine(txt)
        Next


        If ComboBox1.SelectedIndex = 0 Then
            If ComboBox2.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")
            End If
        End If


        If ComboBox1.SelectedIndex = 1 Then
            If ComboBox3.Text <> "" Then
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & ListView1.Items(0).Text & " " & Now.Date & " Export" & ".csv")
            Else
                File.AppendAllText(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv", sb.ToString())
                Process.Start(My.Application.Info.DirectoryPath & "\" & Now.Date & " Export.csv")

            End If
        End If
    End Sub
#End Region


#Region "Debug"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("https://www.tradeskillmaster.com/black-market?realm=US-aegwynn")
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36"
        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
        Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
        Dim httpContent As String = reader.ReadToEnd
        TextBox2.Text = httpContent
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RealmPrice.Width = 0
        RealmQty.Width = 0
        ItemID.Width = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        aProp.SetValue(ListView1, True, Nothing)
        Control.CheckForIllegalCrossThreadCalls = False
        GlobalPrice.Width = 80
        ItemID.Width = 0
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.ShowIcon = False
        Timer2.Enabled = False
    End Sub
    Private Sub Errorcheck()
        For Each zeile In TextBox2.Lines

        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'CheckingUpdates.Show()
        Process.Start("http://www.ownedcore.com/forums/world-of-warcraft/world-of-warcraft-bots-programs/554810-bmah-scanner.html")
    End Sub
#End Region
End Class
