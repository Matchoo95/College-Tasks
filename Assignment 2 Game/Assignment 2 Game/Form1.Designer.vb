<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class levels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(levels))
        Me.road1 = New System.Windows.Forms.PictureBox
        Me.road2 = New System.Windows.Forms.PictureBox
        Me.safeArea3 = New System.Windows.Forms.PictureBox
        Me.safeArea1 = New System.Windows.Forms.PictureBox
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.car1 = New System.Windows.Forms.PictureBox
        Me.car2 = New System.Windows.Forms.PictureBox
        Me.car3 = New System.Windows.Forms.PictureBox
        Me.truck1 = New System.Windows.Forms.PictureBox
        Me.player = New System.Windows.Forms.PictureBox
        Me.litter1 = New System.Windows.Forms.PictureBox
        Me.litter2 = New System.Windows.Forms.PictureBox
        Me.litter3 = New System.Windows.Forms.PictureBox
        Me.levelLabel = New System.Windows.Forms.Label
        Me.livesLabel = New System.Windows.Forms.Label
        Me.litterLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.timerLabel = New System.Windows.Forms.Label
        Me.carSpeedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.boundary1 = New System.Windows.Forms.PictureBox
        Me.boundary2 = New System.Windows.Forms.PictureBox
        Me.boundary3 = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bin = New System.Windows.Forms.PictureBox
        Me.score = New System.Windows.Forms.Label
        Me.scoreLabel = New System.Windows.Forms.Label
        Me.barrier1 = New System.Windows.Forms.PictureBox
        Me.barrier2 = New System.Windows.Forms.PictureBox
        Me.barrier3 = New System.Windows.Forms.PictureBox
        Me.barrier4 = New System.Windows.Forms.PictureBox
        CType(Me.road1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.road2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.safeArea3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.safeArea1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.truck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.litter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.litter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.litter3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boundary1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boundary2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boundary3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrier1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrier2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrier3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrier4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'road1
        '
        Me.road1.Image = CType(resources.GetObject("road1.Image"), System.Drawing.Image)
        Me.road1.Location = New System.Drawing.Point(3, 118)
        Me.road1.Name = "road1"
        Me.road1.Size = New System.Drawing.Size(1486, 243)
        Me.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.road1.TabIndex = 0
        Me.road1.TabStop = False
        '
        'road2
        '
        Me.road2.Image = CType(resources.GetObject("road2.Image"), System.Drawing.Image)
        Me.road2.Location = New System.Drawing.Point(3, 359)
        Me.road2.Name = "road2"
        Me.road2.Size = New System.Drawing.Size(1486, 243)
        Me.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.road2.TabIndex = 1
        Me.road2.TabStop = False
        '
        'safeArea3
        '
        Me.safeArea3.BackColor = System.Drawing.Color.Lime
        Me.safeArea3.Location = New System.Drawing.Point(4, 601)
        Me.safeArea3.Name = "safeArea3"
        Me.safeArea3.Size = New System.Drawing.Size(1485, 222)
        Me.safeArea3.TabIndex = 3
        Me.safeArea3.TabStop = False
        '
        'safeArea1
        '
        Me.safeArea1.BackColor = System.Drawing.Color.Lime
        Me.safeArea1.Location = New System.Drawing.Point(3, -1)
        Me.safeArea1.Name = "safeArea1"
        Me.safeArea1.Size = New System.Drawing.Size(1485, 122)
        Me.safeArea1.TabIndex = 4
        Me.safeArea1.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 2000
        '
        'car1
        '
        Me.car1.Image = CType(resources.GetObject("car1.Image"), System.Drawing.Image)
        Me.car1.Location = New System.Drawing.Point(1301, 254)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(181, 90)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car1.TabIndex = 5
        Me.car1.TabStop = False
        '
        'car2
        '
        Me.car2.BackColor = System.Drawing.Color.White
        Me.car2.Image = CType(resources.GetObject("car2.Image"), System.Drawing.Image)
        Me.car2.Location = New System.Drawing.Point(12, 138)
        Me.car2.Name = "car2"
        Me.car2.Size = New System.Drawing.Size(181, 90)
        Me.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car2.TabIndex = 6
        Me.car2.TabStop = False
        '
        'car3
        '
        Me.car3.Image = CType(resources.GetObject("car3.Image"), System.Drawing.Image)
        Me.car3.Location = New System.Drawing.Point(4, 379)
        Me.car3.Name = "car3"
        Me.car3.Size = New System.Drawing.Size(181, 90)
        Me.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car3.TabIndex = 7
        Me.car3.TabStop = False
        '
        'truck1
        '
        Me.truck1.Image = CType(resources.GetObject("truck1.Image"), System.Drawing.Image)
        Me.truck1.Location = New System.Drawing.Point(1301, 490)
        Me.truck1.Name = "truck1"
        Me.truck1.Size = New System.Drawing.Size(181, 90)
        Me.truck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.truck1.TabIndex = 8
        Me.truck1.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Black
        Me.player.Location = New System.Drawing.Point(664, 635)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(75, 67)
        Me.player.TabIndex = 9
        Me.player.TabStop = False
        '
        'litter1
        '
        Me.litter1.BackColor = System.Drawing.Color.Red
        Me.litter1.Location = New System.Drawing.Point(57, 325)
        Me.litter1.Name = "litter1"
        Me.litter1.Size = New System.Drawing.Size(19, 28)
        Me.litter1.TabIndex = 10
        Me.litter1.TabStop = False
        '
        'litter2
        '
        Me.litter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.litter2.Location = New System.Drawing.Point(1225, 398)
        Me.litter2.Name = "litter2"
        Me.litter2.Size = New System.Drawing.Size(19, 28)
        Me.litter2.TabIndex = 11
        Me.litter2.TabStop = False
        '
        'litter3
        '
        Me.litter3.BackColor = System.Drawing.Color.Yellow
        Me.litter3.Location = New System.Drawing.Point(693, 138)
        Me.litter3.Name = "litter3"
        Me.litter3.Size = New System.Drawing.Size(19, 28)
        Me.litter3.TabIndex = 12
        Me.litter3.TabStop = False
        '
        'levelLabel
        '
        Me.levelLabel.AutoSize = True
        Me.levelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelLabel.Location = New System.Drawing.Point(82, 9)
        Me.levelLabel.Name = "levelLabel"
        Me.levelLabel.Size = New System.Drawing.Size(25, 25)
        Me.levelLabel.TabIndex = 13
        Me.levelLabel.Text = "1"
        '
        'livesLabel
        '
        Me.livesLabel.AutoSize = True
        Me.livesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.livesLabel.Location = New System.Drawing.Point(82, 49)
        Me.livesLabel.Name = "livesLabel"
        Me.livesLabel.Size = New System.Drawing.Size(25, 25)
        Me.livesLabel.TabIndex = 14
        Me.livesLabel.Text = "3"
        '
        'litterLabel
        '
        Me.litterLabel.AutoSize = True
        Me.litterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.litterLabel.Location = New System.Drawing.Point(82, 90)
        Me.litterLabel.Name = "litterLabel"
        Me.litterLabel.Size = New System.Drawing.Size(25, 25)
        Me.litterLabel.TabIndex = 15
        Me.litterLabel.Text = "3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Lives:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Litter:"
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(1424, 9)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(58, 25)
        Me.timerLabel.TabIndex = 19
        Me.timerLabel.Text = "0:00"
        '
        'carSpeedTimer
        '
        '
        'boundary1
        '
        Me.boundary1.Location = New System.Drawing.Point(-73, 118)
        Me.boundary1.Name = "boundary1"
        Me.boundary1.Size = New System.Drawing.Size(62, 484)
        Me.boundary1.TabIndex = 20
        Me.boundary1.TabStop = False
        '
        'boundary2
        '
        Me.boundary2.Location = New System.Drawing.Point(1663, 118)
        Me.boundary2.Name = "boundary2"
        Me.boundary2.Size = New System.Drawing.Size(62, 484)
        Me.boundary2.TabIndex = 21
        Me.boundary2.TabStop = False
        '
        'boundary3
        '
        Me.boundary3.Location = New System.Drawing.Point(-360, 118)
        Me.boundary3.Name = "boundary3"
        Me.boundary3.Size = New System.Drawing.Size(65, 484)
        Me.boundary3.TabIndex = 22
        Me.boundary3.TabStop = False
        '
        'Timer2
        '
        '
        'bin
        '
        Me.bin.BackColor = System.Drawing.Color.Black
        Me.bin.Location = New System.Drawing.Point(1270, 12)
        Me.bin.Name = "bin"
        Me.bin.Size = New System.Drawing.Size(75, 67)
        Me.bin.TabIndex = 23
        Me.bin.TabStop = False
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.Location = New System.Drawing.Point(666, 9)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(80, 25)
        Me.score.TabIndex = 24
        Me.score.Text = "Score:"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(742, 9)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(25, 25)
        Me.scoreLabel.TabIndex = 25
        Me.scoreLabel.Text = "0"
        '
        'barrier1
        '
        Me.barrier1.Location = New System.Drawing.Point(3, -71)
        Me.barrier1.Name = "barrier1"
        Me.barrier1.Size = New System.Drawing.Size(1486, 15)
        Me.barrier1.TabIndex = 26
        Me.barrier1.TabStop = False
        '
        'barrier2
        '
        Me.barrier2.Location = New System.Drawing.Point(4, 868)
        Me.barrier2.Name = "barrier2"
        Me.barrier2.Size = New System.Drawing.Size(1486, 15)
        Me.barrier2.TabIndex = 27
        Me.barrier2.TabStop = False
        '
        'barrier3
        '
        Me.barrier3.Location = New System.Drawing.Point(1608, -1)
        Me.barrier3.Name = "barrier3"
        Me.barrier3.Size = New System.Drawing.Size(31, 824)
        Me.barrier3.TabIndex = 28
        Me.barrier3.TabStop = False
        '
        'barrier4
        '
        Me.barrier4.Location = New System.Drawing.Point(-132, -1)
        Me.barrier4.Name = "barrier4"
        Me.barrier4.Size = New System.Drawing.Size(31, 824)
        Me.barrier4.TabIndex = 29
        Me.barrier4.TabStop = False
        '
        'levels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1494, 824)
        Me.Controls.Add(Me.barrier4)
        Me.Controls.Add(Me.barrier3)
        Me.Controls.Add(Me.barrier2)
        Me.Controls.Add(Me.barrier1)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.bin)
        Me.Controls.Add(Me.boundary3)
        Me.Controls.Add(Me.boundary2)
        Me.Controls.Add(Me.boundary1)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.litterLabel)
        Me.Controls.Add(Me.livesLabel)
        Me.Controls.Add(Me.levelLabel)
        Me.Controls.Add(Me.litter3)
        Me.Controls.Add(Me.litter2)
        Me.Controls.Add(Me.litter1)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.truck1)
        Me.Controls.Add(Me.car3)
        Me.Controls.Add(Me.car2)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.safeArea1)
        Me.Controls.Add(Me.safeArea3)
        Me.Controls.Add(Me.road2)
        Me.Controls.Add(Me.road1)
        Me.Name = "levels"
        Me.Text = "RRR"
        CType(Me.road1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.road2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.safeArea3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.safeArea1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.truck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.litter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.litter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.litter3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boundary1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boundary2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boundary3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrier1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrier2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrier3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrier4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents road1 As System.Windows.Forms.PictureBox
    Friend WithEvents road2 As System.Windows.Forms.PictureBox
    Friend WithEvents safeArea3 As System.Windows.Forms.PictureBox
    Friend WithEvents safeArea1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents car1 As System.Windows.Forms.PictureBox
    Friend WithEvents car2 As System.Windows.Forms.PictureBox
    Friend WithEvents car3 As System.Windows.Forms.PictureBox
    Friend WithEvents truck1 As System.Windows.Forms.PictureBox
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents litter1 As System.Windows.Forms.PictureBox
    Friend WithEvents litter2 As System.Windows.Forms.PictureBox
    Friend WithEvents litter3 As System.Windows.Forms.PictureBox
    Friend WithEvents levelLabel As System.Windows.Forms.Label
    Friend WithEvents livesLabel As System.Windows.Forms.Label
    Friend WithEvents litterLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents timerLabel As System.Windows.Forms.Label
    Friend WithEvents carSpeedTimer As System.Windows.Forms.Timer
    Friend WithEvents boundary1 As System.Windows.Forms.PictureBox
    Friend WithEvents boundary2 As System.Windows.Forms.PictureBox
    Friend WithEvents boundary3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents bin As System.Windows.Forms.PictureBox
    Friend WithEvents score As System.Windows.Forms.Label
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents barrier1 As System.Windows.Forms.PictureBox
    Friend WithEvents barrier2 As System.Windows.Forms.PictureBox
    Friend WithEvents barrier3 As System.Windows.Forms.PictureBox
    Friend WithEvents barrier4 As System.Windows.Forms.PictureBox

End Class
