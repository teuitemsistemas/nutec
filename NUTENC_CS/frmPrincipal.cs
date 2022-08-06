using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUTENC_CS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CadastroDeAlunosSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoSQL f = new frmAlunoSQL();
            f.MdiParent = this;
            f.Show();
        }


        private void CadastroDeAlunosLINQToSQLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
frmAlunoLINQToSQL f = new frmAlunoLINQToSQL();
            f.MdiParent = this;
            f.Show();
        }
    }
}
