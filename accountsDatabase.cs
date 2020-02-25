using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despro
{
    public partial class accountsDatabase : Form
    {
        public string userlocal = "";
        public string typelocal = "";
        public accountsDatabase(string user, string type)
        {
            //initialization
            #region
            InitializeComponent();
            studentButton.Enabled = false;
            loginButton.Enabled = false;
            deviceButton.Enabled = false;
            accountButton.Enabled = false;
            userlocal = user;
            typelocal = type;

            if (type == "icto")
            {
                studentButton.Enabled = true;
                loginButton.Enabled = true;
                deviceButton.Enabled = true;
                accountButton.Enabled = true;
            }
            else if (type == "uso")
            {
                studentButton.Enabled = false;
                loginButton.Enabled = true;
                deviceButton.Enabled = true;
                accountButton.Enabled = false;
            }
            else
            {
                studentButton.Enabled = false;
                loginButton.Enabled = true;
                deviceButton.Enabled = false;
                accountButton.Enabled = false;
            }
            #endregion

        }

        
        private void accountsDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desproDatabaseDataSetAdmin.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.desproDatabaseDataSetAdmin.admin);

        }
        //menu clicks
        #region
        private void studentButton_Click(object sender, EventArgs e)
        {
            studentDatabase studentDatabase = new studentDatabase(userlocal, typelocal);
            Hide();
            studentDatabase.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginDatabase loginDatabase = new loginDatabase(userlocal, typelocal);
            Hide();
            loginDatabase.Show();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal);
            Hide();
            deviceDatabase.Show();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            accountsDatabase accountsDatabase = new accountsDatabase(userlocal, typelocal);
            Hide();
            accountsDatabase.Show();
        }
        #endregion

     
    }
}
