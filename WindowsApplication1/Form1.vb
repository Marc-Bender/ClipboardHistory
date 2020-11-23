Public Class MainWindow
    ReadOnly timeout As Integer = 15 * 1000
    Dim clipboardText As String
    Private Sub clearClipboard()
        Clipboard.Clear()
        NotifyIcon1.BalloonTipText = "Zwischenablage wurde geleert"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub clearHistory()
        HistoryViewerListBox.Items.Clear()
        NotifyIcon1.BalloonTipText = "Zwischenablage verlauf geleert"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Visible = True
    End Sub

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Visible = False
        NotifyIcon1.BalloonTipText = "Start des Programms Clipboard History geschrieben von Marc Bender"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub MainWindow_FocusLost(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Visible = False
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub ClearHistoryButton_Click(sender As Object, e As EventArgs) Handles ClearHistoryButton.Click
        clearHistory()
    End Sub

    Private Sub ClearClipboardButton_Click(sender As Object, e As EventArgs) Handles ClearClipboardButton.Click
        clearClipboard()
    End Sub

    Private Sub VerlaufLeerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerlaufLeerenToolStripMenuItem.Click
        clearHistory()
    End Sub

    Private Sub ZwischenablageLeerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZwischenablageLeerenToolStripMenuItem.Click
        clearClipboard()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Clipboard.ContainsText And (Not Clipboard.GetText.Equals(clipboardText))) Then
            clipboardText = Clipboard.GetText
            HistoryViewerListBox.Items.Insert(0, clipboardText)
        End If
    End Sub

    Private Sub HistoryViewerListBoxItem_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles HistoryViewerListBox.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Try
                Dim rightClickIndex As Integer = HistoryViewerListBox.IndexFromPoint(e.X, e.Y)
                HistoryViewerListBox.Items.RemoveAt(rightClickIndex)
            Catch ex As ArgumentOutOfRangeException
            Catch ex As NullReferenceException
            End Try
        End If
        If (e.Button = MouseButtons.Left) Then
            Dim leftClickIndex As Integer = HistoryViewerListBox.IndexFromPoint(e.X, e.Y)
            Try
                Dim textToPaste As String = HistoryViewerListBox.SelectedItem.ToString
                Clipboard.SetText(textToPaste)
                SendKeys.Send("%{TAB}")
                Threading.Thread.Sleep(100) 'ms
                SendKeys.Send("+{INS}")
            Catch ex As NullReferenceException
            End Try
        End If
    End Sub

    Private Sub HistoryViewerListBoxItem_Key(ByVal sender As Object, ByVal e As KeyEventArgs) Handles HistoryViewerListBox.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            HistoryViewerListBox.Items.RemoveAt(HistoryViewerListBox.SelectedIndex)
        End If
        If (e.KeyCode = Keys.Enter) Then
            Dim textToPaste As String = HistoryViewerListBox.SelectedItem.ToString
            Clipboard.SetText(textToPaste)
            SendKeys.Send("%{TAB}")
            Threading.Thread.Sleep(100) 'ms
            SendKeys.Send("+{INS}")
        End If
    End Sub

    Private Sub HideButton_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub

End Class
