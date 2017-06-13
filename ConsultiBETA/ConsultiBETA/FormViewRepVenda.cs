using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Controller;
using ConsultiBETA.Model;

namespace ConsultiBETA
{
    public partial class FormViewRepVenda : Form
    {

        Venda objVenda = new Venda();
        VendaController controller = new VendaController();
        ClienteController controllerCliente = new ClienteController();
        ChamadoController controllerChamado = new ChamadoController();


        public FormViewRepVenda()
        {
            InitializeComponent();
            
        }
        public FormViewRepVenda(int venda)
        {
            InitializeComponent();
            objVenda = controller.GetVenda(venda);

        }

        private void FormViewRepVenda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            
            DataSet dataSet = new DataSet();
            dataSet = controller.ListarVenda(objVenda.Id);

            ReportDataSource vendaOrdem = new ReportDataSource();
            vendaOrdem.Name = "venda";
            vendaOrdem.Value = dataSet.Tables["venda"];

            localReport.DataSources.Add(vendaOrdem);
            
        }
    }
}
