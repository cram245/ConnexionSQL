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
                butConnect.Enabled = false;
                connection = new SqlConnection(connectionString);
                connection.Open();
                
                butDisconnect.Enabled = true;
                connectionState.Text = connection.State.ToString();
            }
            catch (Exception error) {
                butConnect.Enabled = true;
                butDisconnect.Enabled = false;
                MessageBox.Show(error.Message);
            }
        }

        private void butDisconnect_Click(object sender, EventArgs e)
        {

            try 
            {
                if (connection.State != ConnectionState.Open)
                {
                    return;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            try
            {
                butDisconnect.Enabled = false;
                connection.Close();
                connectionState.Text = connection.State.ToString();
                
                butConnect.Enabled = true;
            }
            catch (Exception error) {
                butDisconnect.Enabled = true;
                butConnect.Enabled = false;
                MessageBox.Show(error.Message);
            }
        }

        private void buttExecute_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(textBox1.Text, connection);

            command.ExecuteNonQuery();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Crear un DataTable para almacenar los resultados.
                DataTable dataTable = new DataTable();

                // Carga los datos del lector en el DataTable.
                dataTable.Load(reader);

                // Establecer el DataTable como origen de datos del DataGridView.
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
