Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Directory.Exists(TextBox1.Text) Then
            Directory.Delete(TextBox1.Text)
        Else
            Directory.CreateDirectory(TextBox1.Text)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
    End Sub
End Class
