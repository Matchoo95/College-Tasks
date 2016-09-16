Public Class Form1

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        MsgBox("I am a regular message box")
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        MsgBox("I am an information box", vbInformation)
    End Sub

    Private Sub btnCritical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCritical.Click
        MsgBox("I am a critical box with a title", vbCritical, "Your title here")
    End Sub

    Private Sub btnExclam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExclam.Click
        MsgBox("I am an exclamation box with a Yes/No option and a title", vbExclamation + vbYesNo, "Title here")
    End Sub

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        MsgBox("I am a question box with a Yes/No and a Cancel Option", vbQuestion + vbYesNoCancel, "Your title")
    End Sub

    Private Sub btnYesNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYesNo.Click
        Dim theResponse As Integer
        theResponse = MsgBox("Do you want to quit?", vbQuestion + vbYesNo, "Quiter")
        If theResponse - vbNo Then
            MsgBox("Okay", vbExclamation, "Goodbye")
            End
        Else
            MsgBox("Thanks for staying", , "Good choice")
        End If
    End Sub
End Class
