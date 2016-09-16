<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWHILELOOP
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
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostcheckDoLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LblInfo = New System.Windows.Forms.Label
        Me.cmdRunLoop = New System.Windows.Forms.Button
        Me.txtMaxNumber = New System.Windows.Forms.TextBox
        Me.lblCounter = New System.Windows.Forms.Label
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostcheckDoLoopToolStripMenuItem, Me.ForLoopToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PostcheckDoLoopToolStripMenuItem
        '
        Me.PostcheckDoLoopToolStripMenuItem.Name = "PostcheckDoLoopToolStripMenuItem"
        Me.PostcheckDoLoopToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PostcheckDoLoopToolStripMenuItem.Text = "Post-check do loop"
        '
        'ForLoopToolStripMenuItem
        '
        Me.ForLoopToolStripMenuItem.Name = "ForLoopToolStripMenuItem"
        Me.ForLoopToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ForLoopToolStripMenuItem.Text = "For loop"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(103, 112)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(107, 17)
        Me.LblInfo.TabIndex = 1
        Me.LblInfo.Text = "Enter a number"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRunLoop
        '
        Me.cmdRunLoop.Location = New System.Drawing.Point(106, 146)
        Me.cmdRunLoop.Name = "cmdRunLoop"
        Me.cmdRunLoop.Size = New System.Drawing.Size(155, 72)
        Me.cmdRunLoop.TabIndex = 2
        Me.cmdRunLoop.Text = "Run Loop"
        Me.cmdRunLoop.UseVisualStyleBackColor = True
        '
        'txtMaxNumber
        '
        Me.txtMaxNumber.Location = New System.Drawing.Point(268, 146)
        Me.txtMaxNumber.Multiline = True
        Me.txtMaxNumber.Name = "txtMaxNumber"
        Me.txtMaxNumber.Size = New System.Drawing.Size(155, 72)
        Me.txtMaxNumber.TabIndex = 3
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(208, 274)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(106, 58)
        Me.lblCounter.TabIndex = 4
        Me.lblCounter.Text = "000"
        '
        'FrmWHILELOOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(536, 420)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.txtMaxNumber)
        Me.Controls.Add(Me.cmdRunLoop)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.menuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmWHILELOOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-check while..do loop"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostcheckDoLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents cmdRunLoop As System.Windows.Forms.Button
    Friend WithEvents txtMaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCounter As System.Windows.Forms.Label
End Class
