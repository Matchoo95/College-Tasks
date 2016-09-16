<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeclection
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
        Me.LabelInfo = New System.Windows.Forms.Label
        Me.chbGame = New System.Windows.Forms.CheckBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(52, 85)
        Me.LabelInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(108, 17)
        Me.LabelInfo.TabIndex = 0
        Me.LabelInfo.Text = "Enter Full Name"
        '
        'chbGame
        '
        Me.chbGame.AutoSize = True
        Me.chbGame.Location = New System.Drawing.Point(169, 200)
        Me.chbGame.Margin = New System.Windows.Forms.Padding(4)
        Me.chbGame.Name = "chbGame"
        Me.chbGame.Size = New System.Drawing.Size(117, 21)
        Me.chbGame.TabIndex = 2
        Me.chbGame.Text = "Play a game?"
        Me.chbGame.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 81)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 23)
        Me.txtName.TabIndex = 3
        '
        'FrmSeclection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(427, 288)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.chbGame)
        Me.Controls.Add(Me.LabelInfo)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSeclection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Want to play a game?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents chbGame As System.Windows.Forms.CheckBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox

End Class
