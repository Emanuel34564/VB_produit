<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulaire_de_creation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtPrix = New System.Windows.Forms.TextBox()
        Me.TxtDesigniation = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(219, 177)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(362, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'TxtPrix
        '
        Me.TxtPrix.Location = New System.Drawing.Point(219, 135)
        Me.TxtPrix.Multiline = True
        Me.TxtPrix.Name = "TxtPrix"
        Me.TxtPrix.Size = New System.Drawing.Size(362, 30)
        Me.TxtPrix.TabIndex = 18
        '
        'TxtDesigniation
        '
        Me.TxtDesigniation.Location = New System.Drawing.Point(219, 96)
        Me.TxtDesigniation.Multiline = True
        Me.TxtDesigniation.Name = "TxtDesigniation"
        Me.TxtDesigniation.Size = New System.Drawing.Size(362, 30)
        Me.TxtDesigniation.TabIndex = 17
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(219, 56)
        Me.TxtCode.Multiline = True
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(362, 30)
        Me.TxtCode.TabIndex = 16
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(219, 20)
        Me.TxtId.Multiline = True
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(362, 30)
        Me.TxtId.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(46, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Date_de_Creation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(46, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Prix"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(46, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Designation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(46, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(46, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 221)
        Me.DataGridView1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(645, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 47)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Formulaire_de_creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtPrix)
        Me.Controls.Add(Me.TxtDesigniation)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formulaire_de_creation"
        Me.Text = "Formulaire_de_creation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtDesigniation As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
