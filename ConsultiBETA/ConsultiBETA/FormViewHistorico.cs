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
    public partial class FormViewHistorico : Form
    {
        public FormViewHistorico()
        {
            InitializeComponent();
        }
        public FormViewHistorico(string query)
        {
            InitializeComponent();
            rtbQuery.Text = query;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
