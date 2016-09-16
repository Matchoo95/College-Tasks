<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enterStockDetails
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
        Me.submitStockData = New System.Windows.Forms.Button
        Me.stockPriceInput = New System.Windows.Forms.TextBox
        Me.stockDescInput = New System.Windows.Forms.TextBox
        Me.stockNameInput = New System.Windows.Forms.TextBox
        Me.stockPriceLbl = New System.Windows.Forms.Label
        Me.stockDescLbl = New System.Windows.Forms.Label
        Me.stockNameLbl = New System.Windows.Forms.Label
        Me.enterStockDetailsTitl = New System.Windows.Forms.Label
        Me.suppIdLbl = New System.Windows.Forms.Label
        Me.suppIdInput = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'submitStockData
        '
        Me.submitStockData.Location = New System.Drawing.Point(692, 103)
        Me.submitStockData.Name = "submitStockData"
        Me.submitStockData.Size = New System.Drawing.Size(128, 43)
        Me.submitStockData.TabIndex = 29
        Me.submitStockData.Text = "Submit Data"
        Me.submitStockData.UseVisualStyleBackColor = True
        '
        'stockPriceInput
        '
        Me.stockPriceInput.Location = New System.Drawing.Point(184, 151)
        Me.stockPriceInput.Name = "stockPriceInput"
        Me.stockPriceInput.Size = New System.Drawing.Size(479, 20)
        Me.stockPriceInput.TabIndex = 28
        '
        'stockDescInput
        '
        Me.stockDescInput.Location = New System.Drawing.Point(184, 127)
        Me.stockDescInput.Name = "stockDescInput"
        Me.stockDescInput.Size = New System.Drawing.Size(479, 20)
        Me.stockDescInput.TabIndex = 27
        '
        'stockNameInput
        '
        Me.stockNameInput.Location = New System.Drawing.Point(184, 103)
        Me.stockNameInput.Name = "stockNameInput"
        Me.stockNameInput.Size = New System.Drawing.Size(479, 20)
        Me.stockNameInput.TabIndex = 26
        '
        'stockPriceLbl
        '
        Me.stockPriceLbl.AutoSize = True
        Me.stockPriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockPriceLbl.Location = New System.Drawing.Point(25, 146)
        Me.stockPriceLbl.Name = "stockPriceLbl"
        Me.stockPriceLbl.Size = New System.Drawing.Size(109, 24)
        Me.stockPriceLbl.TabIndex = 25
        Me.stockPriceLbl.Text = "Stock Price:"
        '
        'stockDescLbl
        '
        Me.stockDescLbl.AutoSize = True
        Me.stockDescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockDescLbl.Location = New System.Drawing.Point(25, 122)
        Me.stockDescLbl.Name = "stockDescLbl"
        Me.stockDescLbl.Size = New System.Drawing.Size(160, 24)
        Me.stockDescLbl.TabIndex = 24
        Me.stockDescLbl.Text = "Stock Description:"
        '
        'stockNameLbl
        '
        Me.stockNameLbl.AutoSize = True
        Me.stockNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockNameLbl.Location = New System.Drawing.Point(25, 98)
        Me.stockNameLbl.Name = "stockNameLbl"
        Me.stockNameLbl.Size = New System.Drawing.Size(117, 24)
        Me.stockNameLbl.TabIndex = 23
        Me.stockNameLbl.Text = "Stock Name:"
        '
        'enterStockDetailsTitl
        '
        Me.enterStockDetailsTitl.AutoSize = True
        Me.enterStockDetailsTitl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterStockDetailsTitl.Location = New System.Drawing.Point(144, 9)
        Me.enterStockDetailsTitl.Name = "enterStockDetailsTitl"
        Me.enterStockDetailsTitl.Size = New System.Drawing.Size(564, 55)
        Me.enterStockDetailsTitl.TabIndex = 22
        Me.enterStockDetailsTitl.Text = "Enter New Stock Details"
        '
        'suppIdLbl
        '
        Me.suppIdLbl.AutoSize = True
        Me.suppIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppIdLbl.Location = New System.Drawing.Point(26, 170)
        Me.suppIdLbl.Name = "suppIdLbl"
        Me.suppIdLbl.Size = New System.Drawing.Size(107, 24)
        Me.suppIdLbl.TabIndex = 30
        Me.suppIdLbl.Text = "Supplier ID:"
        '
        'suppIdInput
        '
        Me.suppIdInput.DisplayMember = "2"
        Me.suppIdInput.FormattingEnabled = True
        Me.suppIdInput.Location = New System.Drawing.Point(184, 178)
        Me.suppIdInput.Name = "suppIdInput"
        Me.suppIdInput.Size = New System.Drawing.Size(479, 21)
        Me.suppIdInput.TabIndex = 31
        Me.suppIdInput.ValueMember = "2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(692, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'enterStockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 228)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.suppIdInput)
        Me.Controls.Add(Me.suppIdLbl)
        Me.Controls.Add(Me.submitStockData)
        Me.Controls.Add(Me.stockPriceInput)
        Me.Controls.Add(Me.stockDescInput)
        Me.Controls.Add(Me.stockNameInput)
        Me.Controls.Add(Me.stockPriceLbl)
        Me.Controls.Add(Me.stockDescLbl)
        Me.Controls.Add(Me.stockNameLbl)
        Me.Controls.Add(Me.enterStockDetailsTitl)
        Me.Name = "enterStockDetails"
        Me.Text = "Enter New Stock Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitStockData As System.Windows.Forms.Button
    Friend WithEvents stockPriceInput As System.Windows.Forms.TextBox
    Friend WithEvents stockDescInput As System.Windows.Forms.TextBox
    Friend WithEvents stockNameInput As System.Windows.Forms.TextBox
    Friend WithEvents stockPriceLbl As System.Windows.Forms.Label
    Friend WithEvents stockDescLbl As System.Windows.Forms.Label
    Friend WithEvents stockNameLbl As System.Windows.Forms.Label
    Friend WithEvents enterStockDetailsTitl As System.Windows.Forms.Label
    Friend WithEvents suppIdLbl As System.Windows.Forms.Label
    Friend WithEvents suppIdInput As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
