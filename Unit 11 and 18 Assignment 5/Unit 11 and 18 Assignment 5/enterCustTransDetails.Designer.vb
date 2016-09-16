<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enterCustTransDetails
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
        Me.submitCustTransData = New System.Windows.Forms.Button
        Me.dobInput = New System.Windows.Forms.TextBox
        Me.dateOfTransLbl = New System.Windows.Forms.Label
        Me.custIdLbl = New System.Windows.Forms.Label
        Me.enterCustTransDetailsTitl = New System.Windows.Forms.Label
        Me.custIdInput = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'submitCustTransData
        '
        Me.submitCustTransData.Location = New System.Drawing.Point(751, 89)
        Me.submitCustTransData.Name = "submitCustTransData"
        Me.submitCustTransData.Size = New System.Drawing.Size(129, 44)
        Me.submitCustTransData.TabIndex = 19
        Me.submitCustTransData.Text = "Submit Data"
        Me.submitCustTransData.UseVisualStyleBackColor = True
        '
        'dobInput
        '
        Me.dobInput.Location = New System.Drawing.Point(246, 138)
        Me.dobInput.Name = "dobInput"
        Me.dobInput.Size = New System.Drawing.Size(479, 20)
        Me.dobInput.TabIndex = 18
        '
        'dateOfTransLbl
        '
        Me.dateOfTransLbl.AutoSize = True
        Me.dateOfTransLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateOfTransLbl.Location = New System.Drawing.Point(64, 133)
        Me.dateOfTransLbl.Name = "dateOfTransLbl"
        Me.dateOfTransLbl.Size = New System.Drawing.Size(176, 24)
        Me.dateOfTransLbl.TabIndex = 16
        Me.dateOfTransLbl.Text = "Date of Transaction:"
        '
        'custIdLbl
        '
        Me.custIdLbl.AutoSize = True
        Me.custIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custIdLbl.Location = New System.Drawing.Point(64, 109)
        Me.custIdLbl.Name = "custIdLbl"
        Me.custIdLbl.Size = New System.Drawing.Size(118, 24)
        Me.custIdLbl.TabIndex = 15
        Me.custIdLbl.Text = "Customer ID:"
        '
        'enterCustTransDetailsTitl
        '
        Me.enterCustTransDetailsTitl.AutoSize = True
        Me.enterCustTransDetailsTitl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterCustTransDetailsTitl.Location = New System.Drawing.Point(12, 23)
        Me.enterCustTransDetailsTitl.Name = "enterCustTransDetailsTitl"
        Me.enterCustTransDetailsTitl.Size = New System.Drawing.Size(932, 55)
        Me.enterCustTransDetailsTitl.TabIndex = 14
        Me.enterCustTransDetailsTitl.Text = "Enter New Customer Transaction Details"
        '
        'custIdInput
        '
        Me.custIdInput.FormattingEnabled = True
        Me.custIdInput.Location = New System.Drawing.Point(246, 109)
        Me.custIdInput.Name = "custIdInput"
        Me.custIdInput.Size = New System.Drawing.Size(479, 21)
        Me.custIdInput.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(751, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'enterCustTransDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 194)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.custIdInput)
        Me.Controls.Add(Me.submitCustTransData)
        Me.Controls.Add(Me.dobInput)
        Me.Controls.Add(Me.dateOfTransLbl)
        Me.Controls.Add(Me.custIdLbl)
        Me.Controls.Add(Me.enterCustTransDetailsTitl)
        Me.Name = "enterCustTransDetails"
        Me.Text = "Enter Customer Transaction Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitCustTransData As System.Windows.Forms.Button
    Friend WithEvents dobInput As System.Windows.Forms.TextBox
    Friend WithEvents dateOfTransLbl As System.Windows.Forms.Label
    Friend WithEvents custIdLbl As System.Windows.Forms.Label
    Friend WithEvents enterCustTransDetailsTitl As System.Windows.Forms.Label
    Friend WithEvents custIdInput As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
