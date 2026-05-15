<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FHangman
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
        Me.components = New System.ComponentModel.Container()
        Me.FLPAbecedario = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.FLPPalabras = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerJuego = New System.Windows.Forms.Timer(Me.components)
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.PBHangman = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FLPAbecedario
        '
        Me.FLPAbecedario.Location = New System.Drawing.Point(837, 193)
        Me.FLPAbecedario.Name = "FLPAbecedario"
        Me.FLPAbecedario.Size = New System.Drawing.Size(556, 351)
        Me.FLPAbecedario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A. Failed: "
        '
        'lblContador
        '
        Me.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContador.Location = New System.Drawing.Point(202, 60)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(83, 40)
        Me.lblContador.TabIndex = 4
        '
        'FLPPalabras
        '
        Me.FLPPalabras.Location = New System.Drawing.Point(828, 62)
        Me.FLPPalabras.Name = "FLPPalabras"
        Me.FLPPalabras.Size = New System.Drawing.Size(564, 76)
        Me.FLPPalabras.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DictionaryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1505, 40)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(266, 44)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(266, 44)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DictionaryToolStripMenuItem1, Me.ScoresToolStripMenuItem})
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(86, 36)
        Me.DictionaryToolStripMenuItem.Text = "&View"
        '
        'DictionaryToolStripMenuItem1
        '
        Me.DictionaryToolStripMenuItem1.Name = "DictionaryToolStripMenuItem1"
        Me.DictionaryToolStripMenuItem1.Size = New System.Drawing.Size(257, 44)
        Me.DictionaryToolStripMenuItem1.Text = "&Dictionary"
        '
        'ScoresToolStripMenuItem
        '
        Me.ScoresToolStripMenuItem.Name = "ScoresToolStripMenuItem"
        Me.ScoresToolStripMenuItem.Size = New System.Drawing.Size(257, 44)
        Me.ScoresToolStripMenuItem.Text = "&Scores"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToolStripMenuItem
        '
        Me.HowToolStripMenuItem.Name = "HowToolStripMenuItem"
        Me.HowToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.HowToolStripMenuItem.Text = "&How to play "
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'TimerJuego
        '
        Me.TimerJuego.Interval = 1000
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(1095, 624)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(0, 37)
        Me.lblTiempo.TabIndex = 7
        '
        'PBHangman
        '
        Me.PBHangman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBHangman.Location = New System.Drawing.Point(86, 209)
        Me.PBHangman.Name = "PBHangman"
        Me.PBHangman.Size = New System.Drawing.Size(454, 510)
        Me.PBHangman.TabIndex = 1
        Me.PBHangman.TabStop = False
        '
        'FHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 781)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.FLPPalabras)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBHangman)
        Me.Controls.Add(Me.FLPAbecedario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FHangman"
        Me.Text = "Hangman"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBHangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FLPAbecedario As FlowLayoutPanel
    Friend WithEvents PBHangman As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblContador As Label
    Friend WithEvents FLPPalabras As FlowLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DictionaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerJuego As Timer
    Friend WithEvents lblTiempo As Label
    Friend WithEvents DictionaryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ScoresToolStripMenuItem As ToolStripMenuItem
End Class
