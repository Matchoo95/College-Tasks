Public Class enterSupplierDetails

    Private Sub submitSuppData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitSuppData.Click
        Dim supplierName As String
        Dim supplierAddress As String
        Dim supplierLandline As Integer


        If suppNameInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf suppAddressInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf suppLandlineInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        End If

        supplierName = suppNameInput.Text
        supplierAddress = suppAddressInput.Text
        supplierLandline = suppLandlineInput.Text
        GlobalVariables.suppId = suppIdInput.Text

        MsgBox("Data added succesfully")
    End Sub

    Private Sub enterSupplierDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub enterSupplierDetailsTitl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterSupplierDetailsTitl.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppIdInput.TextChanged

    End Sub
End Class