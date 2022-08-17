<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(79, 63)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(222, 13)
        Me.Lbl3.TabIndex = 3
        Me.Lbl3.Text = "Cerrar los 2 formularios y salir de la aplicación."
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(150, 104)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 4
        Me.Btn3.Text = "Cerrar"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(105, 152)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(160, 13)
        Me.Lbl4.TabIndex = 6
        Me.Lbl4.Text = "Cerrar solamente este formulario."
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(150, 186)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 23)
        Me.Btn4.TabIndex = 5
        Me.Btn4.Text = "Cerrar"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Lbl3)
        Me.Location = New System.Drawing.Point(520, 120)
        Me.Name = "Form2"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl3 As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Btn4 As Button
End Class
