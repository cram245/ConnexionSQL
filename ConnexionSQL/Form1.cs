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

namespace ConnexionSQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            butDisconnect.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data source= 200.234.224.123,54321;" +
                "Initial Catalog= MarcAlbaEmployees;" +
                "User ID=sa;" +
                "Password = Sql#123456789;";

            try {

                connection = new SqlConnection(connectionString);
                connection.Open();
                butConnect.Enabled = false;
                butDisconnect.Enabled = true;
                connectionState.Text = connection.State.ToString();
                


            }
            catch (Exception error) { 
                MessageBox.Show(error.Message);
            }
        }

        private void butDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connectionState.Text = connection.State.ToString();
                butDisconnect.Enabled = false;
                butConnect.Enabled = true;
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }
    }
}
