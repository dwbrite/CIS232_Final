' Shell Author: Bob Desilets
' Modified by: Devin Brite
' Module Name: Form 4000
' Last Modified: 5/8/2017
' Module Description: Form 4000 is used to calculate, display, and save the race information to a file. 

Imports System.IO
Public Class frmRM4000

    Private Sub frmRM4000_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmRM0000.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalculateResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateResults.Click
        lstTeamResults.Items.Clear()

        ' NumRunnersViewed = 7 runners to view (-1 for indexing)
        Dim numRunnersViewed = 7 - 1
        Dim numTeams As Integer = frmRM1000.lstTeam.Items.Count

        ' Array of existing teams, storing the team's school code.
        Dim teams(numTeams) As String
        ' Multidimensional array that stores the positions of runners in each team.
        Dim results(numTeams, numRunnersViewed) As Integer

        ' Fills the teams array with school codes.
        For team = 0 To numTeams - 1
            Dim strFullText As String = frmRM1000.lstTeam.Items.Item(team)
            teams(team) = strFullText.Substring(0, strFullText.IndexOf("|"))
            For player = 0 To numRunnersViewed
                results(team, player) = 0
            Next
        Next

        ' For each entered racer, add the position result to their respective team.
        Dim numEntries = frmRM3000.lstSyncTimeBibs.Items.Count
        For entry = 0 To numEntries - 1
            Dim strPlayerText As String = frmRM3000.lstSyncTimeBibs.Items.Item(entry)
            Dim intPos As Integer = (entry + 1)
            Dim strBib As String = strPlayerText.Split("-")(2).Trim()
            Dim strTeam As String = strPlayerText.Split("-")(3).Trim().Split("|")(0).Trim()

            Dim team As Integer = Array.IndexOf(teams, strTeam)

            If (team = -1) Then
                MsgBox("Team " + strTeam + " does not exist.", MsgBoxStyle.Critical, "Error")
                Return
            End If

            For player = 0 To numRunnersViewed
                If results(team, player) = 0 Then
                    results(team, player) = intPos
                    Exit For
                End If
            Next
        Next

        ' Calculate points in each team
        Dim points(numTeams - 1) As Integer
        For team = 0 To numTeams - 1
            For players = 0 To 4 'numRunnersViewed
                points(team) += results(team, players)
            Next
        Next

        Dim teamResults(numTeams - 1) As String
        For team = 0 To numTeams - 1
            'For each team, display total, display team code, display player scores.

            Dim strPlayerText As String = ""
            Dim strTeam As String = ""

            'Try
            strPlayerText = frmRM1000.lstTeam.Items.Item(team)
            strTeam = strPlayerText.Split("|")(0)
            'Catch ex As Exception

            'End Try

            Dim blnEmpty As Boolean = True
            teamResults(team) = "  " & points(team).ToString("D4") & vbTab & "     " & strTeam & vbTab
            ' For each player, add to team (that they BELONG TO)
            For players = 0 To numRunnersViewed
                Dim result As String = results(team, players).ToString("D3")
                Dim strResultToAppend As String
                If (result > 0) Then
                    blnEmpty = False
                Else
                    result = "---"
                End If

                If (players < numRunnersViewed) Then
                    strResultToAppend = " " & result & "  "
                Else
                    strResultToAppend = " " & result
                End If

                If blnEmpty Then
                    teamResults(team) = ""
                Else
                    teamResults(team) += strResultToAppend
                End If
            Next
        Next

        Array.Sort(teamResults)

        lstTeamResults.Items.Add("                      T E A M       R E S U L T S")
        lstTeamResults.Items.Add("[Points]    [Team Code] [P-1] [P-2] [P-3] [P-4] [P-5] [P-6] [P-7]")
        For i = 0 To numTeams - 1
            If (Not teamResults(i).Equals("")) Then
                lstTeamResults.Items.Add(teamResults(i))
            End If
        Next

        lstTeamResults.Items.Add("")
        lstTeamResults.Items.Add("             I N D I V I D U A L        R E S U L T S")
        lstTeamResults.Items.Add("==========================================================================")
        lstTeamResults.Items.Add("Pos.     Time      Bib   School         Runner")
        lstTeamResults.Items.Add("==========================================================================")


        For individuals = 0 To frmRM3000.lstSyncTimeBibs.Items.Count - 1
            Dim strSyncTimeBibs As String = frmRM3000.lstSyncTimeBibs.Items.Item(individuals)
            Dim posTimeBib() As String = strSyncTimeBibs.Split("-")
            Dim scodeName() As String = posTimeBib(3).Split("|")

            Dim individualResult As String = posTimeBib(0).Trim().PadLeft(3, "0") & "  - " & posTimeBib(1).Trim() & "  - " & posTimeBib(2).Trim() & "   " & scodeName(0).Trim() & vbTab & vbTab & scodeName(1).Trim() & " " & scodeName(2).Trim()
            lstTeamResults.Items.Add(individualResult)
        Next
        btnArchive.Enabled = True
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        Dim outfile As New System.IO.StreamWriter("C:\Bob\result.txt")
        Dim strFile As String = ""
        For row = 0 To lstTeamResults.Items.Count - 1
            strFile += lstTeamResults.Items.Item(row) & vbNewLine
        Next
        outfile.Write(strFile)
        outfile.Close()
        MsgBox("The file has been saved to C:\Bob\result.txt")
    End Sub
End Class