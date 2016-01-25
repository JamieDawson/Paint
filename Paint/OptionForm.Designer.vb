<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionForm
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
        Me.ComboBoxSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ButtonColor = New System.Windows.Forms.Button()
        Me.ColorDialogBrush = New System.Windows.Forms.ColorDialog()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxSize
        '
        Me.ComboBoxSize.FormattingEnabled = True
        Me.ComboBoxSize.Items.AddRange(New Object() {"Small ", "Medium", "Large "})
        Me.ComboBoxSize.Location = New System.Drawing.Point(12, 47)
        Me.ComboBoxSize.Name = "ComboBoxSize"
        Me.ComboBoxSize.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxSize.TabIndex = 0
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(68, 9)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(57, 13)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "Brush Size"
        '
        'ButtonColor
        '
        Me.ButtonColor.Location = New System.Drawing.Point(15, 86)
        Me.ButtonColor.Name = "ButtonColor"
        Me.ButtonColor.Size = New System.Drawing.Size(166, 23)
        Me.ButtonColor.TabIndex = 2
        Me.ButtonColor.Text = "Change Color"
        Me.ButtonColor.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(15, 149)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(39, 13)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Label1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 189)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "New Canvas"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 342)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.ButtonColor)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.ComboBoxSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OptionForm"
        Me.Text = "OptionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents ButtonColor As Button
    Friend WithEvents ColorDialogBrush As ColorDialog
    Friend WithEvents lblColor As Label
    Friend WithEvents btnClear As Button
End Class
