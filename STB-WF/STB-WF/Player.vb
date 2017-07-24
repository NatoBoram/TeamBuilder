<Serializable()>
Public Class Player
	Dim Name As String
	Dim Score As Double
	Public Sub New(NewName As String, NewScore As Double) ' New
		Name = NewName
		Score = NewScore
		If Score < 1 Then
			Score = 1
		End If
	End Sub
	Public Function GetScore() As Double
		Return Score
	End Function
	Public Sub Won(TeamScore As Double, EnemyScore As Double) ' Victory
		Score += Math.Pow(EnemyScore, 2) / (Score * TeamScore)
	End Sub
	Public Sub Loss(TeamScore As Double, EnemyScore As Double) ' Defeat
		Score -= (Score * TeamScore) / Math.Pow(EnemyScore, 2)
		If Score < 1 Then ' Minimum Score is 1
			Score = 1
		End If
	End Sub
	Public Overrides Function ToString() As String ' ToString
		Return Name
	End Function
End Class