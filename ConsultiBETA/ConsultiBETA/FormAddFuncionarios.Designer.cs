namespace ConsultiBETA
{
    partial class FormAddFuncionarios
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbDesSenha = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.lbDesSenha);
            this.panel1.Controls.Add(this.lbSenha);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lbSalario);
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lbTelefone);
            this.panel1.Controls.Add(this.gbEndereco);
            this.panel1.Controls.Add(this.lbCPF);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 351);
            this.panel1.TabIndex = 0;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(411, 147);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(154, 20);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(84, 105);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(261, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(412, 62);
            this.txtCPF.Mask = "00000000000";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(153, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // lbDesSenha
            // 
            this.lbDesSenha.AutoSize = true;
            this.lbDesSenha.Location = new System.Drawing.Point(571, 105);
            this.lbDesSenha.Name = "lbDesSenha";
            this.lbDesSenha.Size = new System.Drawing.Size(166, 13);
            this.lbDesSenha.TabIndex = 33;
            this.lbDesSenha.Text = "Mínimo 6 caracteres e máximo 10";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(365, 106);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 32;
            this.lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(412, 102);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(153, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Atendente",
            "Administrativo",
            "Estoquista",
            "Gerencia",
            "Técnico"});
            this.cbCargo.Location = new System.Drawing.Point(84, 147);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(261, 21);
            this.cbCargo.TabIndex = 5;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(278, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(133, 24);
            this.lbID.TabIndex = 29;
            this.lbID.Text = "Funcionario ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(355, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(365, 156);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(39, 13);
            this.lbSalario.TabIndex = 23;
            this.lbSalario.Text = "Salario";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(23, 149);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 24;
            this.lbCargo.Text = "Cargo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(161, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(188, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(23, 103);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 20;
            this.lbTelefone.Text = "Telefone";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.cbEstado);
            this.gbEndereco.Controls.Add(this.lbEstado);
            this.gbEndereco.Controls.Add(this.lbCEP);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtNro);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lbCidade);
            this.gbEndereco.Controls.Add(this.lbBairro);
            this.gbEndereco.Controls.Add(this.lbNumero);
            this.gbEndereco.Controls.Add(this.lbRua);
            this.gbEndereco.Location = new System.Drawing.Point(12, 196);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(716, 106);
            this.gbEndereco.TabIndex = 7;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(508, 20);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(155, 20);
            this.txtCEP.TabIndex = 9;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(616, 55);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(47, 21);
            this.cbEstado.TabIndex = 12;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(570, 59);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 7;
            this.lbEstado.Text = "Estado";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(464, 28);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 13);
            this.lbCEP.TabIndex = 5;
            this.lbCEP.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(343, 56);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(210, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(62, 56);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(218, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(343, 21);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(98, 20);
            this.txtNro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(59, 21);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(221, 20);
            this.txtRua.TabIndex = 7;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(293, 59);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 3;
            this.lbCidade.Text = "Cidade";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(18, 59);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 2;
            this.lbBairro.Text = "Bairro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(293, 28);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "Numero";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(18, 28);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(365, 62);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 17;
            this.lbCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(22, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "Nome";
            // 
            // FormAddFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 351);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adiconar/Alterar Funcionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lbDesSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}