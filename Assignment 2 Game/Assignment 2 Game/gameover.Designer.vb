<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameover
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
        Me.gameoverTitle = New System.Windows.Forms.Label
        Me.totalScorebtn = New System.Windows.Forms.Label
        Me.scorelbl = New System.Windows.Forms.Label
        Me.againbtn = New System.Windows.Forms.Button
        Me.gameoverquitbtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'gameoverTitle
        '
        Me.gameoverTitle.AutoSize = True
        Me.gameoverTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameoverTitle.Location = New System.Drawing.Point(217, 36)
        Me.gameoverTitle.Name = "gameoverTitle"
        Me.gameoverTitle.Size = New System.Drawing.Size(52, 55)
        Me.gameoverTitle.TabIndex = 0
        Me.gameoverTitle.Text = "1"
        '
        'totalScorebtn
        '
        Me.totalScorebtn.AutoSize = True
        Me.totalScorebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalScorebtn.Location = New System.Drawing.Point(53, 147)
        Me.totalScorebtn.Name = "totalScorebtn"
        Me.totalScorebtn.Size = New System.Drawing.Size(144, 29)
        Me.totalScorebtn.TabIndex = 1
        Me.totalScorebtn.Text = "Total Score:"
        '
        'scorelbl
        '
        Me.scorelbl.AutoSize = True
        Me.scorelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorelbl.Location = New System.Drawing.Point(191, 149)
        Me.scorelbl.Name = "scorelbl"
        Me.scorelbl.Size = New System.Drawing.Size(26, 29)
        Me.scorelbl.TabIndex = 2
        Me.scorelbl.Text = "0"
        '
        'againbtn
        '
        Me.againbtn.Location = New System.Drawing.Point(74, 288)
        Me.againbtn.Name = "againbtn"
        Me.againbtn.Size = New System.Drawing.Size(202, 94)
        Me.againbtn.TabIndex = 3
        Me.againbtn.Text = "Play Again?"
        Me.againbtn.UseVisualStyleBackColor = True
        '
        'gameoverquitbtn
        '
        Me.gameoverquitbtn.Location = New System.Drawing.Point(457, 288)
        Me.gameoverquitbtn.Name = "gameoverquitbtn"
        Me.gameoverquitbtn.Size = New System.Drawing.Size(202, 94)
        Me.gameoverquitbtn.TabIndex = 4
        Me.gameoverquitbtn.Text = "Quit"
        Me.gameoverquitbtn.UseVisualStyleBackColor = True
        '
        'gameover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 428)
        Me.Controls.Add(Me.gameoverquitbtn)
        Me.Controls.Add(Me.againbtn)
        Me.Controls.Add(Me.scorelbl)
        Me.Controls.Add(Me.totalScorebtn)
        Me.Controls.Add(Me.gameoverTitle)
        Me.Name = "gameover"
        Me.Text = "Game Over!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gameoverTitle As System.Windows.Forms.Label
    Friend WithEvents totalScorebtn As System.Windows.Forms.Label
    Friend WithEvents scorelbl As System.Windows.Forms.Label
    Friend WithEvents againbtn As System.Windows.Forms.Button
    Friend WithEvents gameoverquitbtn As System.Windows.Forms.Button
End Class
