Imports System.Runtime.InteropServices
Public Class MainWindow
    ReadOnly timeout As Integer = 15 * 1000
    Dim autoHideOn As Boolean = My.Settings.autoHideOn
    Dim clipboardText As String
    Private Sub clearClipboard()
        Clipboard.Clear()
        NotifyIcon1.BalloonTipText = "Zwischenablage geleert"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub clearHistory()
        HistoryViewerListBox.Items.Clear()
        NotifyIcon1.BalloonTipText = "Zwischenablageverlauf geleert"
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub paste(textToPaste As String)
        Clipboard.SetText(textToPaste)
        My.Computer.Keyboard.SendKeys("%{TAB}")
        Threading.Thread.Sleep(100) 'ms
        My.Computer.Keyboard.SendKeys("+{INS}")
    End Sub

    Private Sub NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Visible = True
            Me.BringToFront()
        ElseIf e.Button = MouseButtons.Middle Then
            paste(HistoryViewerListBox.Items.Item(0))
        Else
            ' do nothing
        End If
    End Sub

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If autoHideOn = True Then
            Me.Visible = False
            Me.MinimizeBox = False
            Me.ControlBox = False
            Me.CB_autoHide.Checked = True
        Else
            Me.ControlBox = True
            Me.MinimizeBox = True
            Me.CB_autoHide.Checked = False
        End If
        Me.TopMost = My.Settings.alwaysOnTop
        Me.CB_alwaysInForeground.Checked = Me.TopMost
    End Sub

    Private Sub MainWindow_FocusLost(sender As Object, e As EventArgs) Handles Me.Deactivate
        If autoHideOn = True Then
            Me.Visible = False
        End If
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        NotifyIcon1.Visible = False
        My.Settings.Save()
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
            Try
                For Each i As String In HistoryViewerListBox.Items.OfType(Of String)
                    If i.Equals(clipboardText) Then
                        HistoryViewerListBox.Items.RemoveAt(HistoryViewerListBox.Items.IndexOf(i))
                        Exit For
                    End If
                Next

            Catch ex As System.ArgumentNullException
            End Try
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
            Try
                paste(HistoryViewerListBox.SelectedItem.ToString)
            Catch ex As NullReferenceException
            End Try
        End If
    End Sub

    Private Sub HistoryViewerListBoxItem_Key(ByVal sender As Object, ByVal e As KeyEventArgs) Handles HistoryViewerListBox.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Try
                HistoryViewerListBox.Items.RemoveAt(HistoryViewerListBox.SelectedIndex)
            Catch ex As ArgumentOutOfRangeException
            End Try
        End If
        If (e.KeyCode = Keys.Enter) Then
            paste(HistoryViewerListBox.SelectedItem.ToString)
        End If
    End Sub

    Private Sub SelektorAnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelektorAnzeigenToolStripMenuItem.Click
        Me.Visible = True
    End Sub

    Private Sub CB_alwaysInForeground_CheckedChanged(sender As Object, e As EventArgs) Handles CB_alwaysInForeground.CheckedChanged
        Me.TopMost = Not Me.TopMost
        My.Settings.alwaysOnTop = Me.TopMost
    End Sub

    Private Sub CB_autoHide_CheckedChanged(sender As Object, e As EventArgs) Handles CB_autoHide.CheckedChanged
        autoHideOn = Not autoHideOn
        My.Settings.autoHideOn = autoHideOn
        Me.MinimizeBox = Not Me.MinimizeBox
        Me.ControlBox = Not Me.ControlBox
    End Sub
End Class
