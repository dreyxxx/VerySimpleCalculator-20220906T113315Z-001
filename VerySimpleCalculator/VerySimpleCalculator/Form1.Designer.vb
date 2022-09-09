<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblfirstName = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.lblsecondName = New System.Windows.Forms.Label()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnDifference = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnQuotient = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblfirstName
        '
        Me.lblfirstName.AutoSize = True
        Me.lblfirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstName.Location = New System.Drawing.Point(26, 40)
        Me.lblfirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstName.Name = "lblfirstName"
        Me.lblfirstName.Size = New System.Drawing.Size(181, 32)
        Me.lblfirstName.TabIndex = 0
        Me.lblfirstName.Text = "First number:"
        '
        'txtBox1
        '
        Me.txtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox1.Location = New System.Drawing.Point(216, 35)
        Me.txtBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(150, 39)
        Me.txtBox1.TabIndex = 1
        '
        'lblsecondName
        '
        Me.lblsecondName.AutoSize = True
        Me.lblsecondName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondName.Location = New System.Drawing.Point(26, 111)
        Me.lblsecondName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecondName.Name = "lblsecondName"
        Me.lblsecondName.Size = New System.Drawing.Size(223, 32)
        Me.lblsecondName.TabIndex = 0
        Me.lblsecondName.Text = "Second number:"
        '
        'txtBox2
        '
        Me.txtBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox2.Location = New System.Drawing.Point(262, 106)
        Me.txtBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(103, 39)
        Me.txtBox2.TabIndex = 1
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSum.Location = New System.Drawing.Point(30, 180)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(160, 58)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnDifference
        '
        Me.btnDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifference.Location = New System.Drawing.Point(208, 180)
        Me.btnDifference.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Size = New System.Drawing.Size(159, 58)
        Me.btnDifference.TabIndex = 2
        Me.btnDifference.Text = "Difference"
        Me.btnDifference.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.Location = New System.Drawing.Point(30, 248)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(160, 58)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnQuotient
        '
        Me.btnQuotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotient.Location = New System.Drawing.Point(208, 248)
        Me.btnQuotient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuotient.Name = "btnQuotient"
        Me.btnQuotient.Size = New System.Drawing.Size(159, 58)
        Me.btnQuotient.TabIndex = 2
        Me.btnQuotient.Text = "Quotient"
        Me.btnQuotient.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(26, 349)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 32)
        Me.lblResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(430, 420)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnQuotient)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnDifference)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.lblsecondName)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.lblfirstName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "frmVerySimpleCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfirstName As System.Windows.Forms.Label
    Friend WithEvents txtBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblsecondName As System.Windows.Forms.Label
    Friend WithEvents txtBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents btnDifference As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnQuotient As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
