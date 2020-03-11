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
    public partial class deviceDatabase : Form
    {
        public string userlocal = "";
        public string typelocal = "";
        public deviceDatabase(string user, string type, string menuSelect)
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

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
            DataTable dt = new DataTable();


            string sqlstring = "SELECT * FROM dbo.devices";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            sda.Fill(dt);
  
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Device Name";
            dt.Columns[2].ColumnName = "RFID Tag";
            dt.Columns[3].ColumnName = "Owner";
            dt.Columns[4].ColumnName = "Allowed User 1";
            dt.Columns[5].ColumnName = "Allowed User 2";
            dt.Columns[6].ColumnName = "Allowed User 3";
            dt.Columns[7].ColumnName = "Allowed User 4";
            dt.Columns[8].ColumnName = "Allowed User 5";
         
            deviceGrid.DataSource = dt;

        }

        //menu clicks
        #region
        private void studentButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "students");
            Hide();
            deviceDatabase.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "logins");
            Hide();
            deviceDatabase.Show();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "devices");
            Hide();
            deviceDatabase.Show();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "accounts");
            Hide();
            deviceDatabase.Show();
        }


        #endregion

      

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
