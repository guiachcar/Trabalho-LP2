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
        AcaoController controllerAcao = new AcaoController();
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
            btnAddProduto.Visible = false;
            btnRemProduto.Visible = false;
            btnAddServico.Visible = false;
            btnRemServico.Visible = false;
            
            dgvItemsProdutos = dgItemProduto;
            dgvItemsServicos = dgItemServico;
            
        }
        public FormAddChamados(DataGridView dgChamados)
        {
            InitializeComponent();
            Exibir();

            dgvItemsProdutos = dgItemProduto;
            dgvItemsServicos = dgItemServico;

            
            lbAcao.Visible = true;
            rtbAcao.Visible = true;
            lbStatus.Visible = true;
            cbStatus.Visible = true;
            cbCliente.Enabled = false;
            btnAddProduto.Visible = false;
            btnRemProduto.Visible = false;
            btnAddServico.Visible = false;
            btnRemServico.Visible = false;
            btnImprimir.Visible = true;
            btnImprimirVenda.Visible = false;

            

            Chamado chamado = new Chamado();
            chamado = controller.GetChamado(int.Parse(dgChamados.Rows[dgChamados.CurrentRow.Index].Cells[0].Value.ToString()));
            chamado.Acao = controllerAcao.getAcoes(chamado.Id);

            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    break;
                case "Administrativo":
                    cbTecnico.Enabled = false;
                    dtpDataAgendamento.Enabled = false;
                    btnAddProduto.Enabled = false;
                    btnRemProduto.Enabled = false;
                    btnAddServico.Enabled = false;
                    btnRemServico.Enabled = false;
                    rtbAcao.Enabled = false;
                    cbStatus.Enabled = false;
                    btnSalvar.Visible = false;
                    btnImprimirVenda.Visible = true;
                    break;
                case "Estoquista":
                    cbTecnico.Enabled = false;
                    dtpDataAgendamento.Enabled = false;
                    btnAddProduto.Enabled = false;
                    btnRemProduto.Enabled = false;
                    btnAddServico.Enabled = false;
                    btnRemServico.Enabled = false;
                    rtbAcao.Enabled = false;
                    cbStatus.Enabled = false;
                    btnSalvar.Visible = false;
                    break;
                case "Gerencia":
                    break;
                case "Técnico":
                    if(chamado.Funcionario.Id == FormLogin.usuarioLogado)
                    {
                        break;
                    }else
                    {
                        cbTecnico.Enabled = false;
                        dtpDataAgendamento.Enabled = false;
                        btnAddProduto.Enabled = false;
                        btnRemProduto.Enabled = false;
                        btnAddServico.Enabled = false;
                        btnRemServico.Enabled = false;
                        rtbAcao.Enabled = false;
                        cbStatus.Enabled = false;
                        btnSalvar.Visible = false;
                        break;
                    }
                    
            }

            if (chamado.Status1.Id_status == 4)
            {
                cbTecnico.Enabled = false;
                dtpDataAgendamento.Enabled = false;
                btnAddProduto.Enabled = false;
                btnRemProduto.Enabled = false;
                btnAddServico.Enabled = false;
                btnRemServico.Enabled = false;
                rtbAcao.Enabled = false;
                cbStatus.Enabled = false;
                btnSalvar.Visible = false;
                btnImprimirVenda.Visible = true;

                foreach (ItemVendaProduto x in chamado.Produtos)
                {
                    dgItemProduto.Rows.Add(x.Id_item_venda_produto, x.Produto.Nome, x.Quantidade);
                }
                foreach (ItemVendaServico y in chamado.Servicos)
                {
                    dgItemServico.Rows.Add(y.Id_item_venda_servico, y.Servico.Nome, y.Quantidade);
                }
            }

            lbID.Text = chamado.Id.ToString();
            cbTecnico.SelectedValue = chamado.Funcionario.Id;
            cbCliente.SelectedValue = chamado.Cliente.Id;

            cbStatus.ValueMember = "_id_status";
            cbStatus.DisplayMember = "status_chamado";
            cbStatus.DataSource = controllerStatus.Listar().Tables[0];
            cbStatus.SelectedValue = chamado.Status1.Id_status;
            
            rtbDescricao.Text = chamado.Descricao;
            dtpDataAgendamento.Value = chamado.Data_agendamento;
            lbDataAbertura.Text = chamado.Data_abertura.ToString();
            
            foreach(Acao x in chamado.Acao)
            {
                rtbDescricao.Text = rtbDescricao.Text +"\n "+ x.Data_acao + "  -  " + x.Descricao+" \n";
            }

            rtbDescricao.ReadOnly = true;


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

        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Chamado chamado = new Chamado();

            if (lbID.Text == "Chamado ID")
            {
                dtpDataAgendamento.CustomFormat = "yyyy-MM-dd";
                chamado.Data_agendamento = dtpDataAgendamento.Value;
                chamado.Cliente = controllerCliente.getCliente(int.Parse(cbCliente.SelectedValue.ToString()));
                chamado.Funcionario = controllerFuncionario.getFunc(int.Parse(cbTecnico.SelectedValue.ToString()));
                chamado.Descricao = rtbDescricao.Text;
                chamado.Status1 = controllerStatus.GetStatus(1);
                chamado.Status_Venda = controllerStatus.GetStatus(1);

                controller.Cadastrar(chamado);

                MessageBox.Show("Chamado cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormChamados c = Application.OpenForms["FormChamados"] as FormChamados;

                if (c != null)
                {
                    c.Exibir(); 
                }

            }
            else
            {
                chamado = controller.GetChamado(int.Parse(lbID.Text));
                dtpDataAgendamento.CustomFormat = "yyyy-MM-dd";
                chamado.Data_agendamento = dtpDataAgendamento.Value;
                chamado.Cliente = controllerCliente.getCliente(int.Parse(cbCliente.SelectedValue.ToString()));
                chamado.Funcionario = controllerFuncionario.getFunc(int.Parse(cbTecnico.SelectedValue.ToString()));
                chamado.Descricao = rtbDescricao.Text;
                chamado.Acao.Add(new Acao(chamado.Acao.Count + 1, rtbAcao.Text, DateTime.Now));
                chamado.Status1 = controllerStatus.GetStatus(int.Parse(cbStatus.SelectedValue.ToString()));
                chamado.Status_Venda = controllerStatus.GetStatus(1);

                if (chamado.Status1.Id_status == 4)
                {
                    foreach (DataGridViewRow row in dgItemProduto.Rows)
                    {
                        ItemVendaProduto item_produto = new ItemVendaProduto();
                        item_produto.Produto = controllerProduto.getProduto(int.Parse(row.Cells[0].Value.ToString()));
                        item_produto.Quantidade = int.Parse(row.Cells[2].Value.ToString());
                        chamado.Produtos.Add(item_produto);
                    }
                    foreach (DataGridViewRow row1 in dgItemServico.Rows)
                    {
                        ItemVendaServico item_servico = new ItemVendaServico();
                        item_servico.Servico = controllerServico.getServico(int.Parse(row1.Cells[0].Value.ToString()));
                        item_servico.Quantidade = int.Parse(row1.Cells[2].Value.ToString());
                        chamado.Servicos.Add(item_servico);
                    }
                    controller.Finalizar(chamado);

                    MessageBox.Show("Chamado finalizado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FormChamados c = Application.OpenForms["FormChamados"] as FormChamados;

                    if (c != null)
                    {
                        c.Exibir();
                    }

                }
                else
                {
                    controller.Editar(chamado);

                    MessageBox.Show("Chamado alterado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FormChamados c = Application.OpenForms["FormChamados"] as FormChamados;

                    if (c != null)
                    {
                        c.Exibir();
                    }

                }

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

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(cbStatus.SelectedValue.ToString()) == 4)
            {
                btnAddProduto.Visible = true;
                btnRemProduto.Visible = true;
                btnAddServico.Visible = true;
                btnRemServico.Visible = true;
            }else
            {
                btnAddProduto.Visible = false;
                btnRemProduto.Visible = false;
                btnAddServico.Visible = false;
                btnRemServico.Visible = false;
            }
        }
    }
}
