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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(150, 104)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Cerrar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(150, 186)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Cerrar"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(79, 63)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(222, 13)
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.Text = "Cerrar los 2 formularios y salir de la aplicación."
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(105, 152)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(160, 13)
        Me.Lbl2.TabIndex = 3
        Me.Lbl2.Text = "Cerrar solamente este formulario."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Location = New System.Drawing.Point(156, 120)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
End Class
