<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Euler
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
        Me.lblx0 = New System.Windows.Forms.Label()
        Me.lbly0 = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.lblfuncion = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.lblxf = New System.Windows.Forms.Label()
        Me.tx0 = New System.Windows.Forms.TextBox()
        Me.ty0 = New System.Windows.Forms.TextBox()
        Me.txf = New System.Windows.Forms.TextBox()
        Me.th = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblx0
        '
        Me.lblx0.AutoSize = True
        Me.lblx0.Location = New System.Drawing.Point(23, 22)
        Me.lblx0.Name = "lblx0"
        Me.lblx0.Size = New System.Drawing.Size(21, 13)
        Me.lblx0.TabIndex = 0
        Me.lblx0.Text = "x0:"
        '
        'lbly0
        '
        Me.lbly0.AutoSize = True
        Me.lbly0.Location = New System.Drawing.Point(23, 58)
        Me.lbly0.Name = "lbly0"
        Me.lbly0.Size = New System.Drawing.Size(21, 13)
        Me.lbly0.TabIndex = 1
        Me.lbly0.Text = "y0:"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Location = New System.Drawing.Point(23, 205)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(17, 13)
        Me.lblc.TabIndex = 3
        Me.lblc.Text = "C:"
        '
        'lblfuncion
        '
        Me.lblfuncion.AutoSize = True
        Me.lblfuncion.Location = New System.Drawing.Point(23, 169)
        Me.lblfuncion.Name = "lblfuncion"
        Me.lblfuncion.Size = New System.Drawing.Size(48, 13)
        Me.lblfuncion.TabIndex = 2
        Me.lblfuncion.Text = "Función:"
        '
        'lblh
        '
        Me.lblh.AutoSize = True
        Me.lblh.Location = New System.Drawing.Point(23, 129)
        Me.lblh.Name = "lblh"
        Me.lblh.Size = New System.Drawing.Size(16, 13)
        Me.lblh.TabIndex = 5
        Me.lblh.Text = "h:"
        '
        'lblxf
        '
        Me.lblxf.AutoSize = True
        Me.lblxf.Location = New System.Drawing.Point(23, 93)
        Me.lblxf.Name = "lblxf"
        Me.lblxf.Size = New System.Drawing.Size(18, 13)
        Me.lblxf.TabIndex = 4
        Me.lblxf.Text = "xf:"
        '
        'tx0
        '
        Me.tx0.Location = New System.Drawing.Point(50, 19)
        Me.tx0.Name = "tx0"
        Me.tx0.Size = New System.Drawing.Size(76, 20)
        Me.tx0.TabIndex = 7
        '
        'ty0
        '
        Me.ty0.Location = New System.Drawing.Point(50, 58)
        Me.ty0.Name = "ty0"
        Me.ty0.Size = New System.Drawing.Size(76, 20)
        Me.ty0.TabIndex = 8
        '
        'txf
        '
        Me.txf.Location = New System.Drawing.Point(50, 93)
        Me.txf.Name = "txf"
        Me.txf.Size = New System.Drawing.Size(76, 20)
        Me.txf.TabIndex = 9
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(50, 129)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(76, 20)
        Me.th.TabIndex = 10
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(77, 169)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(185, 20)
        Me.tf.TabIndex = 11
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(50, 205)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(76, 20)
        Me.tc.TabIndex = 12
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(346, 17)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 13
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(346, 58)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 14
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Salida.Location = New System.Drawing.Point(439, 19)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(240, 150)
        Me.Salida.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "valor x"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "valor y"
        Me.Column2.Name = "Column2"
        '
        'Euler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 251)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.txf)
        Me.Controls.Add(Me.ty0)
        Me.Controls.Add(Me.tx0)
        Me.Controls.Add(Me.lblh)
        Me.Controls.Add(Me.lblxf)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.lblfuncion)
        Me.Controls.Add(Me.lbly0)
        Me.Controls.Add(Me.lblx0)
        Me.Name = "Euler"
        Me.Text = "Método de Euler"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblx0 As Label
    Friend WithEvents lbly0 As Label
    Friend WithEvents lblc As Label
    Friend WithEvents lblfuncion As Label
    Friend WithEvents lblh As Label
    Friend WithEvents lblxf As Label
    Friend WithEvents tx0 As TextBox
    Friend WithEvents ty0 As TextBox
    Friend WithEvents txf As TextBox
    Friend WithEvents th As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
