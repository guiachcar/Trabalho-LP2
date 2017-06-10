namespace ConsultiBETA
{
    partial class FormVenda
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
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.gbFiltrar.SuspendLayout();
            this.gbVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(14, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(890, 65);
            this.gbFiltrar.TabIndex = 16;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // txtDigiteAqui
            // 
            this.txtDigiteAqui.Location = new System.Drawing.Point(43, 24);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(678, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(757, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbVendas
            // 
            this.gbVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVendas.Controls.Add(this.dgVendas);
            this.gbVendas.Location = new System.Drawing.Point(11, 109);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(893, 343);
            this.gbVendas.TabIndex = 17;
            this.gbVendas.TabStop = false;
            this.gbVendas.Text = "Vendas";
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVendas.Location = new System.Drawing.Point(3, 16);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.ReadOnly = true;
            this.dgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendas.Size = new System.Drawing.Size(887, 324);
            this.dgVendas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Location = new System.Drawing.Point(14, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 81);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(18, 26);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(118, 23);
            this.btnVisualizar.TabIndex = 13;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.gbFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.TextBox txtDigiteAqui;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisualizar;
    }
}