<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FDictionary
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVWords = New System.Windows.Forms.DataGridView()
        Me.BtnSaveDB = New System.Windows.Forms.Button()
        CType(Me.DGVWords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVWords
        '
        Me.DGVWords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVWords.ColumnHeadersHeight = 46
        Me.DGVWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVWords.ColumnHeadersVisible = False
        Me.DGVWords.Location = New System.Drawing.Point(80, 45)
        Me.DGVWords.Name = "DGVWords"
        Me.DGVWords.RowHeadersWidth = 82
        Me.DGVWords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVWords.RowTemplate.Height = 33
        Me.DGVWords.Size = New System.Drawing.Size(387, 545)
        Me.DGVWords.TabIndex = 0
        '
        'BtnSaveDB
        '
        Me.BtnSaveDB.Location = New System.Drawing.Point(80, 649)
        Me.BtnSaveDB.Name = "BtnSaveDB"
        Me.BtnSaveDB.Size = New System.Drawing.Size(387, 61)
        Me.BtnSaveDB.TabIndex = 1
        Me.BtnSaveDB.Text = "Save DB"
        Me.BtnSaveDB.UseVisualStyleBackColor = True
        '
        'FDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 741)
        Me.Controls.Add(Me.BtnSaveDB)
        Me.Controls.Add(Me.DGVWords)
        Me.Name = "FDictionary"
        Me.Text = "Dictionary"
        CType(Me.DGVWords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVWords As DataGridView
    Friend WithEvents BtnSaveDB As Button
End Class
