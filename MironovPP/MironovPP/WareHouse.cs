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

namespace MironovPP
{
    public partial class WareHouse : Form
    {

        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
        public WareHouse()
        {
            InitializeComponent();
        }

        private void CheckWarehouse_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Склад";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewWarehouse.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string detailNumber = DetailNumber.Text;
                string query = "SELECT * FROM Склад WHERE IDDetails = @DetailNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Добавляем параметр для номера детали
                        command.Parameters.AddWithValue("@DetailNumber", detailNumber);

                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewWarehouse.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Specialist specialist = new Specialist();
            specialist.Show();
            this.Close();
        }
    }
}
