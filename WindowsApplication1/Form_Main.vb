Public Class Form_Main
    ReadOnly timeout As Integer = 15 * 1000
    Dim glob_Str_clipboardText As String

    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Declare Sub UnregisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer)

    Private Const Lib_Const_Key_NONE As Integer = &H0
    Private Const Lib_Const_Key_ALT As Integer = &H1
    Private Const Lib_Const_Key_CTRL As Integer = &H2
    Private Const Lib_Const_Key_SHIFT As Integer = &H4
    Private Const Lib_Const_Key_WIN As Integer = &H8

    Private Const Lib_Const_WM_HOTKEY As Integer = &H312

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = Lib_Const_WM_HOTKEY Then
            Select Case m.WParam
                Case 1 ' multiple hotkeys possible but only one needed yet
                    helperFun_showSelector()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub helperFun_showSelector()
        Me.Visible = True
        Me.BringToFront()
        Me.Activate()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub helperFun_clearClipboard()
        Clipboard.Clear()
        NotifyIcon1.BalloonTipText = My.Resources.Str_ClipboardEmptied_DE
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub helperFun_clearHistory()
        ListBox_RecentClipboardEntries.Items.Clear()
        NotifyIcon1.BalloonTipText = My.Resources.Str_HistoryEmptied_DE
        NotifyIcon1.ShowBalloonTip(timeout)
    End Sub

    Private Sub helperFun_paste(textToPaste As String)
        Clipboard.SetText(textToPaste)
        My.Computer.Keyboard.SendKeys("%{TAB}")
        Threading.Thread.Sleep(NumUD_DelayTime.Value) 'ms
        My.Computer.Keyboard.SendKeys("+{INS}")
    End Sub

    Private Sub HandlerFun_on_NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        If e.Button = MouseButtons.Left Then
            helperFun_showSelector()
        ElseIf e.Button = MouseButtons.Middle Then
            helperFun_paste(ListBox_RecentClipboardEntries.Items.Item(0))
        Else
            ' do nothing
        End If
    End Sub

    Private Sub HandlerFun_on_Form_Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.CB_autoHide.Checked = My.Settings.b_autoHideOn
        Me.CB_topMost.Checked = My.Settings.b_topMost
        Me.TopMost = My.Settings.b_topMost

        Me.CB_HotkeyModifiers_ALT.Checked = My.Settings.b_HotkeyModifier_ALT
        Me.CB_HotkeyModifiers_CTRL.Checked = My.Settings.b_HotkeyModifier_CTRL
        Me.CB_HotkeyModifiers_WIN.Checked = My.Settings.b_HotkeyModifier_WIN
        Me.CB_HotkeyModifiers_SHIFT.Checked = My.Settings.b_HotkeyModifier_SHIFT
        Me.ComB_Hotkey_Key.SelectedIndex = My.Settings.Uint_Hotkey_KeyIndex

        HelperFun_SetHotkey()

        If My.Settings.b_autoHideOn = True Then
            Me.Visible = False
            Me.MinimizeBox = False
            Me.ControlBox = False
        Else
            Me.ControlBox = True
            Me.MinimizeBox = True
        End If

        Me.NumUD_DelayTime.Value = My.Settings.Uint_DelayTime
        Me.Lbl_CheckForUpdatesLink.Text = My.Resources.Str_UpdateURL
        Me.Lbl_CurrentVersionNumber.Text = My.Resources.Str_VersionNumber
    End Sub

    Private Sub HelperFun_SetHotkey()
        Dim loc_Int_hotkeyModifier As Integer = 0
        Dim loc_Uint_hotkeyKeyIndex As UInteger
        Try
            loc_Uint_hotkeyKeyIndex = ComB_Hotkey_Key.SelectedIndex
        Catch ex As OverflowException
            Return
        End Try

        Dim loc_RO_Array_hotkeyKeys As Keys() = {
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

        If CB_HotkeyModifiers_CTRL.Checked = True Then
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or Lib_Const_Key_CTRL
        Else
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier And Not Lib_Const_Key_CTRL
        End If

        If CB_HotkeyModifiers_ALT.Checked = True Then
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or Lib_Const_Key_ALT
        Else
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier And Not Lib_Const_Key_ALT
        End If

        If CB_HotkeyModifiers_SHIFT.Checked = True Then
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or Lib_Const_Key_SHIFT
        Else
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier And Not Lib_Const_Key_SHIFT
        End If

        If CB_HotkeyModifiers_WIN.Checked = True Then
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or Lib_Const_Key_WIN
        Else
            loc_Int_hotkeyModifier = loc_Int_hotkeyModifier And Not Lib_Const_Key_WIN
        End If

        My.Settings.b_HotkeyModifier_CTRL = CB_HotkeyModifiers_CTRL.Checked
        My.Settings.b_HotkeyModifier_ALT = CB_HotkeyModifiers_ALT.Checked
        My.Settings.b_HotkeyModifier_SHIFT = CB_HotkeyModifiers_SHIFT.Checked
        My.Settings.b_HotkeyModifier_WIN = CB_HotkeyModifiers_WIN.Checked

        RegisterHotKey(Me.Handle, 1, loc_Int_hotkeyModifier, loc_RO_Array_hotkeyKeys(loc_Uint_hotkeyKeyIndex))

        My.Settings.Uint_Hotkey_KeyIndex = loc_Uint_hotkeyKeyIndex

        My.Settings.Save()
    End Sub

    Private Sub HandlerFun_on_Form_Main_FocusLost(sender As Object, e As EventArgs) Handles Me.Deactivate
        If My.Settings.b_autoHideOn = True Then
            Me.Visible = False
        End If
    End Sub
    Private Sub HandlerFun_on_Form_Main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        UnregisterHotKey(Me.Handle, 1)
    End Sub
    Private Sub HandlerFun_on_TSMItem_End_Click(sender As Object, e As EventArgs) Handles TSMItem_end.Click
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub HandlerFun_on_Btn_clearHistory_Click(sender As Object, e As EventArgs) Handles Btn_clearHistory.Click
        helperFun_clearHistory()
    End Sub

    Private Sub HandlerFun_on_Btn_clearClipboard_Click(sender As Object, e As EventArgs) Handles Btn_clearClipboard.Click
        helperFun_clearClipboard()
    End Sub

    Private Sub HandlerFun_on_TSMItem_clearHistory_Click(sender As Object, e As EventArgs) Handles TSMItem_clearHistory.Click
        helperFun_clearHistory()
    End Sub

    Private Sub HandlerFun_on_TSMItem_clearClipboard_Click(sender As Object, e As EventArgs) Handles TSMItem_clearClipboard.Click
        helperFun_clearClipboard()
    End Sub

    Private Sub HandlerFun_on_Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Clipboard.ContainsText And (Not Clipboard.GetText.Equals(glob_Str_clipboardText)) Then
            glob_Str_clipboardText = Clipboard.GetText
            Try
                For Each loc_str_entry As String In ListBox_RecentClipboardEntries.Items.OfType(Of String)
                    If loc_str_entry.Equals(glob_Str_clipboardText) Then
                        ListBox_RecentClipboardEntries.Items.RemoveAt(ListBox_RecentClipboardEntries.Items.IndexOf(loc_str_entry))
                        Exit For
                    End If
                Next

            Catch ex As System.ArgumentNullException
            End Try
            ListBox_RecentClipboardEntries.Items.Insert(0, glob_Str_clipboardText)
        End If
    End Sub

    Private Sub HandlerFun_on_HistoryViewerListBoxItem_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListBox_RecentClipboardEntries.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Dim loc_Int_rightClickIndex As Integer = ListBox_RecentClipboardEntries.IndexFromPoint(e.X, e.Y)
                ListBox_RecentClipboardEntries.Items.RemoveAt(loc_Int_rightClickIndex)
            Catch ex As ArgumentOutOfRangeException
            Catch ex As NullReferenceException
            End Try
        End If
        If e.Button = MouseButtons.Left Then
            Try
                helperFun_paste(ListBox_RecentClipboardEntries.SelectedItem.ToString)
            Catch ex As NullReferenceException
            End Try
        End If
    End Sub

    Private Sub HandlerFun_on_RecentClipboardEntries_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListBox_RecentClipboardEntries.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                ListBox_RecentClipboardEntries.Items.RemoveAt(ListBox_RecentClipboardEntries.SelectedIndex)
            Catch ex As ArgumentOutOfRangeException
            End Try
        End If
        If e.KeyCode = Keys.Enter Then
            helperFun_paste(ListBox_RecentClipboardEntries.SelectedItem.ToString)
        End If
    End Sub

    Private Sub HandlerFun_on_TSMItem_showSelector_Click(sender As Object, e As EventArgs) Handles TSMItem_showSelector.Click
        helperFun_showSelector()
    End Sub

    Private Sub HandlerFun_on_CB_topMost_CheckedChanged(sender As Object, e As EventArgs) Handles CB_topMost.CheckedChanged
        Me.TopMost = CB_topMost.Checked
        My.Settings.b_topMost = CB_topMost.Checked
        My.Settings.Save()
    End Sub

    Private Sub HandlerFun_on_CB_autoHide_CheckedChanged(sender As Object, e As EventArgs) Handles CB_autoHide.CheckedChanged
        My.Settings.b_autoHideOn = CB_autoHide.Checked
        If CB_autoHide.Checked = True Then
            My.Settings.b_topMost = False
            Me.CB_topMost.Enabled = False
            Me.CB_topMost.Checked = False
            Me.MinimizeBox = False
            Me.ControlBox = False
        Else
            Me.CB_topMost.Enabled = True
            Me.MinimizeBox = True
            Me.ControlBox = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub HandlerFun_on_Lbl_CheckForUpdatesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_CheckForUpdatesLink.LinkClicked
        Form_CheckForUpdates.Visible = False
        Form_CheckForUpdates.Visible = True
        Lbl_CheckForUpdatesLink.LinkVisited = True
    End Sub

    Private Sub HandlerFun_on_Btn_ChangeHotkey_Click(sender As Object, e As EventArgs) Handles Btn_ChangeHotkey.Click
        HelperFun_SetHotkey()
    End Sub

    Private Sub NumUD_DelayTime_ValueChanged(sender As Object, e As EventArgs) Handles NumUD_DelayTime.ValueChanged
        My.Settings.Uint_DelayTime = NumUD_DelayTime.Value
        My.Settings.Save()
    End Sub
End Class
