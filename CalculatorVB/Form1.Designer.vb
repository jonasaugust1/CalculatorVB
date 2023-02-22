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
        Me.ButtonOpDiv = New System.Windows.Forms.Button()
        Me.TextBoxNumber1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNumber2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ButtonOpMult = New System.Windows.Forms.Button()
        Me.ButtonOpSub = New System.Windows.Forms.Button()
        Me.ButtonOpSum = New System.Windows.Forms.Button()
        Me.ButtonOpExp = New System.Windows.Forms.Button()
        Me.ButtonOpFactorial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonOpDiv
        '
        Me.ButtonOpDiv.Location = New System.Drawing.Point(213, 33)
        Me.ButtonOpDiv.Name = "ButtonOpDiv"
        Me.ButtonOpDiv.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpDiv.TabIndex = 1
        Me.ButtonOpDiv.Text = "/"
        Me.ButtonOpDiv.UseVisualStyleBackColor = True
        '
        'TextBoxNumber1
        '
        Me.TextBoxNumber1.Location = New System.Drawing.Point(34, 33)
        Me.TextBoxNumber1.Name = "TextBoxNumber1"
        Me.TextBoxNumber1.Size = New System.Drawing.Size(106, 23)
        Me.TextBoxNumber1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Number 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Number 2"
        '
        'TextBoxNumber2
        '
        Me.TextBoxNumber2.Location = New System.Drawing.Point(32, 92)
        Me.TextBoxNumber2.Name = "TextBoxNumber2"
        Me.TextBoxNumber2.Size = New System.Drawing.Size(108, 23)
        Me.TextBoxNumber2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Result"
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(32, 152)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(108, 23)
        Me.TextBoxResult.TabIndex = 6
        '
        'ButtonOpMult
        '
        Me.ButtonOpMult.Location = New System.Drawing.Point(213, 74)
        Me.ButtonOpMult.Name = "ButtonOpMult"
        Me.ButtonOpMult.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpMult.TabIndex = 8
        Me.ButtonOpMult.Text = "X"
        Me.ButtonOpMult.UseVisualStyleBackColor = True
        '
        'ButtonOpSub
        '
        Me.ButtonOpSub.Location = New System.Drawing.Point(213, 116)
        Me.ButtonOpSub.Name = "ButtonOpSub"
        Me.ButtonOpSub.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpSub.TabIndex = 9
        Me.ButtonOpSub.Text = "-"
        Me.ButtonOpSub.UseVisualStyleBackColor = True
        '
        'ButtonOpSum
        '
        Me.ButtonOpSum.Location = New System.Drawing.Point(298, 33)
        Me.ButtonOpSum.Name = "ButtonOpSum"
        Me.ButtonOpSum.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpSum.TabIndex = 10
        Me.ButtonOpSum.Text = "+"
        Me.ButtonOpSum.UseVisualStyleBackColor = True
        '
        'ButtonOpExp
        '
        Me.ButtonOpExp.Location = New System.Drawing.Point(298, 74)
        Me.ButtonOpExp.Name = "ButtonOpExp"
        Me.ButtonOpExp.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpExp.TabIndex = 11
        Me.ButtonOpExp.Text = "^"
        Me.ButtonOpExp.UseVisualStyleBackColor = True
        '
        'ButtonOpFactorial
        '
        Me.ButtonOpFactorial.Location = New System.Drawing.Point(298, 116)
        Me.ButtonOpFactorial.Name = "ButtonOpFactorial"
        Me.ButtonOpFactorial.Size = New System.Drawing.Size(40, 23)
        Me.ButtonOpFactorial.TabIndex = 12
        Me.ButtonOpFactorial.Text = "!"
        Me.ButtonOpFactorial.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 207)
        Me.Controls.Add(Me.ButtonOpFactorial)
        Me.Controls.Add(Me.ButtonOpExp)
        Me.Controls.Add(Me.ButtonOpSum)
        Me.Controls.Add(Me.ButtonOpSub)
        Me.Controls.Add(Me.ButtonOpMult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNumber2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNumber1)
        Me.Controls.Add(Me.ButtonOpDiv)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonOpDiv As Button
    Friend WithEvents TextBoxNumber1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNumber2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents ButtonOpMult As Button
    Friend WithEvents ButtonOpSub As Button
    Friend WithEvents ButtonOpSum As Button
    Friend WithEvents ButtonOpExp As Button
    Friend WithEvents ButtonOpFactorial As Button
End Class
