using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicar
{
    class CadastroCliente
    {
        // Propriedades (campos da classe)
        public long cnh { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public long cep { get; set; }

        // String de conexão com o BD
        readonly string strConexao = @"server=127.0.0.1;user id=root;database=unicar";

        // Instruções SQL
        public const string strINSERT = "INSERT INTO clientes(cnh, nome, endereco, cidade, estado, cep)"
            + "VALUES(@cnh, @nome, @endereco, @cidade, @estado, @cep);";
        public const string strSELECT = "SELECT cnh, nome, endereco, cidade, estado, cep FROM clientes;";

        // Função Gravar
        public void Gravar()
        {
            using (MySqlConnection oConnection = new MySqlConnection(strConexao))
            {
                using (MySqlCommand oCommand = new MySqlCommand(strINSERT, oConnection))
                {
                    oCommand.Parameters.AddWithValue("@cnh", cnh);
                    oCommand.Parameters.AddWithValue("@nome", nome);
                    oCommand.Parameters.AddWithValue("@endereco", endereco);
                    oCommand.Parameters.AddWithValue("@cidade", cidade);
                    oCommand.Parameters.AddWithValue("@estado", estado);
                    oCommand.Parameters.AddWithValue("@cep", cep);

                    oConnection.Open();
                    oCommand.ExecuteNonQuery();
                    oConnection.Close();
                }
            }
        }

        // Função Listar
        public DataTable Listar()
        {
            DataTable dtRet = new DataTable();
            using (MySqlConnection oConnection = new MySqlConnection(strConexao))
            {
                using (MySqlCommand oCommand = new MySqlCommand(strSELECT, oConnection))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(oCommand);

                    oConnection.Open();
                    da.Fill(dtRet);
                    oConnection.Close();
                }
            }
            return dtRet;
        }
    }
}
