Module md_ClipboardHistory_Helpers
    Private ReadOnly RO_Uint_timeout As UInteger = 15 * 1000

    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer

    Public Sub Ifc_helperFun_showSelector()
        ClipboardHistory.Form_Main.Visible = True
        ClipboardHistory.Form_Main.BringToFront()
        ClipboardHistory.Form_Main.Activate()
        ClipboardHistory.Form_Main.WindowState = FormWindowState.Normal
    End Sub

    Public Sub Ifc_helperFun_clearClipboard()
        Clipboard.Clear()
        ClipboardHistory.Form_Main.NotifyIcon1.BalloonTipText = My.Resources.Str_ClipboardEmptied_DE
        ClipboardHistory.Form_Main.NotifyIcon1.ShowBalloonTip(RO_Uint_timeout)
    End Sub

    Public Sub Ifc_helperFun_clearHistory()
        ClipboardHistory.Form_Main.ListBox_RecentClipboardEntries.Items.Clear()
        ClipboardHistory.Form_Main.NotifyIcon1.BalloonTipText = My.Resources.Str_HistoryEmptied_DE
        ClipboardHistory.Form_Main.NotifyIcon1.ShowBalloonTip(RO_Uint_timeout)
    End Sub

    Public Sub Ifc_helperFun_paste(ByVal arg_str_textToPaste As String)
        Clipboard.SetText(arg_str_textToPaste)
        My.Computer.Keyboard.SendKeys("%{TAB}")
        Threading.Thread.Sleep(ClipboardHistory.Form_Main.NumUD_DelayTime.Value) 'ms
        My.Computer.Keyboard.SendKeys("+{INS}")
    End Sub

    Public Sub Ifc_helperFun_setCheckboxes()
        ClipboardHistory.Form_Main.CB_autoHide.Checked = My.Settings.b_autoHideOn
        ClipboardHistory.Form_Main.CB_topMost.Checked = My.Settings.b_topMost
        ClipboardHistory.Form_Main.TopMost = My.Settings.b_topMost

        ClipboardHistory.Form_Main.CB_HotkeyModifiers_ALT.Checked = My.Settings.b_HotkeyModifier_ALT
        ClipboardHistory.Form_Main.CB_HotkeyModifiers_CTRL.Checked = My.Settings.b_HotkeyModifier_CTRL
        ClipboardHistory.Form_Main.CB_HotkeyModifiers_WIN.Checked = My.Settings.b_HotkeyModifier_WIN
        ClipboardHistory.Form_Main.CB_HotkeyModifiers_SHIFT.Checked = My.Settings.b_HotkeyModifier_SHIFT
        ClipboardHistory.Form_Main.ComB_Hotkey_Key.SelectedIndex = My.Settings.Uint_Hotkey_KeyIndex
    End Sub

    Public Sub Ifc_helperFun_handleAutoHideOnState()
        If ClipboardHistory.Form_Main.CB_autoHide.Checked = True Then
            My.Settings.b_topMost = False
            ClipboardHistory.Form_Main.CB_topMost.Enabled = False
            ClipboardHistory.Form_Main.CB_topMost.Checked = False
            ClipboardHistory.Form_Main.MinimizeBox = False
            ClipboardHistory.Form_Main.ControlBox = False
        Else
            ClipboardHistory.Form_Main.CB_topMost.Enabled = True
            ClipboardHistory.Form_Main.MinimizeBox = True
            ClipboardHistory.Form_Main.ControlBox = True
        End If
    End Sub

    Public Sub Ifc_helperFun_setHotkey()
        Dim loc_Int_hotkeyModifier As Integer = 0
        Dim loc_Uint_hotkeyKeyIndex As UInteger

        Try
            loc_Uint_hotkeyKeyIndex = ClipboardHistory.Form_Main.ComB_Hotkey_Key.SelectedIndex
        Catch ex As OverflowException
            Return
        End Try

        Const Lib_Const_Key_ALT As Integer = &H1
        Const Lib_Const_Key_CTRL As Integer = &H2
        Const Lib_Const_Key_SHIFT As Integer = &H4
        Const Lib_Const_Key_WIN As Integer = &H8

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

        'starting out with loc_Int_hotkeyModifier = 0 so resetting unset bits is not neccessary
        loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or (Lib_Const_Key_CTRL And ClipboardHistory.Form_Main.CB_HotkeyModifiers_CTRL.Checked)
        loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or (Lib_Const_Key_ALT And ClipboardHistory.Form_Main.CB_HotkeyModifiers_ALT.Checked)
        loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or (Lib_Const_Key_SHIFT And ClipboardHistory.Form_Main.CB_HotkeyModifiers_SHIFT.Checked)
        loc_Int_hotkeyModifier = loc_Int_hotkeyModifier Or (Lib_Const_Key_WIN And ClipboardHistory.Form_Main.CB_HotkeyModifiers_WIN.Checked)

        My.Settings.b_HotkeyModifier_CTRL = ClipboardHistory.Form_Main.CB_HotkeyModifiers_CTRL.Checked
        My.Settings.b_HotkeyModifier_ALT = ClipboardHistory.Form_Main.CB_HotkeyModifiers_ALT.Checked
        My.Settings.b_HotkeyModifier_SHIFT = ClipboardHistory.Form_Main.CB_HotkeyModifiers_SHIFT.Checked
        My.Settings.b_HotkeyModifier_WIN = ClipboardHistory.Form_Main.CB_HotkeyModifiers_WIN.Checked

        RegisterHotKey(ClipboardHistory.Form_Main.Handle, 1, loc_Int_hotkeyModifier, loc_RO_Array_hotkeyKeys(loc_Uint_hotkeyKeyIndex))

        My.Settings.Uint_Hotkey_KeyIndex = loc_Uint_hotkeyKeyIndex

        My.Settings.Save()

    End Sub

End Module
