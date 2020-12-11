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
        Me.EndButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerlaufLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZwischenablageLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelektorAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHistoryButton = New System.Windows.Forms.Button()
        Me.ClearClipboardButton = New System.Windows.Forms.Button()
        Me.HistoryViewerListBox = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CB_alwaysInForeground = New System.Windows.Forms.CheckBox()
        Me.CB_autoHide = New System.Windows.Forms.CheckBox()
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
        'EndButton
        '
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(194, 22)
        Me.EndButton.Text = "Beenden"
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
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_autoHide)
        Me.Controls.Add(Me.CB_alwaysInForeground)
        Me.Controls.Add(Me.HistoryViewerListBox)
        Me.Controls.Add(Me.ClearClipboardButton)
        Me.Controls.Add(Me.ClearHistoryButton)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(336, 220)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(336, 220)
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
End Class
