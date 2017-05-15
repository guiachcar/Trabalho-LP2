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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbIDFuncionario = new System.Windows.Forms.Label();
            this.lbProblema = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbIDVenda = new System.Windows.Forms.Label();
            this.lbIDCLiente = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.txtAcao = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtIDVenda = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIDVenda = new System.Windows.Forms.Button();
            this.btnIDFuncionario = new System.Windows.Forms.Button();
            this.btnIDCliente = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.lbIDFuncionario);
            this.panel1.Controls.Add(this.lbProblema);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbIDVenda);
            this.panel1.Controls.Add(this.lbIDCLiente);
            this.panel1.Controls.Add(this.txtIDFuncionario);
            this.panel1.Controls.Add(this.txtAcao);
            this.panel1.Controls.Add(this.txtIDCliente);
            this.panel1.Controls.Add(this.txtIDVenda);
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnIDVenda);
            this.panel1.Controls.Add(this.btnIDFuncionario);
            this.panel1.Controls.Add(this.btnIDCliente);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 308);
            this.panel1.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aberto",
            "Andamento",
            "Finalizado"});
            this.cbStatus.Location = new System.Drawing.Point(136, 201);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 21);
            this.cbStatus.TabIndex = 18;
            // 
            // lbIDFuncionario
            // 
            this.lbIDFuncionario.AutoSize = true;
            this.lbIDFuncionario.Location = new System.Drawing.Point(49, 98);
            this.lbIDFuncionario.Name = "lbIDFuncionario";
            this.lbIDFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbIDFuncionario.TabIndex = 17;
            this.lbIDFuncionario.Text = "Funcionario ID";
            // 
            // lbProblema
            // 
            this.lbProblema.AutoSize = true;
            this.lbProblema.Location = new System.Drawing.Point(49, 174);
            this.lbProblema.Name = "lbProblema";
            this.lbProblema.Size = new System.Drawing.Size(85, 13);
            this.lbProblema.TabIndex = 17;
            this.lbProblema.Text = "Problema( Ação)";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(49, 204);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Status";
            // 
            // lbIDVenda
            // 
            this.lbIDVenda.AutoSize = true;
            this.lbIDVenda.Location = new System.Drawing.Point(49, 138);
            this.lbIDVenda.Name = "lbIDVenda";
            this.lbIDVenda.Size = new System.Drawing.Size(52, 13);
            this.lbIDVenda.TabIndex = 17;
            this.lbIDVenda.Text = "Venda ID";
            // 
            // lbIDCLiente
            // 
            this.lbIDCLiente.AutoSize = true;
            this.lbIDCLiente.Location = new System.Drawing.Point(49, 59);
            this.lbIDCLiente.Name = "lbIDCLiente";
            this.lbIDCLiente.Size = new System.Drawing.Size(53, 13);
            this.lbIDCLiente.TabIndex = 17;
            this.lbIDCLiente.Text = "Cliente ID";
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(136, 95);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtIDFuncionario.TabIndex = 16;
            // 
            // txtAcao
            // 
            this.txtAcao.Location = new System.Drawing.Point(136, 167);
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.Size = new System.Drawing.Size(100, 20);
            this.txtAcao.TabIndex = 16;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(136, 56);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 16;
            // 
            // txtIDVenda
            // 
            this.txtIDVenda.Location = new System.Drawing.Point(136, 131);
            this.txtIDVenda.Name = "txtIDVenda";
            this.txtIDVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIDVenda.TabIndex = 16;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(299, 9);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(20, 24);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "0";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(178, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(114, 24);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "Chamado ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(441, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIDVenda
            // 
            this.btnIDVenda.Location = new System.Drawing.Point(255, 128);
            this.btnIDVenda.Name = "btnIDVenda";
            this.btnIDVenda.Size = new System.Drawing.Size(113, 23);
            this.btnIDVenda.TabIndex = 14;
            this.btnIDVenda.Text = "Buscar/Add Venda";
            this.btnIDVenda.UseVisualStyleBackColor = true;
            this.btnIDVenda.Click += new System.EventHandler(this.btnIDVenda_Click);
            // 
            // btnIDFuncionario
            // 
            this.btnIDFuncionario.Location = new System.Drawing.Point(255, 92);
            this.btnIDFuncionario.Name = "btnIDFuncionario";
            this.btnIDFuncionario.Size = new System.Drawing.Size(113, 23);
            this.btnIDFuncionario.TabIndex = 14;
            this.btnIDFuncionario.Text = "Buscar Funcionario";
            this.btnIDFuncionario.UseVisualStyleBackColor = true;
            this.btnIDFuncionario.Click += new System.EventHandler(this.btnIDFuncionario_Click);
            // 
            // btnIDCliente
            // 
            this.btnIDCliente.Location = new System.Drawing.Point(255, 54);
            this.btnIDCliente.Name = "btnIDCliente";
            this.btnIDCliente.Size = new System.Drawing.Size(113, 23);
            this.btnIDCliente.TabIndex = 14;
            this.btnIDCliente.Text = "Buscar Cliente";
            this.btnIDCliente.UseVisualStyleBackColor = true;
            this.btnIDCliente.Click += new System.EventHandler(this.btnIDCliente_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(221, 276);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(203, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormAddChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 308);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddChamados";
            this.Text = "Adicionar/Alterar/Fechar Chamados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbIDFuncionario;
        private System.Windows.Forms.Label lbProblema;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbIDVenda;
        private System.Windows.Forms.Label lbIDCLiente;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.TextBox txtAcao;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtIDVenda;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIDVenda;
        private System.Windows.Forms.Button btnIDFuncionario;
        private System.Windows.Forms.Button btnIDCliente;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalvar;
    }
}