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
    
    public partial class FormAddChamados : Form
    {
        ChamadoController controller = new ChamadoController();
        FuncionarioController controllerFuncionario = new FuncionarioController();
        ClienteController controllerCliente = new ClienteController();
        ProdutoController controllerProduto = new ProdutoController();
        ServicoController controllerServico = new ServicoController();
        StatusController controllerStatus = new StatusController();
        public static DataGridView dgvItemsServicos;
        public static DataGridView dgvItemsProdutos;

        
        public FormAddChamados()
        {
            InitializeComponent();
            Exibir();

            lbAcao.Visible = false;
            rtbAcao.Visible = false;
            lbStatus.Visible = false;
            cbStatus.Visible = false;
            btnImprimir.Visible = false;
            btnImprimirVenda.Visible = false;

            dgvItemsProdutos = dgItemProduto;
            dgvItemsServicos = dgItemServico;
            
        }
        public FormAddChamados(DataGridView dgChamados)
        {
            InitializeComponent();
            Exibir();

            Chamado chamado = new Chamado();
            chamado = controller.GetChamado(int.Parse(dgChamados.Rows[dgChamados.CurrentRow.Index].Cells[0].Value.ToString()));

            //cbTecnico.SelectedIndex = chamado.Funcionario.Id;
            //cbCliente.SelectedIndex = chamado.Cliente.Id;

            cbStatus.ValueMember = "_id_status";
            cbStatus.DisplayMember = "status_chamado";
            cbStatus.DataSource = controllerStatus.Listar().Tables[0];
            cbStatus.SelectedIndex = chamado.Status1.Id_status;

            //dgvItemsProdutos.DataSource = chamado.Produtos;
            //dgvItemsServicos.DataSource = chamado.Servicos;

            rtbDescricao.Text = chamado.Descricao;
            //dtpDataAgendamento.Value = chamado.Data_agendamento;

            //lbDataAbertura.Text = chamado.Data_abertura.ToString();
            
            foreach(Acao x in chamado.Acao)
            {
                rtbAcao.Text = rtbAcao.Text + x.Data_acao + "  -  " + x.Descricao;
            }



        }
        private void Exibir()
        {
            dtpDataAgendamento.Format = DateTimePickerFormat.Custom;
            dtpDataAgendamento.CustomFormat = "dd/MM/yyyy HH:mm";
            cbTecnico.ValueMember = "pessoa_id";
            cbTecnico.DisplayMember = "nome";
            cbTecnico.DataSource = controllerFuncionario.ListarTecnicos().Tables[0];

            cbCliente.ValueMember = "pessoa_id";
            cbCliente.DisplayMember = "nome";
            cbCliente.DataSource = controllerCliente.Listar().Tables[0];

            lbAcao.Visible = false;
            rtbAcao.Visible = false;
            lbStatus.Visible = false;
            cbStatus.Visible = false;
            btnImprimir.Visible = false;

        }

        private void btnIDCliente_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }

        private void btnIDFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            form.Show();
        }

        private void btnIDVenda_Click(object sender, EventArgs e)
        {
            FormAddVendas form = new FormAddVendas();
            form.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Chamado chamado = new Chamado();

            if (lbID.Text == "Chamado ID")
            {
                dtpDataAgendamento.CustomFormat = "yyyy-MM-dd-HH:mm";
                chamado.Data_agendamento =dtpDataAgendamento.Value;
                chamado.Cliente = controllerCliente.getCliente(int.Parse(cbCliente.SelectedValue.ToString()));
                chamado.Funcionario = controllerFuncionario.getFunc(int.Parse(cbTecnico.SelectedValue.ToString()));
                chamado.Descricao = rtbDescricao.Text;
                chamado.Status1 = controllerStatus.GetStatus(1);
                chamado.Status_Venda = controllerStatus.GetStatus(1);
                foreach (DataGridViewRow row in dgItemProduto.Rows)
                {
                    ItemVendaProduto item_produto = new ItemVendaProduto();
                    item_produto.Produto = controllerProduto.getProduto(int.Parse(row.Cells[0].Value.ToString()));
                    chamado.Produtos.Add(item_produto);
                }
                foreach (DataGridViewRow row1 in dgItemServico.Rows)
                {
                    ItemVendaServico item_servico = new ItemVendaServico();
                    item_servico.Servico = controllerServico.getServico(int.Parse(row1.Cells[0].Value.ToString()));
                    chamado.Servicos.Add(item_servico);
                }
                controller.Cadastrar(chamado);

                MessageBox.Show("Chamado cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                
            }
            else
            {

                
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             
        private void btnAddServico_Click(object sender, EventArgs e)
        {
            FormServicos formServicosItem = new FormServicos(dgItemServico);
            formServicosItem.ShowDialog();

        }

        private void btnRemServico_Click(object sender, EventArgs e)
        {
            dgItemServico.Rows.Remove(dgItemServico.CurrentRow);
            dgvItemsServicos = dgItemServico;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutosItem = new FormProdutos(dgItemProduto);
            formProdutosItem.ShowDialog();
        }

        private void btnRemProduto_Click(object sender, EventArgs e)
        {
            dgItemProduto.Rows.Remove(dgItemProduto.CurrentRow);
            dgvItemsProdutos = dgItemProduto;
        }
    }
}
