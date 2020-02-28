' Shell Author: Bob Desilets
' Modified by: Devin Brite
' Module Name: Form 2000
' Last Modified: 5/8/2017
' Module Description: Form 2000 is used to load runners from a file, add new runners, and delete runners from the roster. 

Imports System.IO
Public Class frmRM2000

    Private Sub frmRM2000_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If frmRM1000.lstTeam.Items.Count > 0 And lstPlayers.Items.Count > 0 Then
            frmRM0000.btnRaceMgr.Enabled = True
        Else
            frmRM0000.btnRaceMgr.Enabled = False
        End If
        UpdateTxtFilePaths()
        frmRM0000.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoadRunners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRunners.Click
        ' This routine loads the lstRunner box from an ASCII .txt file

        ' This routine loads the lstPlayers box from an ASCII .txt file
        ' # Roster [Bib #|School Code|Runner's F-Name|Runner's L-Name]

        Dim strRow As String
        Dim bolFoundCode As Boolean = False
        Dim bolEndCode As Boolean = False
        Dim bolFoundDup As Boolean = False
        Dim intPosition As Integer
        Dim intPosition2
        Dim strRunnerCodeIn As String
        Dim textIn As StreamReader
        Try
            textIn = New StreamReader(
                New FileStream(txtFilePath.Text, FileMode.Open, FileAccess.Read))
            ' Clear Team listbox
            lstPlayers.Items.Clear()
        Catch ex As Exception
            MsgBox("Please enter a valid file.", MsgBoxStyle.Exclamation, "An error has occurred.")
            Return
        End Try

        Do While textIn.Peek <> -1 And Not bolEndCode
            Me.Refresh()
            strRow = textIn.ReadLine.Trim
            If Not bolFoundCode Then
                If "# ROSTER ".Equals(UCase(Mid(strRow, 1, 9))) Then
                    bolFoundCode = True
                End If
            Else
                If Not Mid(strRow, 1, 2).Equals("# ") Then
                    For Each item As String In lstPlayers.Items
                        intPosition = InStr(1, strRow, "|")
                        strRunnerCodeIn = Mid(strRow, 1, intPosition - 1)
                        intPosition2 = InStr(1, item, strRunnerCodeIn)
                        If intPosition2 > 0 Then
                            bolFoundDup = True
                        End If
                    Next
                    If Not bolFoundDup Then
                        lstPlayers.Items.Add(strRow)
                    Else
                        lstPlayers.Items.Add("DUPLICATE BIB #: " & strRow)
                        lstPlayers.Items.Add("Please correct input file and reload runners")
                        bolEndCode = True
                    End If
                End If
            End If
        Loop
    End Sub

    Private Sub btnAddRunners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRunners.Click
        ' This routine loops through a msg box prompting the user for Bib # | School Code | Name
        ' You must scan the existing runner's Bib #s for duplicates... Force the user 
        ' to enter a new number
        'MsgBox("This routine loops through a msg box prompting the user for Bib # | School Code| F-Name | L-Name... You must scan the existing runner's Bib #s for duplicates... Force the user to enter a new number")

        grpAddRunner.Visible = True
        grpAddRunner.Enabled = True
        grpCommand.Enabled = False
        grpBoxFile.Enabled = False
        CheckListEmpty()
    End Sub

    Private Sub btnDeleteRunner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRunner.Click
        'This routine removes a runner from the list based on the entered Bib #... Perform typical validation...Make sure to ask Are You Sure?
        Dim intSelected As Integer = lstPlayers.SelectedIndex
        If intSelected = -1 Then
            MsgBox("No item selected.", MsgBoxStyle.Exclamation, "Delete Runners Confirmation")
            Return
        End If

        Dim response As MsgBoxResult = MsgBox("Are you sure you want to delete " & lstPlayers.SelectedItem & "?",
                                               MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question,
                                              "Delete Runners Confirmation")
        If response = MsgBoxResult.Ok Then
            lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex)
        Else
            MsgBox("No items were removed.", MsgBoxStyle.Exclamation, "Delete Runners Confirmation")
        End If
        CheckListEmpty()
    End Sub

    Private Sub frmRM2000_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub

    Private Sub frmRM2000_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub

    Private Sub CheckListEmpty()
        If (lstPlayers.Items.Count = 0) Then
            btnDeleteRunner.Enabled = False
        Else
            btnDeleteRunner.Enabled = True
        End If
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

    Private Sub btnSaveNewRunner_Click(sender As Object, e As EventArgs) Handles btnSaveNewRunner.Click
        ' Verify inputs, then add them to the list.
        Dim strText As String = ""
        Dim strResult As String = ""
        Dim strErrors As String = ""
        Dim intBibNum As Integer = 0


        strText = Trim(txtBib.Text())
        VerifyText(strText, strResult, strErrors, " [BIB #]", False)
        If (Integer.TryParse(strText, intBibNum)) Then
            For Each item In lstPlayers.Items
                Dim strItemBibId As String = item.Substring(0, item.IndexOf("|"))
                If (strText.Equals(strItemBibId)) Then
                    MsgBox("Found Duplicate BIB #: " & strText, MsgBoxStyle.Exclamation, "An error has occurred.")
                    Return
                End If
            Next
        Else
            MsgBox("Please enter a valid BIB number.", MsgBoxStyle.Exclamation, "An error has occurred.")
            Return
        End If

        strText = Trim(txtSchoolCode.Text().ToUpper)
        VerifyText(strText, strResult, strErrors, " [School Code]", False)

        strText = Trim(txtRunnerFname.Text())
        VerifyText(strText, strResult, strErrors, " [Runner F-Name]", False)

        strText = Trim(txtRunnerLname.Text())
        VerifyText(strText, strResult, strErrors, " [Runner L-Name]", True)

        If (strErrors.Equals("")) Then
            lstPlayers.Items.Add(strResult)
            btnDeleteRunner.Enabled = True
            ClearAddRunner()
            txtSchoolCode.Focus()
        Else
            MsgBox("The following fields contain errors:" & strErrors & ". Please fix them before continuing.", MsgBoxStyle.Exclamation, "An error has occurred.")
        End If
    End Sub

    Private Sub btnCancelNewRunner_Click(sender As Object, e As EventArgs) Handles btnCancelNewRunner.Click
        grpAddRunner.Visible = False
        grpAddRunner.Enabled = False
        grpCommand.Enabled = True
        grpBoxFile.Enabled = True

        ClearAddRunner()
    End Sub

    Private Sub ClearAddRunner()
        txtSchoolCode.Clear()
        txtBib.Clear()
        txtRunnerFname.Clear()
        txtRunnerLname.Clear()
    End Sub

    Private Sub btnRefreshNewRunner_Click(sender As Object, e As EventArgs) Handles btnRefreshNewRunner.Click
        ClearAddRunner()
    End Sub

    Private Sub UpdateTxtFilePaths()
        frmRM0000.txtFilePath.Text = Me.txtFilePath.Text
        frmRM1000.txtFilePath.Text = Me.txtFilePath.Text
    End Sub

End Class