<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLevel
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
        Me.GBLevel = New System.Windows.Forms.GroupBox()
        Me.RbExpert = New System.Windows.Forms.RadioButton()
        Me.RbIntermediate = New System.Windows.Forms.RadioButton()
        Me.RbBegginer = New System.Windows.Forms.RadioButton()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GBLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBLevel
        '
        Me.GBLevel.Controls.Add(Me.RbExpert)
        Me.GBLevel.Controls.Add(Me.RbIntermediate)
        Me.GBLevel.Controls.Add(Me.RbBegginer)
        Me.GBLevel.Location = New System.Drawing.Point(46, 49)
        Me.GBLevel.Name = "GBLevel"
        Me.GBLevel.Size = New System.Drawing.Size(391, 370)
        Me.GBLevel.TabIndex = 0
        Me.GBLevel.TabStop = False
        Me.GBLevel.Text = "Select Level"
        '
        'RbExpert
        '
        Me.RbExpert.AutoSize = True
        Me.RbExpert.Location = New System.Drawing.Point(48, 266)
        Me.RbExpert.Name = "RbExpert"
        Me.RbExpert.Size = New System.Drawing.Size(105, 29)
        Me.RbExpert.TabIndex = 2
        Me.RbExpert.TabStop = True
        Me.RbExpert.Text = "Expert"
        Me.RbExpert.UseVisualStyleBackColor = True
        '
        'RbIntermediate
        '
        Me.RbIntermediate.AutoSize = True
        Me.RbIntermediate.Location = New System.Drawing.Point(48, 177)
        Me.RbIntermediate.Name = "RbIntermediate"
        Me.RbIntermediate.Size = New System.Drawing.Size(161, 29)
        Me.RbIntermediate.TabIndex = 1
        Me.RbIntermediate.TabStop = True
        Me.RbIntermediate.Text = "Intermediate"
        Me.RbIntermediate.UseVisualStyleBackColor = True
        '
        'RbBegginer
        '
        Me.RbBegginer.AutoSize = True
        Me.RbBegginer.Checked = True
        Me.RbBegginer.Location = New System.Drawing.Point(48, 80)
        Me.RbBegginer.Name = "RbBegginer"
        Me.RbBegginer.Size = New System.Drawing.Size(129, 29)
        Me.RbBegginer.TabIndex = 0
        Me.RbBegginer.TabStop = True
        Me.RbBegginer.Text = "Begginer"
        Me.RbBegginer.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(46, 452)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(154, 49)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(283, 452)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(154, 49)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 578)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.GBLevel)
        Me.Name = "FLevel"
        Me.Text = "Level"
        Me.GBLevel.ResumeLayout(False)
        Me.GBLevel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBLevel As GroupBox
    Friend WithEvents RbExpert As RadioButton
    Friend WithEvents RbIntermediate As RadioButton
    Friend WithEvents RbBegginer As RadioButton
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
End Class
