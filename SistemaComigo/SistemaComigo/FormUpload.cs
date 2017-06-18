using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.OleDb;

namespace SistemaComigo
{
    public partial class FormUpload : Form
    {
        public FormUpload()
        {
            InitializeComponent();
        }
        

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
            {
                
                string arquivo = @ofdArquivo.FileName;
                string strConexao = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"", arquivo);
                OleDbConnection conn = new OleDbConnection(strConexao);
                conn.Open();
                DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Cria o objeto dataset para receber o conteúdo do arquivo Excel
                DataSet output = new DataSet();
                foreach (DataRow row in dt.Rows)
                {
                    // obtem o noma da planilha corrente
                    string sheet = row["TABLE_NAME"].ToString();
                    // obtem todos as linhas da planilha corrente
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                    cmd.CommandType = CommandType.Text;
                    // copia os dados da planilha para o datatable
                    DataTable outputTable = new DataTable(sheet);
                    output.Tables.Add(outputTable);
                    new OleDbDataAdapter(cmd).Fill(outputTable);
                }
                if(output.Tables[0].Rows[0][4].ToString() != null)
                    MessageBox.Show(output.Tables[0].Rows[0][4].ToString());
                if (output.Tables[0].Rows[1][33].ToString() != "")
                    MessageBox.Show(output.Tables[0].Rows[1][33].ToString());
                dgvArquivos.DataSource = output.Tables[0];
                dgvArquivos.AutoGenerateColumns = true;
            }


        }
        
    }
}
