
Public Class gameover

    Public Sub againbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles againbtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub gameoverquitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameoverquitbtn.Click
        Application.Exit()
        End
    End Sub

    Private Sub scorelbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scorelbl.Click

    End Sub

    Private Sub gameover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Used selection as this following code is a decision based on the value of GlobalVariables.Lives
        If GlobalVariables.lives > -1 Then
            gameoverTitle.Text = "Well Done!"
        ElseIf GlobalVariables.lives = -1 Then
            gameoverTitle.Text = "Game Over!"
        End If

        scorelbl.Text = GlobalVariables.totalScore

    End Sub
End Class