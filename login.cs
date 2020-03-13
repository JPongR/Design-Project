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
            WrongLabel.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Despro.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.admin WHERE username = '" + usernameBox.Text + "' AND pass = '" + passwordBox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            System.Diagnostics.Debug.WriteLine("username: " + usernameBox.Text);
            System.Diagnostics.Debug.WriteLine("password: " + passwordBox.Text);
            System.Diagnostics.Debug.WriteLine("cell 0,0: " + dt.Rows[0][0].ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM dbo.admin WHERE username = '" + usernameBox.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt1 = new DataTable(); //this is creating a virtual table  
                sda1.Fill(dt1);
                mainMenuSelect mainMenu = new mainMenuSelect(dt1.Rows[0][1].ToString(), dt1.Rows[0][3].ToString());
                Hide();
                mainMenu.Show();
            }
            else
            {
                WrongLabel.Show();
            }
        }
        private void usernameBox_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.Clear();
        }

        private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            WrongLabel.Hide();
        }
    }
}
