<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RBImperial = New System.Windows.Forms.RadioButton()
        Me.RBMatri = New System.Windows.Forms.RadioButton()
        Me.RBQueen = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBKing = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBLino = New System.Windows.Forms.CheckBox()
        Me.CBAlgodon = New System.Windows.Forms.CheckBox()
        Me.CBSeda = New System.Windows.Forms.CheckBox()
        Me.CBHilo = New System.Windows.Forms.CheckBox()
        Me.TxtLino = New System.Windows.Forms.TextBox()
        Me.TxtAlgodon = New System.Windows.Forms.TextBox()
        Me.TxtSeda = New System.Windows.Forms.TextBox()
        Me.TxtHilo = New System.Windows.Forms.TextBox()
        Me.LblSalida = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCubreCama = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBImperial
        '
        Me.RBImperial.AutoSize = True
        Me.RBImperial.Location = New System.Drawing.Point(21, 65)
        Me.RBImperial.Name = "RBImperial"
        Me.RBImperial.Size = New System.Drawing.Size(91, 24)
        Me.RBImperial.TabIndex = 1
        Me.RBImperial.TabStop = True
        Me.RBImperial.Text = "Imperial"
        Me.RBImperial.UseVisualStyleBackColor = True
        '
        'RBMatri
        '
        Me.RBMatri.AutoSize = True
        Me.RBMatri.Location = New System.Drawing.Point(118, 65)
        Me.RBMatri.Name = "RBMatri"
        Me.RBMatri.Size = New System.Drawing.Size(119, 24)
        Me.RBMatri.TabIndex = 2
        Me.RBMatri.TabStop = True
        Me.RBMatri.Text = "Matrimonial"
        Me.RBMatri.UseVisualStyleBackColor = True
        '
        'RBQueen
        '
        Me.RBQueen.AutoSize = True
        Me.RBQueen.Location = New System.Drawing.Point(247, 65)
        Me.RBQueen.Name = "RBQueen"
        Me.RBQueen.Size = New System.Drawing.Size(80, 24)
        Me.RBQueen.TabIndex = 3
        Me.RBQueen.TabStop = True
        Me.RBQueen.Text = "Queen"
        Me.RBQueen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.LblCubreCama)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnCalcular)
        Me.GroupBox1.Controls.Add(Me.LblSalida)
        Me.GroupBox1.Controls.Add(Me.TxtHilo)
        Me.GroupBox1.Controls.Add(Me.TxtSeda)
        Me.GroupBox1.Controls.Add(Me.TxtAlgodon)
        Me.GroupBox1.Controls.Add(Me.TxtLino)
        Me.GroupBox1.Controls.Add(Me.CBHilo)
        Me.GroupBox1.Controls.Add(Me.CBSeda)
        Me.GroupBox1.Controls.Add(Me.CBAlgodon)
        Me.GroupBox1.Controls.Add(Me.CBLino)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RBKing)
        Me.GroupBox1.Controls.Add(Me.RBQueen)
        Me.GroupBox1.Controls.Add(Me.RBImperial)
        Me.GroupBox1.Controls.Add(Me.RBMatri)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 368)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producción"
        '
        'RBKing
        '
        Me.RBKing.AutoSize = True
        Me.RBKing.Location = New System.Drawing.Point(349, 65)
        Me.RBKing.Name = "RBKing"
        Me.RBKing.Size = New System.Drawing.Size(62, 24)
        Me.RBKing.TabIndex = 4
        Me.RBKing.TabStop = True
        Me.RBKing.Text = "King"
        Me.RBKing.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Q65.50"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Q85.99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Q99.99"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Q105.99"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Seleccione el tamaño del cubrecama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Q39.99"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Q30.99"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Q23.99"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Q15.00"
        '
        'CBLino
        '
        Me.CBLino.AutoSize = True
        Me.CBLino.Location = New System.Drawing.Point(21, 161)
        Me.CBLino.Name = "CBLino"
        Me.CBLino.Size = New System.Drawing.Size(62, 24)
        Me.CBLino.TabIndex = 18
        Me.CBLino.Text = "Lino"
        Me.CBLino.UseVisualStyleBackColor = True
        '
        'CBAlgodon
        '
        Me.CBAlgodon.AutoSize = True
        Me.CBAlgodon.Location = New System.Drawing.Point(21, 209)
        Me.CBAlgodon.Name = "CBAlgodon"
        Me.CBAlgodon.Size = New System.Drawing.Size(94, 24)
        Me.CBAlgodon.TabIndex = 19
        Me.CBAlgodon.Text = "Algodón"
        Me.CBAlgodon.UseVisualStyleBackColor = True
        '
        'CBSeda
        '
        Me.CBSeda.AutoSize = True
        Me.CBSeda.Location = New System.Drawing.Point(21, 255)
        Me.CBSeda.Name = "CBSeda"
        Me.CBSeda.Size = New System.Drawing.Size(70, 24)
        Me.CBSeda.TabIndex = 20
        Me.CBSeda.Text = "Seda"
        Me.CBSeda.UseVisualStyleBackColor = True
        '
        'CBHilo
        '
        Me.CBHilo.AutoSize = True
        Me.CBHilo.Location = New System.Drawing.Point(21, 307)
        Me.CBHilo.Name = "CBHilo"
        Me.CBHilo.Size = New System.Drawing.Size(112, 24)
        Me.CBHilo.TabIndex = 21
        Me.CBHilo.Text = "Hilo Crudo"
        Me.CBHilo.UseVisualStyleBackColor = True
        '
        'TxtLino
        '
        Me.TxtLino.Location = New System.Drawing.Point(141, 161)
        Me.TxtLino.Name = "TxtLino"
        Me.TxtLino.Size = New System.Drawing.Size(60, 26)
        Me.TxtLino.TabIndex = 22
        '
        'TxtAlgodon
        '
        Me.TxtAlgodon.Location = New System.Drawing.Point(141, 209)
        Me.TxtAlgodon.Name = "TxtAlgodon"
        Me.TxtAlgodon.Size = New System.Drawing.Size(60, 26)
        Me.TxtAlgodon.TabIndex = 23
        '
        'TxtSeda
        '
        Me.TxtSeda.Location = New System.Drawing.Point(141, 255)
        Me.TxtSeda.Name = "TxtSeda"
        Me.TxtSeda.Size = New System.Drawing.Size(60, 26)
        Me.TxtSeda.TabIndex = 24
        '
        'TxtHilo
        '
        Me.TxtHilo.Location = New System.Drawing.Point(141, 307)
        Me.TxtHilo.Name = "TxtHilo"
        Me.TxtHilo.Size = New System.Drawing.Size(60, 26)
        Me.TxtHilo.TabIndex = 25
        '
        'LblSalida
        '
        Me.LblSalida.AutoSize = True
        Me.LblSalida.Location = New System.Drawing.Point(243, 181)
        Me.LblSalida.Name = "LblSalida"
        Me.LblSalida.Size = New System.Drawing.Size(301, 20)
        Me.LblSalida.TabIndex = 26
        Me.LblSalida.Text = "El costo final del producto será de Q"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCalcular.Location = New System.Drawing.Point(246, 305)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(97, 28)
        Me.BtnCalcular.TabIndex = 27
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLimpiar.Location = New System.Drawing.Point(349, 305)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(86, 28)
        Me.BtnLimpiar.TabIndex = 28
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(441, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblCubreCama
        '
        Me.LblCubreCama.AutoSize = True
        Me.LblCubreCama.Location = New System.Drawing.Point(243, 209)
        Me.LblCubreCama.Name = "LblCubreCama"
        Me.LblCubreCama.Size = New System.Drawing.Size(163, 20)
        Me.LblCubreCama.TabIndex = 30
        Me.LblCubreCama.Text = "Para el cubrecama "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Keyner Sontay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RBImperial As RadioButton
    Friend WithEvents RBMatri As RadioButton
    Friend WithEvents RBQueen As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LblSalida As Label
    Friend WithEvents TxtHilo As TextBox
    Friend WithEvents TxtSeda As TextBox
    Friend WithEvents TxtAlgodon As TextBox
    Friend WithEvents TxtLino As TextBox
    Friend WithEvents CBHilo As CheckBox
    Friend WithEvents CBSeda As CheckBox
    Friend WithEvents CBAlgodon As CheckBox
    Friend WithEvents CBLino As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RBKing As RadioButton
    Friend WithEvents LblCubreCama As Label
End Class
