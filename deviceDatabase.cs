using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despro
{
    public partial class deviceDatabase : Form
    {
        public string userlocal = "",typelocal = "", menulocal = "";
        public DataTable dtlocal = new DataTable();

        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True;"); // making connection   
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
            dtlocal.Reset();
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
            dtlocal.Merge(dt);
        }
        public void callLogins()
        {
            dtlocal.Reset();
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
            dtlocal.Merge(dt);

        }
        public void callAdmins()
        {
            dtlocal.Reset();
            DataTable dt = new DataTable();
            string sqlstring = "SELECT * FROM dbo.admin";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            sda.Fill(dt);

            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Userame";
            dt.Columns[2].ColumnName = "Password";
            dt.Columns[3].ColumnName = "User Type";
            deviceGrid.DataSource = dt;
            dtlocal.Merge(dt);

        }
        public void callStudents()
        {
            dtlocal.Reset();
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
            dtlocal.Merge(dt);

        }
        #endregion
        //menu clicks
        #region
        private void studentButton_Click(object sender, EventArgs e)
        {

            callStudents();
            menulocal = "students";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            callLogins();
            menulocal = "logins";
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            callDevices();
            menulocal = "devices";
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            callAdmins();
            menulocal = "accounts";
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "CSV File|*.csv";
            savefile.ShowDialog();
            try
            {
                dtlocal.ToCSV(savefile.FileName);
            }
            catch
            {

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
    public static class CSVUtlity
    {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false, Encoding.UTF8);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
