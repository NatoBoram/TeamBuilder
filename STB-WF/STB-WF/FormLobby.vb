Public Class FormLobby
	Public Team1 As List(Of Player)
	Public Team2 As List(Of Player)
	Private Sub Lobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		For Each Player As Player In Team1
			ListBoxTeam1.Items.Add(Player)
		Next
		For Each Player As Player In Team2
			ListBoxTeam2.Items.Add(Player)
		Next
	End Sub
	' And the winner is...
	Private Sub ButtonTeam1_Click(sender As Button, e As EventArgs) Handles ButtonTeam1.Click
		Victory(ListBoxTeam1, GetScore(ListBoxTeam1, ListBoxTeam2.Items.Count), GetScore(ListBoxTeam2, ListBoxTeam1.Items.Count))
		Defeat(ListBoxTeam2, GetScore(ListBoxTeam2, ListBoxTeam1.Items.Count), GetScore(ListBoxTeam1, ListBoxTeam2.Items.Count))
		Close()
	End Sub
	Private Sub ButtonTeam2_Click(sender As Button, e As EventArgs) Handles ButtonTeam2.Click
		Victory(ListBoxTeam2, GetScore(ListBoxTeam2, ListBoxTeam1.Items.Count), GetScore(ListBoxTeam1, ListBoxTeam2.Items.Count))
		Defeat(ListBoxTeam1, GetScore(ListBoxTeam1, ListBoxTeam2.Items.Count), GetScore(ListBoxTeam2, ListBoxTeam1.Items.Count))
		Close()
	End Sub
	' Get the average score of one team
	Private Function GetScore(Team As ListBox, EnemyTeam As Integer) As Double
		Dim TeamScore As Double
		For Each Player As Player In Team.Items
			TeamScore += Player.GetScore()
		Next
		Return TeamScore / EnemyTeam
	End Function
	' Victory!
	Private Sub Victory(Team As ListBox, TeamScore As Double, EnemyScore As Double)
		For Each Player As Player In Team.Items
			Player.Won(TeamScore, EnemyScore)
		Next
	End Sub
	' Defeat!
	Private Sub Defeat(Team As ListBox, TeamScore As Double, EnemyScore As Double)
		For Each Player As Player In Team.Items
			Player.Loss(TeamScore, EnemyScore)
		Next
	End Sub
	' Game over
	Private Sub FormLobby_Disposed(sender As Form, e As EventArgs) Handles Me.Closed
		FormMenu.Show()
	End Sub

	Private Sub ListBoxTeam1_DoubleClick(sender As ListBox, e As EventArgs) Handles ListBoxTeam1.DoubleClick

	End Sub

	' Double Click : Swap
	' KeyPress : Delete
End Class