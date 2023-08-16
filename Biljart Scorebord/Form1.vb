Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Const Max_Bereikt = 1
    Const Te_Veel = 2
    Const Nog_Niet = 0
    Const MaxBeurtenMax = 150
    Public ScoreTonen As Boolean
    Private SpelEinde As Boolean


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(My.Application.Info.DirectoryPath + "\Biljart Scorebord.exe")
        If IsExcelInstalled() = False Then
            Me.btSpelerSelect.Enabled = False
            Me.btSpelerSelect.Width = 0
            Me.btSpelerSelect.Visible = False
        Else
            Me.btSpelerSelect.Enabled = True
        End If
        With Me
            'links uitlijnen knoppen
            '.btNieuw.Left = (.Width - .btNieuw.Width - .btStart.Width - .btInstellingen.Width - .btCorrectie.Width - .btSpelerSelect.Width - .btUndo.Width - .btSluiten.Width) / 2
            .btNieuw.Left = 10
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
            .LopendewedstrijdPanel.Top = .btStart.Top + btStart.Height + .lblNaamSpelerA.Height + 10
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
            .VerticalProgressBar1.Left = .lblCarambolesA.Left + .lblCarambolesA.Width + 10
            .VerticalProgressBar2.Left = .lblCarambolesB.Left - .VerticalProgressBar2.Width - 10

            'uitlijnen naam labels
            .lblNaamSpelerA.Left = .topPanel.Left
            .lblNaamSpelerA.Top = .LopendewedstrijdPanel.Top - .lblNaamSpelerA.Height - 5
            .lblNaamSpelerB.Top = .lblNaamSpelerA.Top
            .lblNaamSpelerB.Left = .Width - .lblNaamSpelerB.Width - 5

            .lblBericht.Left = (.bottomPanel.Width - .lblBericht.Width) / 2
            .lblBericht.Top = .LopendewedstrijdPanel.Top + LopendewedstrijdPanel.Height
            .lblBiljartClub.Left = (.bottomPanel.Width - .lblBiljartClub.Width) / 2
            .lblTijd.Left = .Width - .lblTijd.Width
            .lbVersie.Left = 10
            .lbVersie.Text = "Versie " & myFileVersionInfo.FileVersion
            .lbVersie.Top = .PictureBox1.Top + (.PictureBox1.Height - .lbVersie.Height) / 2
            .lbVersie.Left = .PictureBox1.Left + .PictureBox1.Width + 5
            TotaalA = 0
            TotaalB = 0
            'instellingen laden
            .lblBiljartClub.Text = My.Settings.Clubnaam
            .udMaxAantalBeurten.Value = My.Settings.MaxAantalBeurtenStandaard
            .chbMaxAantal.Checked = My.Settings.MaxAantalBeurtenAan
        End With
    End Sub

    Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click
        Dim checkzero As Boolean
        checkzero = Me.udAantalSpelerA.Value = 0 Or Me.udAantalSpelerB.Value = 0
        AantalBereikt = False

        If Me.chbMaxAantal.Checked = True And checkzero Then
            Me.lblBericht.Text = "Max aantal staat aan, aantal is 0."
            Me.lblBericht.ForeColor = Color.Red
        Else
            With Me
                .topPanel.Visible = False
                .LopendewedstrijdPanel.Visible = True
                .lblNaamSpelerA.Text = .tbSpelerAInvoer.Text
                .lblNaamSpelerB.Text = .tbSpelerBInvoer.Text
                .lblNaamSpelerA.Visible = True
                .lblNaamSpelerB.Visible = True
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
                .tbInvoerAantalA.Visible = True
                .tbInvoerAantalB.Visible = False
                .tbInvoerAantalA.Focus()
                .AcceptButton = Me.btPunten
                .btPunten.Enabled = True
                .btStart.Enabled = True
                .lblCarambolesA.ResetText()
                .lblCarambolesB.ResetText()
                .lblGemiddeldeA.ResetText()
                .lblGemiddeldeB.ResetText()
                .lblHoogsteSerieA.ResetText()
                .lblHoogsteSerieB.ResetText()
                .btSpelerSelect.Enabled = False
                .lblBeurten.Text = "Beurten: "
                MaxCarambole_A = .udAantalSpelerA.Value
                MaxCarambole_B = .udAantalSpelerB.Value
                .lbPercA.Visible = .lblMaxAantalA.Visible
                .lbPercB.Visible = .lbPercA.Visible
                .VerticalProgressBar1.Visible = .lblMaxAantalA.Visible
                .VerticalProgressBar2.Visible = .lblMaxAantalB.Visible
                .VerticalProgressBar1.Value = 0
                .VerticalProgressBar2.Value = 0
                .lbPercA.Text = "0%"
                .lbPercB.Text = "0%"
                .lbPercA.ForeColor = Color.Yellow
                .lbPercB.ForeColor = Color.Yellow
                .lbPercA.Left = .lblMaxAantalA.Left + .lblMaxAantalA.Width
                .lbPercB.Left = .lblHoogsteSerieB.Left - .lbPercB.Width
                .lblBericht.ResetText()
                .lblBericht.ForeColor = Color.Yellow
            End With
            Beurten = 0

            TotaalA = 0
            TotaalB = 0

        End If


    End Sub

    Private Sub btNieuw_Click(sender As Object, e As EventArgs) Handles btNieuw.Click
        Dim Result As DialogResult
        If Me.LopendewedstrijdPanel.Visible Then
            Result = Form6.ShowDialog
            If Result = DialogResult.Yes Then
                btUndo.Enabled = False
                Me.topPanel.Visible = True
                Me.LopendewedstrijdPanel.Visible = False
                Me.btCorrectie.Enabled = False
                Me.lblNaamSpelerA.Visible = False
                Me.lblNaamSpelerB.Visible = False
                Me.btSpelerSelect.Enabled = True
                Me.lblBericht.ResetText()
            End If
        End If
    End Sub

    Private Sub chbMaxBeurten_CheckedChanged(sender As Object, e As EventArgs)
        Me.udMaxAantalBeurten.Enabled = Me.chbMaxBeurten.Checked
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sPadLogo As String
        sPadLogo = My.Settings.Logo
        If sPadLogo <> "" Then
            If File.Exists(sPadLogo) And IsValidImage(sPadLogo) Then
                With Me
                    .PictureBox1.Image = Bitmap.FromFile(sPadLogo)
                End With
            Else
                With Me
                    .PictureBox1.Image = My.Resources.StandaardLogo.scorebordlogo
                    Form2.tbLogoPad.ResetText()
                    My.Settings.Logo = ""
                    My.Settings.Save()
                End With
            End If
            With Me
                .lblCarambolesA.Text = ""
                .lblCarambolesB.Text = ""
                .lblGemiddeldeA.Text = ""
                .lblGemiddeldeB.Text = ""
                .lblHoogsteSerieA.Text = ""
                .lblHoogsteSerieB.Text = ""
                .lblBiljartClub.Text = My.Settings.Clubnaam
                .udMaxAantalBeurten.Value = My.Settings.MaxAantalBeurtenStandaard
                .btUndo.Enabled = False
                .lblNaamSpelerA.Visible = False
                .lblNaamSpelerB.Visible = False
                .lblNaamSpelerA.ResetText()
                .lblNaamSpelerB.ResetText()


            End With
        End If
        Erase AantalPerBeurtA
        Erase AantalPerBeurtB

        Me.btCorrectie.Enabled = False
    End Sub



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
        Dim NieuwTotaalA As Long
        Dim NieuwTotaalB As Long
        Dim AantalCheck As Boolean
        Dim MagInvullen As Boolean
        AantalCheck = Me.chbMaxAantal.Checked
        MagInvullen = False



        If HuidigeSpeler = Speler_A Then
            NieuwTotaalA = Val(Me.tbInvoerAantalA.Text) + TotaalA
            If AantalCheck And NieuwTotaalA > MaxCarambole_A Then
                Me.lblBericht.Text = "Te veel caramboles ingevoerd"
                Me.tbInvoerAantalA.ResetText()
                Me.tbInvoerAantalA.Focus()
                MagInvullen = False
            Else
                Beurten = Beurten + 1
                If NieuwTotaalA = MaxCarambole_A And Me.chbMaxAantal.Checked Then
                    AantalBereikt = True
                End If
                ReDim Preserve AantalPerBeurtA(0 To 1, 0 To Beurten - 1)
                AantalPerBeurtA(0, Beurten - 1) = Beurten
                AantalPerBeurtA(1, Beurten - 1) = Val(tbInvoerAantalA.Text)
                Me.tbInvoerAantalB.Visible = True
                Me.tbInvoerAantalA.Visible = False
                Me.tbInvoerAantalA.ResetText()
                Me.tbInvoerAantalB.Focus()
                Me.lblBericht.ResetText()
                MagInvullen = True
            End If
        Else
            NieuwTotaalB = Val(Me.tbInvoerAantalB.Text) + TotaalB
            If AantalCheck And NieuwTotaalB > MaxCarambole_B Then
                Me.lblBericht.Text = "Te veel caramboles ingevoerd"
                Me.tbInvoerAantalB.ResetText()
                Me.tbInvoerAantalB.Focus()
                MagInvullen = False
            Else
                If NieuwTotaalB = MaxCarambole_B And Me.chbMaxAantal.Checked Then
                    AantalBereikt = True
                End If
                ReDim Preserve AantalPerBeurtB(0 To 1, 0 To Beurten - 1)
                AantalPerBeurtB(0, Beurten - 1) = Beurten
                AantalPerBeurtB(1, Beurten - 1) = Val(tbInvoerAantalB.Text)
                Me.tbInvoerAantalA.Visible = True
                Me.tbInvoerAantalB.Visible = False
                Me.tbInvoerAantalB.ResetText()
                Me.tbInvoerAantalA.Focus()
                Me.lblBericht.ResetText()
                MagInvullen = True
            End If

        End If
        If MagInvullen Then
            invullen(HuidigeSpeler)
            If AantalBereikt Then Me.lblBericht.Text = "Aantal bereikt"
            Me.CheckVoorEind()
            HuidigeSpeler = Not HuidigeSpeler
            btUndo.Enabled = True
            If Beurten > 1 Then Me.btCorrectie.Enabled = True
        End If


    End Sub

    Private Sub btInstellingen_Click(sender As Object, e As EventArgs) Handles btInstellingen.Click
        Form2.ShowDialog()
    End Sub
    Private Sub CheckVoorEind()
        If Me.chbMaxBeurten.Checked = True Then
            If HuidigeSpeler = Speler_A Then
                Select Case Beurten
                    Case Me.udMaxAantalBeurten.Value
                        Me.lblBericht.Text = "Laatste beurt"
                    Case Me.udMaxAantalBeurten.Value - 1
                        Me.lblBericht.Text = "Voorlaatste beurt"

                    Case Else
                        Me.lblBericht.ResetText()
                End Select
            Else
                Select Case Beurten
                    Case Me.udMaxAantalBeurten.Value
                        Me.lblBericht.Text = "Einde wedstrijd"
                        Me.btNieuw.Select()
                        Me.btPunten.Enabled = False
                        Me.tbInvoerAantalB.Visible = False
                        Me.tbInvoerAantalA.Visible = False

                        Me.Select()
                    Case Me.udMaxAantalBeurten.Value - 1
                        Me.lblBericht.Text = "Laatste beurt"
                    Case Me.udMaxAantalBeurten.Value - 2
                        Me.lblBericht.Text = "Voorlaatste beurt"
                    Case Else
                        Me.lblBericht.ResetText()
                End Select
            End If
        End If
        If Me.chbMaxAantal.Checked Then
            If AantalBereikt And HuidigeSpeler = Speler_B Then
                Me.lblBericht.Text = "Einde wedstrijd"
                Me.btPunten.Enabled = False
                Me.tbInvoerAantalB.Visible = False
                Me.tbInvoerAantalA.Visible = False
                Me.btNieuw.Select()

            End If
        End If
    End Sub

    Private Sub lblBericht_TextChanged(sender As Object, e As EventArgs) Handles lblBericht.TextChanged
        Select Case Me.lblBericht.Text
            Case "Voorlaatste beurt"
                Me.lblBericht.ForeColor = Color.Red
                Me.lblBericht.BackColor = Color.Black

            Case "Laatste beurt"
                Me.lblBericht.ForeColor = Color.Black
                Me.lblBericht.BackColor = Color.Yellow

            Case "Einde wedstrijd"
                Me.lblBericht.ForeColor = Color.Black
                Me.lblBericht.BackColor = Color.Red
            Case Else
                Me.lblBericht.ForeColor = Color.Yellow
                Me.lblBericht.BackColor = Color.Black
        End Select
    End Sub

    Private Sub btSpelerSelect_Click(sender As Object, e As EventArgs) Handles btSpelerSelect.Click

        Form3.ShowDialog()
    End Sub

    Private Sub btSwitchSpelers_Click(sender As Object, e As EventArgs) Handles btSwitchSpelers.Click
        Dim SpelerTemp As String

        Dim AantalTemp As Long


        With Me
            SpelerTemp = .tbSpelerAInvoer.Text
            AantalTemp = .udAantalSpelerA.Value
            .udAantalSpelerA.Value = .udAantalSpelerB.Value
            .tbSpelerAInvoer.Text = .tbSpelerBInvoer.Text
            .tbSpelerBInvoer.Text = SpelerTemp
            .udAantalSpelerB.Value = AantalTemp

        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTijd.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btCorrectie_Click(sender As Object, e As EventArgs) Handles btCorrectie.Click
        Form5.ShowDialog()
    End Sub

    Private Sub btUndo_Click(sender As Object, e As EventArgs) Handles btUndo.Click
        'Dim i As Int32

        If HuidigeSpeler = Speler_A Then

            Me.tbInvoerAantalB.Visible = True
            Me.tbInvoerAantalA.Visible = False
            Me.tbInvoerAantalA.ResetText()
            Me.tbInvoerAantalB.Focus()
            ReDim Preserve AantalPerBeurtA(0 To 1, 0 To Beurten - 1)
            'TotaalA = 0
            'For i = 0 To AantalPerBeurtA.GetUpperBound(1)
            '    TotaalA = TotaalA + AantalPerBeurtA(1, i)
            'Next i
        Else

            Me.tbInvoerAantalA.Visible = True
            Me.tbInvoerAantalB.Visible = False
            Me.tbInvoerAantalB.ResetText()
            Me.tbInvoerAantalA.Focus()
            ReDim Preserve AantalPerBeurtB(0 To 1, 0 To Beurten - 2)
            'TotaalB = 0
            'For i = 0 To AantalPerBeurtB.GetUpperBound(1)
            '    TotaalB = TotaalB + AantalPerBeurtB(1, i)
            'Next i
            Beurten = Beurten - 1
        End If
        invullen(HuidigeSpeler)
        Me.CheckVoorEind()
        HuidigeSpeler = Not HuidigeSpeler
        If HuidigeSpeler And Beurten = 0 Then btUndo.Enabled = False
    End Sub

    Private Sub lblNaamSpelerB_Resize(sender As Object, e As EventArgs) Handles lblNaamSpelerB.Resize
        With Me
            .lblNaamSpelerB.Top = .lblNaamSpelerA.Top
            .lblNaamSpelerB.Left = .Width - .lblNaamSpelerB.Width - 5
        End With

    End Sub


    Function IsExcelInstalled() As Boolean
        'check of excel geinstalleerd Is
        Dim officetype = Type.GetTypeFromProgID("Excel.Application")
        If officetype = Nothing Then
            IsExcelInstalled = False
        Else
            IsExcelInstalled = True
        End If

        'om te testen
        'IsExcelInstalled = False
    End Function


End Class
