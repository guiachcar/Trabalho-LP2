namespace ConsultiBETA
{
    partial class FormEstoque
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNovoProduto);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.gbProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 482);
            this.panel1.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 447);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.EditarClick);
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
            this.txtDigiteAqui.Location = new System.Drawing.Point(192, 23);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(504, 20);
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
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(823, 326);
            this.dgProdutos.TabIndex = 0;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(136, 447);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(118, 23);
            this.btnNovoProduto.TabIndex = 17;
            this.btnNovoProduto.Text = "Adicionar Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovoProduto;
    }
}