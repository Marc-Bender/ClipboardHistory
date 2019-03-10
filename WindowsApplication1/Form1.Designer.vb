<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationBarContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EndButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZwischenablageLeeren = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationBarContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.NotificationBarContextMenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ClipboardCleaner"
        Me.NotifyIcon1.Visible = True
        '
        'NotificationBarContextMenu
        '
        Me.NotificationBarContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndButton, Me.ZwischenablageLeeren})
        Me.NotificationBarContextMenu.Name = "NotificationBarContextMenu"
        Me.NotificationBarContextMenu.Size = New System.Drawing.Size(349, 70)
        '
        'EndButton
        '
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(348, 22)
        Me.EndButton.Text = "Beenden"
        '
        'ZwischenablageLeeren
        '
        Me.ZwischenablageLeeren.Name = "ZwischenablageLeeren"
        Me.ZwischenablageLeeren.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ZwischenablageLeeren.Size = New System.Drawing.Size(348, 22)
        Me.ZwischenablageLeeren.Text = "Zwischenablage leeren"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 149)
        Me.Enabled = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.NotificationBarContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotificationBarContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EndButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZwischenablageLeeren As System.Windows.Forms.ToolStripMenuItem

End Class
