using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;
using System.Globalization;

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
            
            string sqlQuery1 = "INSERT INTO chamado (cliente_id,funcionario_id,descricao,status,data_agendamento) VALUES ("+ chamado.Cliente.Id+","+chamado.Funcionario.Id+",'"+chamado.Descricao+"','"+chamado.Status1.Id_status+"','"+chamado.Data_agendamento.ToString("yyyy-MM-dd HH:mm:ss") +"')";
            int idCadastrado1 = ExecutarSql(sqlQuery1);
            
        }
        
        public void Editar(Chamado chamado)
        {
            ExecutarSql("INSERT INTO acao (descricao,chamado_id,funcionario_id) VALUES ('" + chamado.Acao[chamado.Acao.Count-1].Descricao + "'," + chamado.Id + "," + chamado.Funcionario.Id + ")");
            ExecutarSql("UPDATE chamado SET funcionario_id=" + chamado.Funcionario.Id + ", status = " + chamado.Status1.Id_status + ", data_agendamento= '" + chamado.Data_agendamento.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE _id_chamado=" + chamado.Id);
        }
        
        public void Finalizar(Chamado chamado)
        {
            decimal ValorTotal = 0;

            string sqlQuery = "INSERT INTO venda (status_venda) VALUES (" + chamado.Status_Venda.Id_status + ")";
            int idCadastrado = ExecutarSql(sqlQuery);
            if (chamado.Produtos != null)
            {
                foreach (ItemVendaProduto x in chamado.Produtos)
                {
                    ExecutarSql("INSERT INTO item_venda_produto (venda_id,produto_id,quantidade) VALUES (" + idCadastrado + "," + x.Produto.Id + "," + x.Quantidade + ")");
                    ValorTotal = ValorTotal + (x.Produto.Valor_venda * x.Quantidade);
                    ExecutarSql("UPDATE estoque SET quantidade=quantidade-"+x.Quantidade+ " WHERE produto_id="+x.Produto.Id);

                }

            }
            if (chamado.Servicos != null)
            {
                foreach (ItemVendaServico y in chamado.Servicos)
                {
                    ExecutarSql("INSERT INTO item_venda_servico (venda_id,servico_id,quantidade) VALUES (" + idCadastrado + "," + y.Servico.Id + "," + y.Quantidade + ")");
                    ValorTotal = ValorTotal + y.Servico.Valor;
                }

            }
            ExecutarSql("UPDATE venda SET valor_total=REPLACE('" + ValorTotal.ToString() + "',',','.') WHERE _id_venda=" + idCadastrado);
            ExecutarSql("INSERT INTO acao (descricao,chamado_id,funcionario_id) VALUES ('" + chamado.Acao[chamado.Acao.Count-1].Descricao + "'," + chamado.Id + "," + chamado.Funcionario.Id + ")");
            ExecutarSql("UPDATE chamado SET funcionario_id=" + chamado.Funcionario.Id + ",venda_id = "+idCadastrado+", status = " + chamado.Status1.Id_status + ", data_agendamento= '" + chamado.Data_agendamento.ToString("yyyy-MM-dd HH:mm:ss") + ", data_fechamento= NOW() ' WHERE _id_chamado=" + chamado.Id);

        }

        public Chamado GetChamado(int id)
        {
            DataRow chamadoRow;
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE ch._id_chamado="+id+";";
            chamadoRow = ExecutarSqlRetornoObj(sqlQuery);
            Chamado chamado = new Chamado();
            chamado.Id = chamadoRow.Field<int>("_id_chamado");
            chamado.Cliente = controllerCliente.getCliente(chamadoRow.Field<int>("cliente_id"));
            chamado.Funcionario = controllerFuncionario.getFunc(chamadoRow.Field<int>("funcionario_id"));
            chamado.Acao = controllerAcao.getAcoes(chamadoRow.Field<int>("_id_chamado"));
            chamado.Descricao = chamadoRow.Field<string>("descricao");
            chamado.Status1 = controllerStatus.GetStatus(chamadoRow.Field<int>("status"));
            chamado.Data_abertura = chamadoRow.Field<DateTime>("data_abertura");
            chamado.Data_agendamento = chamadoRow.Field<DateTime>("data_agendamento"); 
            
            if(chamado.Status1.Id_status == 4)
            {
                chamado.Servicos = controllerVenda.getServicoList(chamadoRow.Field<int>("venda_id"));
                chamado.Produtos = controllerVenda.getProdutoList(chamadoRow.Field<int>("venda_id"));
                chamado.Valor_total = controllerVenda.GetVenda(chamadoRow.Field<int>("venda_id")).Valor_total;
                chamado.Status_Venda = controllerVenda.GetVenda(chamadoRow.Field<int>("venda_id")).Status_Venda;
                //chamado.Data_pagamento = chamadoRow.Field<DateTime>("data_pagamento");
            }

            return chamado;
        }
        public DataSet Listar()
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status;";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public DataSet ListarChamadosRecentes()
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE ch.data_abertura BETWEEN CURRENT_DATE()-15 AND CURRENT_DATE() AND ch.status!=4;";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public DataSet ListarChamadosTecnico(int id)
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE ch.data_agendamento BETWEEN CURRENT_DATE()-1 AND CURRENT_DATE()+1 AND ch.funcionario_id=" + id+";";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public DataSet BuscarChamado(DateTime dataabertura,DateTime dataaberturafinal, string tecnico,string status,string consulta)
        {
            string table = "chamado";
            string sqlQuery = "SELECT * FROM chamado ch INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE ch.funcionario_id=" + tecnico + " AND ch.descricao LIKE '%" + consulta + "%', ch.status=" + status + " AND data_abertura BETWEEN '"+dataabertura.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '"+dataaberturafinal.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}

