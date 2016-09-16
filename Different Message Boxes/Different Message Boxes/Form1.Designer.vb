<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnInfo = New System.Windows.Forms.Button
        Me.btnCritical = New System.Windows.Forms.Button
        Me.btnExclam = New System.Windows.Forms.Button
        Me.btnQuestion = New System.Windows.Forms.Button
        Me.btnYesNo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(24, 63)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(389, 84)
        Me.btnReg.TabIndex = 0
        Me.btnReg.Text = "Regular Message"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(24, 169)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(389, 84)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Information Message"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnCritical
        '
        Me.btnCritical.Location = New System.Drawing.Point(25, 279)
        Me.btnCritical.Name = "btnCritical"
        Me.btnCritical.Size = New System.Drawing.Size(389, 84)
        Me.btnCritical.TabIndex = 2
        Me.btnCritical.Text = "Critical Message"
        Me.btnCritical.UseVisualStyleBackColor = True
        '
        'btnExclam
        '
        Me.btnExclam.Location = New System.Drawing.Point(25, 386)
        Me.btnExclam.Name = "btnExclam"
        Me.btnExclam.Size = New System.Drawing.Size(389, 84)
        Me.btnExclam.TabIndex = 3
        Me.btnExclam.Text = "Exclamation Message"
        Me.btnExclam.UseVisualStyleBackColor = True
        '
        'btnQuestion
        '
        Me.btnQuestion.Location = New System.Drawing.Point(25, 495)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(389, 84)
        Me.btnQuestion.TabIndex = 4
        Me.btnQuestion.Text = "Question Message"
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'btnYesNo
        '
        Me.btnYesNo.Location = New System.Drawing.Point(25, 603)
        Me.btnYesNo.Name = "btnYesNo"
        Me.btnYesNo.Size = New System.Drawing.Size(389, 84)
        Me.btnYesNo.TabIndex = 5
        Me.btnYesNo.Text = "Yes/No Message"
        Me.btnYesNo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 709)
        Me.Controls.Add(Me.btnYesNo)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.btnExclam)
        Me.Controls.Add(Me.btnCritical)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnReg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnCritical As System.Windows.Forms.Button
    Friend WithEvents btnExclam As System.Windows.Forms.Button
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
    Friend WithEvents btnYesNo As System.Windows.Forms.Button

End Class
