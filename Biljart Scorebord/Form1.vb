Public Class Form1

    Public AantalPerBeurtA() As Long
    Public AantalPerBeurtB() As Long
    Public TotaalA As Long, TotaalB As Long
    Public Beurten As Long
    Public MaxCarambole_A As Long, MaxCarambole_B As Long
    Public Gemiddelde_A As Double, Gemiddelde_B As Double
    Public HuidigeSpeler As Boolean


    Public Const Speler_A As Boolean = True, Speler_B As Boolean = False
    Const Max_Bereikt = 1
    Const Te_Veel = 2
    Const Nog_Niet = 0
    Const MaxBeurtenMax = 150
    Public ScoreTonen As Boolean
    Private SpelEinde As Boolean


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        With Me
            'uitlijnen knoppen
            .btNieuw.Left = (.Width - .btNieuw.Width - .btStart.Width - .btCorrectie.Width - .btSpelerSelect.Width - .btUndo.Width - .btSluiten.Width) / 2
            .btStart.Left = .btNieuw.Left + .btNieuw.Width
            .btCorrectie.Left = .btStart.Left + .btStart.Width
            .btInstellingen.Left = .btCorrectie.Left + .btCorrectie.Width
            .btSpelerSelect.Left = .btInstellingen.Left + .btInstellingen.Width
            .btUndo.Left = .btSpelerSelect.Left + .btSpelerSelect.Width
            .btSluiten.Left = .btUndo.Left + .btUndo.Width

            'uitlijnen toppanel
            .topPanel.Left = 5
            .topPanel.Width = .Width
            .LopendewedstrijdPanel.Width = .topPanel.Width
            .LopendewedstrijdPanel.Left = .topPanel.Left
            .LopendewedstrijdPanel.Visible = False
            .InstellenPanel.Left = (.topPanel.Width - .InstellenPanel.Width) / 2

            'uitlijnen bottompanel
            .bottomPanel.Width = .topPanel.Width
            .bottomPanel.Top = .Height - .bottomPanel.Height - 30
            .PictureBox1.Left = 5
            .PictureBox2.Left = .bottomPanel.Width - .PictureBox2.Width - 5

            'uitlijnen lopendwedstrijd panel 
            .lblCarambolesA.Left = 5
            .lblCarambolesB.Left = .LopendewedstrijdPanel.Width - .lblCarambolesB.Width - 5
            .lblGemiddeldeA.Left = 5
            .lblGemiddeldeB.Left = .LopendewedstrijdPanel.Width - .lblGemiddeldeB.Width - 5
            .lblHoogsteSerieA.Left = 5
            .lblHoogsteSerieB.Left = .LopendewedstrijdPanel.Width - .lblHoogsteSerieB.Width - 5
            .lblMaxAantalA.Left = 5
            .lblMaxAantalB.Left = .LopendewedstrijdPanel.Width - .lblMaxAantalB.Width - 5
            .lblBeurten.Left = (.LopendewedstrijdPanel.Width - lblBeurten.Width) / 2
            .lblGemiddelde.Left = .lblBeurten.Left
            .lblHoogsteSerie.Left = .lblBeurten.Left
            .lblMaxAantal.Left = .lblBeurten.Left
            .lblBiljartClub.Left = (.bottomPanel.Width - .lblBiljartClub.Width) / 2
            .tbSpelerAInvoer.Left = 5
            .tbSpelerBInvoer.Left = .LopendewedstrijdPanel.Width - .tbSpelerBInvoer.Width - 5
            .udAantalSpelerA.Left = 5
            .udAantalSpelerB.Left = .LopendewedstrijdPanel.Width - .udAantalSpelerB.Width - 5
            .btPunten.Left = (.topPanel.Width - .btPunten.Width) / 2
            .tbInvoerAantalA.Left = 5
            .tbInvoerAantalB.Left = .LopendewedstrijdPanel.Width - .tbInvoerAantalB.Width - 5
            .btPunten.Left = (.LopendewedstrijdPanel.Width - .btPunten.Width) / 2
            'uitlijnen naam labels
            .lblNaamSpelerA.Left = .topPanel.Left
            .lblNaamSpelerA.Top = .topPanel.Top
            .lblNaamSpelerB.Top = .lblNaamSpelerA.Top
            .lblNaamSpelerB.Left = .Width - .lblNaamSpelerB.Width - 5
        End With
    End Sub

    Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click

        With Me
            .topPanel.Visible = False
            .LopendewedstrijdPanel.Visible = True
            .lblNaamSpelerA.Text = .tbSpelerAInvoer.Text
            .lblNaamSpelerB.Text = .tbSpelerBInvoer.Text
            If .udAantalSpelerA.Value = 0 Or udAantalSpelerB.Value = 0 Then
                .lblMaxAantalA.Visible = False
                .lblMaxAantalB.Visible = False
                .lblMaxAantal.Visible = False
            Else
                .lblMaxAantal.Visible = True
                .lblMaxAantalA.Visible = True
                .lblMaxAantalB.Visible = True
                .lblMaxAantalA.Text = .udAantalSpelerA.Value
                .lblMaxAantalB.Text = .udAantalSpelerB.Value
            End If
            HuidigeSpeler = Speler_A
            Me.tbInvoerAantalA.Visible = True
            Me.tbInvoerAantalB.Visible = False
            Me.tbInvoerAantalA.Focus()
            Me.AcceptButton = Me.btPunten

        End With
    End Sub

    Private Sub btNieuw_Click(sender As Object, e As EventArgs) Handles btNieuw.Click
        Me.topPanel.Visible = True
        Me.LopendewedstrijdPanel.Visible = False
    End Sub

    Private Sub chbMaxBeurten_CheckedChanged(sender As Object, e As EventArgs)
        Me.udMaxAantalBeurten.Enabled = Me.chbMaxBeurten.Checked
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .lblCarambolesA.Text = ""
            .lblCarambolesB.Text = ""
            .lblGemiddeldeA.Text = ""
            .lblGemiddeldeB.Text = ""
            .lblHoogsteSerieA.Text = ""
            .lblHoogsteSerieB.Text = ""
            .lblBiljartClub.Text = My.Settings.Clubnaam

        End With
    End Sub

    Private Function gemiddelde(ByVal gespeeldebeurten As Long, aantalCaramboles As Long) As Double
        If gespeeldebeurten = 0 Then
            gemiddelde = 0
        Else
            gemiddelde = aantalCaramboles / gespeeldebeurten
        End If
    End Function

    Private Sub tbInvoerAantalA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbInvoerAantalA.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbInvoerAantalB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbInvoerAantalB.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btSluiten_Click(sender As Object, e As EventArgs) Handles btSluiten.Click
        Me.Close()
    End Sub

    Private Sub btPunten_Click(sender As Object, e As EventArgs) Handles btPunten.Click
        If HuidigeSpeler = Speler_A Then
            Me.tbInvoerAantalB.Visible = True
            Me.tbInvoerAantalA.Visible = False
            Me.tbInvoerAantalA.ResetText()
            Me.tbInvoerAantalB.Focus()

        Else
            Me.tbInvoerAantalA.Visible = True
            Me.tbInvoerAantalB.Visible = False
            Me.tbInvoerAantalB.ResetText()
            Me.tbInvoerAantalA.Focus()
        End If
        HuidigeSpeler = Not HuidigeSpeler
    End Sub

    Private Sub btInstellingen_Click(sender As Object, e As EventArgs) Handles btInstellingen.Click
        Form2.Show()
    End Sub
End Class
