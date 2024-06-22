Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmPrincipal.Show()
        frmPrincipal.StatusStrip1.Items(0).Text = txtUsuario.Text
        Me.Close()
    End Sub
End Class