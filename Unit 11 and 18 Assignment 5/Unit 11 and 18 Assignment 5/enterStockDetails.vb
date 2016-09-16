Public Class enterStockDetails

    Private Sub submitStockData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitStockData.Click

        Dim stockName As String
        Dim stockDesc As String
        Dim stockPrice As Decimal

        If stockNameInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf stockDescInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf stockPriceInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf suppIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        End If

        If suppIdInput.Text <> GlobalVariables.suppId Then
            MsgBox("Error when validationg foreign key from supplier details, check foreign key and try again.")
        ElseIf suppIdInput.Text = GlobalVariables.suppId Then
        End If

        stockName = stockNameInput.Text
        stockDesc = stockDescInput.Text
        stockPrice = stockPriceInput.Text

        MsgBox("Data added succesfully")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppIdInput.SelectedIndexChanged

    End Sub

    Private Sub enterStockDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dropDownTxt As String

        dropDownTxt = GlobalVariables.suppId

        suppIdInput.Items.Add(GlobalVariables.suppId)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class