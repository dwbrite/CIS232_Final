' Shell Author: Bob Desilets
' Modified by: Devin Brite
' Module Name: Form 3000
' Last Modified: 5/8/2017
' Module Description: Form 3000 is used to load race times from a file and enter and sync the corresponding bib numbers.

Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmRM3000

    Private Sub frmRM3000_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If lstSyncTimeBibs.Items.Count > 0 Then
            frmRM0000.btnResultsMgr.Enabled = True
        Else
            frmRM0000.btnResultsMgr.Enabled = False
        End If
        frmRM0000.Show()
        Me.Hide()

    End Sub

    Private Sub btnSyncTimesBibs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncTimesBibs.Click
        ' This button is disabled until both Times and Bibs have been entered.
        ' The associated list box is invisible until this buttom is pressed
        ' This routine merges Position | Time | Bib #

        Dim intPostion As Integer
        Dim subscript As Integer = 0
        Dim intcount As Integer = 0
        ' Dim item2 As String
        Dim strRunner As String = ""
        Dim strSchool As String = ""

        lstSyncTimeBibs.Items.Clear()
        For Each item As String In lstTimeEntry.Items
            strRunner = "Runner Not Found"
            strSchool = "School Not Found"
            ' find selected BIB #

            lstBibs.SelectedIndex = subscript
            intPostion = InStr(lstBibs.SelectedItem, "- ")
            strRunner = Trim(Mid(lstBibs.SelectedItem, intPostion + 2))
            ' Find School by stepping through lstPlayers
            intcount = lstBibs.Items.Count
            ' Debug.Print(intcount)
            ' Step through lstRoster looking for match of runner from lstPlace
            For Each item2 As String In frmRM2000.lstPlayers.Items
                ' Sample row layout -- lstRoster.Items.Add("A-SHS")
                If strRunner = Mid(item2, 1, 3) Then
                    strSchool = Mid(item2, 5)
                End If
            Next
            lstSyncTimeBibs.Items.Add(item & " - " & strRunner & " - " & strSchool)
            subscript += 1
            Me.Refresh()
        Next
    End Sub

    Private Sub btnEnterResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterResults.Click
        ' This routine loads the lstTeam box from an ASCII .txt file
        Try
            Dim strRow As String
            Dim bolFoundCode As Boolean = False
            Dim bolEndCode As Boolean = False
            Dim bolFoundDup As Boolean = False
            Dim textIn As StreamReader
            Dim intIndex As Integer = 0

            Try
                textIn = New StreamReader(
                New FileStream(txtFilePath.Text, FileMode.Open, FileAccess.Read))
                ' Clear Team listbox
                lstTimeEntry.Items.Clear()
            Catch ex As Exception
                MsgBox("Please enter a valid file.", MsgBoxStyle.Exclamation, "An error has occurred.")
                Return
            End Try

            Dim timeregex As Regex = New Regex("\d?\d:\d\d\.\d?\d")
            Do While textIn.Peek <> -1 And Not bolEndCode
                Me.Refresh()
                strRow = textIn.ReadLine.Trim

                If Not bolFoundCode Then
                    If "# TIME ".Equals(UCase(Mid(strRow, 1, 7))) Then
                        bolFoundCode = True
                    End If
                Else
                    If Not timeregex.IsMatch(strRow) Then
                        MsgBox("Invalid time value: " + strRow + ". Please correct the file and try again.", MsgBoxStyle.Exclamation)
                        lstTimeEntry.Items.Clear()
                        textIn.Close()
                        Throw New Exception("Invalid Time Value Exception")
                    End If
                    intIndex += 1
                    lstTimeEntry.Items.Add(intIndex & " - " & strRow)
                End If
            Loop
            btnEnterBib.Enabled = True
            textIn.Close()
        Catch
            MsgBox("Error Occurred while loading data.", MsgBoxStyle.Critical)
            btnEnterBib.Enabled = False
        End Try

    End Sub

    Private Sub txtFilePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilePath.TextChanged
        If txtFilePath.Text.Length > 0 Then
            btnEnterResults.Enabled = True
        Else
            btnEnterResults.Enabled = False
        End If
    End Sub

    Private Sub btnEnterBib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterBib.Click
        ' The btnBattingAverage click event accepts and displays up to 9 batting averages
        ' and then calculates and displays the team average.
        ' Declare and initialize variables

        Dim resFromScanner As MsgBoxResult = MsgBox("Would you like to enter the BIB numbers from a scanner?", MsgBoxStyle.YesNo, "BIB numbers from scanner?")
        Dim strFilePath As String
        Dim textIn As StreamReader
        Dim strRow As String
        Dim success As Boolean = False

        lstBibs.Items.Clear()

        If resFromScanner = MsgBoxResult.Yes Then
            strFilePath = InputBox("Where is the scanner file located? (.txt)", "Enter the location of the scanner file", "C:\Bob\scanner.txt")
            Try
                textIn = New StreamReader(
                    New FileStream(strFilePath, FileMode.Open, FileAccess.Read))
                ' Clear Team listbox
                lstBibs.Items.Clear()
            Catch ex As Exception
                MsgBox("Please enter a valid file.", MsgBoxStyle.Exclamation, "An error has occurred.")
                Return
            End Try
        Else
            GoTo NORMALOP
        End If

        ' Scanner method
        Dim counter = 0
        Do While textIn.Peek <> -1
            counter += 1
            Me.Refresh()
            strRow = textIn.ReadLine.Trim

            Dim str As String = InputBox("Enter the BIB #" & counter, "Enter the BIB Number", strRow).Trim()

            If (str = "") Then
                success = False
                textIn.Close()
                GoTo ENDOP
            End If

            Dim isDuplicate As Boolean = False
            For j As Integer = 1 To counter
                If (lstBibs.Items.Contains(j & " - " & str)) Then
                    isDuplicate = True
                End If
            Next

            Dim validBibNum As Boolean = False
            Dim strTemp As String = ""
            For j As Integer = 0 To frmRM2000.lstPlayers.Items.Count - 1
                strTemp = frmRM2000.lstPlayers.Items.Item(j).split("|")(0)
                If (strTemp.Equals(str)) Then
                    validBibNum = True
                    Exit For
                End If
            Next

            If (Not IsNumeric(str) Or isDuplicate Or Not validBibNum) Then
                MsgBox("Invalid number. Please do not enter duplicate bib numbers or bib numbers belonging to non-exisistent runners.", MsgBoxStyle.OkOnly)
                textIn.Close()
                GoTo ENDOP
            Else
                lstBibs.Items.Add(counter & " - " & str)
            End If

            If (counter = lstTimeEntry.Items.Count) Then
                success = True
                textIn.Close()
                GoTo ENDOP
            End If
        Loop

