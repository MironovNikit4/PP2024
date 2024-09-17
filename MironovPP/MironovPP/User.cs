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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            string fio = FIO.Text;
            string phone = Phone.Text;
            string markAuto = MarkAuto.Text;
            string modelAuto = ModelAuto.Text;
            string descriptionProblem = DescriptionProblem.Text;

            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";

            // SQL-запрос для вставки данных
            string query = "INSERT INTO Заявки (ФИО, Телефон, Марка, Модель, Описание) VALUES (@FIO, @Phone, @MarkAuto, @ModelAuto, @DescriptionProblem)";

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
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@MarkAuto", markAuto);
                        command.Parameters.AddWithValue("@ModelAuto", modelAuto);
                        command.Parameters.AddWithValue("@DescriptionProblem", descriptionProblem);

                        // Выполнение команды
                        int result = command.ExecuteNonQuery();

                        // Проверка успешности выполнения
                        if (result > 0)
                        {
                            MessageBox.Show("Заявка успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
