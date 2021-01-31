Imports ClipboardHistory.md_ClipboardHistory_Helpers

Public Class Form_Main
    Dim glob_Str_clipboardText As String

    Private Declare Sub UnregisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer)

    Private Const Lib_Const_WM_HOTKEY As Integer = &H312

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = Lib_Const_WM_HOTKEY Then
            Select Case m.WParam
                Case 1 ' multiple hotkeys possible but only one needed yet
                    Ifc_helperFun_showSelector()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub HandlerFun_on_NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        If e.Button = MouseButtons.Left Then
            Ifc_helperFun_showSelector()
        ElseIf e.Button = MouseButtons.Middle Then
            Ifc_helperFun_paste(ListBox_RecentClipboardEntries.Items.Item(0))
        Else
            ' do nothing; right click is handled via the context menu
        End If
    End Sub

    Private Sub HandlerFun_on_Form_Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Ifc_helperFun_setCheckboxes()
        Ifc_helperFun_setHotkey()

        'Cb_autoHideOn.Checked is now set to the correct value so this works as well
        Ifc_helperFun_handleAutoHideOnState()

        Me.NumUD_DelayTime.Value = My.Settings.Uint_DelayTime
        Me.Lbl_CheckForUpdatesLink.Text = My.Resources.Str_UpdateURL
        Me.Lbl_CurrentVersionNumber.Text = My.Resources.Str_VersionNumber
    End Sub

    Private Sub HandlerFun_on_Form_Main_FocusLost(sender As Object, e As EventArgs) Handles Me.Deactivate
        If My.Settings.b_autoHideOn = True Then
            Me.Visible = False
        Else
            'do nothing
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
        Ifc_helperFun_clearHistory()
    End Sub

    Private Sub HandlerFun_on_Btn_clearClipboard_Click(sender As Object, e As EventArgs) Handles Btn_clearClipboard.Click
        Ifc_helperFun_clearClipboard()
    End Sub

    Private Sub HandlerFun_on_TSMItem_clearHistory_Click(sender As Object, e As EventArgs) Handles TSMItem_clearHistory.Click
        Ifc_helperFun_clearHistory()
    End Sub

    Private Sub HandlerFun_on_TSMItem_clearClipboard_Click(sender As Object, e As EventArgs) Handles TSMItem_clearClipboard.Click
        Ifc_helperFun_clearClipboard()
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
                Ifc_helperFun_paste(ListBox_RecentClipboardEntries.SelectedItem.ToString)
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
        ElseIf e.KeyCode = Keys.Enter Then
            Ifc_helperFun_paste(ListBox_RecentClipboardEntries.SelectedItem.ToString)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Private Sub HandlerFun_on_TSMItem_showSelector_Click(sender As Object, e As EventArgs) Handles TSMItem_showSelector.Click
        Ifc_helperFun_showSelector()
    End Sub

    Private Sub HandlerFun_on_CB_topMost_CheckedChanged(sender As Object, e As EventArgs) Handles CB_topMost.CheckedChanged
        Me.TopMost = CB_topMost.Checked
        My.Settings.b_topMost = CB_topMost.Checked
        My.Settings.Save()
    End Sub

    Private Sub HandlerFun_on_CB_autoHide_CheckedChanged(sender As Object, e As EventArgs) Handles CB_autoHide.CheckedChanged
        My.Settings.b_autoHideOn = CB_autoHide.Checked
        Ifc_helperFun_handleAutoHideOnState()
        My.Settings.Save()
    End Sub

    Private Sub HandlerFun_on_Lbl_CheckForUpdatesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_CheckForUpdatesLink.LinkClicked
        Form_CheckForUpdates.Visible = True
        Lbl_CheckForUpdatesLink.LinkVisited = True
    End Sub

    Private Sub HandlerFun_on_Btn_ChangeHotkey_Click(sender As Object, e As EventArgs) Handles Btn_ChangeHotkey.Click
        Ifc_helperFun_setHotkey()
    End Sub

    Private Sub HandlerFun_NumUD_DelayTime_ValueChanged(sender As Object, e As EventArgs) Handles NumUD_DelayTime.ValueChanged
        My.Settings.Uint_DelayTime = NumUD_DelayTime.Value
        My.Settings.Save()
    End Sub
End Class
