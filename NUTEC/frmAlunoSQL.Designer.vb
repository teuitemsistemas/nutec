<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlunoSQL
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdAluno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvListaDeAlunos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPesquisarEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPesquisarCidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPesquisarNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.colIdAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListaDeAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTelefone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdAluno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Aluno"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(138, 191)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 20)
        Me.txtEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(13, 191)
        Me.txtTelefone.Mask = "(99) 0 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefone.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefone"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(13, 142)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(231, 20)
        Me.txtCidade.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cidade"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(13, 94)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(396, 20)
        Me.txtEndereco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(72, 43)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(597, 20)
        Me.txtNome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'txtIdAluno
        '
        Me.txtIdAluno.Location = New System.Drawing.Point(13, 43)
        Me.txtIdAluno.Name = "txtIdAluno"
        Me.txtIdAluno.Size = New System.Drawing.Size(53, 20)
        Me.txtIdAluno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Aluno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpar)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnAtualizar)
        Me.GroupBox2.Controls.Add(Me.btnIncluir)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(375, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(149, 34)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(192, 19)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(149, 34)
        Me.btnAtualizar.TabIndex = 1
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(9, 19)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(149, 34)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvListaDeAlunos)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 335)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesquisa"
        '
        'dgvListaDeAlunos
        '
        Me.dgvListaDeAlunos.AllowUserToAddRows = False
        Me.dgvListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDeAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdAluno, Me.colNome, Me.colEndereco, Me.colCidade, Me.colTelefone, Me.colEmail})
        Me.dgvListaDeAlunos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaDeAlunos.Location = New System.Drawing.Point(3, 77)
        Me.dgvListaDeAlunos.Name = "dgvListaDeAlunos"
        Me.dgvListaDeAlunos.Size = New System.Drawing.Size(714, 255)
        Me.dgvListaDeAlunos.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Controls.Add(Me.txtPesquisarEmail)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtPesquisarCidade)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtPesquisarNome)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 61)
        Me.Panel1.TabIndex = 0
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(609, 12)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(96, 34)
        Me.btnPesquisar.TabIndex = 14
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisarEmail
        '
        Me.txtPesquisarEmail.Location = New System.Drawing.Point(392, 26)
        Me.txtPesquisarEmail.Name = "txtPesquisarEmail"
        Me.txtPesquisarEmail.Size = New System.Drawing.Size(211, 20)
        Me.txtPesquisarEmail.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Email"
        '
        'txtPesquisarCidade
        '
        Me.txtPesquisarCidade.Location = New System.Drawing.Point(247, 26)
        Me.txtPesquisarCidade.Name = "txtPesquisarCidade"
        Me.txtPesquisarCidade.Size = New System.Drawing.Size(139, 20)
        Me.txtPesquisarCidade.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cidade"
        '
        'txtPesquisarNome
        '
        Me.txtPesquisarNome.Location = New System.Drawing.Point(9, 26)
        Me.txtPesquisarNome.Name = "txtPesquisarNome"
        Me.txtPesquisarNome.Size = New System.Drawing.Size(232, 20)
        Me.txtPesquisarNome.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nome"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(558, 19)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(149, 34)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'colIdAluno
        '
        Me.colIdAluno.DataPropertyName = "IdAluno"
        Me.colIdAluno.HeaderText = "ID"
        Me.colIdAluno.Name = "colIdAluno"
        Me.colIdAluno.ReadOnly = True
        Me.colIdAluno.Width = 40
        '
        'colNome
        '
        Me.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNome.DataPropertyName = "Nome"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        '
        'colEndereco
        '
        Me.colEndereco.DataPropertyName = "Endereco"
        Me.colEndereco.HeaderText = "Endereço"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.ReadOnly = True
        Me.colEndereco.Visible = False
        '
        'colCidade
        '
        Me.colCidade.DataPropertyName = "Cidade"
        Me.colCidade.HeaderText = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.ReadOnly = True
        '
        'colTelefone
        '
        Me.colTelefone.DataPropertyName = "Telefone"
        Me.colTelefone.HeaderText = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.ReadOnly = True
        Me.colTelefone.Width = 80
        '
        'colEmail
        '
        Me.colEmail.DataPropertyName = "Email"
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        '
        'frmAlunoSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 621)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlunoSQL"
        Me.Text = "Cadastro de Aluno - SQL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvListaDeAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdAluno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvListaDeAlunos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtPesquisarEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPesquisarCidade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPesquisarNome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents colIdAluno As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As DataGridViewTextBoxColumn
    Friend WithEvents colCidade As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
End Class
