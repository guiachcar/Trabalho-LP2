namespace ConsultiBETA
{
    partial class FormFuncionarios
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgFuncioanarios = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncioanarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.gbFuncionarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 487);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 70);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(335, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(184, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(33, 36);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.AutoSize = true;
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(9, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(622, 65);
            this.gbFiltrar.TabIndex = 15;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // txtDigiteAqui
            // 
            this.txtDigiteAqui.Location = new System.Drawing.Point(133, 23);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(350, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFuncionarios
            // 
            this.gbFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFuncionarios.AutoSize = true;
            this.gbFuncionarios.Controls.Add(this.dgFuncioanarios);
            this.gbFuncionarios.Location = new System.Drawing.Point(9, 83);
            this.gbFuncionarios.Name = "gbFuncionarios";
            this.gbFuncionarios.Size = new System.Drawing.Size(638, 331);
            this.gbFuncionarios.TabIndex = 10;
            this.gbFuncionarios.TabStop = false;
            this.gbFuncionarios.Text = "Funcionarios";
            // 
            // dgFuncioanarios
            // 
            this.dgFuncioanarios.AllowUserToAddRows = false;
            this.dgFuncioanarios.AllowUserToDeleteRows = false;
            this.dgFuncioanarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFuncioanarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFuncioanarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgFuncioanarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncioanarios.Location = new System.Drawing.Point(3, 16);
            this.dgFuncioanarios.Name = "dgFuncioanarios";
            this.dgFuncioanarios.ReadOnly = true;
            this.dgFuncioanarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFuncioanarios.Size = new System.Drawing.Size(631, 301);
            this.dgFuncioanarios.TabIndex = 0;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(650, 487);
            this.Controls.Add(this.panel1);
            this.Name = "FormFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncioanarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.TextBox txtDigiteAqui;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbFuncionarios;
        private System.Windows.Forms.DataGridView dgFuncioanarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}