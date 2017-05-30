namespace ConsultiBETA
{
    partial class Principal
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
            this.menuHistorico = new System.Windows.Forms.MenuStrip();
            this.dgChamadosRecentes = new System.Windows.Forms.DataGridView();
            this.lbChamadosRecentes = new System.Windows.Forms.Label();
            this.lbFinalizarChamados = new System.Windows.Forms.Label();
            this.lbBuscarCliente = new System.Windows.Forms.Label();
            this.lbAbrirChamado = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbFinalizarChamado = new System.Windows.Forms.PictureBox();
            this.pbBuscarCliente = new System.Windows.Forms.PictureBox();
            this.pbAbrirChamado = new System.Windows.Forms.PictureBox();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamadosRecentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalizarChamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrirChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHistorico
            // 
            this.menuHistorico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuHistorico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.estoqueToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.historicoToolStripMenuItem});
            this.menuHistorico.Location = new System.Drawing.Point(0, 0);
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(1020, 24);
            this.menuHistorico.TabIndex = 1;
            this.menuHistorico.Text = "menuStrip1";
            // 
            // dgChamadosRecentes
            // 
            this.dgChamadosRecentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChamadosRecentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChamadosRecentes.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgChamadosRecentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgChamadosRecentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamadosRecentes.Location = new System.Drawing.Point(51, 70);
            this.dgChamadosRecentes.Name = "dgChamadosRecentes";
            this.dgChamadosRecentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgChamadosRecentes.Size = new System.Drawing.Size(907, 217);
            this.dgChamadosRecentes.TabIndex = 4;
            // 
            // lbChamadosRecentes
            // 
            this.lbChamadosRecentes.AutoSize = true;
            this.lbChamadosRecentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbChamadosRecentes.Location = new System.Drawing.Point(293, 50);
            this.lbChamadosRecentes.Name = "lbChamadosRecentes";
            this.lbChamadosRecentes.Size = new System.Drawing.Size(106, 13);
            this.lbChamadosRecentes.TabIndex = 5;
            this.lbChamadosRecentes.Text = "Chamados Recentes";
            // 
            // lbFinalizarChamados
            // 
            this.lbFinalizarChamados.AutoSize = true;
            this.lbFinalizarChamados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFinalizarChamados.Location = new System.Drawing.Point(777, 504);
            this.lbFinalizarChamados.Name = "lbFinalizarChamados";
            this.lbFinalizarChamados.Size = new System.Drawing.Size(93, 13);
            this.lbFinalizarChamados.TabIndex = 9;
            this.lbFinalizarChamados.Text = "Finalizar Chamado";
            // 
            // lbBuscarCliente
            // 
            this.lbBuscarCliente.AutoSize = true;
            this.lbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBuscarCliente.Location = new System.Drawing.Point(469, 504);
            this.lbBuscarCliente.Name = "lbBuscarCliente";
            this.lbBuscarCliente.Size = new System.Drawing.Size(75, 13);
            this.lbBuscarCliente.TabIndex = 10;
            this.lbBuscarCliente.Text = "Buscar Cliente";
            // 
            // lbAbrirChamado
            // 
            this.lbAbrirChamado.AutoSize = true;
            this.lbAbrirChamado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAbrirChamado.Location = new System.Drawing.Point(153, 504);
            this.lbAbrirChamado.Name = "lbAbrirChamado";
            this.lbAbrirChamado.Size = new System.Drawing.Size(76, 13);
            this.lbAbrirChamado.TabIndex = 11;
            this.lbAbrirChamado.Text = "Abrir Chamado";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbUsuario.Location = new System.Drawing.Point(923, 7);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(0, 13);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Click += new System.EventHandler(this.lbUsuario_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // pbFinalizarChamado
            // 
            this.pbFinalizarChamado.BackColor = System.Drawing.Color.MistyRose;
            this.pbFinalizarChamado.Image = global::ConsultiBETA.Properties.Resources.venda;
            this.pbFinalizarChamado.Location = new System.Drawing.Point(683, 319);
            this.pbFinalizarChamado.Name = "pbFinalizarChamado";
            this.pbFinalizarChamado.Size = new System.Drawing.Size(281, 237);
            this.pbFinalizarChamado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFinalizarChamado.TabIndex = 8;
            this.pbFinalizarChamado.TabStop = false;
            // 
            // pbBuscarCliente
            // 
            this.pbBuscarCliente.BackColor = System.Drawing.Color.LightGreen;
            this.pbBuscarCliente.Image = global::ConsultiBETA.Properties.Resources.cliente2;
            this.pbBuscarCliente.Location = new System.Drawing.Point(365, 320);
            this.pbBuscarCliente.Name = "pbBuscarCliente";
            this.pbBuscarCliente.Size = new System.Drawing.Size(281, 237);
            this.pbBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBuscarCliente.TabIndex = 7;
            this.pbBuscarCliente.TabStop = false;
            this.pbBuscarCliente.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbAbrirChamado
            // 
            this.pbAbrirChamado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbAbrirChamado.Image = global::ConsultiBETA.Properties.Resources.chamados;
            this.pbAbrirChamado.Location = new System.Drawing.Point(52, 319);
            this.pbAbrirChamado.Name = "pbAbrirChamado";
            this.pbAbrirChamado.Size = new System.Drawing.Size(281, 237);
            this.pbAbrirChamado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAbrirChamado.TabIndex = 6;
            this.pbAbrirChamado.TabStop = false;
            this.pbAbrirChamado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.cliente;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.cliente1;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.funcionario;
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.servico;
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.produtos;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::ConsultiBETA.Properties.Resources.chamados;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Chamado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.estoque;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.relatorios;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.help;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ConsultiBETA.Properties.Resources.exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1020, 772);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbAbrirChamado);
            this.Controls.Add(this.lbBuscarCliente);
            this.Controls.Add(this.lbFinalizarChamados);
            this.Controls.Add(this.pbFinalizarChamado);
            this.Controls.Add(this.pbBuscarCliente);
            this.Controls.Add(this.pbAbrirChamado);
            this.Controls.Add(this.lbChamadosRecentes);
            this.Controls.Add(this.dgChamadosRecentes);
            this.Controls.Add(this.menuHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHistorico;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuHistorico.ResumeLayout(false);
            this.menuHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamadosRecentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalizarChamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrirChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHistorico;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgChamadosRecentes;
        private System.Windows.Forms.Label lbChamadosRecentes;
        private System.Windows.Forms.PictureBox pbAbrirChamado;
        private System.Windows.Forms.PictureBox pbBuscarCliente;
        private System.Windows.Forms.PictureBox pbFinalizarChamado;
        private System.Windows.Forms.Label lbFinalizarChamados;
        private System.Windows.Forms.Label lbBuscarCliente;
        private System.Windows.Forms.Label lbAbrirChamado;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
    }
}

