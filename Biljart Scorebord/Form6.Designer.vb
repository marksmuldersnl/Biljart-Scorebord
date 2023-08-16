<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonYes = New System.Windows.Forms.Button()
        Me.buttonNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 87)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nieuwe partij starten? De wedstrijdgegevens zullen gewist worden."
        '
        'buttonYes
        '
        Me.buttonYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonYes.ForeColor = System.Drawing.Color.Black
        Me.buttonYes.Location = New System.Drawing.Point(103, 218)
        Me.buttonYes.Name = "buttonYes"
        Me.buttonYes.Size = New System.Drawing.Size(188, 100)
        Me.buttonYes.TabIndex = 1
        Me.buttonYes.Text = "Ja"
        Me.buttonYes.UseVisualStyleBackColor = True
        '
        'buttonNo
        '
        Me.buttonNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonNo.ForeColor = System.Drawing.Color.Black
        Me.buttonNo.Location = New System.Drawing.Point(421, 218)
        Me.buttonNo.Name = "buttonNo"
        Me.buttonNo.Size = New System.Drawing.Size(188, 100)
        Me.buttonNo.TabIndex = 2
        Me.buttonNo.Text = "Nee"
        Me.buttonNo.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(735, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonNo)
        Me.Controls.Add(Me.buttonYes)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nieuwe wedstrijd starten?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents buttonYes As Button
    Friend WithEvents buttonNo As Button
End Class
