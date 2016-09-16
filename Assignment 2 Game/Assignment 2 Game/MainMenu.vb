Public Class MainMenu

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GlobalVariables.level = 1
        GlobalVariables.timeLeft = 300
        GlobalVariables.lives = 3
        GlobalVariables.litterCount = 3
        GlobalVariables.vehicle1Speed = 0
        GlobalVariables.vehicle2Speed = 0
        GlobalVariables.vehicle3Speed = 0
        GlobalVariables.totalScore = 0
    End Sub

    Private Sub Playbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Playbtn.Click
        levels.Show()
        Me.Close()

    End Sub

    Private Sub Quitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitbtn.Click
        Application.Exit()
        End
    End Sub

    Private Sub Instructionsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instructionsbtn.Click
        Me.Hide()
        Instructions.show()
    End Sub
End Class