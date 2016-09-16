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
        Me.components = New System.ComponentModel.Container
        Me.txtStop = New System.Windows.Forms.TextBox
        Me.txtGetReady = New System.Windows.Forms.TextBox
        Me.txtGO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtStop
        '
        Me.txtStop.Location = New System.Drawing.Point(417, 132)
        Me.txtStop.Name = "txtStop"
        Me.txtStop.Size = New System.Drawing.Size(100, 20)
        Me.txtStop.TabIndex = 0
        '
        'txtGetReady
        '
        Me.txtGetReady.Location = New System.Drawing.Point(417, 210)
        Me.txtGetReady.Name = "txtGetReady"
        Me.txtGetReady.Size = New System.Drawing.Size(100, 20)
        Me.txtGetReady.TabIndex = 1
        '
        'txtGO
        '
        Me.txtGO.Location = New System.Drawing.Point(417, 292)
        Me.txtGO.Name = "txtGO"
        Me.txtGO.Size = New System.Drawing.Size(100, 20)
        Me.txtGO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stop!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Get Ready.."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Go!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 68)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Click to set lights going"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(537, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 68)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Click to stop the light for maintenance"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(537, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 68)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Click to end the program"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 686)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGO)
        Me.Controls.Add(Me.txtGetReady)
        Me.Controls.Add(Me.txtStop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStop As System.Windows.Forms.TextBox
    Friend WithEvents txtGetReady As System.Windows.Forms.TextBox
    Friend WithEvents txtGO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
