Public Class FrmWHILELOOP

    Private Sub cmdRunLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRunLoop.Click
        Dim counter As Integer = 0
        Dim TheMax As Integer = txtMaxNumber.Text
        While counter < TheMax
            counter += 1
            lblCounter.Text = counter
            MsgBox("While loop ran " & CStr(counter) & " times")
        End While
    End Sub

    Private Sub PostcheckDoLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostcheckDoLoopToolStripMenuItem.Click
        Me.Hide()
        FrmDOLOOP.Show()
    End Sub

    Private Sub ForLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForLoopToolStripMenuItem.Click
        Me.Hide()
        FrmFORLOOP.Show()
    End Sub
End Class