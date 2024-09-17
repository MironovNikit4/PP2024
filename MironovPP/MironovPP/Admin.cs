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
    public partial class Admin : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
        public Admin()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Заявки";
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
                        dataGridViewAdmin.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void AddSpecialist_Click(object sender, EventArgs e)
        {
            int idRequest;
            bool isIDValid = int.TryParse(IDRequest.Text, out idRequest);
            string selectedSpecialist = SpecialistList.SelectedItem?.ToString();

            if (!isIDValid)
            {
                MessageBox.Show("ID заявки должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectedSpecialist))
            {
                MessageBox.Show("Выберите специалиста из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";

            // SQL-запрос для обновления записи
            string query = "UPDATE Заявки SET Мастер = @Specialist WHERE IDRequest = @IDRequest";

            // Используем блок using для автоматического закрытия соединения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открытие соединения
                    connection.Open();

                    // Создание SQL-команды
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@Specialist", selectedSpecialist);
                        command.Parameters.AddWithValue("@IDRequest", idRequest);

                        // Выполнение команды
                        int result = command.ExecuteNonQuery();

                        // Проверка успешности выполнения
                        if (result > 0)
                        {
                            MessageBox.Show("Специалист успешно назначен на заявку!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при обновлении заявки. Проверьте, существует ли заявка с данным ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SpecialistManage_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
