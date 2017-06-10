namespace ConsultiBETA
{
    partial class FormAddChamados
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
            this.lbDataAbertura = new System.Windows.Forms.Label();
            this.btnImprimirVenda = new System.Windows.Forms.Button();
            this.btnRemProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnRemServico = new System.Windows.Forms.Button();
            this.btnAddServico = new System.Windows.Forms.Button();
            this.dgItemProduto = new System.Windows.Forms.DataGridView();
            this._id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItemServico = new System.Windows.Forms.DataGridView();
            this._id_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDataAgendamento = new System.Windows.Forms.Label();
            this.dtpDataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lbProdutos = new System.Windows.Forms.Label();
            this.lbServico = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbAcao = new System.Windows.Forms.Label();
            this.rtbAcao = new System.Windows.Forms.RichTextBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lbTecnico = new System.Windows.Forms.Label();
            this.lbProblema = new System.Windows.Forms.Label();
            this.lbIDCLiente = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemServico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDataAbertura);
            this.panel1.Controls.Add(this.btnImprimirVenda);
            this.panel1.Controls.Add(this.btnRemProduto);
            this.panel1.Controls.Add(this.btnAddProduto);
            this.panel1.Controls.Add(this.btnRemServico);
            this.panel1.Controls.Add(this.btnAddServico);
            this.panel1.Controls.Add(this.dgItemProduto);
            this.panel1.Controls.Add(this.dgItemServico);
            this.panel1.Controls.Add(this.lbDataAgendamento);
            this.panel1.Controls.Add(this.dtpDataAgendamento);
            this.panel1.Controls.Add(this.cbTecnico);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.lbProdutos);
            this.panel1.Controls.Add(this.lbServico);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbAcao);
            this.panel1.Controls.Add(this.rtbAcao);
            this.panel1.Controls.Add(this.rtbDescricao);
            this.panel1.Controls.Add(this.lbTecnico);
            this.panel1.Controls.Add(this.lbProblema);
            this.panel1.Controls.Add(this.lbIDCLiente);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 547);
            this.panel1.TabIndex = 4;
            // 
            // lbDataAbertura
            // 
            this.lbDataAbertura.AutoSize = true;
            this.lbDataAbertura.Location = new System.Drawing.Point(166, 19);
            this.lbDataAbertura.Name = "lbDataAbertura";
            this.lbDataAbertura.Size = new System.Drawing.Size(0, 13);
            this.lbDataAbertura.TabIndex = 39;
            // 
            // btnImprimirVenda
            // 
            this.btnImprimirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirVenda.Location = new System.Drawing.Point(141, 512);
            this.btnImprimirVenda.Name = "btnImprimirVenda";
            this.btnImprimirVenda.Size = new System.Drawing.Size(160, 23);
            this.btnImprimirVenda.TabIndex = 38;
            this.btnImprimirVenda.Text = "Imprimir Nota";
            this.btnImprimirVenda.UseVisualStyleBackColor = true;
            // 
            // btnRemProduto
            // 
            this.btnRemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemProduto.Location = new System.Drawing.Point(559, 299);
            this.btnRemProduto.Name = "btnRemProduto";
            this.btnRemProduto.Size = new System.Drawing.Size(94, 23);
            this.btnRemProduto.TabIndex = 37;
            this.btnRemProduto.Text = "Remover";
            this.btnRemProduto.UseVisualStyleBackColor = true;
            this.btnRemProduto.Click += new System.EventHandler(this.btnRemProduto_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduto.Location = new System.Drawing.Point(459, 299);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(94, 23);
            this.btnAddProduto.TabIndex = 36;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnRemServico
            // 
            this.btnRemServico.Location = new System.Drawing.Point(160, 299);
            this.btnRemServico.Name = "btnRemServico";
            this.btnRemServico.Size = new System.Drawing.Size(94, 23);
            this.btnRemServico.TabIndex = 35;
            this.btnRemServico.Text = "Remover";
            this.btnRemServico.UseVisualStyleBackColor = true;
            this.btnRemServico.Click += new System.EventHandler(this.btnRemServico_Click);
            // 
            // btnAddServico
            // 
            this.btnAddServico.Location = new System.Drawing.Point(60, 299);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(94, 23);
            this.btnAddServico.TabIndex = 34;
            this.btnAddServico.Text = "Adicionar";
            this.btnAddServico.UseVisualStyleBackColor = true;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // dgItemProduto
            // 
            this.dgItemProduto.AllowUserToAddRows = false;
            this.dgItemProduto.AllowUserToDeleteRows = false;
            this.dgItemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItemProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItemProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id_produto,
            this.produto_nome,
            this.quantidade_produto});
            this.dgItemProduto.Location = new System.Drawing.Point(410, 190);
            this.dgItemProduto.Name = "dgItemProduto";
            this.dgItemProduto.ReadOnly = true;
            this.dgItemProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemProduto.Size = new System.Drawing.Size(366, 101);
            this.dgItemProduto.TabIndex = 33;
            // 
            // _id_produto
            // 
            this._id_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._id_produto.HeaderText = "ID";
            this._id_produto.Name = "_id_produto";
            this._id_produto.ReadOnly = true;
            // 
            // produto_nome
            // 
            this.produto_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto_nome.HeaderText = "Nome Produto";
            this.produto_nome.Name = "produto_nome";
            this.produto_nome.ReadOnly = true;
            // 
            // quantidade_produto
            // 
            this.quantidade_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade_produto.HeaderText = "Quantidade";
            this.quantidade_produto.Name = "quantidade_produto";
            this.quantidade_produto.ReadOnly = true;
            // 
            // dgItemServico
            // 
            this.dgItemServico.AllowUserToAddRows = false;
            this.dgItemServico.AllowUserToDeleteRows = false;
            this.dgItemServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItemServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id_servico,
            this.nome_servico,
            this.quantidade});
            this.dgItemServico.Location = new System.Drawing.Point(18, 191);
            this.dgItemServico.Name = "dgItemServico";
            this.dgItemServico.ReadOnly = true;
            this.dgItemServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemServico.Size = new System.Drawing.Size(358, 101);
            this.dgItemServico.TabIndex = 32;
            // 
            // _id_servico
            // 
            this._id_servico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._id_servico.HeaderText = "ID";
            this._id_servico.Name = "_id_servico";
            this._id_servico.ReadOnly = true;
            // 
            // nome_servico
            // 
            this.nome_servico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_servico.HeaderText = "Nome Serviço";
            this.nome_servico.Name = "nome_servico";
            this.nome_servico.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // lbDataAgendamento
            // 
            this.lbDataAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataAgendamento.AutoSize = true;
            this.lbDataAgendamento.Location = new System.Drawing.Point(286, 19);
            this.lbDataAgendamento.Name = "lbDataAgendamento";
            this.lbDataAgendamento.Size = new System.Drawing.Size(156, 13);
            this.lbDataAgendamento.TabIndex = 31;
            this.lbDataAgendamento.Text = "Data do Agendamento da visita";
            // 
            // dtpDataAgendamento
            // 
            this.dtpDataAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataAgendamento.Location = new System.Drawing.Point(459, 15);
            this.dtpDataAgendamento.Name = "dtpDataAgendamento";
            this.dtpDataAgendamento.Size = new System.Drawing.Size(315, 20);
            this.dtpDataAgendamento.TabIndex = 30;
            // 
            // cbTecnico
            // 
            this.cbTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(459, 56);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(315, 21);
            this.cbTecnico.TabIndex = 29;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(60, 56);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(316, 21);
            this.cbCliente.TabIndex = 28;
            // 
            // lbProdutos
            // 
            this.lbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProdutos.AutoSize = true;
            this.lbProdutos.Location = new System.Drawing.Point(407, 174);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(49, 13);
            this.lbProdutos.TabIndex = 27;
            this.lbProdutos.Text = "Produtos";
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Location = new System.Drawing.Point(15, 174);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(48, 13);
            this.lbServico.TabIndex = 26;
            this.lbServico.Text = "Serviços";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(617, 468);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(162, 21);
            this.cbStatus.TabIndex = 25;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(572, 473);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Status";
            // 
            // lbAcao
            // 
            this.lbAcao.AutoSize = true;
            this.lbAcao.Location = new System.Drawing.Point(18, 339);
            this.lbAcao.Name = "lbAcao";
            this.lbAcao.Size = new System.Drawing.Size(32, 13);
            this.lbAcao.TabIndex = 23;
            this.lbAcao.Text = "Ação";
            // 
            // rtbAcao
            // 
            this.rtbAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAcao.Location = new System.Drawing.Point(18, 356);
            this.rtbAcao.Name = "rtbAcao";
            this.rtbAcao.Size = new System.Drawing.Size(761, 96);
            this.rtbAcao.TabIndex = 22;
            this.rtbAcao.Text = "";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescricao.Location = new System.Drawing.Point(136, 94);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(640, 64);
            this.rtbDescricao.TabIndex = 19;
            this.rtbDescricao.Text = "";
            // 
            // lbTecnico
            // 
            this.lbTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTecnico.AutoSize = true;
            this.lbTecnico.Location = new System.Drawing.Point(385, 59);
            this.lbTecnico.Name = "lbTecnico";
            this.lbTecnico.Size = new System.Drawing.Size(46, 13);
            this.lbTecnico.TabIndex = 17;
            this.lbTecnico.Text = "Técnico";
            // 
            // lbProblema
            // 
            this.lbProblema.AutoSize = true;
            this.lbProblema.Location = new System.Drawing.Point(12, 114);
            this.lbProblema.Name = "lbProblema";
            this.lbProblema.Size = new System.Drawing.Size(108, 13);
            this.lbProblema.TabIndex = 17;
            this.lbProblema.Text = "Problema( Descrição)";
            // 
            // lbIDCLiente
            // 
            this.lbIDCLiente.AutoSize = true;
            this.lbIDCLiente.Location = new System.Drawing.Point(15, 59);
            this.lbIDCLiente.Name = "lbIDCLiente";
            this.lbIDCLiente.Size = new System.Drawing.Size(39, 13);
            this.lbIDCLiente.TabIndex = 17;
            this.lbIDCLiente.Text = "Cliente";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(14, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(114, 24);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "Chamado ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(473, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(307, 512);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(656, 512);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormAddChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 547);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar/Alterar/Fechar Chamados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTecnico;
        private System.Windows.Forms.Label lbProblema;
        private System.Windows.Forms.Label lbIDCLiente;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lbProdutos;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbAcao;
        private System.Windows.Forms.RichTextBox rtbAcao;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbDataAgendamento;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamento;
        private System.Windows.Forms.DataGridView dgItemProduto;
        private System.Windows.Forms.DataGridView dgItemServico;
        private System.Windows.Forms.Button btnRemProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnRemServico;
        private System.Windows.Forms.Button btnAddServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.Button btnImprimirVenda;
        private System.Windows.Forms.Label lbDataAbertura;
    }
}