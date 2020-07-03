using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicar
{
    class CadastroFuncionario
    {
        // Propriedades (campos da classe)
        public string registro { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public long cpf { get; set; }
        public string cargo { get; set; }

        // String de conexão com o BD
        readonly string strConexao = @"server=127.0.0.1;user id=root;database=unicar";

        // Instruções SQL
        public const string strINSERT = "INSERT INTO funcionarios(registro, nome, sobrenome, cpf, cargo)"
            + "VALUES(@registro, @nome, @sobrenome, @cpf, @cargo);";
        public const string strSELECT = "SELECT registro, nome, sobrenome, cpf, cargo FROM funcionarios;";

        // Função Gravar
        public void Gravar()
        {
            using (MySqlConnection oConnection = new MySqlConnection(strConexao))
            {
                using (MySqlCommand oCommand = new MySqlCommand(strINSERT, oConnection))
                {
                    oCommand.Parameters.AddWithValue("@registro", registro);
                    oCommand.Parameters.AddWithValue("@nome", nome);
                    oCommand.Parameters.AddWithValue("@sobrenome", sobrenome);
                    oCommand.Parameters.AddWithValue("@cpf", cpf);
                    oCommand.Parameters.AddWithValue("@cargo", cargo);

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
