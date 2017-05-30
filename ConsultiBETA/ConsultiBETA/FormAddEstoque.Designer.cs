namespace ConsultiBETA
{
    partial class FormAddEstoque
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
            this.lbIDProduto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalver = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantitade = new System.Windows.Forms.Label();
            this.btnProduto = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbProdutoNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbProdutoNome);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Controls.Add(this.lbIDProduto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalver);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.lbQuantitade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 222);
            this.panel1.TabIndex = 3;
            // 
            // lbIDProduto
            // 
            this.lbIDProduto.AutoSize = true;
            this.lbIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDProduto.Location = new System.Drawing.Point(20, 13);
            this.lbIDProduto.Name = "lbIDProduto";
            this.lbIDProduto.Size = new System.Drawing.Size(94, 25);
            this.lbIDProduto.TabIndex = 15;
            this.lbIDProduto.Text = "Produto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 88);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalver
            // 
            this.btnSalver.Location = new System.Drawing.Point(378, 15);
            this.btnSalver.Name = "btnSalver";
            this.btnSalver.Size = new System.Drawing.Size(111, 91);
            this.btnSalver.TabIndex = 14;
            this.btnSalver.Text = "Salvar";
            this.btnSalver.UseVisualStyleBackColor = true;
            this.btnSalver.Click += new System.EventHandler(this.btnSalver_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(176, 180);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(169, 29);
            this.txtQuantidade.TabIndex = 2;
            // 
            // lbQuantitade
            // 
            this.lbQuantitade.AutoSize = true;
            this.lbQuantitade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantitade.Location = new System.Drawing.Point(20, 182);
            this.lbQuantitade.Name = "lbQuantitade";
            this.lbQuantitade.Size = new System.Drawing.Size(133, 25);
            this.lbQuantitade.TabIndex = 7;
            this.lbQuantitade.Text = "Quantidade";
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnProduto.Image = global::ConsultiBETA.Properties.Resources.add;
            this.btnProduto.Location = new System.Drawing.Point(176, 13);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(169, 108);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Buscar";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(25, 90);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 16;
            // 
            // lbProdutoNome
            // 
            this.lbProdutoNome.AutoSize = true;
            this.lbProdutoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdutoNome.Location = new System.Drawing.Point(176, 15);
            this.lbProdutoNome.Name = "lbProdutoNome";
            this.lbProdutoNome.Size = new System.Drawing.Size(0, 20);
            this.lbProdutoNome.TabIndex = 17;
            // 
            // FormAddEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 222);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Num Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIDProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalver;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbQuantitade;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbProdutoNome;
    }
}