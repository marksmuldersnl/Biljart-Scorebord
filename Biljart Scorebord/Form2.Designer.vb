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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.udMaxAantal = New System.Windows.Forms.NumericUpDown()
        Me.cbxMaxAantalBeurtenAan = New System.Windows.Forms.CheckBox()
        Me.tbLogoPad = New System.Windows.Forms.TextBox()
        Me.btSelecteerLogo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btLogoAanpassen = New System.Windows.Forms.Button()
        Me.btStandaard = New System.Windows.Forms.Button()
        Me.cbxMaxAantalAan = New System.Windows.Forms.CheckBox()
        CType(Me.udMaxAantal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSluiten
        '
        Me.btSluiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSluiten.ForeColor = System.Drawing.Color.Black
        Me.btSluiten.Location = New System.Drawing.Point(779, 31)
        Me.btSluiten.Name = "btSluiten"
        Me.btSluiten.Size = New System.Drawing.Size(170, 54)
        Me.btSluiten.TabIndex = 0
        Me.btSluiten.Text = "Sluiten"
        Me.btSluiten.UseVisualStyleBackColor = True
        '
        'btOpslaan
        '
        Me.btOpslaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOpslaan.ForeColor = System.Drawing.Color.Black
        Me.btOpslaan.Location = New System.Drawing.Point(779, 149)
        Me.btOpslaan.Name = "btOpslaan"
        Me.btOpslaan.Size = New System.Drawing.Size(170, 54)
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
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(32, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clubnaam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(32, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Max Aantal Beurten"
        '
        'udMaxAantal
        '
        Me.udMaxAantal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udMaxAantal.Location = New System.Drawing.Point(428, 105)
        Me.udMaxAantal.Name = "udMaxAantal"
        Me.udMaxAantal.Size = New System.Drawing.Size(120, 38)
        Me.udMaxAantal.TabIndex = 5
        Me.udMaxAantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxMaxAantalBeurtenAan
        '
        Me.cbxMaxAantalBeurtenAan.AutoSize = True
        Me.cbxMaxAantalBeurtenAan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMaxAantalBeurtenAan.Location = New System.Drawing.Point(38, 163)
        Me.cbxMaxAantalBeurtenAan.Name = "cbxMaxAantalBeurtenAan"
        Me.cbxMaxAantalBeurtenAan.Size = New System.Drawing.Size(324, 35)
        Me.cbxMaxAantalBeurtenAan.TabIndex = 6
        Me.cbxMaxAantalBeurtenAan.Text = "Max Aantal Beurten Aan"
        Me.cbxMaxAantalBeurtenAan.UseVisualStyleBackColor = True
        '
        'tbLogoPad
        '
        Me.tbLogoPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLogoPad.Location = New System.Drawing.Point(335, 298)
        Me.tbLogoPad.Name = "tbLogoPad"
        Me.tbLogoPad.Size = New System.Drawing.Size(345, 38)
        Me.tbLogoPad.TabIndex = 7
        '
        'btSelecteerLogo
        '
        Me.btSelecteerLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSelecteerLogo.ForeColor = System.Drawing.Color.Black
        Me.btSelecteerLogo.Location = New System.Drawing.Point(38, 298)
        Me.btSelecteerLogo.Name = "btSelecteerLogo"
        Me.btSelecteerLogo.Size = New System.Drawing.Size(262, 38)
        Me.btSelecteerLogo.TabIndex = 8
        Me.btSelecteerLogo.Text = "Selecteer Logo"
        Me.btSelecteerLogo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "png"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btLogoAanpassen
        '
        Me.btLogoAanpassen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogoAanpassen.ForeColor = System.Drawing.Color.Black
        Me.btLogoAanpassen.Location = New System.Drawing.Point(718, 289)
        Me.btLogoAanpassen.Name = "btLogoAanpassen"
        Me.btLogoAanpassen.Size = New System.Drawing.Size(247, 54)
        Me.btLogoAanpassen.TabIndex = 9
        Me.btLogoAanpassen.Text = "Standaard Logo"
        Me.btLogoAanpassen.UseVisualStyleBackColor = True
        '
        'btStandaard
        '
        Me.btStandaard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btStandaard.ForeColor = System.Drawing.Color.Black
        Me.btStandaard.Location = New System.Drawing.Point(779, 89)
        Me.btStandaard.Name = "btStandaard"
        Me.btStandaard.Size = New System.Drawing.Size(170, 54)
        Me.btStandaard.TabIndex = 10
        Me.btStandaard.Text = "Standaard"
        Me.btStandaard.UseVisualStyleBackColor = True
        '
        'cbxMaxAantalAan
        '
        Me.cbxMaxAantalAan.AutoSize = True
        Me.cbxMaxAantalAan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMaxAantalAan.Location = New System.Drawing.Point(38, 204)
        Me.cbxMaxAantalAan.Name = "cbxMaxAantalAan"
        Me.cbxMaxAantalAan.Size = New System.Drawing.Size(222, 35)
        Me.cbxMaxAantalAan.TabIndex = 11
        Me.cbxMaxAantalAan.Text = "Max Aantal Aan"
        Me.cbxMaxAantalAan.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(977, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbxMaxAantalAan)
        Me.Controls.Add(Me.btStandaard)
        Me.Controls.Add(Me.btLogoAanpassen)
        Me.Controls.Add(Me.btSelecteerLogo)
        Me.Controls.Add(Me.tbLogoPad)
        Me.Controls.Add(Me.cbxMaxAantalBeurtenAan)
        Me.Controls.Add(Me.udMaxAantal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbClubnaam)
        Me.Controls.Add(Me.btOpslaan)
        Me.Controls.Add(Me.btSluiten)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Instellingen"
        CType(Me.udMaxAantal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSluiten As Button
    Friend WithEvents btOpslaan As Button
    Friend WithEvents tbClubnaam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents udMaxAantal As NumericUpDown
    Friend WithEvents cbxMaxAantalBeurtenAan As CheckBox
    Friend WithEvents tbLogoPad As TextBox
    Friend WithEvents btSelecteerLogo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btLogoAanpassen As Button
    Friend WithEvents btStandaard As Button
    Friend WithEvents cbxMaxAantalAan As CheckBox
End Class
