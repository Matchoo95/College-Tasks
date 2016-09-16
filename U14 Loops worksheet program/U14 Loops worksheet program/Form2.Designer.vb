<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFORLOOP
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFORLOOP))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.cmdRunLoop = New System.Windows.Forms.Button
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostcheckDoLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrecheckWhileLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblImages = New System.Windows.Forms.Label
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "MenuStrip1"
        '
        'cmdRunLoop
        '
        Me.cmdRunLoop.BackColor = System.Drawing.Color.Black
        Me.cmdRunLoop.ForeColor = System.Drawing.Color.White
        Me.cmdRunLoop.Location = New System.Drawing.Point(158, 98)
        Me.cmdRunLoop.Name = "cmdRunLoop"
        Me.cmdRunLoop.Size = New System.Drawing.Size(206, 94)
        Me.cmdRunLoop.TabIndex = 1
        Me.cmdRunLoop.Text = "Run Loop"
        Me.cmdRunLoop.UseVisualStyleBackColor = False
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "bird.png")
        Me.imageList1.Images.SetKeyName(1, "cross.png")
        Me.imageList1.Images.SetKeyName(2, "tick.png")
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostcheckDoLoopToolStripMenuItem, Me.PrecheckWhileLoopToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PostcheckDoLoopToolStripMenuItem
        '
        Me.PostcheckDoLoopToolStripMenuItem.Name = "PostcheckDoLoopToolStripMenuItem"
        Me.PostcheckDoLoopToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PostcheckDoLoopToolStripMenuItem.Text = "Post-check do loop"
        '
        'PrecheckWhileLoopToolStripMenuItem
        '
        Me.PrecheckWhileLoopToolStripMenuItem.Name = "PrecheckWhileLoopToolStripMenuItem"
        Me.PrecheckWhileLoopToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PrecheckWhileLoopToolStripMenuItem.Text = "Pre-check while loop"
        '
        'lblImages
        '
        Me.lblImages.AutoSize = True
        Me.lblImages.ImageList = Me.imageList1
        Me.lblImages.Location = New System.Drawing.Point(152, 240)
        Me.lblImages.Name = "lblImages"
        Me.lblImages.Size = New System.Drawing.Size(223, 17)
        Me.lblImages.TabIndex = 2
        Me.lblImages.Text = "Run the Loop to view the images"
        Me.lblImages.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmFORLOOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 588)
        Me.Controls.Add(Me.lblImages)
        Me.Controls.Add(Me.cmdRunLoop)
        Me.Controls.Add(Me.menuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmFORLOOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Loop"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdRunLoop As System.Windows.Forms.Button
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostcheckDoLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecheckWhileLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblImages As System.Windows.Forms.Label
End Class
