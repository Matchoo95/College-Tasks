<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enterTransactionDetails
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
        Me.submitTransactionData = New System.Windows.Forms.Button
        Me.custIdLbl = New System.Windows.Forms.Label
        Me.stockIdLbl = New System.Windows.Forms.Label
        Me.custTransIdLbl = New System.Windows.Forms.Label
        Me.enterTransactionDetailsTitl = New System.Windows.Forms.Label
        Me.custTransIdInput = New System.Windows.Forms.ComboBox
        Me.stockIdInput = New System.Windows.Forms.ComboBox
        Me.custIdInput = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'submitTransactionData
        '
        Me.submitTransactionData.Location = New System.Drawing.Point(743, 92)
        Me.submitTransactionData.Name = "submitTransactionData"
        Me.submitTransactionData.Size = New System.Drawing.Size(128, 43)
        Me.submitTransactionData.TabIndex = 37
        Me.submitTransactionData.Text = "Submit Data"
        Me.submitTransactionData.UseVisualStyleBackColor = True
        '
        'custIdLbl
        '
        Me.custIdLbl.AutoSize = True
        Me.custIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custIdLbl.Location = New System.Drawing.Point(12, 146)
        Me.custIdLbl.Name = "custIdLbl"
        Me.custIdLbl.Size = New System.Drawing.Size(118, 24)
        Me.custIdLbl.TabIndex = 33
        Me.custIdLbl.Text = "Customer ID:"
        '
        'stockIdLbl
        '
        Me.stockIdLbl.AutoSize = True
        Me.stockIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockIdLbl.Location = New System.Drawing.Point(12, 122)
        Me.stockIdLbl.Name = "stockIdLbl"
        Me.stockIdLbl.Size = New System.Drawing.Size(83, 24)
        Me.stockIdLbl.TabIndex = 32
        Me.stockIdLbl.Text = "Stock ID:"
        '
        'custTransIdLbl
        '
        Me.custTransIdLbl.AutoSize = True
        Me.custTransIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custTransIdLbl.Location = New System.Drawing.Point(12, 98)
        Me.custTransIdLbl.Name = "custTransIdLbl"
        Me.custTransIdLbl.Size = New System.Drawing.Size(221, 24)
        Me.custTransIdLbl.TabIndex = 31
        Me.custTransIdLbl.Text = "Customer Transaction ID:"
        '
        'enterTransactionDetailsTitl
        '
        Me.enterTransactionDetailsTitl.AutoSize = True
        Me.enterTransactionDetailsTitl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterTransactionDetailsTitl.Location = New System.Drawing.Point(108, 9)
        Me.enterTransactionDetailsTitl.Name = "enterTransactionDetailsTitl"
        Me.enterTransactionDetailsTitl.Size = New System.Drawing.Size(701, 55)
        Me.enterTransactionDetailsTitl.TabIndex = 30
        Me.enterTransactionDetailsTitl.Text = "Enter New Transaction Details"
        '
        'custTransIdInput
        '
        Me.custTransIdInput.DisplayMember = "2"
        Me.custTransIdInput.FormattingEnabled = True
        Me.custTransIdInput.Location = New System.Drawing.Point(240, 100)
        Me.custTransIdInput.Name = "custTransIdInput"
        Me.custTransIdInput.Size = New System.Drawing.Size(497, 21)
        Me.custTransIdInput.TabIndex = 38
        Me.custTransIdInput.ValueMember = "2"
        '
        'stockIdInput
        '
        Me.stockIdInput.FormattingEnabled = True
        Me.stockIdInput.Location = New System.Drawing.Point(240, 128)
        Me.stockIdInput.Name = "stockIdInput"
        Me.stockIdInput.Size = New System.Drawing.Size(497, 21)
        Me.stockIdInput.TabIndex = 39
        '
        'custIdInput
        '
        Me.custIdInput.FormattingEnabled = True
        Me.custIdInput.Location = New System.Drawing.Point(240, 156)
        Me.custIdInput.Name = "custIdInput"
        Me.custIdInput.Size = New System.Drawing.Size(497, 21)
        Me.custIdInput.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(742, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'enterTransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 196)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.custIdInput)
        Me.Controls.Add(Me.stockIdInput)
        Me.Controls.Add(Me.custTransIdInput)
        Me.Controls.Add(Me.submitTransactionData)
        Me.Controls.Add(Me.custIdLbl)
        Me.Controls.Add(Me.stockIdLbl)
        Me.Controls.Add(Me.custTransIdLbl)
        Me.Controls.Add(Me.enterTransactionDetailsTitl)
        Me.Name = "enterTransactionDetails"
        Me.Text = "Enter New Transaction Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitTransactionData As System.Windows.Forms.Button
    Friend WithEvents custIdLbl As System.Windows.Forms.Label
    Friend WithEvents stockIdLbl As System.Windows.Forms.Label
    Friend WithEvents custTransIdLbl As System.Windows.Forms.Label
    Friend WithEvents enterTransactionDetailsTitl As System.Windows.Forms.Label
    Friend WithEvents custTransIdInput As System.Windows.Forms.ComboBox
    Friend WithEvents stockIdInput As System.Windows.Forms.ComboBox
    Friend WithEvents custIdInput As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
