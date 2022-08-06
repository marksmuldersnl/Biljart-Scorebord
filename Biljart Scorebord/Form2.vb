Public Class Form2


    Private Sub btSluiten_Click(sender As Object, e As EventArgs) Handles btSluiten.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.tbClubnaam.Text = My.Settings.Clubnaam
    End Sub

    Private Sub btOpslaan_Click(sender As Object, e As EventArgs) Handles btOpslaan.Click
        My.Settings.Clubnaam = tbClubnaam.Text
        My.Settings.Save()
        Form1.lblBiljartClub.Text = My.Settings.Clubnaam
    End Sub
End Class