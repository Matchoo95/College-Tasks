Public Class FrmDOLOOP
    Private Sub clearTHElist()
        lbxNumbers.Items.Clear()
    End Sub

    Private Sub cmdForLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdForLoop.Click
        Dim ObjRandom As New Random
        Dim intRandomNumber As Integer = 0
        clearTHElist()
        Do Until intRandomNumber = 25
            intRandomNumber = ObjRandom.Next(100)
            lbxNumbers.Items.Add(intRandomNumber.ToString)
        Loop
    End Sub

    Private Sub PrecheckWhileLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecheckWhileLoopToolStripMenuItem.Click
        Me.Hide()
        FrmWHILELOOP.Show()
    End Sub

    Private Sub ForLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForLoopToolStripMenuItem.Click
        Me.Hide()
        FrmFORLOOP.Show()

    End Sub
End Class
