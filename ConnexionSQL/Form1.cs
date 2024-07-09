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
            CheckConnection();
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
                CheckConnection();
                
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
                connection.Close();
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            CheckConnection();
        }

        private void buttExecute_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(textBox1.Text, connection);
                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Crear un DataTable para almacenar los resultados.
                    DataTable dataTable = new DataTable();

                    // Carga los datos del lector en el DataTable.
                    dataTable.Load(reader);

                    string text = "Nombre de las columnas: \n";
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        text += col.ColumnName + "\n";
                    }
                    MessageBox.Show(text);

                    // Establecer el DataTable como origen de datos del DataGridView.
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckConnection()
        {
            if (connection == null)
            {
                butConnect.Enabled = true;
                butDisconnect.Enabled = false;
                buttExecute.Enabled = false;
                connectionState.Text = "Stand by";
                return;
            }

            switch (connection.State)
            {
                case ConnectionState.Open:
                    butConnect.Enabled = false;
                    butDisconnect.Enabled = true;
                    buttExecute.Enabled = true;
                    break;
                case ConnectionState.Closed:
                    butConnect.Enabled = true;
                    butDisconnect.Enabled = false;
                    buttExecute.Enabled = false;
                    break;
                case ConnectionState.Broken:
                    butConnect.Enabled = true;
                    butDisconnect.Enabled = false;
                    buttExecute.Enabled = false;
                    break;
                default:
                    butConnect.Enabled = false;
                    butDisconnect.Enabled = true;
                    buttExecute.Enabled = true;
                    break;
            }

            connectionState.Text = connection.State.ToString();
        }
    }
}
