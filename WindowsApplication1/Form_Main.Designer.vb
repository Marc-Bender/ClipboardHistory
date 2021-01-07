<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationBarContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMItem_clearHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItem_clearClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItem_showSelector = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItem_end = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_clearHistory = New System.Windows.Forms.Button()
        Me.Btn_clearClipboard = New System.Windows.Forms.Button()
        Me.ListBox_RecentClipboardEntries = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CB_topMost = New System.Windows.Forms.CheckBox()
        Me.CB_autoHide = New System.Windows.Forms.CheckBox()
        Me.HotkeyValue = New System.Windows.Forms.Label()
        Me.Lbl_CheckForUpdatesLink = New System.Windows.Forms.LinkLabel()
        Me.ComB_Hotkey_Key = New System.Windows.Forms.ComboBox()
        Me.Btn_ChangeHotkey = New System.Windows.Forms.Button()
        Me.Lbl_CurrentVersionNumber = New System.Windows.Forms.Label()
        Me.CB_HotkeyModifiers_CTRL = New System.Windows.Forms.CheckBox()
        Me.CB_HotkeyModifiers_SHIFT = New System.Windows.Forms.CheckBox()
        Me.CB_HotkeyModifiers_ALT = New System.Windows.Forms.CheckBox()
        Me.CB_HotkeyModifiers_WIN = New System.Windows.Forms.CheckBox()
        Me.NotificationBarContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.NotificationBarContextMenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ClipboardHistory"
        Me.NotifyIcon1.Visible = True
        '
        'NotificationBarContextMenu
        '
        Me.NotificationBarContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItem_clearHistory, Me.TSMItem_clearClipboard, Me.TSMItem_showSelector, Me.TSMItem_end})
        Me.NotificationBarContextMenu.Name = "NotificationBarContextMenu"
        Me.NotificationBarContextMenu.Size = New System.Drawing.Size(195, 92)
        '
        'TSMItem_clearHistory
        '
        Me.TSMItem_clearHistory.Name = "TSMItem_clearHistory"
        Me.TSMItem_clearHistory.Size = New System.Drawing.Size(194, 22)
        Me.TSMItem_clearHistory.Text = "Verlauf leeren"
        '
        'TSMItem_clearClipboard
        '
        Me.TSMItem_clearClipboard.Name = "TSMItem_clearClipboard"
        Me.TSMItem_clearClipboard.Size = New System.Drawing.Size(194, 22)
        Me.TSMItem_clearClipboard.Text = "Zwischenablage leeren"
        '
        'TSMItem_showSelector
        '
        Me.TSMItem_showSelector.Name = "TSMItem_showSelector"
        Me.TSMItem_showSelector.Size = New System.Drawing.Size(194, 22)
        Me.TSMItem_showSelector.Text = "Selektor Anzeigen"
        '
        'TSMItem_end
        '
        Me.TSMItem_end.Name = "TSMItem_end"
        Me.TSMItem_end.Size = New System.Drawing.Size(194, 22)
        Me.TSMItem_end.Text = "Beenden"
        '
        'Btn_clearHistory
        '
        Me.Btn_clearHistory.Location = New System.Drawing.Point(12, 115)
        Me.Btn_clearHistory.Name = "Btn_clearHistory"
        Me.Btn_clearHistory.Size = New System.Drawing.Size(129, 23)
        Me.Btn_clearHistory.TabIndex = 2
        Me.Btn_clearHistory.Text = "Verlauf leeren"
        Me.Btn_clearHistory.UseVisualStyleBackColor = True
        '
        'Btn_clearClipboard
        '
        Me.Btn_clearClipboard.Location = New System.Drawing.Point(168, 115)
        Me.Btn_clearClipboard.Name = "Btn_clearClipboard"
        Me.Btn_clearClipboard.Size = New System.Drawing.Size(140, 23)
        Me.Btn_clearClipboard.TabIndex = 3
        Me.Btn_clearClipboard.Text = "Zwischenablage leeren"
        Me.Btn_clearClipboard.UseVisualStyleBackColor = True
        '
        'ListBox_RecentClipboardEntries
        '
        Me.ListBox_RecentClipboardEntries.FormattingEnabled = True
        Me.ListBox_RecentClipboardEntries.Location = New System.Drawing.Point(12, 12)
        Me.ListBox_RecentClipboardEntries.Name = "ListBox_RecentClipboardEntries"
        Me.ListBox_RecentClipboardEntries.Size = New System.Drawing.Size(296, 95)
        Me.ListBox_RecentClipboardEntries.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CB_topMost
        '
        Me.CB_topMost.AutoSize = True
        Me.CB_topMost.Location = New System.Drawing.Point(12, 145)
        Me.CB_topMost.Name = "CB_topMost"
        Me.CB_topMost.Size = New System.Drawing.Size(128, 17)
        Me.CB_topMost.TabIndex = 5
        Me.CB_topMost.Text = "Immer im Vordergrund"
        Me.CB_topMost.UseVisualStyleBackColor = True
        '
        'CB_autoHide
        '
        Me.CB_autoHide.AutoSize = True
        Me.CB_autoHide.Location = New System.Drawing.Point(168, 145)
        Me.CB_autoHide.Name = "CB_autoHide"
        Me.CB_autoHide.Size = New System.Drawing.Size(148, 17)
        Me.CB_autoHide.TabIndex = 6
        Me.CB_autoHide.Text = "Automatisch ausblenden?"
        Me.CB_autoHide.UseVisualStyleBackColor = True
        '
        'HotkeyValue
        '
        Me.HotkeyValue.AutoSize = True
        Me.HotkeyValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HotkeyValue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HotkeyValue.Location = New System.Drawing.Point(195, 227)
        Me.HotkeyValue.Name = "HotkeyValue"
        Me.HotkeyValue.Size = New System.Drawing.Size(73, 15)
        Me.HotkeyValue.TabIndex = 7
        Me.HotkeyValue.Text = "*STRG + F12"
        '
        'Lbl_CheckForUpdatesLink
        '
        Me.Lbl_CheckForUpdatesLink.Location = New System.Drawing.Point(9, 222)
        Me.Lbl_CheckForUpdatesLink.Name = "Lbl_CheckForUpdatesLink"
        Me.Lbl_CheckForUpdatesLink.Size = New System.Drawing.Size(299, 32)
        Me.Lbl_CheckForUpdatesLink.TabIndex = 0
        Me.Lbl_CheckForUpdatesLink.TabStop = True
        Me.Lbl_CheckForUpdatesLink.Text = "www.example.com"
        '
        'ComB_Hotkey_Key
        '
        Me.ComB_Hotkey_Key.FormattingEnabled = True
        Me.ComB_Hotkey_Key.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "DEL", "ENTER", "BKSP", "SPACE", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.ComB_Hotkey_Key.Location = New System.Drawing.Point(219, 168)
        Me.ComB_Hotkey_Key.Name = "ComB_Hotkey_Key"
        Me.ComB_Hotkey_Key.Size = New System.Drawing.Size(76, 21)
        Me.ComB_Hotkey_Key.TabIndex = 10
        '
        'Btn_ChangeHotkey
        '
        Me.Btn_ChangeHotkey.Location = New System.Drawing.Point(9, 193)
        Me.Btn_ChangeHotkey.Name = "Btn_ChangeHotkey"
        Me.Btn_ChangeHotkey.Size = New System.Drawing.Size(109, 23)
        Me.Btn_ChangeHotkey.TabIndex = 11
        Me.Btn_ChangeHotkey.Text = "Hotkey ändern"
        Me.Btn_ChangeHotkey.UseVisualStyleBackColor = True
        '
        'Lbl_CurrentVersionNumber
        '
        Me.Lbl_CurrentVersionNumber.AutoSize = True
        Me.Lbl_CurrentVersionNumber.Location = New System.Drawing.Point(275, 203)
        Me.Lbl_CurrentVersionNumber.Name = "Lbl_CurrentVersionNumber"
        Me.Lbl_CurrentVersionNumber.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_CurrentVersionNumber.TabIndex = 12
        Me.Lbl_CurrentVersionNumber.Text = "V.4711"
        '
        'CB_HotkeyModifiers_CTRL
        '
        Me.CB_HotkeyModifiers_CTRL.AutoSize = True
        Me.CB_HotkeyModifiers_CTRL.Location = New System.Drawing.Point(12, 169)
        Me.CB_HotkeyModifiers_CTRL.Name = "CB_HotkeyModifiers_CTRL"
        Me.CB_HotkeyModifiers_CTRL.Size = New System.Drawing.Size(54, 17)
        Me.CB_HotkeyModifiers_CTRL.TabIndex = 13
        Me.CB_HotkeyModifiers_CTRL.Text = "CTRL"
        Me.CB_HotkeyModifiers_CTRL.UseVisualStyleBackColor = True
        '
        'CB_HotkeyModifiers_SHIFT
        '
        Me.CB_HotkeyModifiers_SHIFT.AutoSize = True
        Me.CB_HotkeyModifiers_SHIFT.Location = New System.Drawing.Point(61, 168)
        Me.CB_HotkeyModifiers_SHIFT.Name = "CB_HotkeyModifiers_SHIFT"
        Me.CB_HotkeyModifiers_SHIFT.Size = New System.Drawing.Size(57, 17)
        Me.CB_HotkeyModifiers_SHIFT.TabIndex = 14
        Me.CB_HotkeyModifiers_SHIFT.Text = "SHIFT"
        Me.CB_HotkeyModifiers_SHIFT.UseVisualStyleBackColor = True
        '
        'CB_HotkeyModifiers_ALT
        '
        Me.CB_HotkeyModifiers_ALT.AutoSize = True
        Me.CB_HotkeyModifiers_ALT.Location = New System.Drawing.Point(117, 168)
        Me.CB_HotkeyModifiers_ALT.Name = "CB_HotkeyModifiers_ALT"
        Me.CB_HotkeyModifiers_ALT.Size = New System.Drawing.Size(46, 17)
        Me.CB_HotkeyModifiers_ALT.TabIndex = 15
        Me.CB_HotkeyModifiers_ALT.Text = "ALT"
        Me.CB_HotkeyModifiers_ALT.UseVisualStyleBackColor = True
        '
        'CB_HotkeyModifiers_WIN
        '
        Me.CB_HotkeyModifiers_WIN.AutoSize = True
        Me.CB_HotkeyModifiers_WIN.Location = New System.Drawing.Point(167, 168)
        Me.CB_HotkeyModifiers_WIN.Name = "CB_HotkeyModifiers_WIN"
        Me.CB_HotkeyModifiers_WIN.Size = New System.Drawing.Size(48, 17)
        Me.CB_HotkeyModifiers_WIN.TabIndex = 16
        Me.CB_HotkeyModifiers_WIN.Text = "WIN"
        Me.CB_HotkeyModifiers_WIN.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_HotkeyModifiers_WIN)
        Me.Controls.Add(Me.CB_HotkeyModifiers_ALT)
        Me.Controls.Add(Me.CB_HotkeyModifiers_SHIFT)
        Me.Controls.Add(Me.CB_HotkeyModifiers_CTRL)
        Me.Controls.Add(Me.Lbl_CurrentVersionNumber)
        Me.Controls.Add(Me.Btn_ChangeHotkey)
        Me.Controls.Add(Me.ComB_Hotkey_Key)
        Me.Controls.Add(Me.Lbl_CheckForUpdatesLink)
        Me.Controls.Add(Me.HotkeyValue)
        Me.Controls.Add(Me.CB_autoHide)
        Me.Controls.Add(Me.CB_topMost)
        Me.Controls.Add(Me.ListBox_RecentClipboardEntries)
        Me.Controls.Add(Me.Btn_clearClipboard)
        Me.Controls.Add(Me.Btn_clearHistory)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(336, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(336, 290)
        Me.Name = "Form_Main"
        Me.Text = "Clipboard History"
        Me.NotificationBarContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotificationBarContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TSMItem_end As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMItem_clearHistory As ToolStripMenuItem
    Friend WithEvents Btn_clearHistory As Button
    Friend WithEvents Btn_clearClipboard As Button
    Friend WithEvents ListBox_RecentClipboardEntries As ListBox
    Friend WithEvents TSMItem_clearClipboard As ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TSMItem_showSelector As ToolStripMenuItem
    Friend WithEvents CB_topMost As CheckBox
    Friend WithEvents CB_autoHide As CheckBox
    Friend WithEvents HotkeyValue As Label
    Friend WithEvents Lbl_CheckForUpdatesLink As LinkLabel
    Friend WithEvents ComB_Hotkey_Key As ComboBox
    Friend WithEvents Btn_ChangeHotkey As Button
    Friend WithEvents Lbl_CurrentVersionNumber As Label
    Friend WithEvents CB_HotkeyModifiers_CTRL As CheckBox
    Friend WithEvents CB_HotkeyModifiers_SHIFT As CheckBox
    Friend WithEvents CB_HotkeyModifiers_ALT As CheckBox
    Friend WithEvents CB_HotkeyModifiers_WIN As CheckBox
End Class
