using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultiBETA
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }


        private void tmProgressarBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                tmProgressarBar.Enabled = false;
                this.Visible = false;
                Principal form_principal = new Principal(this);
                form_principal.Show();

            }
        }
    }
}
