Imports System.ComponentModel

Public Class Settings
    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Normal = True Then
            RadioButton1.Checked = True
        ElseIf My.Settings.Thausand = True Then
            RadioButton2.Checked = True
        ElseIf My.Settings.K = True Then
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.Normal = True
            My.Settings.Thausand = False
            My.Settings.K = False
        ElseIf RadioButton2.Checked = True Then
            My.Settings.Normal = False
            My.Settings.Thausand = True
            My.Settings.K = False
        ElseIf RadioButton3.Checked = True Then
            My.Settings.Normal = False
            My.Settings.Thausand = False
            My.Settings.K = True
        End If

        Form1.ListView1.Items.Clear()
        Form1.ListView2.Items.Clear()
        Form1.ListView3.Items.Clear()
        Form1.ToolStripProgressBar1.Value = 0
        Form1.ToolStripStatusLabel1.Text = ""
        Form1.TextBox1.Text = ""
        Form1.Button_Filter.Enabled = False
        Form1.Button_ClearFilter.Enabled = False

        Me.Close()
    End Sub
End Class