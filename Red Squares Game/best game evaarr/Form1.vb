Public Class FrmSeclection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chbGame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbGame.CheckedChanged
        'If the textbox is empty then display a message box
        If txtName.Text = "" Then
            MsgBox("You must enter a name!", MsgBoxStyle.Information, "Name")
        Else
            'Otherwise, hide this form and display the new game form
            Me.Hide()
            FrmGame.Show()
        End If

    End Sub

    Public Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub LabelInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelInfo.Click

    End Sub
End Class
