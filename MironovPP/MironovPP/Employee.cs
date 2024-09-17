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
    public partial class Employee : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
        public Employee()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Сотрудники";
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
                        dataGridViewEmployee.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string fio = FIO.Text;
            int age;
            bool isAgeValid = int.TryParse(Age.Text, out age);
            string phone = Phone.Text;

            if (!isAgeValid)
            {
                MessageBox.Show("Возраст должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";

            // SQL-запрос для вставки данных
            string query = "INSERT INTO Сотрудники (ФИО, Возраст, Телефон) VALUES (@FIO, @Age, @Phone)";

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
                        command.Parameters.AddWithValue("@FIO", fio);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Phone", phone);

                        // Выполнение команды
                        int result = command.ExecuteNonQuery();

                        // Проверка успешности выполнения
                        if (result > 0)
                        {
                            MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            int idEmployee;
            bool isIdValid = int.TryParse(IDEmployee.Text, out idEmployee);

            if (!isIdValid)
            {
                MessageBox.Show("ID сотрудника должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
            // SQL-запрос для удаления записи
            string query = "DELETE FROM Сотрудники WHERE IDEmployer = @IDEmployee";

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
                        // Добавление параметра ID сотрудника
                        command.Parameters.AddWithValue("@IDEmployee", idEmployee);

                        // Выполнение команды
                        int result = command.ExecuteNonQuery();

                        // Проверка успешности выполнения
                        if (result > 0)
                        {
                            MessageBox.Show("Сотрудник успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Сотрудник с таким ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Close_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
    }
