Public Class Form1

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            player2.Top = player2.Top - 8
        End If
        If e.KeyCode = Keys.Down Then
            player2.Top = player2.Top + 8
        End If
        If e.KeyCode = Keys.Left Then
            player2.Left = player2.Left - 8
        End If
        If e.KeyCode = Keys.Right Then
            player2.Left = player2.Left + 8
        End If
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Convert.ToInt32(Keys.D)) Then
            player1.Left = player1.Left + 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.W)) Then
            player1.Left = player1.Left - 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.A)) Then
            player1.Top = player1.Top + 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.S)) Then
            player1.Top = player1.Top - 8

        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finishLine.Click

    End Sub

    Private Sub player2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2.Click

    End Sub
End Class
