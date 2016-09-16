Imports System.Data.OleDb
Public Class Form1

    Private Sub queryEntryBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Query_Entry.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mainMenuOptions.Items.Add("Enter Customer Account Details")
        mainMenuOptions.Items.Add("Enter Customer Transaction Details")
        mainMenuOptions.Items.Add("Enter Stock Details")
        mainMenuOptions.Items.Add("Enter Supplier Details")
        mainMenuOptions.Items.Add("Enter Transaction Details")



    End Sub

    Private Sub mainMenuOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainMenuOptions.SelectedIndexChanged

    End Sub

    Private Sub mainMenuSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainMenuSubmit.Click
        If mainMenuOptions.Text = "Enter Customer Account Details" Then
            enterCustomerAccountDetails.Show()
            Me.Hide()
        ElseIf mainMenuOptions.Text = "Enter Customer Transaction Details" Then
            enterCustTransDetails.Show()
            Me.Hide()
        ElseIf mainMenuOptions.Text = "Enter Stock Details" Then
            enterStockDetails.Show()
            Me.Hide()
        ElseIf mainMenuOptions.Text = "Enter Supplier Details" Then
            enterSupplierDetails.Show()
            Me.Hide()
        ElseIf mainMenuOptions.Text = "Enter Transaction Details" Then
            enterTransactionDetails.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub mainMenuTtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainMenuTtl.Click

    End Sub
End Class

Public Class GlobalVariables
    Public Shared custId As Integer
    Public Shared suppId As Integer
    Public Shared stockId As Integer
    Public Shared custTransId As Integer

End Class
