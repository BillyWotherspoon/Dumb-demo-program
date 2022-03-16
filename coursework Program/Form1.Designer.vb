<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Subtract = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Devide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(298, 44)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 23)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(89, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(221, 23)
        Me.TextBox2.TabIndex = 1
        '
        'Subtract
        '
        Me.Subtract.Location = New System.Drawing.Point(159, 108)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(151, 44)
        Me.Subtract.TabIndex = 0
        Me.Subtract.Text = "Subtract"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Location = New System.Drawing.Point(159, 158)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(151, 44)
        Me.Multiply.TabIndex = 0
        Me.Multiply.Text = "Multiply"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Devide
        '
        Me.Devide.Location = New System.Drawing.Point(13, 158)
        Me.Devide.Name = "Devide"
        Me.Devide.Size = New System.Drawing.Size(140, 44)
        Me.Devide.TabIndex = 0
        Me.Devide.Text = "Devide"
        Me.Devide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number 2"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(89, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(221, 23)
        Me.TextBox3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Devide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Subtract)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Course Work Demo App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Subtract As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Devide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
End Class
