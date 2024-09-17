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
    public partial class Registration : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public Registration()
        {
            InitializeComponent();
            Password.TextChanged += Password_TextChanged;
            show.CheckedChanged += show_CheckedChanged;
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Close();
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            Password_TextChanged(sender, e);
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (!show.Checked)
            {
                Password.PasswordChar = '*';
            }
            else
            {
                Password.PasswordChar = '\0';
            }
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                if (IsLoginUnique(login))
                {
                    AddUserToDatabase(login, password);
                    MessageBox.Show("Успешная регистрация!");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Логин уже занят. Пожалуйста, введите другой логин.");
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль.");
            }
        }
        private bool IsLoginUnique(string login)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Data WHERE Login = @Login", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Login", login);

                int result = (int)sqlCommand.ExecuteScalar();

                return result == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void AddUserToDatabase(string login, string password)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Data (Login, Password) VALUES (@Login, @Password)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Login", login);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
