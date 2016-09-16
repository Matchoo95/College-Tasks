Public Class FrmHelp

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHelp.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicTable.Click

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        FrmGrades.Show()
        Me.Hide()

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Call FrmGrades.ResetToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Dim theResponse As Integer
        theResponse = MsgBox("Do you want to quit?", vbQuestion + vbYesNo, "")
        If theResponse = vbYes Then
            Close()
        End If
    End Sub
End Class