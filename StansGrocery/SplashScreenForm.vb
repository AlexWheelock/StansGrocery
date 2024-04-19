Public Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaitTimer.Start()
    End Sub

    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        StansGroceryForm.Show()
        Me.Close()
    End Sub

End Class