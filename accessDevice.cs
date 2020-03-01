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
    public partial class accessDevice : Form
    {
        public string userlocal = "";
        public string typelocal = "";
        public accessDevice(string user, string type, string access)
        {
            InitializeComponent();
            userlocal = user;
            typelocal = type;
            if (access == "add" )
                saveButton.Text = "ADD";
            else if (access == "edit")
                saveButton.Text = "SAVE";
            else
                saveButton.Text = "DELETE";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            deviceDatabase deviceDatabase = new deviceDatabase(userlocal, typelocal);
            Hide();
            deviceDatabase.Show();
        }
    }
}
