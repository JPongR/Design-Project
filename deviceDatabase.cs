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
    public partial class deviceDatabase : Form
    {
        public string userlocal = "";
        public string typelocal = "";
        public deviceDatabase(string user, string type)
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

        private void deviceDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desproDataSet.deviceAithorization' table. You can move, or remove it, as needed.
            this.deviceAithorizationTableAdapter.Fill(this.desproDataSet.deviceAithorization);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            accessDevice accessDevice = new accessDevice(userlocal, typelocal, "add");
            Hide();
            accessDevice.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            accessDevice accessDevice = new accessDevice(userlocal, typelocal,"edit");
            Hide();
            accessDevice.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            accessDevice accessDevice = new accessDevice(userlocal, typelocal, "delete");
            Hide();
            accessDevice.Show();
        }
    }
}
