Public Class Form2


    Private Sub btSluiten_Click(sender As Object, e As EventArgs) Handles btSluiten.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.tbClubnaam.Text = My.Settings.Clubnaam
        Me.cbxMaxAantalBeurtenAan.Checked = My.Settings.MaxAantalBeurtenAan
        Me.udMaxAantal.Value = My.Settings.MaxAantalBeurtenStandaard

    End Sub

    Private Sub btOpslaan_Click(sender As Object, e As EventArgs) Handles btOpslaan.Click
        My.Settings.Clubnaam = tbClubnaam.Text
        My.Settings.MaxAantalBeurtenAan = Me.cbxMaxAantalBeurtenAan.Checked
        My.Settings.MaxAantalBeurtenStandaard = Me.udMaxAantal.Value
        My.Settings.Save()
        Form1.lblBiljartClub.Text = My.Settings.Clubnaam
        Form1.udMaxAantalBeurten.Value = My.Settings.MaxAantalBeurtenStandaard
        Form1.chbMaxBeurten.Checked = My.Settings.MaxAantalBeurtenAan

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class