using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Model;
using ConsultiBETA.Controller;

namespace ConsultiBETA
{
    public partial class FormVendaReport : Form
    {
        VendaController controller = new VendaController();

        public FormVendaReport()
        {
            InitializeComponent();
        }
        public FormVendaReport(int venda)
        {
            InitializeComponent();
            CrystalReport2 report = new CrystalReport2();
            report.SetDataSource(controller.ListItemVendas(venda));
            report.Refresh();
        }
    }
}
