using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryUser
{
    public class ConnClass
    {
        //---Propriedades
        private const string Server = "TAU0712120W11-1\\SQLEXPRESS"; //---Nome do Servidor
        private const string DataBase = "CB_Controle_Estoque";//---Nome do Banco de Dados
        private const string User = "senac";//---Nome do Usuário do Banco de Dados 
        private const string Password = "senac";//---Senha do Usuário do Banco de Dados

        //---String (Cadeia) de Conexão --- (Juntar os dados de conexão)
        protected string StrConn = $"Data Source = {Server}; Initial Catalog = {DataBase}; User Id = {User}; Password = {Password}; Encrypt = False";

        //---Adiconar o plugin: System.Data.SqlClient e logo em seguida adicionar no inicio da class/Biblioteca : using System.Data.SqlClient;

        //---Método para conectar conectar com Banco de Dados
        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection(StrConn); //--- instancioando um objeto "_conn"
            return _conn;
        }

    }
}
