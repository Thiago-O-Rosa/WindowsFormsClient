using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser
{
    public class ClassUser
    {
        //Propriedade

        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password)
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
        }
         //Métodos
        
        public string Entrar (string email, string password)
        {
            
            if (email == "teste@gmail.com" && password == "teste123")
            {
                return "Login feito com sucesso";
            }
            else {
                return "Email e/ou senha inválidos.";
            }

        }

        public string Registrar (string name, string email, string password)
        {
            return "";
        }

       

    }
}
