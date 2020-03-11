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
    public partial class accessDevice : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Despro.mdf;Integrated Security=True"); // making connection   
        public string userlocal = "";
        public string typelocal = "";
        public string access, sqlstring;
        public accessDevice(string user, string type, string accesslocal)
        {
            InitializeComponent();
            userlocal = user;
            typelocal = type;
            access = accesslocal;
            rfidBox.ReadOnly = false;
            ownerBox.ReadOnly = false;
            allowed1Box.ReadOnly = false;
            allowed2Box.ReadOnly = false;
            allowed3Box.ReadOnly = false;
            allowed4Box.ReadOnly = false;
            allowed5Box.ReadOnly = false;
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
                deviceBox.ReadOnly = true;
                rfidBox.ReadOnly = true;
                ownerBox.ReadOnly = true;
                allowed1Box.ReadOnly = true;
                allowed2Box.ReadOnly = true;
                allowed3Box.ReadOnly = true;
                allowed4Box.ReadOnly = true;
                allowed5Box.ReadOnly = true;

            }


        }

        private void button1_Click(object sender, EventArgs e) //backbutton
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal, "devices");
            Hide();
            deviceDatabase.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.devices WHERE id = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                idLabel.Text = dt.Rows[0][0].ToString();
                deviceBox.Text = dt.Rows[0][1].ToString();
                rfidBox.Text = dt.Rows[0][2].ToString();
                ownerBox.Text = dt.Rows[0][3].ToString();
                allowed1Box.Text = dt.Rows[0][4].ToString();
                allowed2Box.Text = dt.Rows[0][5].ToString();
                allowed3Box.Text = dt.Rows[0][6].ToString();
                allowed4Box.Text = dt.Rows[0][7].ToString();
                allowed5Box.Text = dt.Rows[0][8].ToString();
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
            deviceBox.Text = "";
            rfidBox.Text = "";
            ownerBox.Text = "";
            allowed1Box.Text = "";
            allowed2Box.Text = "";
            allowed3Box.Text = "";
            allowed4Box.Text = "";
            allowed5Box.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (access == "add")
            {
               sqlstring = "INSERT INTO dbo.devices (deviceName,rfidTag,owner,allowedUser1,allowedUser2,allowedUser3,allowedUser4,allowedUser5) VALUES('"+deviceBox.Text+"','"+rfidBox.Text+"','"+ownerBox.Text+"','"+allowed1Box.Text+ "','" + allowed2Box.Text + "','" + allowed3Box.Text + "','" + allowed4Box.Text + "','" + allowed5Box.Text + "')";                       
            }
            else if (access == "edit")
            {
                sqlstring = "UPDATE dbo.devices set deviceName = '" + deviceBox.Text + "', rfidTag = '"+rfidBox.Text+"', owner = '"+ownerBox.Text+"', allowedUser1 = '"+allowed1Box.Text+ "', allowedUser2 = '" + allowed2Box.Text + "', allowedUser3 = '" + allowed3Box.Text + "', allowedUser4 = '" + allowed4Box.Text + "', allowedUser5 = '" + allowed5Box.Text + "' WHERE id = '"+idLabel.Text+"'";

            }else //delete
            {
                sqlstring = "DELETE FROM dbo.devices WHERE id = '" + idLabel.Text + "'";
            }
            SqlCommand sda = new SqlCommand(sqlstring, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Succesfull");
            clear();
        }
    }
}
