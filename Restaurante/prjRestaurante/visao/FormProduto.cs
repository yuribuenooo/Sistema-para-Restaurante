﻿using System;
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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioPrincipal pai = (FormularioPrincipal)this.MdiParent;
            pai.frProdutos = null;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            tabela.Listar(bs);
            lbId.DataBindings.Add(new Binding("Text", bs, "idproduto"));
            lbNome.DataBindings.Add(new Binding("Text", bs, "nome"));
            lbPreco.DataBindings.Add(new Binding("Text", bs, "preco"));
            lbTipo.DataBindings.Add(new Binding("Text", bs, "tipo.descricao"));


            bn.BindingSource = bs;
        }

       

    }
}
