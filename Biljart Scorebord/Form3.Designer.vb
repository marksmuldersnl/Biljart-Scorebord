<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.cbxKiesCompetitie = New System.Windows.Forms.ComboBox()
        Me.btInvullen = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.cbxKiesCompetitieB = New System.Windows.Forms.ComboBox()
        Me.cbxSelecteerSpelerB = New System.Windows.Forms.ComboBox()
        Me.cbxSelecteerSpelerA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxKiesCompetitie
        '
        Me.cbxKiesCompetitie.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxKiesCompetitie.FormattingEnabled = True
        Me.cbxKiesCompetitie.Location = New System.Drawing.Point(605, 35)
        Me.cbxKiesCompetitie.Name = "cbxKiesCompetitie"
        Me.cbxKiesCompetitie.Size = New System.Drawing.Size(825, 81)
        Me.cbxKiesCompetitie.TabIndex = 0
        '
        'btInvullen
        '
        Me.btInvullen.BackColor = System.Drawing.Color.Black
        Me.btInvullen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btInvullen.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvullen.ForeColor = System.Drawing.Color.Yellow
        Me.btInvullen.Location = New System.Drawing.Point(58, 545)
        Me.btInvullen.Name = "btInvullen"
        Me.btInvullen.Size = New System.Drawing.Size(273, 81)
        Me.btInvullen.TabIndex = 1
        Me.btInvullen.Text = "&Invullen"
        Me.btInvullen.UseVisualStyleBackColor = False
        '
        'btClose
        '
        Me.btClose.BackColor = System.Drawing.Color.Black
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.ForeColor = System.Drawing.Color.Yellow
        Me.btClose.Location = New System.Drawing.Point(1157, 532)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(273, 81)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "&Sluiten"
        Me.btClose.UseVisualStyleBackColor = False
        '
        'cbxKiesCompetitieB
        '
        Me.cbxKiesCompetitieB.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxKiesCompetitieB.FormattingEnabled = True
        Me.cbxKiesCompetitieB.Location = New System.Drawing.Point(605, 277)
        Me.cbxKiesCompetitieB.Name = "cbxKiesCompetitieB"
        Me.cbxKiesCompetitieB.Size = New System.Drawing.Size(825, 81)
        Me.cbxKiesCompetitieB.TabIndex = 3
        '
        'cbxSelecteerSpelerB
        '
        Me.cbxSelecteerSpelerB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbxSelecteerSpelerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSelecteerSpelerB.FormattingEnabled = True
        Me.cbxSelecteerSpelerB.Location = New System.Drawing.Point(605, 408)
        Me.cbxSelecteerSpelerB.Name = "cbxSelecteerSpelerB"
        Me.cbxSelecteerSpelerB.Size = New System.Drawing.Size(825, 81)
        Me.cbxSelecteerSpelerB.TabIndex = 4
        '
        'cbxSelecteerSpelerA
        '
        Me.cbxSelecteerSpelerA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbxSelecteerSpelerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSelecteerSpelerA.FormattingEnabled = True
        Me.cbxSelecteerSpelerA.Location = New System.Drawing.Point(605, 153)
        Me.cbxSelecteerSpelerA.Name = "cbxSelecteerSpelerA"
        Me.cbxSelecteerSpelerA.Size = New System.Drawing.Size(825, 81)
        Me.cbxSelecteerSpelerA.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(45, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 64)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kies competitie"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(45, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 64)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kies competitie"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(45, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(507, 64)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kies speler 1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(45, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(507, 64)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kies speler 2"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1451, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxSelecteerSpelerA)
        Me.Controls.Add(Me.cbxSelecteerSpelerB)
        Me.Controls.Add(Me.cbxKiesCompetitieB)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btInvullen)
        Me.Controls.Add(Me.cbxKiesCompetitie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Kies Speler"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxKiesCompetitie As ComboBox
    Friend WithEvents btInvullen As Button
    Friend WithEvents btClose As Button
    Friend WithEvents cbxKiesCompetitieB As ComboBox
    Friend WithEvents cbxSelecteerSpelerB As ComboBox
    Friend WithEvents cbxSelecteerSpelerA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
