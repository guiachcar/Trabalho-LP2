namespace ConsultiBETA
{
    partial class Principal
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
            this.gpPesquisa = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gpPessoa = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbBotao = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpPesquisa.SuspendLayout();
            this.gpPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPesquisa
            // 
            this.gpPesquisa.Controls.Add(this.textBox1);
            this.gpPesquisa.Controls.Add(this.btnFiltrar);
            this.gpPesquisa.Location = new System.Drawing.Point(13, 13);
            this.gpPesquisa.Name = "gpPesquisa";
            this.gpPesquisa.Size = new System.Drawing.Size(699, 100);
            this.gpPesquisa.TabIndex = 0;
            this.gpPesquisa.TabStop = false;
            this.gpPesquisa.Text = "Pesquisa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(556, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 46);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // gpPessoa
            // 
            this.gpPessoa.Controls.Add(this.dataGridView1);
            this.gpPessoa.Location = new System.Drawing.Point(13, 120);
            this.gpPessoa.Name = "gpPessoa";
            this.gpPessoa.Size = new System.Drawing.Size(699, 250);
            this.gpPessoa.TabIndex = 1;
            this.gpPessoa.TabStop = false;
            this.gpPessoa.Text = "Pessoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbBotao
            // 
            this.gbBotao.Controls.Add(this.button4);
            this.gbBotao.Controls.Add(this.button3);
            this.gbBotao.Controls.Add(this.button2);
            this.gbBotao.Controls.Add(this.button1);
            this.gbBotao.Location = new System.Drawing.Point(16, 376);
            this.gbBotao.Name = "gbBotao";
            this.gbBotao.Size = new System.Drawing.Size(699, 53);
            this.gbBotao.TabIndex = 2;
            this.gbBotao.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 441);
            this.Controls.Add(this.gbBotao);
            this.Controls.Add(this.gpPessoa);
            this.Controls.Add(this.gpPesquisa);
            this.Name = "Principal";
            this.Text = "CONSULTI";
            this.gpPesquisa.ResumeLayout(false);
            this.gpPesquisa.PerformLayout();
            this.gpPessoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPesquisa;
        private System.Windows.Forms.GroupBox gpPessoa;
        private System.Windows.Forms.GroupBox gbBotao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

