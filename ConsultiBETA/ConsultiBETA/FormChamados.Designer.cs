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
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lbConsulta = new System.Windows.Forms.Label();
            this.lbPor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFercharChamdo = new System.Windows.Forms.Button();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.gbFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgFuncioanarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_acao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncioanarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiltrar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnFercharChamdo);
            this.panel1.Controls.Add(this.btnAbrirChamado);
            this.panel1.Controls.Add(this.gbFuncionarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 478);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.txtDigiteAqui);
            this.gbFiltrar.Controls.Add(this.cbFiltrar);
            this.gbFiltrar.Controls.Add(this.lbConsulta);
            this.gbFiltrar.Controls.Add(this.lbPor);
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(9, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(638, 65);
            this.gbFiltrar.TabIndex = 15;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // txtDigiteAqui
            // 
            this.txtDigiteAqui.Location = new System.Drawing.Point(282, 23);
            this.txtDigiteAqui.Name = "txtDigiteAqui";
            this.txtDigiteAqui.Size = new System.Drawing.Size(201, 20);
            this.txtDigiteAqui.TabIndex = 14;
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "ID Chamado",
            "ID Cliente",
            "ID Funcinario",
            "STATUS"});
            this.cbFiltrar.Location = new System.Drawing.Point(69, 22);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbFiltrar.TabIndex = 13;
            // 
            // lbConsulta
            // 
            this.lbConsulta.AutoSize = true;
            this.lbConsulta.Location = new System.Drawing.Point(208, 29);
            this.lbConsulta.Name = "lbConsulta";
            this.lbConsulta.Size = new System.Drawing.Size(58, 13);
            this.lbConsulta.TabIndex = 12;
            this.lbConsulta.Text = "Digite Aqui";
            // 
            // lbPor
            // 
            this.lbPor.AutoSize = true;
            this.lbPor.Location = new System.Drawing.Point(15, 30);
            this.lbPor.Name = "lbPor";
            this.lbPor.Size = new System.Drawing.Size(23, 13);
            this.lbPor.TabIndex = 12;
            this.lbPor.Text = "Por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(260, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFercharChamdo
            // 
            this.btnFercharChamdo.Location = new System.Drawing.Point(136, 446);
            this.btnFercharChamdo.Name = "btnFercharChamdo";
            this.btnFercharChamdo.Size = new System.Drawing.Size(118, 23);
            this.btnFercharChamdo.TabIndex = 12;
            this.btnFercharChamdo.Text = "Fechar Chamado";
            this.btnFercharChamdo.UseVisualStyleBackColor = true;
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(12, 446);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(118, 23);
            this.btnAbrirChamado.TabIndex = 13;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            // 
            // gbFuncionarios
            // 
            this.gbFuncionarios.Controls.Add(this.dgFuncioanarios);
            this.gbFuncionarios.Location = new System.Drawing.Point(9, 83);
            this.gbFuncionarios.Name = "gbFuncionarios";
            this.gbFuncionarios.Size = new System.Drawing.Size(648, 345);
            this.gbFuncionarios.TabIndex = 10;
            this.gbFuncionarios.TabStop = false;
            this.gbFuncionarios.Text = "Funcionarios";
            // 
            // dgFuncioanarios
            // 
            this.dgFuncioanarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncioanarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClienteID,
            this.FuncionarioID,
            this.VendaID,
            this.list_acao,
            this.status});
            this.dgFuncioanarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFuncioanarios.Enabled = false;
            this.dgFuncioanarios.Location = new System.Drawing.Point(3, 16);
            this.dgFuncioanarios.Name = "dgFuncioanarios";
            this.dgFuncioanarios.Size = new System.Drawing.Size(642, 326);
            this.dgFuncioanarios.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ClienteID
            // 
            this.ClienteID.HeaderText = "Cliente ID";
            this.ClienteID.Name = "ClienteID";
            // 
            // FuncionarioID
            // 
            this.FuncionarioID.HeaderText = "Funcionario ID";
            this.FuncionarioID.Name = "FuncionarioID";
            // 
            // VendaID
            // 
            this.VendaID.HeaderText = "Venda ID";
            this.VendaID.Name = "VendaID";
            // 
            // list_acao
            // 
            this.list_acao.HeaderText = "Ação";
            this.list_acao.Name = "list_acao";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // FormChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 478);
            this.Controls.Add(this.panel1);
            this.Name = "FormChamados";
            this.RightToLeftLayout = true;
            this.Text = "Chamados";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label lbConsulta;
        private System.Windows.Forms.Label lbPor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFercharChamdo;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.GroupBox gbFuncionarios;
        private System.Windows.Forms.DataGridView dgFuncioanarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_acao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}