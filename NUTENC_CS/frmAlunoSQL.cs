using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NUTENC_CS
{
    public partial class frmAlunoSQL : Form
    {
        public frmAlunoSQL()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True");

            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

            conexao.Open();

            comando.Connection = conexao;
            comando.CommandText = string.Format("Insert Into Alunos (IdAluno, Nome, Endereco, Cidade, Telefone, Email) Values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", txtIdAluno.Text, txtNome.Text, txtEndereco.Text, txtCidade.Text, txtTelefone.Text, txtEmail.Text);
            comando.ExecuteNonQuery();

            conexao.Close();

            txtIdAluno.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";

            MessageBox.Show("Aluno inserido com sucesso!", "Inserir aluno");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            {
                System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True");

                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

                conexao.Open();

                comando.Connection = conexao;
                comando.CommandText = string.Format("Update Alunos Set IdAluno = {0}, Nome = '{1}', Endereco = '{2}', Cidade = '{3}', Telefone = '{4}', Email = '{5}' Where IdAluno = {0}", txtIdAluno.Text, txtNome.Text, txtEndereco.Text, txtCidade.Text, txtTelefone.Text, txtEmail.Text);
                comando.ExecuteNonQuery();

                conexao.Close();

                txtIdAluno.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";

                MessageBox.Show("Aluno atualizado com sucesso!", "Atualizar aluno");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True");

                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

                conexao.Open();

                comando.Connection = conexao;
                comando.CommandText = string.Format("Delete from Alunos Where IdAluno = {0}", txtIdAluno.Text);
                comando.ExecuteNonQuery();

                conexao.Close();

                txtIdAluno.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";

                MessageBox.Show("Aluno excluído com sucesso!", "Excluir aluno");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            {
                System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=NUTEC;Integrated Security=True");
                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();


                conexao.Open();

                comando.Connection = conexao;
                comando.CommandText = string.Format("Select * From Alunos Where Nome like '%{0}%'", txtPesquisarNome.Text);

                DataSet banco = new DataSet();

                System.Data.SqlClient.SqlDataAdapter adaptadorDeDados = new System.Data.SqlClient.SqlDataAdapter(comando.CommandText, conexao);
                adaptadorDeDados.Fill(banco);

                conexao.Close();

                dgvListaDeAlunos.DataSource = banco.Tables[0];
                dgvListaDeAlunos.Refresh();
            }

        }

        private void dgvListaDeAlunos_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdAluno.Text = dgvListaDeAlunos.CurrentRow.Cells["colIdAluno"].Value.ToString();
            this.txtNome.Text = dgvListaDeAlunos.CurrentRow.Cells["colNome"].Value.ToString();
            this.txtEndereco.Text = dgvListaDeAlunos.CurrentRow.Cells["colEndereco"].Value.ToString();
            this.txtCidade.Text = dgvListaDeAlunos.CurrentRow.Cells["colCidade"].Value.ToString();
            this.txtTelefone.Text = dgvListaDeAlunos.CurrentRow.Cells["colTelefone"].Value.ToString();
            this.txtEmail.Text = dgvListaDeAlunos.CurrentRow.Cells["colEmail"].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdAluno.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }
    }
}
