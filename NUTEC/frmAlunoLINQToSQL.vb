Public Class frmAlunoLINQToSQL
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim banco As New BancoDeDadosDataContext

        Dim aluno As New Alunos

        aluno.IdAluno = txtIdAluno.Text
        aluno.Nome = txtNome.Text
        aluno.Endereco = txtEndereco.Text
        aluno.Cidade = txtCidade.Text
        aluno.Telefone = txtTelefone.Text
        aluno.Email = txtEmail.Text

        banco.Alunos.InsertOnSubmit(aluno)

        banco.SubmitChanges()

        banco.Connection.Close()


        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno inserido com sucesso!", "Inserir aluno")

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim banco As New BancoDeDadosDataContext

        Dim aluno = (From a In banco.Alunos Where a.IdAluno = txtIdAluno.Text Select a).SingleOrDefault

        aluno.IdAluno = txtIdAluno.Text
        aluno.Nome = txtNome.Text
        aluno.Endereco = txtEndereco.Text
        aluno.Cidade = txtCidade.Text
        aluno.Telefone = txtTelefone.Text
        aluno.Email = txtEmail.Text

        banco.SubmitChanges()

        banco.Connection.Close()

        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno atualizado com sucesso!", "Atualizar aluno")

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim banco As New BancoDeDadosDataContext

        Dim aluno = (From a In banco.Alunos Where a.IdAluno = txtIdAluno.Text Select a).SingleOrDefault

        banco.Alunos.DeleteOnSubmit(aluno)

        banco.SubmitChanges()

        banco.Connection.Close()

        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno excluído com sucesso!", "Excluir aluno")

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click



        Dim banco As New BancoDeDadosDataContext

        Dim alunos = (From a In banco.Alunos Where a.Nome.Contains(txtNome.Text) Select a).ToList


        dgvListaDeAlunos.DataSource = alunos
        dgvListaDeAlunos.Refresh()

        banco.Connection.Close()

    End Sub

    Private Sub dgvListaDeAlunos_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaDeAlunos.DoubleClick
        Me.txtIdAluno.Text = dgvListaDeAlunos.CurrentRow.Cells("colIdAluno").Value
        Me.txtNome.Text = dgvListaDeAlunos.CurrentRow.Cells("colNome").Value
        Me.txtEndereco.Text = dgvListaDeAlunos.CurrentRow.Cells("colEndereco").Value
        Me.txtCidade.Text = dgvListaDeAlunos.CurrentRow.Cells("colCidade").Value
        Me.txtTelefone.Text = dgvListaDeAlunos.CurrentRow.Cells("colTelefone").Value
        Me.txtEmail.Text = dgvListaDeAlunos.CurrentRow.Cells("colEmail").Value
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""
    End Sub
End Class
