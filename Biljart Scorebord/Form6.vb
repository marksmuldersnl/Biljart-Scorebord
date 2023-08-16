Public Class Form6
    Private Sub buttonYes_Click(sender As Object, e As EventArgs) Handles buttonYes.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub buttonNo_Click(sender As Object, e As EventArgs) Handles buttonNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class