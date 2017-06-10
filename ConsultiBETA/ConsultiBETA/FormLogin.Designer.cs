namespace ConsultiBETA
{
    partial class FormLogin
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbAguarde = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(26, 56);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(162, 23);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário (CPF)";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSenha.Location = new System.Drawing.Point(87, 108);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(78, 23);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha";
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(191, 154);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(91, 39);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(303, 154);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(91, 39);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbAguarde
            // 
            this.lbAguarde.AutoSize = true;
            this.lbAguarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAguarde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAguarde.Location = new System.Drawing.Point(30, 154);
            this.lbAguarde.Name = "lbAguarde";
            this.lbAguarde.Size = new System.Drawing.Size(117, 25);
            this.lbAguarde.TabIndex = 6;
            this.lbAguarde.Text = "Aguarde ...";
            this.lbAguarde.Visible = false;
            // 
            // txUsuario
            // 
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.Location = new System.Drawing.Point(195, 58);
            this.txUsuario.Mask = "00000000000";
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(199, 29);
            this.txUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(192, 110);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(202, 29);
            this.txtSenha.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 213);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbAguarde);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segurança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbAguarde;
        private System.Windows.Forms.MaskedTextBox txUsuario;
        private System.Windows.Forms.MaskedTextBox txtSenha;
    }
}