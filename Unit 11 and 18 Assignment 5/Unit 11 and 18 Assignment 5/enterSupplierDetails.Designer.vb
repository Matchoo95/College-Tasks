<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enterSupplierDetails
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
        Me.submitSuppData = New System.Windows.Forms.Button
        Me.suppLandlineInput = New System.Windows.Forms.TextBox
        Me.suppAddressInput = New System.Windows.Forms.TextBox
        Me.suppNameInput = New System.Windows.Forms.TextBox
        Me.suppLandlineLbl = New System.Windows.Forms.Label
        Me.suppAddressLbl = New System.Windows.Forms.Label
        Me.suppNameLbl = New System.Windows.Forms.Label
        Me.enterSupplierDetailsTitl = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.suppIdInput = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'submitSuppData
        '
        Me.submitSuppData.Location = New System.Drawing.Point(709, 98)
        Me.submitSuppData.Name = "submitSuppData"
        Me.submitSuppData.Size = New System.Drawing.Size(128, 48)
        Me.submitSuppData.TabIndex = 21
        Me.submitSuppData.Text = "Submit Data"
        Me.submitSuppData.UseVisualStyleBackColor = True
        '
        'suppLandlineInput
        '
        Me.suppLandlineInput.Location = New System.Drawing.Point(202, 151)
        Me.suppLandlineInput.Name = "suppLandlineInput"
        Me.suppLandlineInput.Size = New System.Drawing.Size(479, 20)
        Me.suppLandlineInput.TabIndex = 20
        '
        'suppAddressInput
        '
        Me.suppAddressInput.Location = New System.Drawing.Point(202, 127)
        Me.suppAddressInput.Name = "suppAddressInput"
        Me.suppAddressInput.Size = New System.Drawing.Size(479, 20)
        Me.suppAddressInput.TabIndex = 19
        '
        'suppNameInput
        '
        Me.suppNameInput.Location = New System.Drawing.Point(202, 103)
        Me.suppNameInput.Name = "suppNameInput"
        Me.suppNameInput.Size = New System.Drawing.Size(479, 20)
        Me.suppNameInput.TabIndex = 18
        '
        'suppLandlineLbl
        '
        Me.suppLandlineLbl.AutoSize = True
        Me.suppLandlineLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppLandlineLbl.Location = New System.Drawing.Point(29, 146)
        Me.suppLandlineLbl.Name = "suppLandlineLbl"
        Me.suppLandlineLbl.Size = New System.Drawing.Size(162, 24)
        Me.suppLandlineLbl.TabIndex = 17
        Me.suppLandlineLbl.Text = "Supplier Landline:"
        '
        'suppAddressLbl
        '
        Me.suppAddressLbl.AutoSize = True
        Me.suppAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppAddressLbl.Location = New System.Drawing.Point(29, 122)
        Me.suppAddressLbl.Name = "suppAddressLbl"
        Me.suppAddressLbl.Size = New System.Drawing.Size(160, 24)
        Me.suppAddressLbl.TabIndex = 16
        Me.suppAddressLbl.Text = "Supplier Address:"
        '
        'suppNameLbl
        '
        Me.suppNameLbl.AutoSize = True
        Me.suppNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppNameLbl.Location = New System.Drawing.Point(29, 98)
        Me.suppNameLbl.Name = "suppNameLbl"
        Me.suppNameLbl.Size = New System.Drawing.Size(141, 24)
        Me.suppNameLbl.TabIndex = 15
        Me.suppNameLbl.Text = "Supplier Name:"
        '
        'enterSupplierDetailsTitl
        '
        Me.enterSupplierDetailsTitl.AutoSize = True
        Me.enterSupplierDetailsTitl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterSupplierDetailsTitl.Location = New System.Drawing.Point(172, 9)
        Me.enterSupplierDetailsTitl.Name = "enterSupplierDetailsTitl"
        Me.enterSupplierDetailsTitl.Size = New System.Drawing.Size(509, 55)
        Me.enterSupplierDetailsTitl.TabIndex = 14
        Me.enterSupplierDetailsTitl.Text = "Enter Supplier Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(708, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'suppIdInput
        '
        Me.suppIdInput.Location = New System.Drawing.Point(202, 177)
        Me.suppIdInput.Name = "suppIdInput"
        Me.suppIdInput.Size = New System.Drawing.Size(479, 20)
        Me.suppIdInput.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Supplier ID:"
        '
        'enterSupplierDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 215)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.suppIdInput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.submitSuppData)
        Me.Controls.Add(Me.suppLandlineInput)
        Me.Controls.Add(Me.suppAddressInput)
        Me.Controls.Add(Me.suppNameInput)
        Me.Controls.Add(Me.suppLandlineLbl)
        Me.Controls.Add(Me.suppAddressLbl)
        Me.Controls.Add(Me.suppNameLbl)
        Me.Controls.Add(Me.enterSupplierDetailsTitl)
        Me.Name = "enterSupplierDetails"
        Me.Text = "enterSupplierDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitSuppData As System.Windows.Forms.Button
    Friend WithEvents suppLandlineInput As System.Windows.Forms.TextBox
    Friend WithEvents suppAddressInput As System.Windows.Forms.TextBox
    Friend WithEvents suppNameInput As System.Windows.Forms.TextBox
    Friend WithEvents suppLandlineLbl As System.Windows.Forms.Label
    Friend WithEvents suppAddressLbl As System.Windows.Forms.Label
    Friend WithEvents suppNameLbl As System.Windows.Forms.Label
    Friend WithEvents enterSupplierDetailsTitl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents suppIdInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
