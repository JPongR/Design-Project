using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Despro
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            Hide();
            mainMenu.Show();
        }
    }
}
