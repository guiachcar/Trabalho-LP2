namespace ConsultiBETA
{
    partial class FormHistorico
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
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Location = new System.Drawing.Point(13, 13);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistorico.Size = new System.Drawing.Size(738, 400);
            this.dgHistorico.TabIndex = 0;
            this.dgHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorico_CellContentClick);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(264, 420);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(243, 34);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.dgHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHistorico";
            this.Text = "Historico Operações";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.Button btOk;
    }
}