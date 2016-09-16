<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Background
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Search = New System.Windows.Forms.Button
        Me.EnterQuery = New System.Windows.Forms.TextBox
        Me.BookTitle = New System.Windows.Forms.TextBox
        Me.BAuthor = New System.Windows.Forms.TextBox
        Me.ISBN = New System.Windows.Forms.TextBox
        Me.SearchText = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Delete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(445, 114)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(172, 90)
        Me.Search.TabIndex = 0
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'EnterQuery
        '
        Me.EnterQuery.Location = New System.Drawing.Point(428, 223)
        Me.EnterQuery.Name = "EnterQuery"
        Me.EnterQuery.Size = New System.Drawing.Size(211, 20)
        Me.EnterQuery.TabIndex = 1
        '
        'BookTitle
        '
        Me.BookTitle.Location = New System.Drawing.Point(153, 399)
        Me.BookTitle.Name = "BookTitle"
        Me.BookTitle.Size = New System.Drawing.Size(209, 20)
        Me.BookTitle.TabIndex = 2
        '
        'BAuthor
        '
        Me.BAuthor.Location = New System.Drawing.Point(428, 399)
        Me.BAuthor.Name = "BAuthor"
        Me.BAuthor.Size = New System.Drawing.Size(205, 20)
        Me.BAuthor.TabIndex = 3
        '
        'ISBN
        '
        Me.ISBN.Location = New System.Drawing.Point(702, 399)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(208, 20)
        Me.ISBN.TabIndex = 4
        '
        'SearchText
        '
        Me.SearchText.AutoSize = True
        Me.SearchText.Location = New System.Drawing.Point(344, 226)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(78, 13)
        Me.SearchText.TabIndex = 5
        Me.SearchText.Text = "Search by Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Author"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(664, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ISBN"
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(92, 114)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(172, 90)
        Me.Delete.TabIndex = 9
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Background
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 593)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchText)
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.BAuthor)
        Me.Controls.Add(Me.BookTitle)
        Me.Controls.Add(Me.EnterQuery)
        Me.Controls.Add(Me.Search)
        Me.Name = "Background"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents EnterQuery As System.Windows.Forms.TextBox
    Friend WithEvents BookTitle As System.Windows.Forms.TextBox
    Friend WithEvents BAuthor As System.Windows.Forms.TextBox
    Friend WithEvents ISBN As System.Windows.Forms.TextBox
    Friend WithEvents SearchText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.Button

End Class
