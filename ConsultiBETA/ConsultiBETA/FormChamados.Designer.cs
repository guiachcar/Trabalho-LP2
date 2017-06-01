namespace ConsultiBETA
{
    partial class FormChamados
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
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.txtDigiteAqui = new System.Windows.Forms.TextBox();
            this.lbDataAbertura = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFercharChamdo = new System.Windows.Forms.Button();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.gbChamados = new System.Windows.Forms.GroupBox();
            this.dgChamados = new System.Windows.Forms.DataGridView();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpAberturaFinal = new System.Windows.Forms.DateTimePicker();
            this.lbAte = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbChamados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.btnFercharChamdo);
            this.panel1.Controls.Add(this.btnAbrirChamado);
            this.panel1.Controls.Add(this.gbChamados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 512);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.lbDescricao);
            this.gbFiltrar.Controls.Add(this.lbStatus);
            this.gbFiltrar.Controls.Add(this.lbFuncionario);
            this.gbFiltrar.Controls.Add(this.cbStatus);
            this.gbFiltrar.Controls.Add(this.cbTecnico);
            this.gbFiltrar.Controls.Add(this.lbAte);
            this.gbFiltrar.Controls.Add(this.dtpAberturaFinal);
            this.gbFiltrar.Controls.Add(this.dtpAbertura);
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
            this.gbFiltrar.Controls.Add(this.lbDataAbertura);
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(9, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(935, 99);
            this.gbFiltrar.TabIndex = 15;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // txtDigiteAqui
            // 
            this.txtDigiteAqui.Location = new System.Drawing.Point(374, 72);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(409, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // lbDataAbertura
            // 
            this.lbDataAbertura.AutoSize = true;
            this.lbDataAbertura.Location = new System.Drawing.Point(16, 24);
            this.lbDataAbertura.Name = "lbDataAbertura";
            this.lbDataAbertura.Size = new System.Drawing.Size(73, 13);
            this.lbDataAbertura.TabIndex = 12;
            this.lbDataAbertura.Text = "Data Abertura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(800, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 47);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnFercharChamdo
            // 
            this.btnFercharChamdo.Location = new System.Drawing.Point(136, 476);
            this.btnFercharChamdo.Name = "btnFercharChamdo";
            this.btnFercharChamdo.Size = new System.Drawing.Size(187, 23);
            this.btnFercharChamdo.TabIndex = 12;
            this.btnFercharChamdo.Text = "Alimetar/Fechar Chamado";
            this.btnFercharChamdo.UseVisualStyleBackColor = true;
            this.btnFercharChamdo.Click += new System.EventHandler(this.btnFercharChamdo_Click);
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(12, 476);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(118, 23);
            this.btnAbrirChamado.TabIndex = 13;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // gbChamados
            // 
            this.gbChamados.Controls.Add(this.dgChamados);
            this.gbChamados.Location = new System.Drawing.Point(9, 117);
            this.gbChamados.Name = "gbChamados";
            this.gbChamados.Size = new System.Drawing.Size(935, 337);
            this.gbChamados.TabIndex = 10;
            this.gbChamados.TabStop = false;
            this.gbChamados.Text = "Chamados";
            // 
            // dgChamados
            // 
            this.dgChamados.AllowUserToAddRows = false;
            this.dgChamados.AllowUserToDeleteRows = false;
            this.dgChamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChamados.Enabled = false;
            this.dgChamados.Location = new System.Drawing.Point(3, 16);
            this.dgChamados.Name = "dgChamados";
            this.dgChamados.ReadOnly = true;
            this.dgChamados.Size = new System.Drawing.Size(929, 318);
            this.dgChamados.TabIndex = 0;
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.CustomFormat = "dd/MM/yyyy";
            this.dtpAbertura.Location = new System.Drawing.Point(101, 19);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(200, 20);
            this.dtpAbertura.TabIndex = 15;
            // 
            // dtpAberturaFinal
            // 
            this.dtpAberturaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpAberturaFinal.Location = new System.Drawing.Point(347, 19);
            this.dtpAberturaFinal.Name = "dtpAberturaFinal";
            this.dtpAberturaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpAberturaFinal.TabIndex = 16;
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(315, 23);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(22, 13);
            this.lbAte.TabIndex = 17;
            this.lbAte.Text = "até";
            // 
            // cbTecnico
            // 
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(617, 18);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(298, 21);
            this.cbTecnico.TabIndex = 18;
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Location = new System.Drawing.Point(561, 23);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(46, 13);
            this.lbFuncionario.TabIndex = 20;
            this.lbFuncionario.Text = "Tecnico";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(19, 77);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(85, 13);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "Status Chamado";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(303, 76);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 22;
            this.lbDescricao.Text = "Descrição";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(119, 72);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(166, 21);
            this.cbStatus.TabIndex = 19;
            // 
            // FormChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 512);
            this.Controls.Add(this.panel1);
            this.Name = "FormChamados";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados";
            this.panel1.ResumeLayout(false);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbChamados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.TextBox txtDigiteAqui;
        private System.Windows.Forms.Label lbDataAbertura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFercharChamdo;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.GroupBox gbChamados;
        private System.Windows.Forms.DataGridView dgChamados;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label lbAte;
        private System.Windows.Forms.DateTimePicker dtpAberturaFinal;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}