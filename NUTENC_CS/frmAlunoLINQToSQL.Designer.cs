namespace NUTENC_CS
{
    partial class frmAlunoLINQToSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.colIdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisarEmail = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPesquisarCidade = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeAlunos)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.dgvListaDeAlunos);
            this.GroupBox3.Controls.Add(this.Panel1);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox3.Location = new System.Drawing.Point(0, 286);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(720, 335);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Pesquisa";
            // 
            // dgvListaDeAlunos
            // 
            this.dgvListaDeAlunos.AllowUserToAddRows = false;
            this.dgvListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAluno,
            this.colNome,
            this.colEndereco,
            this.colCidade,
            this.colTelefone,
            this.colEmail});
            this.dgvListaDeAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDeAlunos.Location = new System.Drawing.Point(3, 77);
            this.dgvListaDeAlunos.Name = "dgvListaDeAlunos";
            this.dgvListaDeAlunos.Size = new System.Drawing.Size(714, 255);
            this.dgvListaDeAlunos.TabIndex = 1;
            this.dgvListaDeAlunos.DoubleClick += new System.EventHandler(this.dgvListaDeAlunos_DoubleClick);
            // 
            // colIdAluno
            // 
            this.colIdAluno.DataPropertyName = "IdAluno";
            this.colIdAluno.HeaderText = "ID";
            this.colIdAluno.Name = "colIdAluno";
            this.colIdAluno.ReadOnly = true;
            this.colIdAluno.Width = 40;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "Endereco";
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.Visible = false;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnPesquisar);
            this.Panel1.Controls.Add(this.txtPesquisarEmail);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.txtPesquisarCidade);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.txtPesquisarNome);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(3, 16);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(714, 61);
            this.Panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(609, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 34);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisarEmail
            // 
            this.txtPesquisarEmail.Location = new System.Drawing.Point(392, 26);
            this.txtPesquisarEmail.Name = "txtPesquisarEmail";
            this.txtPesquisarEmail.Size = new System.Drawing.Size(211, 20);
            this.txtPesquisarEmail.TabIndex = 13;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(389, 10);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(32, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Email";
            // 
            // txtPesquisarCidade
            // 
            this.txtPesquisarCidade.Location = new System.Drawing.Point(247, 26);
            this.txtPesquisarCidade.Name = "txtPesquisarCidade";
            this.txtPesquisarCidade.Size = new System.Drawing.Size(139, 20);
            this.txtPesquisarCidade.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(244, 10);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(40, 13);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Cidade";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(9, 26);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(232, 20);
            this.txtPesquisarNome.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 10);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 13);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Nome";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnLimpar);
            this.GroupBox2.Controls.Add(this.btnExcluir);
            this.GroupBox2.Controls.Add(this.btnAtualizar);
            this.GroupBox2.Controls.Add(this.btnIncluir);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox2.Location = new System.Drawing.Point(0, 227);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(720, 59);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Comandos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(558, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 34);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(375, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 34);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(192, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(149, 34);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(9, 19);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(149, 34);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtEmail);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtTelefone);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtCidade);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtEndereco);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtNome);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtIdAluno);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(720, 227);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Dados do Aluno";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(138, 175);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 191);
            this.txtTelefone.Mask = "(99) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(13, 175);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Telefone";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 142);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(231, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Cidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(13, 94);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(396, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(597, 20);
            this.txtNome.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(72, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nome";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Location = new System.Drawing.Point(13, 43);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(53, 20);
            this.txtIdAluno.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Id Aluno";
            // 
            // frmAlunoLINQToSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 621);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmAlunoLINQToSQL";
            this.Text = "Cadastro de Aluno - LINQ to SQL";
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeAlunos)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.DataGridView dgvListaDeAlunos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIdAluno;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.TextBox txtPesquisarEmail;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPesquisarCidade;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtPesquisarNome;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnAtualizar;
        internal System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.MaskedTextBox txtTelefone;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtIdAluno;
        internal System.Windows.Forms.Label Label1;
    }
}