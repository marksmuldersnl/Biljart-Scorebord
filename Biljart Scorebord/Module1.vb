Module Module1
    Public Const Speler_A As Boolean = True, Speler_B As Boolean = False
    Public AantalPerBeurtA(0 To 1, 0 To 0) As Long
    Public AantalPerBeurtB(0 To 1, 0 To 0) As Long
    Public HoogsteSerieA As Long
    Public HoogsteSerieB As Long
    Public TotaalA As Long, TotaalB As Long
    Public Beurten As Long
    Public MaxCarambole_A As Long
    Public MaxCarambole_B As Long
    Public Gemiddelde_A As Double
    Public Gemiddelde_B As Double
    Public HuidigeSpeler As Boolean
    Public dtSpeler1 As DataTable
    Public dtSpeler2 As DataTable
    Public AantalBereikt As Boolean



    Public Sub invullen(ByVal Speler As Boolean)
        Dim i As Int32
        If Speler = Speler_A Then

            Form1.lblBeurten.Text = "Beurten: " & Beurten
            If Beurten > 0 Then
                HoogsteSerieA = AantalPerBeurtA(1, 0)
                TotaalA = 0
                For i = 0 To AantalPerBeurtA.GetUpperBound(1)
                    If Val(AantalPerBeurtA(1, i)) > HoogsteSerieA Then HoogsteSerieA = Val(AantalPerBeurtA(1, i))
                    TotaalA = TotaalA + Val(AantalPerBeurtA(1, i))

                Next
                Form1.lblCarambolesA.Text = TotaalA
                Form1.lblHoogsteSerieA.Text = HoogsteSerieA

                Gemiddelde_A = Math.Round(gemiddelde(Beurten, TotaalA), 3, MidpointRounding.ToEven)

            Else
                Form1.lblHoogsteSerieA.Text = 0
                Form1.lblCarambolesA.Text = 0
                Form1.lblBeurten.Text = "Beurten: " & Beurten
                Gemiddelde_A = 0

            End If
            Form1.lblGemiddeldeA.Text = Gemiddelde_A.ToString("N3")

        Else
            If Beurten > 0 Then

                HoogsteSerieB = AantalPerBeurtB(1, 0)
                TotaalB = 0
                For i = 0 To AantalPerBeurtB.GetUpperBound(1)
                    If AantalPerBeurtB(1, i) > HoogsteSerieB Then HoogsteSerieB = (AantalPerBeurtB(1, i))
                    TotaalB = TotaalB + (AantalPerBeurtB(1, i))
                Next
                Form1.lblCarambolesB.Text = TotaalB
                Form1.lblHoogsteSerieB.Text = HoogsteSerieB

                Gemiddelde_B = Math.Round(gemiddelde(Beurten, TotaalB), 3, MidpointRounding.ToEven)


            Else
                Form1.lblHoogsteSerieB.Text = 0
                Form1.lblCarambolesB.Text = 0
                Gemiddelde_B = 0
                Form1.lblHoogsteSerieA.Text = 0
                Gemiddelde_A = 0
                Form1.lblGemiddeldeA.Text = Gemiddelde_A.ToString("N3")
                Form1.lblCarambolesA.Text = 0

            End If
            Form1.lblGemiddeldeB.Text = Gemiddelde_B.ToString("N3")
        End If
        With Form1
            .lblBeurten.Text = "Beurten: " & Beurten
            .lbPercA.Text = Int(percentage(TotaalA, MaxCarambole_A)).ToString & "%"
            .lbPercB.Text = Int(percentage(TotaalB, MaxCarambole_B)).ToString & "%"
            .VerticalProgressBar1.Value = Math.Min(100, Int(percentage(TotaalA, MaxCarambole_A)))
            .VerticalProgressBar2.Value = Math.Min(100, Int(percentage(TotaalB, MaxCarambole_B)))
        End With
        Select Case percentage(TotaalA, MaxCarambole_A) - percentage(TotaalB, MaxCarambole_B)
            Case < 0
                Form1.lbPercA.ForeColor = Color.Red
                Form1.lbPercB.ForeColor = Color.Green
            Case > 0
                Form1.lbPercA.ForeColor = Color.Green
                Form1.lbPercB.ForeColor = Color.Red
            Case 0
                Form1.lbPercA.ForeColor = Color.Blue
                Form1.lbPercB.ForeColor = Color.Blue
        End Select



    End Sub

    Public Function gemiddelde(ByVal gespeeldebeurten As Long, aantalCaramboles As Long) As Double
        If gespeeldebeurten = 0 Then
            gemiddelde = 0
        Else
            gemiddelde = aantalCaramboles / gespeeldebeurten
        End If
    End Function
    Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            ' Image.FromFile throws an OutOfMemoryException  
            ' if the file does not have a valid image format or 
            ' GDI+ does not support the pixel format of the file. 
            ' 
            Return False
        End Try
        Return True
    End Function
    Function percentage(ByVal aantal As Long, max As Long) As Double
        If max > 0 Then
            Return 100 * aantal / max
        Else
            Return 0
        End If
    End Function
    Public Sub LoadSettings()
        Form1.lblBiljartClub.Text = My.Settings.Clubnaam
        Form1.udMaxAantalBeurten.Value = My.Settings.MaxAantalBeurtenStandaard
        Form1.chbMaxBeurten.Checked = My.Settings.MaxAantalBeurtenAan
        Form1.chbMaxAantal.Checked = My.Settings.MaxAantalAan
    End Sub
End Module

