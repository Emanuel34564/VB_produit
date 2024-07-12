<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnSupprimezr = New System.Windows.Forms.Button()
        Me.Base_produitDataSet1 = New VB_produit.base_produitDataSet1()
        Me.ProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduitTableAdapter = New VB_produit.base_produitDataSet1TableAdapters.produitTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatedeCreationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_produitDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn, Me.DatedeCreationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProduitBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(798, 372)
        Me.DataGridView1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Fuchsia
        Me.Button3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(651, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 39)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Rechercher"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(54, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 39)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(280, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 39)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnSupprimezr
        '
        Me.BtnSupprimezr.BackColor = System.Drawing.Color.Red
        Me.BtnSupprimezr.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupprimezr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSupprimezr.Location = New System.Drawing.Point(465, 414)
        Me.BtnSupprimezr.Name = "BtnSupprimezr"
        Me.BtnSupprimezr.Size = New System.Drawing.Size(130, 39)
        Me.BtnSupprimezr.TabIndex = 25
        Me.BtnSupprimezr.Text = "Supprimer"
        Me.BtnSupprimezr.UseVisualStyleBackColor = False
        '
        'Base_produitDataSet1
        '
        Me.Base_produitDataSet1.DataSetName = "base_produitDataSet1"
        Me.Base_produitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduitBindingSource
        '
        Me.ProduitBindingSource.DataMember = "produit"
        Me.ProduitBindingSource.DataSource = Me.Base_produitDataSet1
        '
        'ProduitTableAdapter
        '
        Me.ProduitTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 57
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationDataGridViewTextBoxColumn.Width = 88
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        Me.PrixDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrixDataGridViewTextBoxColumn.Width = 49
        '
        'DatedeCreationDataGridViewTextBoxColumn
        '
        Me.DatedeCreationDataGridViewTextBoxColumn.DataPropertyName = "Date_de_Creation"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DatedeCreationDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatedeCreationDataGridViewTextBoxColumn.HeaderText = "Date_de_Creation"
        Me.DatedeCreationDataGridViewTextBoxColumn.Name = "DatedeCreationDataGridViewTextBoxColumn"
        Me.DatedeCreationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatedeCreationDataGridViewTextBoxColumn.Width = 118
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSupprimezr)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Formulaire_produit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_produitDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSupprimezr As Button
    Friend WithEvents Base_produitDataSet1 As base_produitDataSet1
    Friend WithEvents ProduitBindingSource As BindingSource
    Friend WithEvents ProduitTableAdapter As base_produitDataSet1TableAdapters.produitTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatedeCreationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
