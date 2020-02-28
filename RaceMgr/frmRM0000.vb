' Shell Author: Bob Desilets
' Modified by: Devin Brite
' Module Name: Form 0000
' Last Modified: 5/8/2017
' Module Description: Form 0000 is the main menu. It is used to access the other modules in the application.

Public Class frmRM0000

    Private Sub frmRM0000_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        grpCommand.Text = TimeOfDay
        frmRM1000.grpCommand.Text = TimeOfDay
        frmRM2000.grpCommand.Text = TimeOfDay
        frmRM3000.grpCommand.Text = TimeOfDay
        frmRM4000.grpCommand.Text = TimeOfDay
    End Sub

    Private Sub btnTeamMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeamMgr.Click
        UpdateTxtFilePaths()
        frmRM1000.Show()
        Me.Hide()
    End Sub

    Private Sub btnRunnerMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunnerMgr.Click
        UpdateTxtFilePaths()
        frmRM2000.Show()
        Me.Hide()
    End Sub

    Private Sub btnRaceMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaceMgr.Click
        frmRM3000.Show()
        Me.Hide()
    End Sub

    Private Sub btnResultsMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultsMgr.Click

        frmRM4000.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub UpdateTxtFilePaths()
        frmRM1000.txtFilePath.Text = Me.txtFilePath.Text
        frmRM2000.txtFilePath.Text = Me.txtFilePath.Text
    End Sub
End Class
