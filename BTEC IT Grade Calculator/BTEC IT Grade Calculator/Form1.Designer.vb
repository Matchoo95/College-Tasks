<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGrades))
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchOnlineForHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ButCalc = New System.Windows.Forms.Button
        Me.LblFinalGrade = New System.Windows.Forms.Label
        Me.Logo3 = New System.Windows.Forms.PictureBox
        Me.Logo1 = New System.Windows.Forms.PictureBox
        Me.Logo2 = New System.Windows.Forms.PictureBox
        Me.LblPassCount = New System.Windows.Forms.Label
        Me.LblMeritCount = New System.Windows.Forms.Label
        Me.LblDistinCount = New System.Windows.Forms.Label
        Me.ButUp1 = New System.Windows.Forms.Label
        Me.ButUp2 = New System.Windows.Forms.Label
        Me.ButUp3 = New System.Windows.Forms.Label
        Me.ButDwn1 = New System.Windows.Forms.Label
        Me.ButDwn2 = New System.Windows.Forms.Label
        Me.ButDwn3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblGrade = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DisplayScore = New System.Windows.Forms.Label
        Me.MainMenu.SuspendLayout()
        CType(Me.Logo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1404, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpPageToolStripMenuItem, Me.SearchOnlineForHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpPageToolStripMenuItem
        '
        Me.HelpPageToolStripMenuItem.Name = "HelpPageToolStripMenuItem"
        Me.HelpPageToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.HelpPageToolStripMenuItem.Text = "Help Page"
        '
        'SearchOnlineForHelpToolStripMenuItem
        '
        Me.SearchOnlineForHelpToolStripMenuItem.Name = "SearchOnlineForHelpToolStripMenuItem"
        Me.SearchOnlineForHelpToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SearchOnlineForHelpToolStripMenuItem.Text = "Search Online for Help"
        '
        'ButCalc
        '
        Me.ButCalc.Location = New System.Drawing.Point(565, 38)
        Me.ButCalc.Name = "ButCalc"
        Me.ButCalc.Size = New System.Drawing.Size(266, 99)
        Me.ButCalc.TabIndex = 1
        Me.ButCalc.Text = "Calculate Grade"
        Me.ButCalc.UseVisualStyleBackColor = True
        '
        'LblFinalGrade
        '
        Me.LblFinalGrade.AutoSize = True
        Me.LblFinalGrade.Location = New System.Drawing.Point(613, 140)
        Me.LblFinalGrade.Name = "LblFinalGrade"
        Me.LblFinalGrade.Size = New System.Drawing.Size(169, 22)
        Me.LblFinalGrade.TabIndex = 2
        Me.LblFinalGrade.Text = "Your Final Grade is:"
        '
        'Logo3
        '
        Me.Logo3.Image = CType(resources.GetObject("Logo3.Image"), System.Drawing.Image)
        Me.Logo3.Location = New System.Drawing.Point(1201, 27)
        Me.Logo3.Name = "Logo3"
        Me.Logo3.Size = New System.Drawing.Size(201, 147)
        Me.Logo3.TabIndex = 4
        Me.Logo3.TabStop = False
        '
        'Logo1
        '
        Me.Logo1.Image = CType(resources.GetObject("Logo1.Image"), System.Drawing.Image)
        Me.Logo1.Location = New System.Drawing.Point(1021, 27)
        Me.Logo1.Name = "Logo1"
        Me.Logo1.Size = New System.Drawing.Size(174, 66)
        Me.Logo1.TabIndex = 6
        Me.Logo1.TabStop = False
        '
        'Logo2
        '
        Me.Logo2.Image = CType(resources.GetObject("Logo2.Image"), System.Drawing.Image)
        Me.Logo2.Location = New System.Drawing.Point(1021, 108)
        Me.Logo2.Name = "Logo2"
        Me.Logo2.Size = New System.Drawing.Size(157, 66)
        Me.Logo2.TabIndex = 7
        Me.Logo2.TabStop = False
        '
        'LblPassCount
        '
        Me.LblPassCount.BackColor = System.Drawing.Color.White
        Me.LblPassCount.Location = New System.Drawing.Point(121, 411)
        Me.LblPassCount.Name = "LblPassCount"
        Me.LblPassCount.Size = New System.Drawing.Size(183, 130)
        Me.LblPassCount.TabIndex = 8
        Me.LblPassCount.Text = "0"
        Me.LblPassCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMeritCount
        '
        Me.LblMeritCount.BackColor = System.Drawing.Color.White
        Me.LblMeritCount.Location = New System.Drawing.Point(613, 411)
        Me.LblMeritCount.Name = "LblMeritCount"
        Me.LblMeritCount.Size = New System.Drawing.Size(183, 130)
        Me.LblMeritCount.TabIndex = 9
        Me.LblMeritCount.Text = "0"
        Me.LblMeritCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDistinCount
        '
        Me.LblDistinCount.BackColor = System.Drawing.Color.White
        Me.LblDistinCount.Location = New System.Drawing.Point(1124, 411)
        Me.LblDistinCount.Name = "LblDistinCount"
        Me.LblDistinCount.Size = New System.Drawing.Size(183, 130)
        Me.LblDistinCount.TabIndex = 10
        Me.LblDistinCount.Text = "0"
        Me.LblDistinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButUp1
        '
        Me.ButUp1.Image = CType(resources.GetObject("ButUp1.Image"), System.Drawing.Image)
        Me.ButUp1.Location = New System.Drawing.Point(84, 251)
        Me.ButUp1.Name = "ButUp1"
        Me.ButUp1.Size = New System.Drawing.Size(257, 176)
        Me.ButUp1.TabIndex = 11
        '
        'ButUp2
        '
        Me.ButUp2.Image = CType(resources.GetObject("ButUp2.Image"), System.Drawing.Image)
        Me.ButUp2.Location = New System.Drawing.Point(574, 251)
        Me.ButUp2.Name = "ButUp2"
        Me.ButUp2.Size = New System.Drawing.Size(257, 176)
        Me.ButUp2.TabIndex = 12
        '
        'ButUp3
        '
        Me.ButUp3.Image = CType(resources.GetObject("ButUp3.Image"), System.Drawing.Image)
        Me.ButUp3.Location = New System.Drawing.Point(1085, 251)
        Me.ButUp3.Name = "ButUp3"
        Me.ButUp3.Size = New System.Drawing.Size(257, 176)
        Me.ButUp3.TabIndex = 13
        '
        'ButDwn1
        '
        Me.ButDwn1.Image = CType(resources.GetObject("ButDwn1.Image"), System.Drawing.Image)
        Me.ButDwn1.Location = New System.Drawing.Point(84, 525)
        Me.ButDwn1.Name = "ButDwn1"
        Me.ButDwn1.Size = New System.Drawing.Size(257, 176)
        Me.ButDwn1.TabIndex = 14
        '
        'ButDwn2
        '
        Me.ButDwn2.Image = CType(resources.GetObject("ButDwn2.Image"), System.Drawing.Image)
        Me.ButDwn2.Location = New System.Drawing.Point(574, 525)
        Me.ButDwn2.Name = "ButDwn2"
        Me.ButDwn2.Size = New System.Drawing.Size(257, 176)
        Me.ButDwn2.TabIndex = 15
        '
        'ButDwn3
        '
        Me.ButDwn3.Image = CType(resources.GetObject("ButDwn3.Image"), System.Drawing.Image)
        Me.ButDwn3.Location = New System.Drawing.Point(1085, 525)
        Me.ButDwn3.Name = "ButDwn3"
        Me.ButDwn3.Size = New System.Drawing.Size(257, 176)
        Me.ButDwn3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(672, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Merit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1160, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 22)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Distinction"
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Myriad Web Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(666, 182)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(0, 27)
        Me.LblGrade.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(721, 182)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(682, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(721, 182)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 23
        '
        'DisplayScore
        '
        Me.DisplayScore.AutoSize = True
        Me.DisplayScore.Location = New System.Drawing.Point(13, 38)
        Me.DisplayScore.Name = "DisplayScore"
        Me.DisplayScore.Size = New System.Drawing.Size(138, 22)
        Me.DisplayScore.TabIndex = 24
        Me.DisplayScore.Text = "Current Score ="
        '
        'FrmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1404, 710)
        Me.Controls.Add(Me.DisplayScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblGrade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblDistinCount)
        Me.Controls.Add(Me.ButDwn3)
        Me.Controls.Add(Me.LblMeritCount)
        Me.Controls.Add(Me.ButDwn2)
        Me.Controls.Add(Me.LblPassCount)
        Me.Controls.Add(Me.ButDwn1)
        Me.Controls.Add(Me.ButUp3)
        Me.Controls.Add(Me.ButUp2)
        Me.Controls.Add(Me.ButUp1)
        Me.Controls.Add(Me.Logo2)
        Me.Controls.Add(Me.Logo1)
        Me.Controls.Add(Me.Logo3)
        Me.Controls.Add(Me.LblFinalGrade)
        Me.Controls.Add(Me.ButCalc)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Myriad Web Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 3 BTEC Diploma in IT Grade Calculator"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.Logo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchOnlineForHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButCalc As System.Windows.Forms.Button
    Friend WithEvents LblFinalGrade As System.Windows.Forms.Label
    Friend WithEvents Logo3 As System.Windows.Forms.PictureBox
    Friend WithEvents Logo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblPassCount As System.Windows.Forms.Label
    Friend WithEvents LblMeritCount As System.Windows.Forms.Label
    Friend WithEvents LblDistinCount As System.Windows.Forms.Label
    Friend WithEvents ButUp1 As System.Windows.Forms.Label
    Friend WithEvents ButUp2 As System.Windows.Forms.Label
    Friend WithEvents ButUp3 As System.Windows.Forms.Label
    Friend WithEvents ButDwn1 As System.Windows.Forms.Label
    Friend WithEvents ButDwn2 As System.Windows.Forms.Label
    Friend WithEvents ButDwn3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblGrade As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DisplayScore As System.Windows.Forms.Label

End Class
