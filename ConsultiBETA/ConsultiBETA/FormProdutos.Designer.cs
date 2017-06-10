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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.gbProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 561);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQuantidade);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(12, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(296, 31);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 17;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(364, 28);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 16;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(470, 26);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(117, 23);
            this.btnSelecionar.TabIndex = 15;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(18, 26);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(159, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
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
            this.txtDigiteAqui.Location = new System.Drawing.Point(205, 23);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(491, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(702, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbProdutos
            // 
            this.gbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProdutos.Controls.Add(this.dgProdutos);
            this.gbProdutos.Location = new System.Drawing.Point(9, 83);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(893, 343);
            this.gbProdutos.TabIndex = 10;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(887, 324);
            this.dgProdutos.TabIndex = 0;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}