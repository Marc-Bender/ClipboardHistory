Public Class Form1
    ReadOnly timeout As Integer = 15 * 1000
    REM timeout is in millis
    Private Sub clear()
        Clipboard.Clear()
        NotifyIcon1.BalloonTipText = "Zwischenablage wurde geleert"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        clear()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Visible = False
        NotifyIcon1.BalloonTipText = "Start des Programms ClipboardCleaner geschrieben von Marc Bender"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        NotifyIcon1.BalloonTipText = "Tschüss"
        NotifyIcon1.ShowBalloonTip(timeout)
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub ZwischenablageLeeren_Click(sender As Object, e As EventArgs) Handles ZwischenablageLeeren.Click
        clear()
    End Sub
End Class
