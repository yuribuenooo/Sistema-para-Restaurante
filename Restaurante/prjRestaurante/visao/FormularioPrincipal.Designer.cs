namespace prjRestaurante.visao
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnComandas,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1059, 93);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(91, 89);
            this.mnProdutos.Text = "Produtos";
            this.mnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnProdutos.Click += new System.EventHandler(this.mnProdutos_Click);
            // 
            // mnMesas
            // 
            this.mnMesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Size = new System.Drawing.Size(76, 89);
            this.mnMesas.Text = "Mesas";
            this.mnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // mnComandas
            // 
            this.mnComandas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnComandas.Image = ((System.Drawing.Image)(resources.GetObject("mnComandas.Image")));
            this.mnComandas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnComandas.Name = "mnComandas";
            this.mnComandas.Size = new System.Drawing.Size(102, 89);
            this.mnComandas.Text = "Comandas";
            this.mnComandas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // mnSair
            // 
            this.mnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(76, 89);
            this.mnSair.Text = "Sair";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 667);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormularioPrincipal";
            this.Text = "Controle de Restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnComandas;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}