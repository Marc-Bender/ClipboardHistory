<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationBarContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerlaufLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZwischenablageLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelektorAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHistoryButton = New System.Windows.Forms.Button()
        Me.ClearClipboardButton = New System.Windows.Forms.Button()
        Me.HistoryViewerListBox = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CB_alwaysInForeground = New System.Windows.Forms.CheckBox()
        Me.CB_autoHide = New System.Windows.Forms.CheckBox()
        Me.HotkeyValue = New System.Windows.Forms.Label()
        Me.CheckForUpdatesLink = New System.Windows.Forms.LinkLabel()
        Me.HotkeyKey_cb = New System.Windows.Forms.ComboBox()
        Me.ChangeHotkey_Btn = New System.Windows.Forms.Button()
        Me.VersionNumber_Label = New System.Windows.Forms.Label()
        Me.HotkeyModifiers_CTRL_cb = New System.Windows.Forms.CheckBox()
        Me.HotkeyModifiers_SHIFT_cb = New System.Windows.Forms.CheckBox()
        Me.HotkeyModifiers_ALT_cb = New System.Windows.Forms.CheckBox()
        Me.HotkeyModifiers_WIN_cb = New System.Windows.Forms.CheckBox()
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
        Me.NotificationBarContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerlaufLeerenToolStripMenuItem, Me.ZwischenablageLeerenToolStripMenuItem, Me.SelektorAnzeigenToolStripMenuItem, Me.EndButton})
        Me.NotificationBarContextMenu.Name = "NotificationBarContextMenu"
        Me.NotificationBarContextMenu.Size = New System.Drawing.Size(195, 92)
        '
        'VerlaufLeerenToolStripMenuItem
        '
        Me.VerlaufLeerenToolStripMenuItem.Name = "VerlaufLeerenToolStripMenuItem"
        Me.VerlaufLeerenToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.VerlaufLeerenToolStripMenuItem.Text = "Verlauf leeren"
        '
        'ZwischenablageLeerenToolStripMenuItem
        '
        Me.ZwischenablageLeerenToolStripMenuItem.Name = "ZwischenablageLeerenToolStripMenuItem"
        Me.ZwischenablageLeerenToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ZwischenablageLeerenToolStripMenuItem.Text = "Zwischenablage leeren"
        '
        'SelektorAnzeigenToolStripMenuItem
        '
        Me.SelektorAnzeigenToolStripMenuItem.Name = "SelektorAnzeigenToolStripMenuItem"
        Me.SelektorAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SelektorAnzeigenToolStripMenuItem.Text = "Selektor Anzeigen"
        '
        'EndButton
        '
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(194, 22)
        Me.EndButton.Text = "Beenden"
        '
        'ClearHistoryButton
        '
        Me.ClearHistoryButton.Location = New System.Drawing.Point(12, 115)
        Me.ClearHistoryButton.Name = "ClearHistoryButton"
        Me.ClearHistoryButton.Size = New System.Drawing.Size(129, 23)
        Me.ClearHistoryButton.TabIndex = 2
        Me.ClearHistoryButton.Text = "Verlauf leeren"
        Me.ClearHistoryButton.UseVisualStyleBackColor = True
        '
        'ClearClipboardButton
        '
        Me.ClearClipboardButton.Location = New System.Drawing.Point(168, 115)
        Me.ClearClipboardButton.Name = "ClearClipboardButton"
        Me.ClearClipboardButton.Size = New System.Drawing.Size(140, 23)
        Me.ClearClipboardButton.TabIndex = 3
        Me.ClearClipboardButton.Text = "Zwischenablage leeren"
        Me.ClearClipboardButton.UseVisualStyleBackColor = True
        '
        'HistoryViewerListBox
        '
        Me.HistoryViewerListBox.FormattingEnabled = True
        Me.HistoryViewerListBox.Location = New System.Drawing.Point(12, 12)
        Me.HistoryViewerListBox.Name = "HistoryViewerListBox"
        Me.HistoryViewerListBox.Size = New System.Drawing.Size(296, 95)
        Me.HistoryViewerListBox.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CB_alwaysInForeground
        '
        Me.CB_alwaysInForeground.AutoSize = True
        Me.CB_alwaysInForeground.Location = New System.Drawing.Point(12, 145)
        Me.CB_alwaysInForeground.Name = "CB_alwaysInForeground"
        Me.CB_alwaysInForeground.Size = New System.Drawing.Size(128, 17)
        Me.CB_alwaysInForeground.TabIndex = 5
        Me.CB_alwaysInForeground.Text = "Immer im Vordergrund"
        Me.CB_alwaysInForeground.UseVisualStyleBackColor = True
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
        'CheckForUpdatesLink
        '
        Me.CheckForUpdatesLink.Location = New System.Drawing.Point(9, 222)
        Me.CheckForUpdatesLink.Name = "CheckForUpdatesLink"
        Me.CheckForUpdatesLink.Size = New System.Drawing.Size(299, 32)
        Me.CheckForUpdatesLink.TabIndex = 0
        Me.CheckForUpdatesLink.TabStop = True
        Me.CheckForUpdatesLink.Text = "www.example.com"
        '
        'HotkeyKey_cb
        '
        Me.HotkeyKey_cb.FormattingEnabled = True
        Me.HotkeyKey_cb.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "DEL", "ENTER", "BKSP", "SPACE", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.HotkeyKey_cb.Location = New System.Drawing.Point(219, 168)
        Me.HotkeyKey_cb.Name = "HotkeyKey_cb"
        Me.HotkeyKey_cb.Size = New System.Drawing.Size(76, 21)
        Me.HotkeyKey_cb.TabIndex = 10
        '
        'ChangeHotkey_Btn
        '
        Me.ChangeHotkey_Btn.Location = New System.Drawing.Point(9, 193)
        Me.ChangeHotkey_Btn.Name = "ChangeHotkey_Btn"
        Me.ChangeHotkey_Btn.Size = New System.Drawing.Size(109, 23)
        Me.ChangeHotkey_Btn.TabIndex = 11
        Me.ChangeHotkey_Btn.Text = "Hotkey ändern"
        Me.ChangeHotkey_Btn.UseVisualStyleBackColor = True
        '
        'VersionNumber_Label
        '
        Me.VersionNumber_Label.AutoSize = True
        Me.VersionNumber_Label.Location = New System.Drawing.Point(275, 203)
        Me.VersionNumber_Label.Name = "VersionNumber_Label"
        Me.VersionNumber_Label.Size = New System.Drawing.Size(41, 13)
        Me.VersionNumber_Label.TabIndex = 12
        Me.VersionNumber_Label.Text = "V.4711"
        '
        'HotkeyModifiers_CTRL_cb
        '
        Me.HotkeyModifiers_CTRL_cb.AutoSize = True
        Me.HotkeyModifiers_CTRL_cb.Location = New System.Drawing.Point(12, 169)
        Me.HotkeyModifiers_CTRL_cb.Name = "HotkeyModifiers_CTRL_cb"
        Me.HotkeyModifiers_CTRL_cb.Size = New System.Drawing.Size(54, 17)
        Me.HotkeyModifiers_CTRL_cb.TabIndex = 13
        Me.HotkeyModifiers_CTRL_cb.Text = "CTRL"
        Me.HotkeyModifiers_CTRL_cb.UseVisualStyleBackColor = True
        '
        'HotkeyModifiers_SHIFT_cb
        '
        Me.HotkeyModifiers_SHIFT_cb.AutoSize = True
        Me.HotkeyModifiers_SHIFT_cb.Location = New System.Drawing.Point(61, 168)
        Me.HotkeyModifiers_SHIFT_cb.Name = "HotkeyModifiers_SHIFT_cb"
        Me.HotkeyModifiers_SHIFT_cb.Size = New System.Drawing.Size(57, 17)
        Me.HotkeyModifiers_SHIFT_cb.TabIndex = 14
        Me.HotkeyModifiers_SHIFT_cb.Text = "SHIFT"
        Me.HotkeyModifiers_SHIFT_cb.UseVisualStyleBackColor = True
        '
        'HotkeyModifiers_ALT_cb
        '
        Me.HotkeyModifiers_ALT_cb.AutoSize = True
        Me.HotkeyModifiers_ALT_cb.Location = New System.Drawing.Point(117, 168)
        Me.HotkeyModifiers_ALT_cb.Name = "HotkeyModifiers_ALT_cb"
        Me.HotkeyModifiers_ALT_cb.Size = New System.Drawing.Size(46, 17)
        Me.HotkeyModifiers_ALT_cb.TabIndex = 15
        Me.HotkeyModifiers_ALT_cb.Text = "ALT"
        Me.HotkeyModifiers_ALT_cb.UseVisualStyleBackColor = True
        '
        'HotkeyModifiers_WIN_cb
        '
        Me.HotkeyModifiers_WIN_cb.AutoSize = True
        Me.HotkeyModifiers_WIN_cb.Location = New System.Drawing.Point(167, 168)
        Me.HotkeyModifiers_WIN_cb.Name = "HotkeyModifiers_WIN_cb"
        Me.HotkeyModifiers_WIN_cb.Size = New System.Drawing.Size(48, 17)
        Me.HotkeyModifiers_WIN_cb.TabIndex = 16
        Me.HotkeyModifiers_WIN_cb.Text = "WIN"
        Me.HotkeyModifiers_WIN_cb.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.HotkeyModifiers_WIN_cb)
        Me.Controls.Add(Me.HotkeyModifiers_ALT_cb)
        Me.Controls.Add(Me.HotkeyModifiers_SHIFT_cb)
        Me.Controls.Add(Me.HotkeyModifiers_CTRL_cb)
        Me.Controls.Add(Me.VersionNumber_Label)
        Me.Controls.Add(Me.ChangeHotkey_Btn)
        Me.Controls.Add(Me.HotkeyKey_cb)
        Me.Controls.Add(Me.CheckForUpdatesLink)
        Me.Controls.Add(Me.HotkeyValue)
        Me.Controls.Add(Me.CB_autoHide)
        Me.Controls.Add(Me.CB_alwaysInForeground)
        Me.Controls.Add(Me.HistoryViewerListBox)
        Me.Controls.Add(Me.ClearClipboardButton)
        Me.Controls.Add(Me.ClearHistoryButton)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(336, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(336, 290)
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Clipboard History"
        Me.NotificationBarContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotificationBarContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EndButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerlaufLeerenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearHistoryButton As Button
    Friend WithEvents ClearClipboardButton As Button
    Friend WithEvents HistoryViewerListBox As ListBox
    Friend WithEvents ZwischenablageLeerenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SelektorAnzeigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CB_alwaysInForeground As CheckBox
    Friend WithEvents CB_autoHide As CheckBox
    Friend WithEvents HotkeyValue As Label
    Friend WithEvents CheckForUpdatesLink As LinkLabel
    Friend WithEvents HotkeyKey_cb As ComboBox
    Friend WithEvents ChangeHotkey_Btn As Button
    Friend WithEvents VersionNumber_Label As Label
    Friend WithEvents HotkeyModifiers_CTRL_cb As CheckBox
    Friend WithEvents HotkeyModifiers_SHIFT_cb As CheckBox
    Friend WithEvents HotkeyModifiers_ALT_cb As CheckBox
    Friend WithEvents HotkeyModifiers_WIN_cb As CheckBox
End Class
