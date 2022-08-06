Public Class frmAlunoSQL
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim conexao As New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True")

        Dim comando As New SqlClient.SqlCommand

        conexao.Open()

        comando.Connection = conexao
        comando.CommandText = String.Format("Insert Into Alunos (IdAluno, Nome, Endereco, Cidade, Telefone, Email) Values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", txtIdAluno.Text, txtNome.Text, txtEndereco.Text, txtCidade.Text, txtTelefone.Text, txtEmail.Text)
        comando.ExecuteNonQuery()

        conexao.Close()

        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno inserido com sucesso!", "Inserir aluno")

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim conexao As New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True")

        Dim comando As New SqlClient.SqlCommand

        conexao.Open()

        comando.Connection = conexao
        comando.CommandText = String.Format("Update Alunos Set IdAluno = {0}, Nome = '{1}', Endereco = '{2}', Cidade = '{3}', Telefone = '{4}', Email = '{5}' Where IdAluno = {0}", txtIdAluno.Text, txtNome.Text, txtEndereco.Text, txtCidade.Text, txtTelefone.Text, txtEmail.Text)
        comando.ExecuteNonQuery()

        conexao.Close()

        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno atualizado com sucesso!", "Atualizar aluno")

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim conexao As New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True")

        Dim comando As New SqlClient.SqlCommand

        conexao.Open()

        comando.Connection = conexao
        comando.CommandText = String.Format("Delete from Alunos Where IdAluno = {0}", txtIdAluno.Text)
        comando.ExecuteNonQuery()

        conexao.Close()

        txtIdAluno.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""

        MessageBox.Show("Aluno excluído com sucesso!", "Excluir aluno")

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim conexao As New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True")
        Dim comando As New SqlClient.SqlCommand


        conexao.Open()

        comando.Connection = conexao
        comando.CommandText = String.Format("Select * From Alunos Where Nome like '%{0}%'", txtPesquisarNome.Text)

        Dim banco As New DataSet

        Dim adaptadorDeDados As New SqlClient.SqlDataAdapter(comando.CommandText, conexao)
        adaptadorDeDados.Fill(banco)

        conexao.Close()

        dgvListaDeAlunos.DataSource = banco.Tables(0)
        dgvListaDeAlunos.Refresh()



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
