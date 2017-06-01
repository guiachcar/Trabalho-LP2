using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;

namespace ConsultiBETA.Controller
{
    class ChamadoController:Controller
    {
        ClienteController controllerCliente = new ClienteController();
        FuncionarioController controllerFuncionario = new FuncionarioController();
        AcaoController controllerAcao = new AcaoController();
        StatusController controllerStatus = new StatusController();
        VendaController controllerVenda = new VendaController();

        public void Cadastrar(Chamado chamado)
        {
            float ValorTotal = 0;

            string sqlQuery = "INSERT INTO venda (status) VALUES ("+chamado.Status_Venda.Id_status+")";
            int idCadastrado = ExecutarSql(sqlQuery);
            if(chamado.Produtos != null)
            {
                foreach(ItemVendaProduto x in chamado.Produtos)
                {
                    ExecutarSql("INSERT INTO item_venda_produto (venda_id,produto_id,quantidade) VALUES (" + idCadastrado + ","+x.Produto.Id+","+x.Quantidade+")");
                    ValorTotal = ValorTotal + x.Produto.Valor_venda;
                }
                
            }
            if (chamado.Servicos != null)
            {
                foreach (ItemVendaServico y in chamado.Servicos)
                {
                    ExecutarSql("INSERT INTO item_venda_servico (venda_id,servico_id,quantidade) VALUES (" + idCadastrado + "," + y.Servico.Id + ","+y.Quantidade+")");
                    ValorTotal = ValorTotal + y.Servico.Valor;
                }

            }
            ExecutarSql("UPDATE venda SET valor_total="+ValorTotal+" WHERE _id_venda="+idCadastrado);

            string sqlQuery1 = "INSERT INTO chamado (cliente_id,funcionario_id,venda_id,descricao,status,data_agendamento) VALUES ("+ chamado.Cliente.Id+","+chamado.Funcionario.Id+","+idCadastrado+",'"+chamado.Descricao+"','"+chamado.Status1.Id_status+"','"+chamado.Data_agendamento.ToString()+"')";
            int idCadastrado1 = ExecutarSql(sqlQuery1);
            
        }
        
        public void Editar(Cliente cliente)
        {
            
        }
        
        public Chamado GetChamado(int id)
        {
            DataRow chamadoRow;
            string sqlQuery = "SELECT * FROM venda ve INNER JOIN chamado ch ON ch.venda_id=ve._id_venda INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE ch._id_chamado="+id+";";
            chamadoRow = ExecutarSqlRetornoObj(sqlQuery);
            Chamado chamado = new Chamado();
            chamado.Id = chamadoRow.Field<int>("_id_chamado");
            chamado.Cliente = controllerCliente.getCliente(chamadoRow.Field<int>("cliente_id"));
            chamado.Funcionario = controllerFuncionario.getFunc(chamadoRow.Field<int>("funcionario_id"));
            chamado.Acao = controllerAcao.getAcoes(chamadoRow.Field<int>("_id_chamado"));
            chamado.Servicos = controllerVenda.getServicoList(chamadoRow.Field<int>("_id_venda"));
            chamado.Produtos = controllerVenda.getProdutoList(chamadoRow.Field<int>("_id_venda"));
            chamado.Descricao = chamadoRow.Field<string>("descricao");
            chamado.Status1 = controllerStatus.GetStatus(chamadoRow.Field<int>("status"));
            //chamado.Data_abertura.Date.ToString(chamadoRow.Field<string>("data_abertura"));
            //chamado.Data_agendamento.Date.ToString(chamadoRow.Field<string>("data_agendamento"));
            chamado.Status_Venda = controllerStatus.GetStatus(chamadoRow.Field<int>("status_venda"));
            chamado.Valor_total = chamadoRow.Field<float>("valor_total");
            //chamado.Data_pagamento.Date.ToString(chamadoRow.Field<string>("data_pagamento"));
            return chamado;
        }
        public DataSet Listar()
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status;";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }

        public DataSet BuscarChamado(string consulta)
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado WHERE funcionario_id=" + consulta + " AND descricao LIKE '%" + consulta + "%', status=" + consulta + " AND data_abertura ";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}

