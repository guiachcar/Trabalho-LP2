using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ConsultiBETA.Controller
{
    class Controller
    {
        private string conexao = "Persist Security Info=False;server=159.203.179.94;database=consulti;uid=consulti;server = 159.203.179.94; database = consulti;Connect Timeout=28800;Command Timeout=28800; uid = consulti; pwd =ifsp2017";
        //private string conexao = "Persist Security Info=False;server=localhost;database=consulti;uid=root;server = localhost; database = consulti;Connect Timeout=28800;Command Timeout=28800; uid = root; pwd =";


        public void RegistrarHistorico(String query, int funcionario_id)
        {
            MySqlConnection objConexao = new MySqlConnection(conexao);
            query = query.Replace("'", " + ");
            query = query.Replace("INSERT INTO", "I-");
            query = query.Replace("UPDATE", "U-");
            query = query.Replace("SET", ",");
            query = query.Replace("DELETE", "Exclusão de cadastro");
            string sqlQuery = "INSERT INTO historico (funcionario_id , query) VALUES (" + funcionario_id + ", '"+query+"')";
            try
            {
                objConexao.Open();
                MySqlCommand exQuery = new MySqlCommand(sqlQuery, objConexao);
                exQuery.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco" + e, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                objConexao.Close();
                objConexao.Dispose();
            }

        }

        public int ExecutarSql(string sqlQuery)
        {
        
            int ultimoId = 0;
            MySqlConnection objConexao = new MySqlConnection(conexao);
            try
            {
                objConexao.Open();
                MySqlCommand exQuery = new MySqlCommand(sqlQuery, objConexao);
                exQuery.ExecuteNonQuery();
                if (exQuery.LastInsertedId != 0)
                {
                    exQuery.Parameters.Add(new MySqlParameter("ultimoId", exQuery.LastInsertedId));
                    ultimoId = Convert.ToInt32(exQuery.Parameters["@ultimoId"].Value);
                }
                    
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco" + e, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                objConexao.Close();
                RegistrarHistorico(sqlQuery, FormLogin.usuarioLogado);
                objConexao.Dispose();

            }
            return ultimoId;

        }
        public DataRow ExecutarSqlRetornoObj(string sqlQuery)
        {

            
            DataRow informacao = null;
            DataSet mDataSet = new DataSet();
            MySqlConnection objConexao = new MySqlConnection(conexao);
            try
            {
                objConexao.Open();
                //cria um adapter utilizando a instrução SQL para aceder à tabela
                MySqlDataAdapter mAdapter = new MySqlDataAdapter(sqlQuery, objConexao);


                //Estrutura da tabela 
                DataTable objDataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                mAdapter.Fill(objDataTable);

                //Cria lista
                List<string> ListaDeDados = new List<string>();

                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    //Adiciona na lista Especificando a clouna 
                    informacao = dataRow;
                }


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco" + e, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                objConexao.Close();
                objConexao.Dispose();
            }
            return informacao;

        }
        public List<DataRow> ExecutarSqlRetorno(string sqlQuery)
        {

            
            //Cria lista
            List<DataRow> lista = new List<DataRow>();

            DataSet mDataSet = new DataSet();
            MySqlConnection objConexao = new MySqlConnection(conexao);
            try
            {
                objConexao.Open();
                //cria um adapter utilizando a instrução SQL para aceder à tabela
                MySqlDataAdapter mAdapter = new MySqlDataAdapter(sqlQuery, objConexao);

                    
                //Estrutura da tabela 
                    DataTable objDataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                mAdapter.Fill(objDataTable);

                

                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    //Adiciona na lista Especificando a clouna 
                    DataRow informacao = dataRow;
                    lista.Add(informacao);
                }

                
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco" + e, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                objConexao.Close();
                objConexao.Dispose();
            }
            return lista;

        }

        public DataSet ExecutarSqlRetGrid(string sqlQuery,string table)
        {

            
            DataSet mDataSet = new DataSet();
            
            MySqlConnection objConexao = new MySqlConnection(conexao);
            try
            {
                objConexao.Open();
                //cria um adapter utilizando a instrução SQL para aceder à tabela
                MySqlDataAdapter mAdapter = new MySqlDataAdapter(sqlQuery, objConexao);
                //preenche o dataset através do adapter
                mAdapter.Fill(mDataSet, table);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco" + e, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                objConexao.Close();
                objConexao.Dispose();
                
            }
            return mDataSet;

        }

    }
}