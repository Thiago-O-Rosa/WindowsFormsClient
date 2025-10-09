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
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
        }

        private ClassUser _user = new ClassUser(0,"","","");

        //private ConnClass _conn = new ConnClass();

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
            //Entrada de Dados 
            string email = tbxEmail.Text.Trim();
            string password = tbxSenha.Text.Trim();
            tbxEmail.Focus();


            //Processamento
            DataTable dt = _user.Entrar(email, password);//usando o objeto, com o  método (Entrar) com os valores email,passwor

            if(dt.Rows.Count > 0)
            {
                
                MessageBox.Show("Login realizado com sucesso");
                FormHome _formHome = new FormHome();
                _formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível fazer o Login. \nVerifique seu Email e Senha e tente novamente.", "Email ou Senha Incorretos");
            }

            
        }


        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxEmail.Focus();
            if (e.KeyChar == 13) // 13 = é o código do botão ENTER
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void tbxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxSenha.Focus();
            if (e.KeyChar == 13) // 13 = é o código do botão ENTER
            {
                btnEntrar_Click(sender, e);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Tratamento de erro
        //    try //----Tentar executar o comando...
        //    {
        //        using (SqlConnection cn = _conn.GetConnection())
        //        {
        //            cn.Open();
        //            MessageBox.Show(cn.ToString(), "Banco de Dados");
        //        }
        //    }
        //    catch (Exception erro) //--- Pegar um erro ....
        //    {
        //        MessageBox.Show(erro.ToString(), "Erro no BD");
        //    }
        //    //finally {} // Executa mesmo que o try falha
        //}
    }

    
}
