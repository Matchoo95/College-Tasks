Public Class enterTransactionDetails

    Private Sub enterTransactionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dropDownTxt1 As String
        Dim dropDownTxt2 As String
        Dim dropDownTxt3 As String

        dropDownTxt1 = GlobalVariables.custId
        custIdInput.Items.Add(GlobalVariables.custId)

        dropDownTxt2 = GlobalVariables.custTransId
        custTransIdInput.Items.Add(GlobalVariables.custId)

        dropDownTxt3 = GlobalVariables.stockId
        stockIdInput.Items.Add(GlobalVariables.stockId)



    End Sub

    Private Sub submitStockData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitTransactionData.Click

        If custTransIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf stockIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        End If


        GlobalVariables.custTransId = custTransIdInput.Text

        If custIdInput.Text <> GlobalVariables.custId Then
            MsgBox("Error when validating foreign key from customer account details, check foreign key and try again.")
        ElseIf custIdInput.Text = GlobalVariables.custId Then
        End If
        If stockIdInput.Text <> GlobalVariables.stockId Then
            MsgBox("Error when validationg foreign key from stock details, check foreign key and try again.")
        ElseIf stockIdInput.Text = GlobalVariables.stockId Then
        End If

        MsgBox("Data added succesfully")
    End Sub

    Private Sub custIdInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub stockIdInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub custTransInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub custTransIdInput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custTransIdInput.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class