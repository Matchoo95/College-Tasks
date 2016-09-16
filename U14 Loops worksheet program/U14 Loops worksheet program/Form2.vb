Public Class FrmFORLOOP

    Private Sub cmdRunLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRunLoop.Click
        Dim intCount As Integer
        For intCount = 0 To 4
            MessageBox.Show("Counter is currently: " + CStr(intCount))
            lblImages.Image = imageList1.Images(intCount)
        Next intCount
    End Sub

    Private Sub PrecheckWhileLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecheckWhileLoopToolStripMenuItem.Click
        Me.Hide()
        FrmWHILELOOP.Show()
    End Sub

    Private Sub PostcheckDoLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostcheckDoLoopToolStripMenuItem.Click
        Me.Hide()
        FrmDOLOOP.Show()
    End Sub
End Class