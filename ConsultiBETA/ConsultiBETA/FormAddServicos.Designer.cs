namespace ConsultiBETA
{
    partial class FormAddServicos
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSalver = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lbValor);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnSalver);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 181);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(315, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(123, 104);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(435, 20);
            this.txtDescricao.TabIndex = 19;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(60, 107);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(458, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 17;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(411, 61);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 16;
            this.lbValor.Text = "Valor";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(230, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(95, 24);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "Serviço ID";
            // 
            // btnSalver
            // 
            this.btnSalver.Location = new System.Drawing.Point(135, 145);
            this.btnSalver.Name = "btnSalver";
            this.btnSalver.Size = new System.Drawing.Size(174, 23);
            this.btnSalver.TabIndex = 14;
            this.btnSalver.Text = "Salvar";
            this.btnSalver.UseVisualStyleBackColor = true;
            this.btnSalver.Click += new System.EventHandler(this.btnSalver_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(81, 61);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome";
            // 
            // FormAddServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 181);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddServicos";
            this.Text = "Adicionar/Alterar Serviços";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalver;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnCancelar;
    }
}