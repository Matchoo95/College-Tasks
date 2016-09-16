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
        Me.SearchEventAbtn = New System.Windows.Forms.Button
        Me.plantName = New System.Windows.Forms.TextBox
        Me.seasonToPlant = New System.Windows.Forms.TextBox
        Me.seasonToFlower = New System.Windows.Forms.TextBox
        Me.typeOfPlant = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PLantsDataSet = New WindowsApplication1.PLantsDataSet
        Me.PlantyStuffTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlantyStuffTableTableAdapter = New WindowsApplication1.PLantsDataSetTableAdapters.PlantyStuffTableTableAdapter
        Me.PlantNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeasonToPlantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeasonToFlowerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrowthHabitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HardinessRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PotSizelitresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostOfBuyingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLantsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantyStuffTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchEventAbtn
        '
        Me.SearchEventAbtn.Location = New System.Drawing.Point(238, 82)
        Me.SearchEventAbtn.Name = "SearchEventAbtn"
        Me.SearchEventAbtn.Size = New System.Drawing.Size(117, 47)
        Me.SearchEventAbtn.TabIndex = 0
        Me.SearchEventAbtn.Text = "Add Data"
        Me.SearchEventAbtn.UseVisualStyleBackColor = True
        '
        'plantName
        '
        Me.plantName.Location = New System.Drawing.Point(55, 70)
        Me.plantName.Name = "plantName"
        Me.plantName.Size = New System.Drawing.Size(100, 20)
        Me.plantName.TabIndex = 1
        '
        'seasonToPlant
        '
        Me.seasonToPlant.Location = New System.Drawing.Point(55, 96)
        Me.seasonToPlant.Name = "seasonToPlant"
        Me.seasonToPlant.Size = New System.Drawing.Size(100, 20)
        Me.seasonToPlant.TabIndex = 2
        '
        'seasonToFlower
        '
        Me.seasonToFlower.Location = New System.Drawing.Point(55, 122)
        Me.seasonToFlower.Name = "seasonToFlower"
        Me.seasonToFlower.Size = New System.Drawing.Size(100, 20)
        Me.seasonToFlower.TabIndex = 3
        '
        'typeOfPlant
        '
        Me.typeOfPlant.Location = New System.Drawing.Point(55, 148)
        Me.typeOfPlant.Name = "typeOfPlant"
        Me.typeOfPlant.Size = New System.Drawing.Size(100, 20)
        Me.typeOfPlant.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlantNameDataGridViewTextBoxColumn, Me.SeasonToPlantDataGridViewTextBoxColumn, Me.SeasonToFlowerDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.GrowthHabitDataGridViewTextBoxColumn, Me.HardinessRatingDataGridViewTextBoxColumn, Me.PotSizelitresDataGridViewTextBoxColumn, Me.CostOfBuyingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlantyStuffTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(954, 389)
        Me.DataGridView1.TabIndex = 5
        '
        'PLantsDataSet
        '
        Me.PLantsDataSet.DataSetName = "PLantsDataSet"
        Me.PLantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlantyStuffTableBindingSource
        '
        Me.PlantyStuffTableBindingSource.DataMember = "PlantyStuffTable"
        Me.PlantyStuffTableBindingSource.DataSource = Me.PLantsDataSet
        '
        'PlantyStuffTableTableAdapter
        '
        Me.PlantyStuffTableTableAdapter.ClearBeforeFill = True
        '
        'PlantNameDataGridViewTextBoxColumn
        '
        Me.PlantNameDataGridViewTextBoxColumn.DataPropertyName = "Plant Name"
        Me.PlantNameDataGridViewTextBoxColumn.HeaderText = "Plant Name"
        Me.PlantNameDataGridViewTextBoxColumn.Name = "PlantNameDataGridViewTextBoxColumn"
        '
        'SeasonToPlantDataGridViewTextBoxColumn
        '
        Me.SeasonToPlantDataGridViewTextBoxColumn.DataPropertyName = "Season to plant"
        Me.SeasonToPlantDataGridViewTextBoxColumn.HeaderText = "Season to plant"
        Me.SeasonToPlantDataGridViewTextBoxColumn.Name = "SeasonToPlantDataGridViewTextBoxColumn"
        '
        'SeasonToFlowerDataGridViewTextBoxColumn
        '
        Me.SeasonToFlowerDataGridViewTextBoxColumn.DataPropertyName = "Season to flower"
        Me.SeasonToFlowerDataGridViewTextBoxColumn.HeaderText = "Season to flower"
        Me.SeasonToFlowerDataGridViewTextBoxColumn.Name = "SeasonToFlowerDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        '
        'GrowthHabitDataGridViewTextBoxColumn
        '
        Me.GrowthHabitDataGridViewTextBoxColumn.DataPropertyName = "Growth habit"
        Me.GrowthHabitDataGridViewTextBoxColumn.HeaderText = "Growth habit"
        Me.GrowthHabitDataGridViewTextBoxColumn.Name = "GrowthHabitDataGridViewTextBoxColumn"
        '
        'HardinessRatingDataGridViewTextBoxColumn
        '
        Me.HardinessRatingDataGridViewTextBoxColumn.DataPropertyName = "Hardiness rating"
        Me.HardinessRatingDataGridViewTextBoxColumn.HeaderText = "Hardiness rating"
        Me.HardinessRatingDataGridViewTextBoxColumn.Name = "HardinessRatingDataGridViewTextBoxColumn"
        '
        'PotSizelitresDataGridViewTextBoxColumn
        '
        Me.PotSizelitresDataGridViewTextBoxColumn.DataPropertyName = "Pot Size (litres)"
        Me.PotSizelitresDataGridViewTextBoxColumn.HeaderText = "Pot Size (litres)"
        Me.PotSizelitresDataGridViewTextBoxColumn.Name = "PotSizelitresDataGridViewTextBoxColumn"
        '
        'CostOfBuyingDataGridViewTextBoxColumn
        '
        Me.CostOfBuyingDataGridViewTextBoxColumn.DataPropertyName = "Cost of buying (£)"
        Me.CostOfBuyingDataGridViewTextBoxColumn.HeaderText = "Cost of buying (£)"
        Me.CostOfBuyingDataGridViewTextBoxColumn.Name = "CostOfBuyingDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 609)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.typeOfPlant)
        Me.Controls.Add(Me.seasonToFlower)
        Me.Controls.Add(Me.seasonToPlant)
        Me.Controls.Add(Me.plantName)
        Me.Controls.Add(Me.SearchEventAbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLantsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantyStuffTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchEventAbtn As System.Windows.Forms.Button
    Friend WithEvents plantName As System.Windows.Forms.TextBox
    Friend WithEvents seasonToPlant As System.Windows.Forms.TextBox
    Friend WithEvents seasonToFlower As System.Windows.Forms.TextBox
    Friend WithEvents typeOfPlant As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PLantsDataSet As WindowsApplication1.PLantsDataSet
    Friend WithEvents PlantyStuffTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlantyStuffTableTableAdapter As WindowsApplication1.PLantsDataSetTableAdapters.PlantyStuffTableTableAdapter
    Friend WithEvents PlantNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonToPlantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonToFlowerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrowthHabitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardinessRatingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PotSizelitresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostOfBuyingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
