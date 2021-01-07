Imports System.Windows.Forms

Public Class Form_CheckForUpdates

    Private Sub HandlerFun_on_Btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub HandlerFun_on_Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub HandlerFun_on_CheckForUpdatesBrowserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Uri.TryCreate(My.Resources.Str_UpdateURL, UriKind.Absolute, WebBrws_gitHubPage.Url)
    End Sub
End Class
