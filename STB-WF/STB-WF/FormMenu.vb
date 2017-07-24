Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class FormMenu
	Dim FileName As String = "data.bin"
	Dim Players As New List(Of Player)
	Dim LEVEL As String() = {"No Account", "Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7", "Level 8", "Level 9",
			"Level 10", "Level 11", "Level 12", "Level 13", "Level 14", "Level 15", "Level 16", "Level 17", "Level 18", "Level 19",
			"Level 20", "Level 21", "Level 22", "Level 23", "Level 24", "Level 25", "Level 26", "Level 27", "Level 28", "Level 29", "Unranked",
			"Bronze V", "Bronze IV", "Bronze III", "Bronze II", "Bronze I",
			"Silver V", "Silver IV", "Silver III", "Silver II", "Silver I",
			"Gold V", "Gold IV", "Gold III", "Gold II", "Gold I",
			"Platinum V", "Platinum IV", "Platinum III", "Platinum II", "Platinum I",
			"Diamond V", "Diamond IV", "Diamond III", "Diamond II", "Diamond I",
			"Master", "Challenger"}
	Private Sub FormMenu_Load(sender As Form, e As EventArgs) Handles MyBase.Load
		ComboBoxRank.Items.AddRange(LEVEL)
		Read()
		For Each Player In Players
			ListBoxPlayers.Items.Add(Player)
		Next
	End Sub
	Private Sub Read()
		If File.Exists(FileName) Then
			Dim TestFileStream As Stream = File.OpenRead(FileName)
			Dim deserializer As New BinaryFormatter
			Players = CType(deserializer.Deserialize(TestFileStream), List(Of Player))
			TestFileStream.Close()
		Else Write()
		End If
	End Sub
	Public Sub Write()
		Dim TestFileStream As Stream = File.Create(FileName)
		Dim serializer As New BinaryFormatter
		serializer.Serialize(TestFileStream, Players)
		TestFileStream.Close()
	End Sub
	' Add a player
	Private Sub ButtonAddPlayer_Click(sender As Button, e As EventArgs) Handles ButtonAddPlayer.Click
		TextBoxName.Text.Trim({CChar(" ")})
		' Check for empty
		If TextBoxName.Text = "" Or ComboBoxRank.Text = "" Then
			Return
		End If
		' Check for duplicate
		For Each Player As Player In Players
			If TextBoxName.Text = Player.ToString Then
				Return
			End If
		Next
		' Commit
		Players.Add(New Player(TextBoxName.Text, ComboBoxRank.SelectedIndex))
		ListBoxPlayers.Items.Add(Players(Players.Count - 1))
		' Clean text box
		TextBoxName.Text = ""
	End Sub
	' Remove a player
	Private Sub ButtonRemovePlayer_Click(sender As Button, e As EventArgs) Handles ButtonRemovePlayer.Click
		While Not IsNothing(ListBoxPlayers.SelectedItem)
			Players.Remove(ListBoxPlayers.SelectedItem)
			ListBoxPlayers.Items.Remove(ListBoxPlayers.SelectedItem)
		End While
	End Sub
	' Add to lobby
	Private Sub ButtonAddLobby_Click(sender As Button, e As EventArgs) Handles ButtonAddLobby.Click
		While Not IsNothing(ListBoxPlayers.SelectedItem)
			ListBoxLobby.Items.Add(ListBoxPlayers.SelectedItem)
			ListBoxPlayers.Items.Remove(ListBoxPlayers.SelectedItem)
		End While
	End Sub
	' Remove from lobby
	Private Sub ButtonRemoveLobby_Click(sender As Button, e As EventArgs) Handles ButtonRemoveLobby.Click
		While Not IsNothing(ListBoxLobby.SelectedItem)
			ListBoxPlayers.Items.Add(ListBoxLobby.SelectedItem)
			ListBoxLobby.Items.Remove(ListBoxLobby.SelectedItem)
		End While
	End Sub
	' Start!
	Private Sub ButtonStart_Click(sender As Button, e As EventArgs) Handles ButtonStart.Click
		' Get all players from the ListBox
		Dim Lobby As New List(Of Player)
		For Each Player As Player In ListBoxLobby.Items
			Lobby.Add(Player)
		Next
		' Create two teams
		Dim Team1 As New List(Of Player)
		Dim Team2 As New List(Of Player)
		' Distribute players
		While Lobby.Count > 0
			SelectWorstTeam(Team1, Team2).Add(SelectBestPlayer(Lobby))
			Lobby.Remove(SelectBestPlayer(Lobby))
		End While
		' Change form
		FormLobby.Team1 = Team1
		FormLobby.Team2 = Team2
		Hide()
		FormLobby.Show()
	End Sub
	' Select Best Player
	Private Function SelectBestPlayer(Lobby As List(Of Player)) As Player
		' Get the best score
		Dim BestScore As Double = 0
		For Each Player As Player In Lobby
			BestScore = Math.Max(BestScore, Player.GetScore)
		Next
		' Get the best players
		Dim BestPlayers As New List(Of Player)
		For Each Player As Player In Lobby
			If Player.GetScore = BestScore Then
				BestPlayers.Add(Player)
			End If
		Next
		' Select a random good player
		Dim generator As New Random
		Return BestPlayers(generator.Next(0, BestPlayers.Count))
	End Function
	' Select Worst Team
	Private Function SelectWorstTeam(Team1 As List(Of Player), Team2 As List(Of Player)) As List(Of Player)
		' Get Team 1 Score
		Dim Score1 As Double = 0
		For Each Player As Player In Team1
			Score1 += Player.GetScore
		Next
		' Get Team 2 Score
		Dim Score2 As Double = 0
		For Each Player As Player In Team2
			Score2 += Player.GetScore
		Next
		If Score1 = Score2 Then ' Same score?
			Dim generator As New Random
			Select Case generator.Next(1, 3)
				Case 1 : Return Team1
				Case 2 : Return Team2
			End Select
		ElseIf Score1 < Score2 Then ' Team 1?
			Return Team1
		ElseIf Score2 < Score1 Then ' Team 2?
			Return Team2
		End If
		Return Nothing ' Error
	End Function
	' Enter NewPlayer
	Private Sub AddPlayer_KeyPress(sender As Control, e As KeyPressEventArgs) Handles TextBoxName.KeyPress, ComboBoxRank.KeyPress
		If e.KeyChar = Chr(13) Then
			ButtonAddPlayer_Click(ButtonAddPlayer, e)
		End If
	End Sub
	' KeyDown Players
	Private Sub ListBoxPlayers_KeyPress(sender As ListBox, e As KeyEventArgs) Handles ListBoxPlayers.KeyDown
		If e.KeyCode = Keys.Enter Then
			ButtonAddLobby_Click(ButtonAddLobby, e)
		ElseIf e.KeyCode = Keys.Delete Then
			ButtonRemovePlayer_Click(ButtonRemovePlayer, e)
		End If
	End Sub
	' Double Click Players
	Private Sub ListBoxPlayers_DoubleClick(sender As ListBox, e As EventArgs) Handles ListBoxPlayers.DoubleClick
		ButtonAddLobby_Click(ButtonAddLobby, e)
	End Sub
	' KeyDown Lobby
	Private Sub ListBoxLobby_KeyPress(sender As ListBox, e As KeyEventArgs) Handles ListBoxLobby.KeyDown
		If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Back Then
			ButtonRemoveLobby_Click(ButtonRemoveLobby, e)
		End If
	End Sub
	' Double Click Lobby
	Private Sub ListBoxLobby_DoubleClick(sender As ListBox, e As EventArgs) Handles ListBoxLobby.DoubleClick
		ButtonRemoveLobby_Click(ButtonRemoveLobby, e)
	End Sub
    ' The End
    Private Sub FormMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Write()
    End Sub
End Class
