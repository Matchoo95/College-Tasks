<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MainTitle = New System.Windows.Forms.Label
        Me.road1 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Playbtn = New System.Windows.Forms.Button
        Me.Instructionsbtn = New System.Windows.Forms.Button
        Me.Quitbtn = New System.Windows.Forms.Button
        CType(Me.road1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTitle
        '
        Me.MainTitle.AutoSize = True
        Me.MainTitle.BackColor = System.Drawing.Color.Transparent
        Me.MainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTitle.Location = New System.Drawing.Point(12, 72)
        Me.MainTitle.Name = "MainTitle"
        Me.MainTitle.Size = New System.Drawing.Size(1139, 73)
        Me.MainTitle.TabIndex = 0
        Me.MainTitle.Text = "Rihanna the Road Crossing Recycler!"
        '
        'road1
        '
        Me.road1.Image = CType(resources.GetObject("road1.Image"), System.Drawing.Image)
        Me.road1.Location = New System.Drawing.Point(-224, 239)
        Me.road1.Name = "road1"
        Me.road1.Size = New System.Drawing.Size(1486, 243)
        Me.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.road1.TabIndex = 1
        Me.road1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-179, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1486, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-130, 470)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1486, 243)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Playbtn
        '
        Me.Playbtn.Location = New System.Drawing.Point(41, 318)
        Me.Playbtn.Name = "Playbtn"
        Me.Playbtn.Size = New System.Drawing.Size(211, 103)
        Me.Playbtn.TabIndex = 4
        Me.Playbtn.Text = "Play"
        Me.Playbtn.UseVisualStyleBackColor = True
        '
        'Instructionsbtn
        '
        Me.Instructionsbtn.Location = New System.Drawing.Point(478, 318)
        Me.Instructionsbtn.Name = "Instructionsbtn"
        Me.Instructionsbtn.Size = New System.Drawing.Size(211, 103)
        Me.Instructionsbtn.TabIndex = 5
        Me.Instructionsbtn.Text = "View Instructions"
        Me.Instructionsbtn.UseVisualStyleBackColor = True
        '
        'Quitbtn
        '
        Me.Quitbtn.Location = New System.Drawing.Point(883, 318)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(211, 103)
        Me.Quitbtn.TabIndex = 6
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 543)
        Me.Controls.Add(Me.Quitbtn)
        Me.Controls.Add(Me.Instructionsbtn)
        Me.Controls.Add(Me.Playbtn)
        Me.Controls.Add(Me.MainTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.road1)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.road1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainTitle As System.Windows.Forms.Label
    Friend WithEvents road1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Playbtn As System.Windows.Forms.Button
    Friend WithEvents Instructionsbtn As System.Windows.Forms.Button
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
End Class
