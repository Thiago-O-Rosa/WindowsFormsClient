using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;

namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private ClassUser _user = new ClassUser(0,"","","");

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //this.Close(); --> Fecha apenas o Form atual
            Application.Exit();//Fecha todos os Forms
        }

        private void pbxSenha_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '\0';
        }

        private void pbxSenha_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Inicialização
            string email = "";
            string password = "";

            //Entrada de Dados 
            email = tbxEmail.Text;
            password = tbxSenha.Text;

            //Processamento
           string menssagem = _user.Entrar(email, password);
            MessageBox.Show(menssagem, "Loguin");//Saída

            if(menssagem == "Login feito com sucesso")
            {
                FormHome _formHome = new FormHome();
                _formHome.Show();
                this.Hide();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

    
}
