namespace ConsultiBETA
{
    partial class FormRelatorio
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbEntre = new System.Windows.Forms.GroupBox();
            this.gbA = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbDataDe = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbFiltrarRelatorio = new System.Windows.Forms.GroupBox();
            this.rbEstoque = new System.Windows.Forms.RadioButton();
            this.rbChamado = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gbEntre.SuspendLayout();
            this.gbA.SuspendLayout();
            this.gbDataDe.SuspendLayout();
            this.gbFiltrarRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.gbEntre);
            this.panel1.Controls.Add(this.gbFiltrarRelatorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 268);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(117, 233);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gbEntre
            // 
            this.gbEntre.Controls.Add(this.gbA);
            this.gbEntre.Controls.Add(this.gbDataDe);
            this.gbEntre.Location = new System.Drawing.Point(23, 82);
            this.gbEntre.Name = "gbEntre";
            this.gbEntre.Size = new System.Drawing.Size(469, 148);
            this.gbEntre.TabIndex = 2;
            this.gbEntre.TabStop = false;
            this.gbEntre.Text = "Entre";
            // 
            // gbA
            // 
            this.gbA.Controls.Add(this.dateTimePicker2);
            this.gbA.Location = new System.Drawing.Point(237, 19);
            this.gbA.Name = "gbA";
            this.gbA.Size = new System.Drawing.Size(225, 70);
            this.gbA.TabIndex = 2;
            this.gbA.TabStop = false;
            this.gbA.Text = "A";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // gbDataDe
            // 
            this.gbDataDe.Controls.Add(this.dateTimePicker1);
            this.gbDataDe.Location = new System.Drawing.Point(6, 19);
            this.gbDataDe.Name = "gbDataDe";
            this.gbDataDe.Size = new System.Drawing.Size(225, 70);
            this.gbDataDe.TabIndex = 0;
            this.gbDataDe.TabStop = false;
            this.gbDataDe.Text = "De";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // gbFiltrarRelatorio
            // 
            this.gbFiltrarRelatorio.Controls.Add(this.rbEstoque);
            this.gbFiltrarRelatorio.Controls.Add(this.rbChamado);
            this.gbFiltrarRelatorio.Location = new System.Drawing.Point(143, 23);
            this.gbFiltrarRelatorio.Name = "gbFiltrarRelatorio";
            this.gbFiltrarRelatorio.Size = new System.Drawing.Size(231, 53);
            this.gbFiltrarRelatorio.TabIndex = 0;
            this.gbFiltrarRelatorio.TabStop = false;
            this.gbFiltrarRelatorio.Text = "De";
            // 
            // rbEstoque
            // 
            this.rbEstoque.AutoSize = true;
            this.rbEstoque.Location = new System.Drawing.Point(112, 19);
            this.rbEstoque.Name = "rbEstoque";
            this.rbEstoque.Size = new System.Drawing.Size(64, 17);
            this.rbEstoque.TabIndex = 0;
            this.rbEstoque.TabStop = true;
            this.rbEstoque.Text = "Estoque";
            this.rbEstoque.UseVisualStyleBackColor = true;
            // 
            // rbChamado
            // 
            this.rbChamado.AutoSize = true;
            this.rbChamado.Location = new System.Drawing.Point(6, 19);
            this.rbChamado.Name = "rbChamado";
            this.rbChamado.Size = new System.Drawing.Size(70, 17);
            this.rbChamado.TabIndex = 0;
            this.rbChamado.TabStop = true;
            this.rbChamado.Text = "Chamado";
            this.rbChamado.UseVisualStyleBackColor = true;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 268);
            this.Controls.Add(this.panel1);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.panel1.ResumeLayout(false);
            this.gbEntre.ResumeLayout(false);
            this.gbA.ResumeLayout(false);
            this.gbDataDe.ResumeLayout(false);
            this.gbFiltrarRelatorio.ResumeLayout(false);
            this.gbFiltrarRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltrarRelatorio;
        private System.Windows.Forms.GroupBox gbDataDe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbEstoque;
        private System.Windows.Forms.RadioButton rbChamado;
        private System.Windows.Forms.GroupBox gbEntre;
        private System.Windows.Forms.GroupBox gbA;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
    }
}