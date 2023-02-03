Public Class Form5
    Private Sub btSluiten_Click(sender As Object, e As EventArgs) Handles btSluiten.Click
        Me.Close()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        update_listboxes()
    End Sub
    Private Sub update_listboxes()
        Dim i As Long
        Dim i1 As Long, i2 As Long
        With Me
            If AantalPerBeurtA.GetUpperBound(1) <> -1 Then
                i1 = .cbBeurten1.SelectedIndex
                i2 = .cbBeurten2.SelectedIndex
                .cbBeurten1.Items.Clear()
                .cbBeurten2.Items.Clear()
                .cbCaramboles1.Items.Clear()
                .cbCaramboles2.Items.Clear()

                For i = 0 To AantalPerBeurtA.GetUpperBound(1)
                    With Me
                        .cbBeurten1.Items.Add(AantalPerBeurtA(0, i))
                        .cbCaramboles1.Items.Add(AantalPerBeurtA(1, i))
                    End With

                Next i
            End If
            If AantalPerBeurtB.GetUpperBound(1) <> -1 Then
                For i = 0 To AantalPerBeurtB.GetUpperBound(1)
                    .cbBeurten2.Items.Add(AantalPerBeurtB(0, i))
                    .cbCaramboles2.Items.Add(AantalPerBeurtB(1, i))
                Next i

            End If
            .cbBeurten1.SelectedIndex = i1
            .cbBeurten2.SelectedIndex = i2
        End With
    End Sub

    Private Sub cbCaramboles1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCaramboles1.SelectedIndexChanged
        With Me
            .cbBeurten1.SelectedIndex = .cbCaramboles1.SelectedIndex
        End With
    End Sub

    Private Sub cbCaramboles2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCaramboles2.SelectedIndexChanged
        With Me
            .cbBeurten2.SelectedIndex = .cbCaramboles2.SelectedIndex
        End With

    End Sub

    Private Sub cbBeurten1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBeurten1.SelectedIndexChanged
        With Me
            .cbCaramboles1.SelectedIndex = .cbBeurten1.SelectedIndex
        End With

    End Sub

    Private Sub cbBeurten2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBeurten2.SelectedIndexChanged
        With Me
            .cbCaramboles2.SelectedIndex = .cbBeurten2.SelectedIndex
        End With
    End Sub

    Private Sub btAanpassenSpeler1_Click(sender As Object, e As EventArgs) Handles btAanpassenSpeler1.Click
        Dim i As Long
        i = Me.cbCaramboles1.SelectedIndex

        If i <> -1 Then
            AantalPerBeurtA(1, i) = Me.udSpeler1.Value
            update_listboxes()
            invullen(Speler_A)
        End If
    End Sub

    Private Sub btAanpassenSpeler2_Click(sender As Object, e As EventArgs) Handles btAanpassenSpeler2.Click
        Dim i As Long
        i = Me.cbCaramboles2.SelectedIndex

        If i <> -1 Then
            AantalPerBeurtB(1, i) = Me.udSpeler2.Value
            update_listboxes()
            invullen(Speler_B)
        End If
    End Sub




End Class