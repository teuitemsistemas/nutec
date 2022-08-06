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
    public partial class frmAlunoLINQToSQL : Form
    {
        public frmAlunoLINQToSQL()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            BancoDeDadosDataContext banco = new BancoDeDadosDataContext();

            Alunos aluno = new Alunos();

            aluno.IdAluno = System.Convert.ToInt32(txtIdAluno.Text);
            aluno.Nome = txtNome.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Cidade = txtCidade.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Email = txtEmail.Text;

            banco.Alunos.InsertOnSubmit(aluno);

            banco.SubmitChanges();

            banco.Connection.Close();


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
                {
                    BancoDeDadosDataContext banco = new BancoDeDadosDataContext();

                    var aluno = banco.Alunos
                                .Where(a => a.IdAluno.ToString() == txtIdAluno.Text)
                                .SingleOrDefault();


                    aluno.IdAluno = Convert.ToInt32(txtIdAluno.Text);
                    aluno.Nome = txtNome.Text;
                    aluno.Endereco = txtEndereco.Text;
                    aluno.Cidade = txtCidade.Text;
                    aluno.Telefone = txtTelefone.Text;
                    aluno.Email = txtEmail.Text;

                    banco.SubmitChanges();

                    banco.Connection.Close();
                }


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
                BancoDeDadosDataContext banco = new BancoDeDadosDataContext();

                var aluno = banco.Alunos
                                .Where(a => a.IdAluno.ToString() == txtIdAluno.Text)
                                .SingleOrDefault();

                banco.Alunos.DeleteOnSubmit(aluno);

                banco.SubmitChanges();

                banco.Connection.Close();

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
                BancoDeDadosDataContext banco = new BancoDeDadosDataContext();

                var alunos = banco.Alunos
                             .Where(a => a.Nome.Contains(txtNome.Text))
                             .ToList();

                dgvListaDeAlunos.DataSource = alunos;
                dgvListaDeAlunos.Refresh();

                banco.Connection.Close();

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
