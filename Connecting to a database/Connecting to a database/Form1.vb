Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PLantsDataSet.PlantyStuffTable' table. You can move, or remove it, as needed.
        Me.PlantyStuffTableTableAdapter.Fill(Me.PLantsDataSet.PlantyStuffTable)

    End Sub


    Private Sub SearchEventAbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEventAbtn.Click


        DatabaseConnection.Open()
        Dim SearchDatabase As OleDbCommand = New OleDbCommand("SELECT plantName.PlantName, BadgeClauses.Clause FROM BadgeClauses WHERE BadgeClauses.BadgeName = '" & SBNametxt.Text & "'", DatabaseConnection)
        Dim SearchResults As OleDbDataReader = SearchDatabase.ExecuteReader



        If SearchResults.HasRows Then
            SearchResults.Read()
            plantName = SearchResults.Item("Plant Name").ToString
            seasonToPlant = SearchResults.Item("Season to plant").ToString
            seasonToFlower = SearchResults.Item("Season to flower").ToString
            typeOfPlant = SearchResults.Item("Type").ToString
            SearchResults.Show()
            Me.Close()
        Else
            MsgBox("No Record found")
        End If

        DatabaseConnection.Close()
    End Sub
    End Sub
End Class
