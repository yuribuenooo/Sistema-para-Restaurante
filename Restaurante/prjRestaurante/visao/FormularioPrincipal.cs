using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestaurante.visao
{
    public partial class FormularioPrincipal : Form
    {
        public FormProduto frProdutos = null;
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja Sair ?",
            "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                Environment.Exit(0); //sair do programa
            }
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            if (frProdutos == null)
            {
                frProdutos = new FormProduto();
                frProdutos.MdiParent = this;
                frProdutos.Location = new Point(0, 0);
                frProdutos.Show();
            }
        }
    }
}
