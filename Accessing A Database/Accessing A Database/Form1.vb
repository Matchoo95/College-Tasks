Imports System.Data.OleDb
Public Class Background
    Dim DatabaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CourseworkDatabase.mdb")


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click



        DatabaseConnection.Open()
        Dim SearchDatabase As OleDbCommand = New OleDbCommand("SELECT * FROM BookDetails WHERE BookDetails.BookTitle ='" & EnterQuery.Text & "'", DatabaseConnection)
        Dim SearchResults As OleDbDataReader = SearchDatabase.ExecuteReader

        If SearchResults.HasRows Then
            SearchResults.Read()

            BookTitle.Text = SearchResults.Item("BookTitle").ToString
            BAuthor.Text = SearchResults.Item("BAuthor").ToString
            ISBN.Text = SearchResults.Item("ISBN").ToString




        End If
        DatabaseConnection.Close()

    End Sub
    Private Sub DeleteRecord()
        Dim Query As String
        Dim CMD As New OleDbCommand
        Query = "DELETE FROM BookDetails WHERE BookDetails.BookTitle='" & BookTitle.Text & "'"
        CMD = (New OleDbCommand(Query, DatabaseConnection))
        CMD.ExecuteNonQuery()
    End Sub


    Private Sub BookTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookTitle.TextChanged

    End Sub

    Private Sub BAuthor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAuthor.TextChanged

    End Sub

    Private Sub ISBN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISBN.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
