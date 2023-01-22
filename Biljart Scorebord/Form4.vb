Public Class Form4
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Application.MinimumSplashScreenDisplayTime = 1000
    End Sub

    Private Sub Form4_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Label1.Left = (Me.Width - Me.Label1.Width) / 2
        Me.Label2.Left = (Me.Width - Me.Label2.Width) / 2
        Me.Label1.Top = 40
        Me.Label2.Top = Me.Height - Me.Label2.Height - 40

    End Sub
End Class