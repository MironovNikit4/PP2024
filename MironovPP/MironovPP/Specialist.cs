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
    public partial class Specialist : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
        public Specialist()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Warehouse_Click(object sender, EventArgs e)
        {
            WareHouse warehouse = new WareHouse();
            warehouse.Show();
            this.Close();

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

        private void AcceptRequest_Click(object sender, EventArgs e)
        {
            string requestId = IDRequest.Text.Trim();
            string detailNumber = DetailNumber.Text.Trim();
            string detailKolvoText = DetailKolvo.Text.Trim();

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(requestId) || string.IsNullOrEmpty(detailNumber) || string.IsNullOrEmpty(detailKolvoText))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Проверяем, что количество деталей является числом
            if (!int.TryParse(detailKolvoText, out int detailKolvo))
            {
                MessageBox.Show("Введите корректное количество деталей.");
                return;
            }

            // Выполняем запрос к базе данных
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверяем, существует ли заявка с таким ID
                    string checkRequestQuery = "SELECT COUNT(*) FROM Заявки WHERE IDRequest = @idRequest";
                    using (SqlCommand checkRequestCommand = new SqlCommand(checkRequestQuery, connection))
                    {
                        checkRequestCommand.Parameters.AddWithValue("@idRequest", requestId);
                        int requestCount = (int)checkRequestCommand.ExecuteScalar();

                        if (requestCount == 0)
                        {
                            MessageBox.Show("Заявка с таким ID не найдена.");
                            return;
                        }
                    }

                    // Проверяем, есть ли достаточно деталей на складе
                    string checkStockQuery = "SELECT Количество FROM Склад WHERE IDDetails = @detailNumber";
                    using (SqlCommand checkStockCommand = new SqlCommand(checkStockQuery, connection))
                    {
                        checkStockCommand.Parameters.AddWithValue("@detailNumber", detailNumber);
                        object stockObj = checkStockCommand.ExecuteScalar();

                        if (stockObj == null)
                        {
                            MessageBox.Show("Деталь с таким номером не найдена.");
                            return;
                        }

                        int stockQuantity = (int)stockObj;

                        if (stockQuantity < detailKolvo)
                        {
                            MessageBox.Show("Недостаточно деталей на складе.");
                            return;
                        }

                        // Обновляем количество деталей на складе
                        string updateStockQuery = "UPDATE Склад SET Количество = Количество - @detailKolvo WHERE IDDetails = @detailNumber";
                        using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection))
                        {
                            updateStockCommand.Parameters.AddWithValue("@detailKolvo", detailKolvo);
                            updateStockCommand.Parameters.AddWithValue("@detailNumber", detailNumber);
                            updateStockCommand.ExecuteNonQuery();
                        }

                        // Обновляем статус заявки на "Принята"
                        string updateRequestQuery = "UPDATE Заявки SET Статус = @status WHERE IDRequest = @idRequest";
                        using (SqlCommand updateRequestCommand = new SqlCommand(updateRequestQuery, connection))
                        {
                            updateRequestCommand.Parameters.AddWithValue("@status", "Принята");
                            updateRequestCommand.Parameters.AddWithValue("@idRequest", requestId);
                            updateRequestCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Заявка принята и количество деталей на складе обновлено.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void DeclineRequest_Click(object sender, EventArgs e)
        {
            string requestId = IDRequest.Text.Trim();

            // Проверяем, что ID не пустой
            if (string.IsNullOrEmpty(requestId))
            {
                MessageBox.Show("Введите ID заявки.");
                return;
            }

            // Выполняем запрос к базе данных
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Создаем команду для обновления статуса заявки
                    string query = "UPDATE Заявки SET Статус = @status WHERE IDRequest = @idRequest";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем параметры
                        command.Parameters.AddWithValue("@status", "Отклонено");
                        command.Parameters.AddWithValue("@idRequest", requestId);

                        // Выполняем команду
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Статус заявки успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Заявка с таким ID не найдена.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
