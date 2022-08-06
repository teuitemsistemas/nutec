namespace NUTENC_CS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroDeAlunosSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrosToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // CadastrosToolStripMenuItem
            // 
            this.CadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroDeAlunosSQLToolStripMenuItem,
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem});
            this.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem";
            this.CadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.CadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // CadastroDeAlunosSQLToolStripMenuItem
            // 
            this.CadastroDeAlunosSQLToolStripMenuItem.Name = "CadastroDeAlunosSQLToolStripMenuItem";
            this.CadastroDeAlunosSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.CadastroDeAlunosSQLToolStripMenuItem.Text = "Cadastro de Alunos - SQL";
            this.CadastroDeAlunosSQLToolStripMenuItem.Click += new System.EventHandler(this.CadastroDeAlunosSQLToolStripMenuItem_Click);
            // 
            // CadastroDeAlunosLINQToSQLToolStripMenuItem
            // 
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem.Name = "CadastroDeAlunosLINQToSQLToolStripMenuItem";
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem.Text = "Cadastro de Alunos - LINQ to SQL";
            this.CadastroDeAlunosLINQToSQLToolStripMenuItem.Click += new System.EventHandler(this.CadastroDeAlunosLINQToSQLToolStripMenuItem_Click_1);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.SairToolStripMenuItem.Text = "&Sair";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Workshop NUTEC - C#.Net";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem CadastrosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CadastroDeAlunosSQLToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CadastroDeAlunosLINQToSQLToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
    }
}

