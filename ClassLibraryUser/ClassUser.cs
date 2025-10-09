using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryUser
{
    public class ClassUser
    {
        //Propriedade

        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password)
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
        }
         //Métodos CRUD Read = Select
        public DataTable Entrar (string email, string password)
        {
            var dt = new DataTable();//var similar ao VARCHAR // variável temporário
            string sql = "SELECT * FROM Usuario WHERE email=@Email AND senha=@Password";
            
            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))//usando o fill() para injetar o CMD no DT (tabela do sql)
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception erro)//pega o erro
            {
                Console.WriteLine(erro.Message);
            }
            return dt;
        }

        public string Registrar (string name, string email, string password)
        {
            return "";
        }

       

    }
}
