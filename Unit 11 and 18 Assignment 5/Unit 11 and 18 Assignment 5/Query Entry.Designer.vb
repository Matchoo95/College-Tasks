<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query_Entry
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
        Me.queryEntryTtl = New System.Windows.Forms.Label
        Me.srchBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'queryEntryTtl
        '
        Me.queryEntryTtl.AutoSize = True
        Me.queryEntryTtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryEntryTtl.Location = New System.Drawing.Point(254, 9)
        Me.queryEntryTtl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.queryEntryTtl.Name = "queryEntryTtl"
        Me.queryEntryTtl.Size = New System.Drawing.Size(291, 55)
        Me.queryEntryTtl.TabIndex = 0
        Me.queryEntryTtl.Text = "Query Entry"
        '
        'srchBtn
        '
        Me.srchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchBtn.Location = New System.Drawing.Point(642, 122)
        Me.srchBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.srchBtn.Name = "srchBtn"
        Me.srchBtn.Size = New System.Drawing.Size(121, 33)
        Me.srchBtn.TabIndex = 1
        Me.srchBtn.Text = "Search"
        Me.srchBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose an option to search for:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(327, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(311, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(642, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Query_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 485)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.srchBtn)
        Me.Controls.Add(Me.queryEntryTtl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Query_Entry"
        Me.Text = "Query_Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryEntryTtl As System.Windows.Forms.Label
    Friend WithEvents srchBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
