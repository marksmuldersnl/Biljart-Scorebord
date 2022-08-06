<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btSluiten = New System.Windows.Forms.Button()
        Me.btOpslaan = New System.Windows.Forms.Button()
        Me.tbClubnaam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btSluiten
        '
        Me.btSluiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSluiten.ForeColor = System.Drawing.Color.Black
        Me.btSluiten.Location = New System.Drawing.Point(815, 31)
        Me.btSluiten.Name = "btSluiten"
        Me.btSluiten.Size = New System.Drawing.Size(134, 54)
        Me.btSluiten.TabIndex = 0
        Me.btSluiten.Text = "Sluiten"
        Me.btSluiten.UseVisualStyleBackColor = True
        '
        'btOpslaan
        '
        Me.btOpslaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOpslaan.ForeColor = System.Drawing.Color.Black
        Me.btOpslaan.Location = New System.Drawing.Point(815, 105)
        Me.btOpslaan.Name = "btOpslaan"
        Me.btOpslaan.Size = New System.Drawing.Size(134, 54)
        Me.btOpslaan.TabIndex = 1
        Me.btOpslaan.Text = "Opslaan"
        Me.btOpslaan.UseVisualStyleBackColor = True
        '
        'tbClubnaam
        '
        Me.tbClubnaam.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClubnaam.Location = New System.Drawing.Point(183, 47)
        Me.tbClubnaam.Name = "tbClubnaam"
        Me.tbClubnaam.Size = New System.Drawing.Size(365, 38)
        Me.tbClubnaam.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clubnaam"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(977, 591)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbClubnaam)
        Me.Controls.Add(Me.btOpslaan)
        Me.Controls.Add(Me.btSluiten)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSluiten As Button
    Friend WithEvents btOpslaan As Button
    Friend WithEvents tbClubnaam As TextBox
    Friend WithEvents Label1 As Label
End Class
