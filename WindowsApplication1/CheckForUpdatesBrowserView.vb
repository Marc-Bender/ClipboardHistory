Imports System.Windows.Forms

Public Class CheckForUpdatesBrowserWindow

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckForUpdatesBrowserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Uri.TryCreate(My.Resources.UpdateURL, UriKind.Absolute, WebBrowser1.Url)
    End Sub
End Class
