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
    public partial class accessStudents : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
        public string userlocal = "";
        public string typelocal = "";
        public string access, sqlstring;

        private void backButton_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "students");
            Hide();
            deviceDatabase.Show();
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
            entryBox.Text = "";
            exitBox.Text = "";
            rfidBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            clearButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.students WHERE id = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                idLabel.Text = dt.Rows[0][0].ToString();
                firstNameBox.Text = dt.Rows[0][2].ToString();
                lastNameBox.Text = dt.Rows[0][1].ToString();
                middleNameBox.Text = dt.Rows[0][3].ToString();
                courseBox.Text = dt.Rows[0][5].ToString();
                studentNumberBox.Text = dt.Rows[0][4].ToString();
                collegeBox.Text = dt.Rows[0][6].ToString();
                entryBox.Text = dt.Rows[0][8].ToString();
                exitBox.Text = dt.Rows[0][9].ToString();
                rfidBox.Text = dt.Rows[0][7].ToString();
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
                sqlstring = "INSERT INTO dbo.students (firstName,lastName,middleName,studentNumber,course,college,lastEntry,lastExit,rfidTag) VALUES('" + firstNameBox.Text + "','" + lastNameBox.Text + "','" + middleNameBox.Text + "','" + studentNumberBox.Text + "','" + courseBox.Text + "','" + collegeBox.Text + "','" + entryBox.Text + "','" + exitBox.Text + "', '" + rfidBox.Text + "')";
            }
            else if (access == "edit")
            {
                sqlstring = "UPDATE dbo.students SET firstName = '" + firstNameBox.Text + "', lastName = '" + lastNameBox.Text + "', middleName = '" + middleNameBox.Text + "', studentNumber = '" + studentNumberBox.Text + "', course = '" + courseBox.Text + "', college = '" + collegeBox.Text + "', lastEntry = '" + entryBox.Text + "', lastExit = '" + exitBox.Text + "', rfidTag = '" + rfidBox.Text + "' WHERE id = '" + idLabel.Text + "'";

            }
            else //delete
            {
                sqlstring = "DELETE FROM dbo.students WHERE id = '" + idLabel.Text + "'";
            }
            SqlCommand sda = new SqlCommand(sqlstring, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Succesfull");
            clear();
        }

        public accessStudents(string user, string type, string accesslocal)
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

            }
        }
    }
}
