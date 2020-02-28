' Shell Author: Bob Desilets
' Modified by: Devin Brite
' Module Name: Form 1000
' Last Modified: 5/8/2017
' Module Description: Form 1000 is used to load teams from a file, add new teams, and delete teams from the roster. 

Imports System.IO
Public Class frmRM1000

    Private Sub frmRM1000_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If lstTeam.Items.Count > 0 And frmRM2000.lstPlayers.Items.Count > 0 Then
            frmRM0000.btnRaceMgr.Enabled = True
        Else
            frmRM0000.btnRaceMgr.Enabled = False
        End If
        UpdateTxtFilePaths()
        frmRM0000.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoadTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadTeam.Click
        ' This routine loads the lstTeam box from an ASCII .txt file
        ' # School [School Code | Name | Coach F-Name| Coach L-Name | AD F-Name | AD L-Name]

        Dim strRow As String
        Dim bolFoundCode As Boolean = False
        Dim bolEndCode As Boolean = False
        Dim bolFoundDup As Boolean = False
        Dim intPosition As Integer
        Dim intPosition2
        Dim strTeamCodeIn As String
        Dim textIn As StreamReader
        Try
            textIn = New StreamReader(
                New FileStream(txtFilePath.Text, FileMode.Open, FileAccess.Read))
            ' Clear Team listbox
            lstTeam.Items.Clear()
        Catch ex As Exception
            MsgBox("Please enter a valid file.", MsgBoxStyle.Exclamation, "An error has occurred.")
            Return
        End Try

        Do While textIn.Peek <> -1 And Not bolEndCode
            Me.Refresh()
            strRow = textIn.ReadLine.Trim
            If Not bolFoundCode Then
                If "# SCHOOL ".Equals(UCase(Mid(strRow, 1, 9))) Then
                    bolFoundCode = True
                End If
            Else
                If Not Mid(strRow, 1, 2).Equals("# ") Then
                    For Each item As String In lstTeam.Items
                        intPosition = InStr(1, strRow, "|")
                        strTeamCodeIn = Mid(strRow, 1, intPosition - 1)
                        intPosition2 = InStr(1, item, strTeamCodeIn)
                        If intPosition2 > 0 Then
                            bolFoundDup = True
                            MsgBox("Found Duplicate School Code: " & strTeamCodeIn)
                        End If
                    Next
                    If Not bolFoundDup Then
                        lstTeam.Items.Add(strRow)
                    Else
                        lstTeam.Items.Add("DUPLICATE School Code: " & strRow)
                        lstTeam.Items.Add("Please correct input file and reload teams")
                        bolEndCode = True
                    End If
                Else
                    bolEndCode = True
                End If
            End If
        Loop
        CheckListEmpty()
    End Sub

    Private Sub btnDeleteTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTeam.Click
        'This routine removes a Team from the list based on the entered Team Code.. Perform typical validation...
        'MsgBox("This routine removes a Team from the list based on the entered Team Code... Perform typical validation...Make sure to ask Are You Sure?")
        Dim intSelected As Integer = lstTeam.SelectedIndex
        If intSelected = -1 Then
            MsgBox("No item selected.", MsgBoxStyle.Exclamation, "Delete Team Confirmation")
            Return
        End If

        Dim response As MsgBoxResult = MsgBox("Are you sure you want to delete " & lstTeam.SelectedItem & "?",
                                               MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question,
                                              "Delete Team Confirmation")
        If response = MsgBoxResult.Ok Then
            lstTeam.Items.RemoveAt(lstTeam.SelectedIndex)
        Else
            MsgBox("No items were removed.", MsgBoxStyle.Exclamation, "Delete Team Confirmation")
        End If
        CheckListEmpty()
    End Sub

    Private Sub frmRM1000_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If txtFilePath.Text.Trim = "" Then
        ' txtFilePath.Text = frmRM0000.txtFilePath.Text
        'End If
    End Sub

    Private Sub CheckListEmpty()
        If (lstTeam.Items.Count = 0) Then
            btnDeleteTeam.Enabled = False
        Else
            btnDeleteTeam.Enabled = True
        End If
    End Sub

    Private Sub btnAddTeam_Click(sender As Object, e As EventArgs) Handles btnAddTeam.Click
        grpAddTeam.Visible = True
        grpAddTeam.Enabled = True
        grpCommand.Enabled = False
        grpBoxFile.Enabled = False
        CheckListEmpty()
    End Sub

    Private Sub btnSaveTeam_Click(sender As Object, e As EventArgs) Handles btnSaveNewTeam.Click
        ' Verify inputs, then add them to the list.
        Dim strText As String = ""
        Dim strResult As String = ""
        Dim strErrors As String = ""

        strText = Trim(txtSchoolCode.Text().ToUpper)
        VerifyText(strText, strResult, strErrors, " [School Code]", False)
        For Each item As String In lstTeam.Items
            Dim strSchoolCode As String = item.Substring(0, item.IndexOf("|"))
            If strSchoolCode.Equals(strText) Then
                MsgBox("Found Duplicate School Code: " & strText, MsgBoxStyle.Exclamation, "An error has occurred.")
                Return
            End If
        Next

        strText = Trim(txtSchoolName.Text())
        VerifyText(strText, strResult, strErrors, " [School Name]", False)


        strText = Trim(txtCoachFirst.Text())
        VerifyText(strText, strResult, strErrors, " [Coach F-Name]", False)

        strText = Trim(txtCoachLast.Text())
        VerifyText(strText, strResult, strErrors, " [Coach L-Name]", False)


        strText = Trim(txtAdFirst.Text())
        VerifyText(strText, strResult, strErrors, " [AD F-Name]", False)

        strText = Trim(txtAdLast.Text())
        VerifyText(strText, strResult, strErrors, " [AD L-Name]", True)

        If (strErrors.Equals("")) Then
            lstTeam.Items.Add(strResult)
            btnDeleteTeam.Enabled = True
            ClearAddTeam()
            txtSchoolCode.Focus()
        Else
            MsgBox("The following fields contain errors:" & strErrors & ". Please fix them before continuing.", MsgBoxStyle.Exclamation, "An error has occurred.")
        End If
    End Sub

    Private Sub btnCancelNewTeam_Click(sender As Object, e As EventArgs) Handles btnCancelNewTeam.Click
        grpAddTeam.Visible = False
        grpAddTeam.Enabled = False
        grpCommand.Enabled = True
        grpBoxFile.Enabled = True

        ClearAddTeam()
    End Sub

    Private Sub btnRefreshNewTeam_Click(sender As Object, e As EventArgs) Handles btnRefreshNewTeam.Click
        ClearAddTeam()
    End Sub

    Private Sub ClearAddTeam()
        txtSchoolCode.Clear()
        txtSchoolName.Clear()
        txtCoachFirst.Clear()
        txtCoachLast.Clear()
        txtAdFirst.Clear()
        txtAdLast.Clear()
    End Sub

    Private Sub VerifyText(strText As String, ByRef strResult As String, ByRef strErrors As String, strError As String, blnLast As Boolean)
        If (strText.Count < 1) Then
            strErrors += strError
        Else
            If (blnLast) Then
                strResult += strText
            Else
                strResult += strText & "|"
            End If
        End If
    End Sub

    Private Sub UpdateTxtFilePaths()
        frmRM0000.txtFilePath.Text = Me.txtFilePath.Text
        frmRM2000.txtFilePath.Text = Me.txtFilePath.Text
    End Sub
End Class