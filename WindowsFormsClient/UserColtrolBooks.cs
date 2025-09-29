using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;


namespace WindowsFormsClient
{
    public partial class UserColtrolBooks : UserControl
    {
        public UserColtrolBooks()
        {
            InitializeComponent();
        }

        private ClassPecaTI _lista = new ClassPecaTI ("", "", "", 0 , 0 , "" ,0 ,0);

       
        private void UserControlBooks_Load(object sender, EventArgs e)
        {
           
        }
    }
}
