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
using System.Collections;

namespace ConsultiBETA
{
    public partial class FormChamados : Form
    {
        ChamadoController controller = new ChamadoController();
        FuncionarioController controllerFuncionario = new FuncionarioController();
        EstoqueController controllerEstoque = new EstoqueController();
        ClienteController controllerCliente = new ClienteController();
        StatusController controllerStatus = new StatusController();



        public FormChamados()
        {
            InitializeComponent();
            dtpAbertura.Format = DateTimePickerFormat.Custom;
            dtpAbertura.CustomFormat = "dd/MM/yyyy";
            dtpAberturaFinal.Format = DateTimePickerFormat.Custom;
            dtpAberturaFinal.CustomFormat = "dd/MM/yyyy";

            cbTecnico.ValueMember = "pessoa_id";
            cbTecnico.DisplayMember = "nome";
            cbTecnico.DataSource = controllerFuncionario.ListarTecnicos().Tables[0];

            cbStatus.ValueMember = "_id_status";
            cbStatus.DisplayMember = "status_chamado";
            cbStatus.DataSource = controllerStatus.Listar().Tables[0];

            Exibir();


        }
        public void Exibir()
        {
            dgChamados.DataSource = controller.Listar();
            dgChamados.DataMember = "chamado";
            dgChamados.Columns[0].HeaderText = "Chamado";
            dgChamados.Columns[1].Visible = false;
            dgChamados.Columns[2].Visible = false;
            dgChamados.Columns[3].Visible = false;
            dgChamados.Columns[4].HeaderText = "Descrição";
            dgChamados.Columns[5].Visible = false;
            dgChamados.Columns[6].HeaderText = "Data Abertura";
            dgChamados.Columns[7].HeaderText = "Data Agendamento";
            dgChamados.Columns[8].HeaderText = "Data Fechamento";
            dgChamados.Columns[9].Visible = false;
            dgChamados.Columns[10].HeaderText = "Cliente";
            dgChamados.Columns[11].Visible = false;
            dgChamados.Columns[12].Visible = false;
            dgChamados.Columns[13].Visible = false;
            dgChamados.Columns[14].Visible = false;
            dgChamados.Columns[15].Visible = false;
            dgChamados.Columns[16].Visible = false;
            dgChamados.Columns[17].HeaderText = "Telefone Cliente";
            dgChamados.Columns[18].Visible = false;
            dgChamados.Columns[19].Visible = false;
            dgChamados.Columns[20].HeaderText = "Status";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados();
            form.ShowDialog();
        }

        private void btnFercharChamdo_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados(dgChamados);
            form.ShowDialog();
        }
    
    }
}
