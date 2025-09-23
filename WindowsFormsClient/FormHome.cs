using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = true;
            _userControlBooks.Visible = false;
            _userControlFAQ.Visible = false;
            _userControlSobre.Visible = false;
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = false;
            _userControlBooks.Visible = true;
            _userControlFAQ.Visible = false;
            _userControlSobre.Visible = false;
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = false;
            _userControlBooks.Visible = false;
            _userControlFAQ.Visible = true;
            _userControlSobre.Visible = false;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = false;
            _userControlBooks.Visible = false;
            _userControlFAQ.Visible = false;
            _userControlSobre.Visible = true;
        }

        
    }
}
