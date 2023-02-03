Imports System.ComponentModel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports File = System.IO.File


Public Class Form3
    Dim dtSpelersLijst1 As New DataTable
    Dim dtSpelerslijst2 As New DataTable
    Dim xlsApp As New Excel.Application
    Dim wb As Excel.Workbook
    Dim ws1 As Excel.Worksheet, ws2 As Excel.Worksheet


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sPath As String, i As Long
        Dim sFile As String

        sPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Biljart_Scorebord"
        With Me
            .cbxSelecteerSpelerA.DataSource = Nothing
            .cbxSelecteerSpelerB.DataSource = Nothing

        End With
        sFile = sPath & "\spelerslijsten.xlsx"
        If Not Directory.Exists(sPath) Then
            Directory.CreateDirectory(sPath)
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\spelerslijsten.xlsx", sPath & "\spelerslijsten.xlsx")
        Else

            If Not File.Exists(sFile) Then
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\spelerslijsten.xlsx", sPath & "\spelerslijsten.xlsx")
            End If
        End If
        Me.cbxKiesCompetitie.Items.Clear()
        Me.cbxKiesCompetitieB.Items.Clear()
        If File.Exists(sPath & "\spelerslijsten.xlsx") Then


            wb = xlsApp.Workbooks.Open(sPath & "\spelerslijsten.xlsx", [ReadOnly]:=True)
            For i = 1 To wb.Sheets.Count
                Me.cbxKiesCompetitie.Items.Add(wb.Sheets(i).name)
                Me.cbxKiesCompetitie.Text = "Kies competitie"
                Me.cbxKiesCompetitieB.Items.Add(wb.Sheets(i).name)
                Me.cbxKiesCompetitieB.Text = "Kies competitie"
            Next


        Else
            cbxKiesCompetitie.Text = "Geen spelerslijst gevonden"
        End If
        Me.btInvullen.Enabled = False
    End Sub



    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not wb.Name <> "" Then



            wb.Close(SaveChanges:=False)

            xlsApp.Quit()

            dtSpeler1.Clear()
            dtSpeler2.Clear()
        End If
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()

    End Sub

    Private Sub cbxKiesCompetitie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxKiesCompetitie.SelectedIndexChanged
        Dim LaatsteRij As Long



        If Me.cbxKiesCompetitie.SelectedIndex <> -1 Then
            Me.cbxSelecteerSpelerA.DataSource = Nothing

            dtSpelersLijst1 = New DataTable
            ws1 = wb.Worksheets(Me.cbxKiesCompetitie.Text)
            dtSpelersLijst1.Columns.Add("Naam")
            dtSpelersLijst1.Columns.Add("Aantal")
            LaatsteRij = ws1.Range("A1048576").End(Excel.XlDirection.xlUp).Row
            If LaatsteRij = 1 Then
                cbxSelecteerSpelerA.Items.Clear()
                cbxSelecteerSpelerA.Text = "Lege competitie"
            Else
                cbxSelecteerSpelerA.Items.Clear()
                cbxSelecteerSpelerA.ResetText()
                For i = 2 To LaatsteRij
                    dtSpelersLijst1.Rows.Add(ws1.Range("A" & i).Value, ws1.Range("B" & i).Value)
                Next

                With Me.cbxSelecteerSpelerA
                    .DataSource = dtSpelersLijst1
                    .DisplayMember = "Naam"
                    .SelectedIndex = -1
                End With

            End If

        Else
            Me.cbxSelecteerSpelerA.Items.Clear()
        End If
        Me.cbxKiesCompetitieB.SelectedIndex = Me.cbxKiesCompetitie.SelectedIndex
    End Sub

    Private Sub cbxSelecteerSpelerA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelecteerSpelerA.SelectedIndexChanged

        If Me.cbxSelecteerSpelerA.SelectedIndex <> -1 And Me.cbxSelecteerSpelerB.SelectedIndex <> -1 Then
            Me.btInvullen.Enabled = True
        Else
            Me.btInvullen.Enabled = False
        End If
    End Sub

    Private Sub cbxSelecteerSpelerB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelecteerSpelerB.SelectedIndexChanged

        If Me.cbxSelecteerSpelerA.SelectedIndex <> -1 And Me.cbxSelecteerSpelerB.SelectedIndex <> -1 Then
            Me.btInvullen.Enabled = True
        Else
            Me.btInvullen.Enabled = False
        End If
    End Sub

    Private Sub cbxKiesCompetitieB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxKiesCompetitieB.SelectedIndexChanged
        Dim LaatsteRij As Long



        If Me.cbxKiesCompetitie.SelectedIndex <> -1 Then
            Me.cbxSelecteerSpelerB.DataSource = Nothing
            ws2 = wb.Worksheets(Me.cbxKiesCompetitieB.Text)
            dtSpelerslijst2 = New DataTable
            dtSpelerslijst2.Columns.Add("Naam")
            dtSpelerslijst2.Columns.Add("Aantal")
            LaatsteRij = ws2.Range("A1048576").End(Excel.XlDirection.xlUp).Row
            If LaatsteRij = 1 Then
                Me.cbxSelecteerSpelerB.Items.Clear()
                Me.cbxSelecteerSpelerB.Text = "Lege competitie"

            Else

                For i = 2 To LaatsteRij
                    dtSpelerslijst2.Rows.Add(ws2.Range("A" & i).Value, ws2.Range("B" & i).Value)
                Next
                With Me.cbxSelecteerSpelerB
                    .DataSource = dtSpelerslijst2
                    .DisplayMember = "Naam"
                    .SelectedIndex = -1
                End With


            End If

        Else
            Me.cbxSelecteerSpelerB.Items.Clear()
        End If
    End Sub

    Private Sub btInvullen_Click(sender As Object, e As EventArgs) Handles btInvullen.Click

        Form1.tbSpelerAInvoer.Text = dtSpelersLijst1.Rows(Me.cbxSelecteerSpelerA.SelectedIndex).Item("Naam")
        Form1.tbSpelerBInvoer.Text = dtSpelerslijst2.Rows(Me.cbxSelecteerSpelerB.SelectedIndex).Item("Naam")
        Form1.udAantalSpelerA.Value = dtSpelersLijst1.Rows(Me.cbxSelecteerSpelerA.SelectedIndex).Item("Aantal")
        Form1.udAantalSpelerB.Value = dtSpelerslijst2.Rows(Me.cbxSelecteerSpelerB.SelectedIndex).Item("Aantal")
        Me.Close()
    End Sub

    Private Sub cbxSelecteerSpelerA_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cbxSelecteerSpelerA.DrawItem
        Dim drv As DataRowView = DirectCast(cbxSelecteerSpelerA.Items(e.Index), DataRowView)

        Dim id As String = drv("Naam").ToString()
        Dim productname As String = drv("Aantal").ToString()


        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width * 0.8

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        Using p As New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width * 0.8
        r2.Width = r2.Width / 2

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(productname, e.Font, sb, r2)
        End Using

        Using p As New Pen(Color.Black)
            e.Graphics.DrawLine(p, r2.Right, 0, r2.Right, r2.Bottom)
        End Using
    End Sub

    Private Sub cbxSelecteerSpelerB_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cbxSelecteerSpelerB.DrawItem
        Dim drv As DataRowView = DirectCast(cbxSelecteerSpelerB.Items(e.Index), DataRowView)

        Dim id As String = drv("Naam").ToString()
        Dim productname As String = drv("Aantal").ToString()


        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width * 0.8

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        Using p As New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width * 0.8
        r2.Width = r2.Width / 2

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(productname, e.Font, sb, r2)
        End Using

        Using p As New Pen(Color.Black)
            e.Graphics.DrawLine(p, r2.Right, 0, r2.Right, r2.Bottom)
        End Using
    End Sub

    Private Sub cbxKiesCompetitieB_DataSourceChanged(sender As Object, e As EventArgs) Handles cbxKiesCompetitieB.DataSourceChanged
        With Me.cbxSelecteerSpelerB
            .SelectedIndex = -1
        End With
    End Sub
End Class