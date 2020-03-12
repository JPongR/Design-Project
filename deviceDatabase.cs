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
        public string userlocal = "",typelocal = "", menulocal = "";
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
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
            menulocal = menuSelect;
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



            //which table
            #region
            if (menuSelect == "devices")
            {
                callDevices();
            }else if (menuSelect == "students")
            {
                callStudents();
            }
            else if(menuSelect == "logins")
            {
                callLogins();
            }
            else
            {
                callAdmins();
            }
            #endregion



        }
        //call tables
        #region
        public void callDevices ()
        {
           
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
        public void callLogins()
        {
            DataTable dt = new DataTable();
            string sqlstring = "SELECT * FROM dbo.login";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            sda.Fill(dt);

            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "First Name";
            dt.Columns[2].ColumnName = "Last Name";
            dt.Columns[3].ColumnName = "Middle Name";
            dt.Columns[4].ColumnName = "Student Number";
            dt.Columns[5].ColumnName = "Course";
            dt.Columns[6].ColumnName = "College";
            dt.Columns[7].ColumnName = "Date";
            dt.Columns[8].ColumnName = "Time In";
            dt.Columns[9].ColumnName = "Entry Point";
            dt.Columns[10].ColumnName = "Time Out";
            dt.Columns[11].ColumnName = "Exit Point";
            dt.Columns[12].ColumnName = "Bus Location Exit Point";
            deviceGrid.DataSource = dt;
        }
        public void callAdmins()
        {
            DataTable dt = new DataTable();
            string sqlstring = "SELECT * FROM dbo.admin";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            sda.Fill(dt);

            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Userame";
            dt.Columns[2].ColumnName = "Password";
            dt.Columns[3].ColumnName = "User Type";
            deviceGrid.DataSource = dt;
        }
        public void callStudents()
        {
            DataTable dt = new DataTable();
            string sqlstring = "SELECT * FROM dbo.students";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            sda.Fill(dt);

            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Last Name";
            dt.Columns[2].ColumnName = "First Name";
            dt.Columns[3].ColumnName = "Middle Name";
            dt.Columns[4].ColumnName = "Student Number";
            dt.Columns[5].ColumnName = "Course";
            dt.Columns[6].ColumnName = "College";
            dt.Columns[7].ColumnName = "RFID Tag";
            dt.Columns[8].ColumnName = "Last Entry Point";
            dt.Columns[9].ColumnName = "Last Exit Point";
            deviceGrid.DataSource = dt;
        }
        #endregion
        //menu clicks
        #region
        private void studentButton_Click(object sender, EventArgs e)
        {

            callStudents();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            callLogins();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            callDevices();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            callAdmins();
        }


        #endregion

      

        private void addButton_Click(object sender, EventArgs e)
        {
            if (menulocal == "devices")
            {
                accessDevice accessDevice = new accessDevice(userlocal, typelocal, "add");
                Hide();
                accessDevice.Show();
            }else if (menulocal == "students")
            {
                accessStudents accessStudents = new accessStudents(userlocal, typelocal, "add");
                Hide();
                accessStudents.Show();

            }
            else if (menulocal == "logins")
            {
                accessLogin accessLogin = new accessLogin(userlocal, typelocal, "add");
                Hide();
                accessLogin.Show();
            }
            else
            {
                accessAccounts accessAccounts = new accessAccounts(userlocal, typelocal, "add");
                Hide();
                accessAccounts.Show();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (menulocal == "devices")
            {
                accessDevice accessDevice = new accessDevice(userlocal, typelocal,"edit");
            Hide();
            accessDevice.Show();
            }else if (menulocal == "students")
            {
                accessStudents accessStudents = new accessStudents(userlocal, typelocal, "edit");
                Hide();
                accessStudents.Show();
            }
            else if (menulocal == "logins")
            {
                accessLogin accessLogin = new accessLogin(userlocal, typelocal, "edit");
                Hide();
                accessLogin.Show();
            }
            else
            {
                accessAccounts accessAccounts = new accessAccounts(userlocal, typelocal, "edit");
                Hide();
                accessAccounts.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (menulocal == "devices")
            {
                accessDevice accessDevice = new accessDevice(userlocal, typelocal, "delete");
            Hide();
            accessDevice.Show();
            }else if (menulocal == "students")
            {
                accessStudents accessStudents = new accessStudents(userlocal, typelocal, "delete");
                Hide();
                accessStudents.Show();
            }
            else if (menulocal == "logins")
            {
                accessLogin accessLogin = new accessLogin(userlocal, typelocal, "delete");
                Hide();
                accessLogin.Show();
            }
            else
            {
                accessAccounts accessAccounts = new accessAccounts(userlocal, typelocal, "delete");
                Hide();
                accessAccounts.Show();
            }
        }
    }
}