NORMALOP:
        ' Normal method
        For i As Integer = 1 To lstTimeEntry.Items.Count
            Dim str As String = InputBox("Enter the BIB #" & i, "Enter the BIB Number", 100 + i).Trim()

            If (str = "") Then
                success = False
                Exit For
            End If

            Dim isDuplicate As Boolean = False
            For j As Integer = 1 To i
                If (lstBibs.Items.Contains(j & " - " & str)) Then
                    isDuplicate = True
                End If
            Next

            Dim validBibNum As Boolean = False
            Dim strTemp As String = ""
            For j As Integer = 0 To frmRM2000.lstPlayers.Items.Count - 1
                strTemp = frmRM2000.lstPlayers.Items.Item(j).split("|")(0)
                If (strTemp.Equals(str)) Then
                    validBibNum = True
                    Exit For
                End If
            Next


            If (Not IsNumeric(str) Or isDuplicate Or Not validBibNum) Then
                i -= 1
                MsgBox("Invalid number. Please do not enter duplicate bib numbers or bib numbers belonging to non-exisistent runners.", MsgBoxStyle.OkOnly)
            Else
                lstBibs.Items.Add(i & " - " & str)
            End If

            If (i = lstTimeEntry.Items.Count) Then
                success = True
            End If
        Next

ENDOP:
        If (success) Then
            btnSyncTimesBibs.Enabled = True
        Else
            MsgBox("Operation Cancelled.", MsgBoxStyle.Exclamation)
            lstBibs.Items.Clear()
        End If
        frmRM4000.btnArchive.Enabled = False
    End Sub

End Class