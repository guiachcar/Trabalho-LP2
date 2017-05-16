namespace ConsultiBETA
{
    partial class FormProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lbConsulta = new System.Windows.Forms.Label();
            this.lbPor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.gbProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 480);
            this.panel1.TabIndex = 2;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
            this.gbFiltrar.Controls.Add(this.cbFiltrar);
            this.gbFiltrar.Controls.Add(this.lbConsulta);
            this.gbFiltrar.Controls.Add(this.lbPor);
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(9, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(826, 65);
            this.gbFiltrar.TabIndex = 15;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // txtDigiteAqui
            // 
            this.txtDigiteAqui.Location = new System.Drawing.Point(282, 23);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(414, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Tipo"});
            this.cbFiltrar.Location = new System.Drawing.Point(69, 22);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbFiltrar.TabIndex = 13;
            // 
            // lbConsulta
            // 
            this.lbConsulta.AutoSize = true;
            this.lbConsulta.Location = new System.Drawing.Point(208, 29);
            this.lbConsulta.Name = "lbConsulta";
            this.lbConsulta.Size = new System.Drawing.Size(58, 13);
            this.lbConsulta.TabIndex = 12;
            this.lbConsulta.Text = "Digite Aqui";
            // 
            // lbPor
            // 
            this.lbPor.AutoSize = true;
            this.lbPor.Location = new System.Drawing.Point(15, 30);
            this.lbPor.Name = "lbPor";
            this.lbPor.Size = new System.Drawing.Size(23, 13);
            this.lbPor.TabIndex = 12;
            this.lbPor.Text = "Por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(702, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(260, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(136, 446);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 446);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.dgProdutos);
            this.gbProdutos.Location = new System.Drawing.Point(9, 83);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(829, 345);
            this.gbProdutos.TabIndex = 10;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Tipo,
            this.Descricao,
            this.valor_venda,
            this.Valor_Compra,
            this.Quantidade});
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdutos.Enabled = false;
            this.dgProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(823, 326);
            this.dgProdutos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 200;
            // 
            // valor_venda
            // 
            this.valor_venda.HeaderText = "Valor Venda";
            this.valor_venda.Name = "valor_venda";
            // 
            // Valor_Compra
            // 
            this.Valor_Compra.HeaderText = "Valor Compra";
            this.Valor_Compra.Name = "Valor_Compra";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.panel1);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.panel1.ResumeLayout(false);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.TextBox txtDigiteAqui;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label lbConsulta;
        private System.Windows.Forms.Label lbPor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}