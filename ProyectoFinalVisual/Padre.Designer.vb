<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Padre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Padre))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegundosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F4Form4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ReservaToolStripMenuItem, Me.F4Form4ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimerosToolStripMenuItem, Me.SegundosToolStripMenuItem, Me.PostresToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.MenuToolStripMenuItem.Text = "Carta"
        '
        'PrimerosToolStripMenuItem
        '
        Me.PrimerosToolStripMenuItem.Name = "PrimerosToolStripMenuItem"
        Me.PrimerosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PrimerosToolStripMenuItem.Text = "Primeros"
        '
        'SegundosToolStripMenuItem
        '
        Me.SegundosToolStripMenuItem.Name = "SegundosToolStripMenuItem"
        Me.SegundosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SegundosToolStripMenuItem.Text = "Segundos"
        '
        'PostresToolStripMenuItem
        '
        Me.PostresToolStripMenuItem.Name = "PostresToolStripMenuItem"
        Me.PostresToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PostresToolStripMenuItem.Text = "Postres"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReservaToolStripMenuItem.Text = "Reserva"
        '
        'F4Form4ToolStripMenuItem
        '
        Me.F4Form4ToolStripMenuItem.Name = "F4Form4ToolStripMenuItem"
        Me.F4Form4ToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.F4Form4ToolStripMenuItem.Text = "Salir"
        Me.F4Form4ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 69)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Food on time"
        '
        'Padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Padre"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F4Form4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PrimerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegundosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PostresToolStripMenuItem As ToolStripMenuItem
End Class
