namespace ConsultiBETA
{
    partial class FormAddVendas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbValorTotalResultado = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProdutosAdicionar = new System.Windows.Forms.Button();
            this.btnProdutosRemover = new System.Windows.Forms.Button();
            this.cbProdutos = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnServicoesAdicionar = new System.Windows.Forms.Button();
            this.btnServicosRemover = new System.Windows.Forms.Button();
            this.gbServicos = new System.Windows.Forms.GroupBox();
            this.dgServicos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lbValorTotalResultado);
            this.panel1.Controls.Add(this.lbValorTotal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 421);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(30, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbValorTotalResultado
            // 
            this.lbValorTotalResultado.AutoSize = true;
            this.lbValorTotalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalResultado.Location = new System.Drawing.Point(652, 357);
            this.lbValorTotalResultado.Name = "lbValorTotalResultado";
            this.lbValorTotalResultado.Size = new System.Drawing.Size(122, 39);
            this.lbValorTotalResultado.TabIndex = 22;
            this.lbValorTotalResultado.Text = "250,80";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(445, 357);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(184, 39);
            this.lbValorTotal.TabIndex = 21;
            this.lbValorTotal.Text = "Valor Total";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProdutosAdicionar);
            this.panel3.Controls.Add(this.btnProdutosRemover);
            this.panel3.Controls.Add(this.cbProdutos);
            this.panel3.Location = new System.Drawing.Point(12, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 130);
            this.panel3.TabIndex = 20;
            // 
            // btnProdutosAdicionar
            // 
            this.btnProdutosAdicionar.Location = new System.Drawing.Point(687, 34);
            this.btnProdutosAdicionar.Name = "btnProdutosAdicionar";
            this.btnProdutosAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutosAdicionar.TabIndex = 1;
            this.btnProdutosAdicionar.Text = "Adicionar";
            this.btnProdutosAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnProdutosRemover
            // 
            this.btnProdutosRemover.Location = new System.Drawing.Point(687, 73);
            this.btnProdutosRemover.Name = "btnProdutosRemover";
            this.btnProdutosRemover.Size = new System.Drawing.Size(75, 23);
            this.btnProdutosRemover.TabIndex = 1;
            this.btnProdutosRemover.Text = "Remover";
            this.btnProdutosRemover.UseVisualStyleBackColor = true;
            // 
            // cbProdutos
            // 
            this.cbProdutos.Controls.Add(this.dgProdutos);
            this.cbProdutos.Location = new System.Drawing.Point(15, 18);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(647, 97);
            this.cbProdutos.TabIndex = 0;
            this.cbProdutos.TabStop = false;
            this.cbProdutos.Text = "Produtos";
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Tipo,
            this.dataGridViewTextBoxColumn3,
            this.valor_venda,
            this.Quantidade});
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdutos.Enabled = false;
            this.dgProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(641, 78);
            this.dgProdutos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // valor_venda
            // 
            this.valor_venda.HeaderText = "Valor Venda";
            this.valor_venda.Name = "valor_venda";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnServicoesAdicionar);
            this.panel2.Controls.Add(this.btnServicosRemover);
            this.panel2.Controls.Add(this.gbServicos);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 130);
            this.panel2.TabIndex = 19;
            // 
            // btnServicoesAdicionar
            // 
            this.btnServicoesAdicionar.Location = new System.Drawing.Point(687, 34);
            this.btnServicoesAdicionar.Name = "btnServicoesAdicionar";
            this.btnServicoesAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnServicoesAdicionar.TabIndex = 1;
            this.btnServicoesAdicionar.Text = "Adicionar";
            this.btnServicoesAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnServicosRemover
            // 
            this.btnServicosRemover.Location = new System.Drawing.Point(687, 73);
            this.btnServicosRemover.Name = "btnServicosRemover";
            this.btnServicosRemover.Size = new System.Drawing.Size(75, 23);
            this.btnServicosRemover.TabIndex = 1;
            this.btnServicosRemover.Text = "Remover";
            this.btnServicosRemover.UseVisualStyleBackColor = true;
            // 
            // gbServicos
            // 
            this.gbServicos.Controls.Add(this.dgServicos);
            this.gbServicos.Location = new System.Drawing.Point(15, 18);
            this.gbServicos.Name = "gbServicos";
            this.gbServicos.Size = new System.Drawing.Size(647, 97);
            this.gbServicos.TabIndex = 0;
            this.gbServicos.TabStop = false;
            this.gbServicos.Text = "Serviços";
            // 
            // dgServicos
            // 
            this.dgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Descricao,
            this.Valor});
            this.dgServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgServicos.Enabled = false;
            this.dgServicos.Location = new System.Drawing.Point(3, 16);
            this.dgServicos.Name = "dgServicos";
            this.dgServicos.Size = new System.Drawing.Size(641, 78);
            this.dgServicos.TabIndex = 1;
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
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 300;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(342, 9);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(20, 24);
            this.lbNumero.TabIndex = 16;
            this.lbNumero.Text = "0";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(221, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(83, 24);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "VendaID";
            // 
            // FormAddVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 421);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Itens e Serviços";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.cbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbServicos;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnServicoesAdicionar;
        private System.Windows.Forms.Button btnServicosRemover;
        private System.Windows.Forms.DataGridView dgServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProdutosAdicionar;
        private System.Windows.Forms.Button btnProdutosRemover;
        private System.Windows.Forms.GroupBox cbProdutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbValorTotalResultado;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}