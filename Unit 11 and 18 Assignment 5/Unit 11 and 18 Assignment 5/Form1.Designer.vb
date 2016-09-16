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
        Me.mainMenuTtl = New System.Windows.Forms.Label
        Me.mainMenuSubmit = New System.Windows.Forms.Button
        Me.instructionsLbl = New System.Windows.Forms.Label
        Me.mainMenuOptions = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'mainMenuTtl
        '
        Me.mainMenuTtl.AutoSize = True
        Me.mainMenuTtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainMenuTtl.Location = New System.Drawing.Point(167, 9)
        Me.mainMenuTtl.Name = "mainMenuTtl"
        Me.mainMenuTtl.Size = New System.Drawing.Size(451, 55)
        Me.mainMenuTtl.TabIndex = 0
        Me.mainMenuTtl.Text = "Database Manager"
        '
        'mainMenuSubmit
        '
        Me.mainMenuSubmit.Location = New System.Drawing.Point(497, 135)
        Me.mainMenuSubmit.Name = "mainMenuSubmit"
        Me.mainMenuSubmit.Size = New System.Drawing.Size(75, 23)
        Me.mainMenuSubmit.TabIndex = 2
        Me.mainMenuSubmit.Text = "Submit"
        Me.mainMenuSubmit.UseVisualStyleBackColor = True
        '
        'instructionsLbl
        '
        Me.instructionsLbl.AutoSize = True
        Me.instructionsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsLbl.Location = New System.Drawing.Point(186, 80)
        Me.instructionsLbl.Name = "instructionsLbl"
        Me.instructionsLbl.Size = New System.Drawing.Size(396, 24)
        Me.instructionsLbl.TabIndex = 3
        Me.instructionsLbl.Text = "Select an option from the drop down list below"
        '
        'mainMenuOptions
        '
        Me.mainMenuOptions.DisplayMember = "2"
        Me.mainMenuOptions.FormattingEnabled = True
        Me.mainMenuOptions.Location = New System.Drawing.Point(190, 137)
        Me.mainMenuOptions.Name = "mainMenuOptions"
        Me.mainMenuOptions.Size = New System.Drawing.Size(301, 21)
        Me.mainMenuOptions.TabIndex = 4
        Me.mainMenuOptions.ValueMember = "2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 275)
        Me.Controls.Add(Me.mainMenuOptions)
        Me.Controls.Add(Me.instructionsLbl)
        Me.Controls.Add(Me.mainMenuSubmit)
        Me.Controls.Add(Me.mainMenuTtl)
        Me.Name = "Form1"
        Me.Text = "Database Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenuTtl As System.Windows.Forms.Label
    Friend WithEvents mainMenuSubmit As System.Windows.Forms.Button
    Friend WithEvents instructionsLbl As System.Windows.Forms.Label
    Friend WithEvents mainMenuOptions As System.Windows.Forms.ComboBox

End Class
