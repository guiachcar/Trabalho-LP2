namespace ConsultiBETA
{
    partial class FormViewVenda
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
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.txtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDataPagamento
            // 
            this.lbDataPagamento.AutoSize = true;
            this.lbDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPagamento.Location = new System.Drawing.Point(132, 61);
            this.lbDataPagamento.Name = "lbDataPagamento";
            this.lbDataPagamento.Size = new System.Drawing.Size(186, 25);
            this.lbDataPagamento.TabIndex = 0;
            this.lbDataPagamento.Text = "Data Pagamento";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPagamento.Location = new System.Drawing.Point(137, 104);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(181, 31);
            this.txtDataPagamento.TabIndex = 1;
            this.txtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(59, 168);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(140, 44);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(236, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 44);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(56, 14);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 24);
            this.lbId.TabIndex = 4;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(154, 14);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(0, 24);
            this.lbCliente.TabIndex = 5;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(360, 14);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(0, 24);
            this.lbValor.TabIndex = 6;
            // 
            // FormViewVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 224);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.lbDataPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormViewVenda";
            this.Text = "Visualizar Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.MaskedTextBox txtDataPagamento;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbValor;
    }
}