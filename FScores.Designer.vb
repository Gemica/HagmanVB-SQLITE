<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FScores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVScores = New System.Windows.Forms.DataGridView()
        Me.BtbFailsSort = New System.Windows.Forms.Button()
        Me.BtnTimeSort = New System.Windows.Forms.Button()
        Me.BtnTodaySort = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        CType(Me.DGVScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVScores
        '
        Me.DGVScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVScores.Location = New System.Drawing.Point(41, 39)
        Me.DGVScores.Name = "DGVScores"
        Me.DGVScores.RowHeadersWidth = 82
        Me.DGVScores.RowTemplate.Height = 33
        Me.DGVScores.Size = New System.Drawing.Size(1164, 353)
        Me.DGVScores.TabIndex = 0
        '
        'BtbFailsSort
        '
        Me.BtbFailsSort.Location = New System.Drawing.Point(43, 436)
        Me.BtbFailsSort.Name = "BtbFailsSort"
        Me.BtbFailsSort.Size = New System.Drawing.Size(139, 46)
        Me.BtbFailsSort.TabIndex = 1
        Me.BtbFailsSort.Text = "Fails Sort"
        Me.BtbFailsSort.UseVisualStyleBackColor = True
        '
        'BtnTimeSort
        '
        Me.BtnTimeSort.Location = New System.Drawing.Point(216, 436)
        Me.BtnTimeSort.Name = "BtnTimeSort"
        Me.BtnTimeSort.Size = New System.Drawing.Size(149, 46)
        Me.BtnTimeSort.TabIndex = 2
        Me.BtnTimeSort.Text = "Time Sort"
        Me.BtnTimeSort.UseVisualStyleBackColor = True
        '
        'BtnTodaySort
        '
        Me.BtnTodaySort.Location = New System.Drawing.Point(394, 436)
        Me.BtnTodaySort.Name = "BtnTodaySort"
        Me.BtnTodaySort.Size = New System.Drawing.Size(167, 46)
        Me.BtnTodaySort.TabIndex = 3
        Me.BtnTodaySort.Text = "Today Sort"
        Me.BtnTodaySort.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(598, 436)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(119, 46)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 540)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnTodaySort)
        Me.Controls.Add(Me.BtnTimeSort)
        Me.Controls.Add(Me.BtbFailsSort)
        Me.Controls.Add(Me.DGVScores)
        Me.Name = "FScores"
        Me.Text = "FScores"
        CType(Me.DGVScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVScores As DataGridView
    Friend WithEvents BtbFailsSort As Button
    Friend WithEvents BtnTimeSort As Button
    Friend WithEvents BtnTodaySort As Button
    Friend WithEvents BtnReset As Button
End Class
