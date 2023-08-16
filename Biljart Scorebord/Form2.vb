Imports System.IO

Public Class Form2


    Private Sub btSluiten_Click(sender As Object, e As EventArgs) Handles btSluiten.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.tbClubnaam.Text = My.Settings.Clubnaam
        Me.cbxMaxAantalBeurtenAan.Checked = My.Settings.MaxAantalBeurtenAan
        Me.udMaxAantal.Value = My.Settings.MaxAantalBeurtenStandaard
        Me.OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        Me.tbLogoPad.Text = My.Settings.Logo
        Me.cbxMaxAantalAan.Checked = My.Settings.MaxAantalAan
    End Sub

    Private Sub btOpslaan_Click(sender As Object, e As EventArgs) Handles btOpslaan.Click
        My.Settings.Clubnaam = tbClubnaam.Text
        My.Settings.MaxAantalBeurtenAan = Me.cbxMaxAantalBeurtenAan.Checked
        My.Settings.MaxAantalBeurtenStandaard = Me.udMaxAantal.Value
        My.Settings.Logo = Me.tbLogoPad.Text
        My.Settings.MaxAantalAan = Me.cbxMaxAantalAan.Checked
        My.Settings.Save()
        LoadSettings()
    End Sub

    Private Sub btSelecteerLogo_Click(sender As Object, e As EventArgs) Handles btSelecteerLogo.Click
        Dim sPadLogo As String
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tbLogoPad.Clear()
            Dim grade = OpenFileDialog1.FileName



            'Dim directoryPath As String = Path.GetDirectoryName(FolderBrowserDialog1.SelectedPath)

            tbLogoPad.Text = grade
            sPadLogo = Me.tbLogoPad.Text
            If sPadLogo <> "" Then
                If File.Exists(sPadLogo) And IsValidImage(sPadLogo) Then
                    With Form1
                        .PictureBox1.Image = Bitmap.FromFile(sPadLogo)


                    End With
                Else
                    With Form1
                        .PictureBox1.Image = My.Resources.StandaardLogo.scorebordlogo
                        Me.tbLogoPad.ResetText()
                    End With
                End If
            Else
                With Form1
                    .PictureBox1.Image = My.Resources.StandaardLogo.scorebordlogo
                    Me.tbLogoPad.ResetText()
                End With
            End If
        End If
        'Exit File Directory



        Form1.PictureBox2.Image = Form1.PictureBox1.Image
    End Sub

    Private Sub btLogoAanpassen_Click(sender As Object, e As EventArgs) Handles btLogoAanpassen.Click
        With Form1
            .PictureBox1.Image = My.Resources.StandaardLogo.scorebordlogo
            .PictureBox2.Image = .PictureBox1.Image

        End With
        Me.tbLogoPad.ResetText()
    End Sub

    Private Sub btStandaard_Click(sender As Object, e As EventArgs) Handles btStandaard.Click
        With Form1
            .PictureBox1.Image = My.Resources.StandaardLogo.scorebordlogo
            .PictureBox2.Image = .PictureBox1.Image
            .udMaxAantalBeurten.Value = Convert.ToInt64(My.Resources.StandaardLogo.MaxAantalBeurenStandaard)
            .lblBiljartClub.Text = My.Resources.StandaardLogo.StandaardClubnaam
        End With
        With Me
            .tbLogoPad.ResetText()
            .udMaxAantal.Value = Convert.ToInt64(My.Resources.StandaardLogo.MaxAantalBeurenStandaard)
            .tbClubnaam.Text = My.Resources.StandaardLogo.StandaardClubnaam


        End With
        My.Settings.Save()
    End Sub
End Class