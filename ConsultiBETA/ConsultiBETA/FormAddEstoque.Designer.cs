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
            this.lbNumProduto = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbIDProduto = new System.Windows.Forms.Label();
            this.lbIDEstoque = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalver = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantitade = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNumProduto);
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbIDProduto);
            this.panel1.Controls.Add(this.lbIDEstoque);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalver);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.lbQuantitade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 166);
            this.panel1.TabIndex = 3;
            // 
            // lbNumProduto
            // 
            this.lbNumProduto.AutoSize = true;
            this.lbNumProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumProduto.Location = new System.Drawing.Point(136, 42);
            this.lbNumProduto.Name = "lbNumProduto";
            this.lbNumProduto.Size = new System.Drawing.Size(40, 24);
            this.lbNumProduto.TabIndex = 15;
            this.lbNumProduto.Text = "100";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(136, 9);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(20, 24);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "1";
            // 
            // lbIDProduto
            // 
            this.lbIDProduto.AutoSize = true;
            this.lbIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDProduto.Location = new System.Drawing.Point(20, 42);
            this.lbIDProduto.Name = "lbIDProduto";
            this.lbIDProduto.Size = new System.Drawing.Size(98, 24);
            this.lbIDProduto.TabIndex = 15;
            this.lbIDProduto.Text = "Produto ID";
            // 
            // lbIDEstoque
            // 
            this.lbIDEstoque.AutoSize = true;
            this.lbIDEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDEstoque.Location = new System.Drawing.Point(20, 9);
            this.lbIDEstoque.Name = "lbIDEstoque";
            this.lbIDEstoque.Size = new System.Drawing.Size(102, 24);
            this.lbIDEstoque.TabIndex = 15;
            this.lbIDEstoque.Text = "Estoque ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalver
            // 
            this.btnSalver.Location = new System.Drawing.Point(24, 133);
            this.btnSalver.Name = "btnSalver";
            this.btnSalver.Size = new System.Drawing.Size(203, 23);
            this.btnSalver.TabIndex = 14;
            this.btnSalver.Text = "Salvar";
            this.btnSalver.UseVisualStyleBackColor = true;
            this.btnSalver.Click += new System.EventHandler(this.btnSalver_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(105, 86);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(265, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // lbQuantitade
            // 
            this.lbQuantitade.AutoSize = true;
            this.lbQuantitade.Location = new System.Drawing.Point(21, 86);
            this.lbQuantitade.Name = "lbQuantitade";
            this.lbQuantitade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantitade.TabIndex = 7;
            this.lbQuantitade.Text = "Quantidade";
            // 
            // FormAddEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 166);
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
        private System.Windows.Forms.Label lbNumProduto;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbIDProduto;
        private System.Windows.Forms.Label lbIDEstoque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalver;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbQuantitade;
    }
}