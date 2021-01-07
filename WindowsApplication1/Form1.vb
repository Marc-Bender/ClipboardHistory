Imports System.Runtime.InteropServices
Public Class MainWindow
    ReadOnly timeout As Integer = 15 * 1000
    Dim clipboardText As String

    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Declare Sub UnregisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer)

    Private Const Key_NONE As Integer = &H0
    Private Const Key_ALT As Integer = &H1
    Private Const Key_CTRL As Integer = &H2
    Private Const Key_SHIFT As Integer = &H4
    Private Const Key_WIN As Integer = &H8

    Private Const WM_HOTKEY As Integer = &H312

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            Select Case m.WParam
                Case 1 ' multiple hotkeys possible but only one needed yet
                    Me.Visible = True
                    Me.BringToFront()
                    Me.Activate()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub


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
            Me.Activate()
        ElseIf e.Button = MouseButtons.Middle Then
            paste(HistoryViewerListBox.Items.Item(0))
        Else
            ' do nothing
        End If
    End Sub

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.CB_autoHide.Checked = My.Settings.autoHideOn
        Me.CB_alwaysInForeground.Checked = My.Settings.alwaysOnTop
        Me.TopMost = My.Settings.alwaysOnTop

        Me.HotkeyModifiers_ALT_cb.Checked = My.Settings.HotkeyModifierALT_SET
        Me.HotkeyModifiers_CTRL_cb.Checked = My.Settings.HotkeyModifierCTRL_SET
        Me.HotkeyModifiers_WIN_cb.Checked = My.Settings.HotkeyModifierWIN_SET
        Me.HotkeyModifiers_SHIFT_cb.Checked = My.Settings.HotkeyModifierSHIFT_SET
        Me.HotkeyKey_cb.SelectedIndex = My.Settings.HotkeyKeyIndex

        SetHotkey()

        If My.Settings.autoHideOn = True Then
            Me.Visible = False
            Me.MinimizeBox = False
            Me.ControlBox = False
        Else
            Me.ControlBox = True
            Me.MinimizeBox = True
        End If

        Me.CheckForUpdatesLink.Text = My.Resources.UpdateURL
        Me.VersionNumber_Label.Text = My.Resources.VersionNumberString
    End Sub

    Private Sub SetHotkey()
        Dim hotkeyModifier As Integer = 0
        Dim hotkeyKeyIndex As UInteger
        Try
            hotkeyKeyIndex = HotkeyKey_cb.SelectedIndex
        Catch ex As OverflowException
            Return
        End Try
        Dim hotkeyKeys As Keys() = {
                                        Keys.A,
                                        Keys.B,
                                        Keys.C,
                                        Keys.D,
                                        Keys.E,
                                        Keys.F,
                                        Keys.G,
                                        Keys.H,
                                        Keys.I,
                                        Keys.J,
                                        Keys.K,
                                        Keys.L,
                                        Keys.M,
                                        Keys.N,
                                        Keys.O,
                                        Keys.P,
                                        Keys.Q,
                                        Keys.R,
                                        Keys.S,
                                        Keys.T,
                                        Keys.U,
                                        Keys.V,
                                        Keys.W,
                                        Keys.X,
                                        Keys.Y,
                                        Keys.Z,
                                        Keys.D1,
                                        Keys.D2,
                                        Keys.D3,
                                        Keys.D4,
                                        Keys.D5,
                                        Keys.D6,
                                        Keys.D7,
                                        Keys.D8,
                                        Keys.D9,
                                        Keys.D0,
                                        Keys.Delete,
                                        Keys.Enter,
                                        Keys.Back,
                                        Keys.Space,
                                        Keys.F1,
                                        Keys.F2,
                                        Keys.F3,
                                        Keys.F4,
                                        Keys.F5,
                                        Keys.F6,
                                        Keys.F7,
                                        Keys.F8,
                                        Keys.F9,
                                        Keys.F10,
                                        Keys.F11,
                                        Keys.F12
                                    }

        If (HotkeyModifiers_CTRL_cb.Checked = True) Then
            hotkeyModifier = hotkeyModifier Or Key_CTRL
        Else
            hotkeyModifier = hotkeyModifier And Not Key_CTRL
        End If

        If (HotkeyModifiers_ALT_cb.Checked = True) Then
            hotkeyModifier = hotkeyModifier Or Key_ALT
        Else
            hotkeyModifier = hotkeyModifier And Not Key_ALT
        End If

        If (HotkeyModifiers_SHIFT_cb.Checked = True) Then
            hotkeyModifier = hotkeyModifier Or Key_SHIFT
        Else
            hotkeyModifier = hotkeyModifier And Not Key_SHIFT
        End If

        If (HotkeyModifiers_WIN_cb.Checked = True) Then
            hotkeyModifier = hotkeyModifier Or Key_WIN
        Else
            hotkeyModifier = hotkeyModifier And Not Key_WIN
        End If

        My.Settings.HotkeyModifierCTRL_SET = HotkeyModifiers_CTRL_cb.Checked
        My.Settings.HotkeyModifierALT_SET = HotkeyModifiers_ALT_cb.Checked
        My.Settings.HotkeyModifierSHIFT_SET = HotkeyModifiers_SHIFT_cb.Checked
        My.Settings.HotkeyModifierWIN_SET = HotkeyModifiers_WIN_cb.Checked

        RegisterHotKey(Me.Handle, 1, hotkeyModifier, hotkeyKeys(hotkeyKeyIndex))

        My.Settings.HotkeyKeyIndex = hotkeyKeyIndex

        My.Settings.Save()
    End Sub

    Private Sub MainWindow_FocusLost(sender As Object, e As EventArgs) Handles Me.Deactivate
        If My.Settings.autoHideOn = True Then
            Me.Visible = False
        End If
    End Sub
    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        UnregisterHotKey(Me.Handle, 1)
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
        Me.TopMost = CB_alwaysInForeground.Checked
        My.Settings.alwaysOnTop = CB_alwaysInForeground.Checked
        My.Settings.Save()
    End Sub

    Private Sub CB_autoHide_CheckedChanged(sender As Object, e As EventArgs) Handles CB_autoHide.CheckedChanged
        My.Settings.autoHideOn = CB_autoHide.Checked
        If CB_autoHide.Checked = True Then
            My.Settings.alwaysOnTop = False
            Me.CB_alwaysInForeground.Enabled = False
            Me.CB_alwaysInForeground.Checked = False
            Me.MinimizeBox = False
            Me.ControlBox = False
        Else
            Me.CB_alwaysInForeground.Enabled = True
            Me.MinimizeBox = True
            Me.ControlBox = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub CheckForUpdatesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CheckForUpdatesLink.LinkClicked
        CheckForUpdatesBrowserWindow.Visible = False
        CheckForUpdatesBrowserWindow.Visible = True
        CheckForUpdatesLink.LinkVisited = True
    End Sub

    Private Sub ChangeHotkey_Btn_Click(sender As Object, e As EventArgs) Handles ChangeHotkey_Btn.Click
        SetHotkey()
    End Sub

End Class
