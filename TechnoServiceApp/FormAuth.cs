using Npgsql;
using System;
using System.Windows.Forms;

namespace TechnoServiceApp
{
    public partial class FormAuth : Form
    {
        DataBase db = new DataBase();

        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин.");
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль.");
            }
            else
            {
                int? roleUser = null;
                string passwordUser = null;

                db.openConnection();

                NpgsqlCommand checkUser = new NpgsqlCommand(
                    $"SELECT password, id_role FROM users WHERE login = '{login}'", db.getConnection());

                NpgsqlDataReader reader = checkUser.ExecuteReader();
                if (reader.Read())
                {
                    passwordUser = reader.GetString(0);
                    roleUser = (int?)reader.GetInt32(1);
                }
                db.closeConnection();

                if (roleUser != null && passwordUser != null)
                {
                    if (passwordUser != password)
                    {   
                        MessageBox.Show("Не верный пароль.");
                    }

                    if (passwordUser == password)
                    {
                        Form formMain = new FormMain(roleUser, login);
                        this.Hide();
                        formMain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином не существует.");
                }

            }
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            this.Hide();
            formReg.Show();
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
