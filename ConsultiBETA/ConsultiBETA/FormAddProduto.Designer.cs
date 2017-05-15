namespace ConsultiBETA
{
    partial class FormAddProdutos
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbValorVenda = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSalver = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbValorCompra = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.lbValorCompra);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lbValorVenda);
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalver);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 239);
            this.panel1.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(127, 127);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(423, 20);
            this.txtDescricao.TabIndex = 19;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(57, 134);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(123, 161);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.Text = "0,00";
            // 
            // lbValorVenda
            // 
            this.lbValorVenda.AutoSize = true;
            this.lbValorVenda.Location = new System.Drawing.Point(53, 164);
            this.lbValorVenda.Name = "lbValorVenda";
            this.lbValorVenda.Size = new System.Drawing.Size(65, 13);
            this.lbValorVenda.TabIndex = 16;
            this.lbValorVenda.Text = "Valor Venda";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(344, 9);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(20, 24);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "0";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(282, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 24);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // btnSalver
            // 
            this.btnSalver.Location = new System.Drawing.Point(105, 197);
            this.btnSalver.Name = "btnSalver";
            this.btnSalver.Size = new System.Drawing.Size(203, 23);
            this.btnSalver.TabIndex = 14;
            this.btnSalver.Text = "Salvar";
            this.btnSalver.UseVisualStyleBackColor = true;
            this.btnSalver.Click += new System.EventHandler(this.btnSalver_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(57, 61);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(57, 100);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 20;
            this.lbTipo.Text = "Tipo";
            // 
            // lbValorCompra
            // 
            this.lbValorCompra.AutoSize = true;
            this.lbValorCompra.Location = new System.Drawing.Point(238, 164);
            this.lbValorCompra.Name = "lbValorCompra";
            this.lbValorCompra.Size = new System.Drawing.Size(70, 13);
            this.lbValorCompra.TabIndex = 20;
            this.lbValorCompra.Text = "Valor Compra";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(123, 97);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAddProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 239);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddProdutos";
            this.Text = "Adicionar/Alterar Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbValorCompra;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbValorVenda;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSalver;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnCancelar;
    }
}