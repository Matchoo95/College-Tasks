<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDOLOOP
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.menuTxt = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdForLoop = New System.Windows.Forms.Button
        Me.lbxNumbers = New System.Windows.Forms.ListBox
        Me.lblComment = New System.Windows.Forms.Label
        Me.ForLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrecheckWhileLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuTxt})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(542, 24)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "MenuStrip1"
        '
        'menuTxt
        '
        Me.menuTxt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForLoopToolStripMenuItem, Me.PrecheckWhileLoopToolStripMenuItem})
        Me.menuTxt.Name = "menuTxt"
        Me.menuTxt.Size = New System.Drawing.Size(50, 20)
        Me.menuTxt.Text = "Menu"
        '
        'cmdForLoop
        '
        Me.cmdForLoop.BackColor = System.Drawing.Color.Black
        Me.cmdForLoop.ForeColor = System.Drawing.Color.White
        Me.cmdForLoop.Location = New System.Drawing.Point(196, 96)
        Me.cmdForLoop.Name = "cmdForLoop"
        Me.cmdForLoop.Size = New System.Drawing.Size(160, 70)
        Me.cmdForLoop.TabIndex = 1
        Me.cmdForLoop.Text = "Run Loop"
        Me.cmdForLoop.UseVisualStyleBackColor = False
        '
        'lbxNumbers
        '
        Me.lbxNumbers.FormattingEnabled = True
        Me.lbxNumbers.ItemHeight = 17
        Me.lbxNumbers.Location = New System.Drawing.Point(196, 184)
        Me.lbxNumbers.Name = "lbxNumbers"
        Me.lbxNumbers.Size = New System.Drawing.Size(160, 327)
        Me.lbxNumbers.TabIndex = 2
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(165, 539)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(219, 17)
        Me.lblComment.TabIndex = 3
        Me.lblComment.Text = "The loop will stop if 25 is reached"
        '
        'ForLoopToolStripMenuItem
        '
        Me.ForLoopToolStripMenuItem.Name = "ForLoopToolStripMenuItem"
        Me.ForLoopToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ForLoopToolStripMenuItem.Text = "For loop"
        '
        'PrecheckWhileLoopToolStripMenuItem
        '
        Me.PrecheckWhileLoopToolStripMenuItem.Name = "PrecheckWhileLoopToolStripMenuItem"
        Me.PrecheckWhileLoopToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PrecheckWhileLoopToolStripMenuItem.Text = "Pre-check while loop"
        '
        'FrmDOLOOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 587)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lbxNumbers)
        Me.Controls.Add(Me.cmdForLoop)
        Me.Controls.Add(Me.menuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDOLOOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Post-check do..until loop"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuTxt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdForLoop As System.Windows.Forms.Button
    Friend WithEvents lbxNumbers As System.Windows.Forms.ListBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents ForLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecheckWhileLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
