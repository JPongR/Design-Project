using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despro
{
    public partial class accessAccounts : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
        public string userlocal = "";
        public string typelocal = "";
        public string access, sqlstring;
        public accessAccounts(string user, string type, string accesslocal)
        {
            InitializeComponent();
            userlocal = user;
            typelocal = type;
            access = accesslocal;
            usernameBox.ReadOnly = false;
            passwordBox.ReadOnly = false;
          
            if (access == "add")
            {
                saveButton.Text = "ADD";
                searchBox.Enabled = false;
                searchButton.Enabled = false;
                clearButton.Enabled = true;
            }
            else if (access == "edit")
            {
                saveButton.Text = "SAVE";
                searchBox.Enabled = true;
                searchButton.Enabled = true;
                clearButton.Enabled = false;
            }
            else
            {
                saveButton.Text = "DELETE";
                searchBox.Enabled = true;
                searchButton.Enabled = true;
                clearButton.Enabled = false;
                usernameBox.ReadOnly = true;
                passwordBox.ReadOnly = true;


            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            clearButton.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "accounts");
            Hide();
            deviceDatabase.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.admin WHERE id = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                idLabel.Text = dt.Rows[0][0].ToString();
                usernameBox.Text = dt.Rows[0][1].ToString();
                passwordBox.Text = dt.Rows[0][2].ToString();
                typeBox.Text = dt.Rows[0][3].ToString();
                clearButton.Enabled = true;

            }
            catch (Exception en)
            {
                MessageBox.Show("No matching record found.");
                Console.WriteLine(en.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (access == "add")
            {
                sqlstring = "INSERT INTO dbo.admin (username,pass,type) VALUES('" + usernameBox.Text + "','" + passwordBox.Text + "','" + typeBox.Text + "')";
            }
            else if (access == "edit")
            {
                sqlstring = "UPDATE dbo.admin set username = '" + usernameBox.Text + "', pass = '" + passwordBox.Text + "', type = '" + typeBox.Text + "' WHERE id = '" + idLabel.Text + "'";

            }
            else //delete
            {
                sqlstring = "DELETE FROM dbo.admin WHERE id = '" + idLabel.Text + "'";
            }
            SqlCommand sda = new SqlCommand(sqlstring, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Succesfull");
            clear();
        }

        public void clear()
        {
            idLabel.Text = "";
            usernameBox.Text = "";
            passwordBox.Text = "";
            typeBox.Text = "";
        }
    }
}
