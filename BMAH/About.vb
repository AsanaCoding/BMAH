Imports System.ComponentModel

Public Class About
    Private Sub About_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.tradeskillmaster.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://eu.battle.net/wow/de/character/Blackhand/Tr%C3%ACss/advanced")
        Process.Start("http://www.elitepvpers.com/forum/members/2222233-flexyo.html")
        Process.Start("http://www.ownedcore.com/forums/members/842024-asana.html")
    End Sub
End Class