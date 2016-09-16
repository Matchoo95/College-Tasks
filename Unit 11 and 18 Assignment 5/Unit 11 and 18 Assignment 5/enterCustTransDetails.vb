Imports System.Data.OleDb

Public Class enterCustTransDetails

    Private Sub enterCustAccDetailsTitl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterCustTransDetailsTitl.Click

    End Sub

    Private Sub submitCustTransData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitCustTransData.Click

        Dim databaseConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=assignment5database.accdb")
        Dim InsertToDb As New OleDb.OleDbCommand
        Dim dateOfTrans As Date


        If custIdInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        ElseIf dobInput.Text = String.Empty Then
            MsgBox("Some fields are still blank, please enter the correct information in to all fields before continuing.")
        End If

        dobInput.Text = dateOfTrans


        databaseConnection.Open()

        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "ID"
        InsertToDb.Parameters.Item("ID").Value = GlobalVariables.custId
        InsertToDb.Parameters.Add(InsertToDb.CreateParameter).ParameterName = "dateOfTransaction"
        InsertToDb.Parameters.Item("dateOfTransaction").Value = dateOfTrans


        InsertToDb.CommandText = "INSERT INTO CustomerAccountDetails VALUES (custFullName, custAddress, custLandline, custMobile, custDOB, custCreditDetails, ID);"
        InsertToDb.CommandType = CommandType.Text
        InsertToDb.Connection = databaseConnection
        InsertToDb.ExecuteNonQuery()

        databaseConnection.Close()




        MsgBox("Data added succesfully")

    End Sub

    Private Sub custIdInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub custIdInput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custIdInput.SelectedIndexChanged


    End Sub

    Private Sub enterCustTransDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim databaseConnection As New OleDb.OleDbConnection
        Dim counter As Integer

        databaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=assignment5database.accdb"

        databaseConnection.Open()

        Dim searchDatabase As OleDbCommand = New OleDbCommand("SELECT CustomerAccountDetails.ID FROM CustomerAccountDetails WHERE CustomerAccountDetails.ID", databaseConnection)
        Dim searchResults As OleDbDataReader = searchDatabase.ExecuteReader

        If searchResults.HasRows Then
            Do While searchResults.Read()
                custIdInput.Items.Add(searchResults.Item(0))
                counter = counter + 1
            Loop
        ElseIf searchResults.HasRows = False Then
            MsgBox("Error retrieving data, requested table contains no records.")
        End If
        databaseConnection.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub dobInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dobInput.TextChanged

    End Sub
End Class