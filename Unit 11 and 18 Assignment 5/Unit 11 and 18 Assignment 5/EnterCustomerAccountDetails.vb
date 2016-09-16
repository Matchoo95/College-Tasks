
Public Class enterCustomerAccountDetails
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitCustAccData.Click

        Dim databaseConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=assignment5database.accdb")
        Dim InsertToDb As New OleDb.OleDbCommand
        Dim custName As String
        Dim custAddress As String
        Dim custCredit As String
        Dim custDob As String
        Dim custLandline As String
        Dim custMobile As String

        If custNameInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custAddressInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custCreditInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custDobInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custLandlineInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custMobileInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf custIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        End If

        custName = custNameInput.Text
        custAddress = custAddressInput.Text
        custCredit = custCreditInput.Text
        custDob = custDobInput.Text
        custLandline = custLandlineInput.Text
        custMobile = custMobileInput.Text

        GlobalVariables.custId = custIdInput.Text

        databaseConnection.Open()

        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "ID"
        InsertToDb.Parameters.Item("ID").Value = GlobalVariables.custId
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custFullName"
        InsertToDb.Parameters.Item("custFullName").Value = custName
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custAddress"
        InsertToDb.Parameters.Item("custAddress").Value = custAddress
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custLandline"
        InsertToDb.Parameters.Item("custLandline").Value = custLandline
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custMobile"
        InsertToDb.Parameters.Item("custMobile").Value = custMobile
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custDOB"
        InsertToDb.Parameters.Item("custDOB").Value = custDob
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "custCreditDetails"
        InsertToDb.Parameters.Item("custCreditDetails").Value = custCredit

        InsertToDb.CommandText = "INSERT INTO CustomerAccountDetails VALUES (custFullName, custAddress, custLandline, custMobile, custDOB, custCreditDetails, ID);"
        InsertToDb.CommandType = CommandType.Text
        InsertToDb.Connection = databaseConnection
        InsertToDb.ExecuteNonQuery()
    
        databaseConnection.Close()

        MsgBox("Data added succesfully")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub custNameInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custNameInput.TextChanged

    End Sub

    Private Sub enterCustomerAccountDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub enterCustAccDetailsTitl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterCustAccDetailsTitl.Click

    End Sub
End Class