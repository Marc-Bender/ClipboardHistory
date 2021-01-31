<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CheckForUpdates
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
        Me.WebBrws_gitHubPage = New System.Windows.Forms.WebBrowser()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrws_gitHubPage
        '
        Me.WebBrws_gitHubPage.AllowWebBrowserDrop = False
        Me.WebBrws_gitHubPage.Location = New System.Drawing.Point(13, 13)
        Me.WebBrws_gitHubPage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrws_gitHubPage.Name = "WebBrws_gitHubPage"
        Me.WebBrws_gitHubPage.Size = New System.Drawing.Size(1152, 654)
        Me.WebBrws_gitHubPage.TabIndex = 1
        Me.WebBrws_gitHubPage.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Ok.AutoSize = True
        Me.Btn_Ok.Location = New System.Drawing.Point(1025, 710)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(32, 23)
        Me.Btn_Ok.TabIndex = 2
        Me.Btn_Ok.Text = "OK"
        '
        'Form_CheckForUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 745)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.WebBrws_gitHubPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CheckForUpdates"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auf Updates auf Github suchen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrws_gitHubPage As WebBrowser
    Friend WithEvents Btn_Ok As Button
End Class
