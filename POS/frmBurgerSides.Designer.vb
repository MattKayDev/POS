﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgerSides
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgerSides))
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(183, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(111, 33)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Salad?"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(300, 73)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(138, 41)
        Me.button2.TabIndex = 13
        Me.button2.Text = "Onions"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(156, 73)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(138, 41)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Tomato"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(12, 73)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(138, 41)
        Me.button3.TabIndex = 11
        Me.button3.Text = "Lettuce"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(300, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 41)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "No Salad"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 41)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Full Salad"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(156, 194)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(138, 41)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Sauce?"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmBurgerSides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 247)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBurgerSides"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button3 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
End Class
