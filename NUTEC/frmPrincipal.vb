Public Class frmPrincipal
    Private Sub CadastroDeAlunosSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAlunosSQLToolStripMenuItem.Click
        Dim f As New frmAlunoSQL
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CadastroDeAlunosLINQToSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAlunosLINQToSQLToolStripMenuItem.Click
        Dim f As New frmAlunoLINQToSQL
        f.MdiParent = Me
        f.Show()
    End Sub
End Class