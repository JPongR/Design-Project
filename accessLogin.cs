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
    public partial class accessLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
        public string userlocal = "";
        public string typelocal = "";
        public string access, sqlstring;
        public accessLogin(string user, string type, string accesslocal)
        {
            InitializeComponent();
            userlocal = user;
            typelocal = type;
            access = accesslocal;
            lastNameBox.ReadOnly = false;
            firstNameBox.ReadOnly = false;
            middleNameBox.ReadOnly = false;
            studentNumberBox.ReadOnly = false;
            collegeBox.ReadOnly = false;
            courseBox.ReadOnly = false;
            rfidBox.ReadOnly = false;
            entryBox.ReadOnly = false;
            exitBox.ReadOnly = false;
            dateBox.ReadOnly = false;
            entrancePointBox.ReadOnly = false;
            exitPointBox.ReadOnly = false;
            gpsBox.ReadOnly = false;
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
                lastNameBox.ReadOnly = true;
                firstNameBox.ReadOnly = true;
                middleNameBox.ReadOnly = true;
                studentNumberBox.ReadOnly = true;
                collegeBox.ReadOnly = true;
                courseBox.ReadOnly = true;
                rfidBox.ReadOnly = true;
                entryBox.ReadOnly = true;
                exitBox.ReadOnly = true;
                dateBox.ReadOnly = true;
                entrancePointBox.ReadOnly = true;
                exitPointBox.ReadOnly = true;
                gpsBox.ReadOnly = true;

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.login WHERE id = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                idLabel.Text = dt.Rows[0][0].ToString();
                firstNameBox.Text = dt.Rows[0][1].ToString();
                lastNameBox.Text = dt.Rows[0][2].ToString();
                middleNameBox.Text = dt.Rows[0][3].ToString();
                courseBox.Text = dt.Rows[0][4].ToString();
                collegeBox.Text = dt.Rows[0][5].ToString();
                dateBox.Text = dt.Rows[0][6].ToString();
                entryBox.Text = dt.Rows[0][7].ToString();
                entrancePointBox.Text = dt.Rows[0][8].ToString();
                exitBox.Text = dt.Rows[0][9].ToString();
                exitPointBox.Text = dt.Rows[0][10].ToString();
                gpsBox.Text = dt.Rows[0][11].ToString();
                rfidBox.Text = dt.Rows[0][12].ToString();
                clearButton.Enabled = true;

            }
            catch (Exception en)
            {
                MessageBox.Show("No matching record found.");
                Console.WriteLine(en.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            clearButton.Enabled = false;
        }
        public void clear()
        {
            idLabel.Text = "";
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            middleNameBox.Text = "";
            studentNumberBox.Text = "";
            courseBox.Text = "";
            collegeBox.Text = "";
            dateBox.Text = "";
            entryBox.Text = "";
            entrancePointBox.Text = "";
            exitBox.Text = "";
            exitPointBox.Text = "";
            gpsBox.Text = "";
            rfidBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (access == "add")
            {
                sqlstring = "INSERT INTO dbo.login (givenName,lastName,middleName,studentNumber,course,college,date,timeIn,entrancePoint,timeOut,exitPoint,location,rfid) VALUES('" + firstNameBox.Text + "','" + lastNameBox.Text + "','" + middleNameBox.Text + "','" + studentNumberBox.Text + "','" + courseBox.Text + "','" + collegeBox.Text + "','" + dateBox.Text + "','" + entryBox.Text + "','"+ entrancePointBox.Text+"','"+ exitBox.Text +"','"+ exitPointBox.Text+ "','"+ gpsBox.Text +"', '"+ rfidBox.Text +"')";
            }
            else if (access == "edit")
            {
                sqlstring = "UPDATE dbo.login SET givenName = '" + firstNameBox.Text + "', lastName = '" + lastNameBox.Text + "', middleName = '" + middleNameBox.Text + "', studentNumber = '" + studentNumberBox.Text + "', course = '" + courseBox.Text + "', college = '" + collegeBox.Text + "', date = '" + dateBox.Text + "', timeIn = '" + entryBox.Text + "', entrancePoint = '"+entrancePointBox.Text+"',timeOut = '"+exitBox.Text+"',exitPoint = '"+exitPointBox.Text+"', location = '"+gpsBox.Text+"', rfid = '"+rfidBox.Text+"' WHERE id = '" + idLabel.Text + "'";

            }
            else //delete
            {
                sqlstring = "DELETE FROM dbo.login WHERE id = '" + idLabel.Text + "'";
            }
            SqlCommand sda = new SqlCommand(sqlstring, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Succesfull");
            clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "logins");
            Hide();
            deviceDatabase.Show();
        }


    }
}
