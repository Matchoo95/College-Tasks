<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.HelpStrip = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LblHelpTitle = New System.Windows.Forms.Label
        Me.Logo3 = New System.Windows.Forms.PictureBox
        Me.Logo1 = New System.Windows.Forms.PictureBox
        Me.Logo2 = New System.Windows.Forms.PictureBox
        Me.TxtHelp = New System.Windows.Forms.TextBox
        Me.PicTable = New System.Windows.Forms.PictureBox
        Me.Logo33 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.HelpStrip.SuspendLayout()
        CType(Me.Logo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpStrip
        '
        Me.HelpStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.HelpStrip.Location = New System.Drawing.Point(0, 0)
        Me.HelpStrip.Name = "HelpStrip"
        Me.HelpStrip.Size = New System.Drawing.Size(1404, 24)
        Me.HelpStrip.TabIndex = 0
        Me.HelpStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ResetToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'LblHelpTitle
        '
        Me.LblHelpTitle.AutoSize = True
        Me.LblHelpTitle.Font = New System.Drawing.Font("Myriad Web Pro", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelpTitle.Location = New System.Drawing.Point(26, 48)
        Me.LblHelpTitle.Name = "LblHelpTitle"
        Me.LblHelpTitle.Size = New System.Drawing.Size(355, 31)
        Me.LblHelpTitle.TabIndex = 1
        Me.LblHelpTitle.Text = "How to use this Application"
        '
        'Logo3
        '
        Me.Logo3.Image = CType(resources.GetObject("Logo3.Image"), System.Drawing.Image)
        Me.Logo3.Location = New System.Drawing.Point(1722, 27)
        Me.Logo3.Name = "Logo3"
        Me.Logo3.Size = New System.Drawing.Size(201, 147)
        Me.Logo3.TabIndex = 5
        Me.Logo3.TabStop = False
        '
        'Logo1
        '
        Me.Logo1.Image = CType(resources.GetObject("Logo1.Image"), System.Drawing.Image)
        Me.Logo1.Location = New System.Drawing.Point(1021, 27)
        Me.Logo1.Name = "Logo1"
        Me.Logo1.Size = New System.Drawing.Size(174, 66)
        Me.Logo1.TabIndex = 7
        Me.Logo1.TabStop = False
        '
        'Logo2
        '
        Me.Logo2.Image = CType(resources.GetObject("Logo2.Image"), System.Drawing.Image)
        Me.Logo2.Location = New System.Drawing.Point(1021, 108)
        Me.Logo2.Name = "Logo2"
        Me.Logo2.Size = New System.Drawing.Size(155, 66)
        Me.Logo2.TabIndex = 8
        Me.Logo2.TabStop = False
        '
        'TxtHelp
        '
        Me.TxtHelp.AllowDrop = True
        Me.TxtHelp.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHelp.Location = New System.Drawing.Point(397, 55)
        Me.TxtHelp.Multiline = True
        Me.TxtHelp.Name = "TxtHelp"
        Me.TxtHelp.ReadOnly = True
        Me.TxtHelp.Size = New System.Drawing.Size(601, 138)
        Me.TxtHelp.TabIndex = 9
        Me.TxtHelp.Text = resources.GetString("TxtHelp.Text")
        '
        'PicTable
        '
        Me.PicTable.BackColor = System.Drawing.Color.Transparent
        Me.PicTable.Image = CType(resources.GetObject("PicTable.Image"), System.Drawing.Image)
        Me.PicTable.InitialImage = CType(resources.GetObject("PicTable.InitialImage"), System.Drawing.Image)
        Me.PicTable.Location = New System.Drawing.Point(92, 217)
        Me.PicTable.Name = "PicTable"
        Me.PicTable.Size = New System.Drawing.Size(1258, 577)
        Me.PicTable.TabIndex = 10
        Me.PicTable.TabStop = False
        '
        'Logo33
        '
        Me.Logo33.Image = CType(resources.GetObject("Logo33.Image"), System.Drawing.Image)
        Me.Logo33.Location = New System.Drawing.Point(1201, 27)
        Me.Logo33.Name = "Logo33"
        Me.Logo33.Size = New System.Drawing.Size(201, 147)
        Me.Logo33.TabIndex = 11
        Me.Logo33.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(721, 182)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(699, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(721, 182)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1404, 710)
        Me.Controls.Add(Me.Logo33)
        Me.Controls.Add(Me.PicTable)
        Me.Controls.Add(Me.TxtHelp)
        Me.Controls.Add(Me.Logo2)
        Me.Controls.Add(Me.Logo1)
        Me.Controls.Add(Me.Logo3)
        Me.Controls.Add(Me.LblHelpTitle)
        Me.Controls.Add(Me.HelpStrip)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Myriad Web Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.HelpStrip
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 3 BTEC Diploma in IT Grade Calculator"
        Me.HelpStrip.ResumeLayout(False)
        Me.HelpStrip.PerformLayout()
        CType(Me.Logo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblHelpTitle As System.Windows.Forms.Label
    Friend WithEvents Logo3 As System.Windows.Forms.PictureBox
    Friend WithEvents Logo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtHelp As System.Windows.Forms.TextBox
    Friend WithEvents PicTable As System.Windows.Forms.PictureBox
    Friend WithEvents Logo33 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
