using System;
using System.Windows.Forms;
using Npgsql;

namespace TechnoServiceApp
{
    public partial class FormReg : Form
    {
        DataBase db = new DataBase();

        public FormReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            db.openConnection();

            string FIO = textBoxFIO.Text;
            string telephone = textBoxTelephone.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(FIO))
            {
                MessageBox.Show("Заполните поле ФИО.");

                return;
            }

            if (telephone.Length != 18)
            {
                MessageBox.Show("Заполните поле Телефон.");

                return;
            }

            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Заполните поле Логин.");

                return;
            }

            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поле Пароль.");

                return;
            }

            db.openConnection();

            NpgsqlCommand checkUser = new NpgsqlCommand($"SELECT id FROM users WHERE login = '{login}'", db.getConnection());
            int? checkLogin = (int?)checkUser.ExecuteScalar();


            if(checkLogin == null)
            {
                int idUser = db.autoincriment("users");
                NpgsqlCommand insertUser = new NpgsqlCommand($"INSERT INTO users VALUES ({idUser}, '{login}', '{password}', 4)", db.getConnection());
                insertUser.ExecuteNonQuery();

                string[] ArrayFIO = FIO.Split(' ');

                NpgsqlCommand insertClient = new NpgsqlCommand($"INSERT INTO clients VALUES ({db.autoincriment("clients")},'{ArrayFIO[0]}', '{ArrayFIO[1]}', '{ArrayFIO[2]}', '{telephone}', {idUser})", db.getConnection());
                insertClient.ExecuteNonQuery();

                MessageBox.Show("Вы успешно зарегистрированы.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
            }

            db.closeConnection();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form formAuth = new FormAuth();
            formAuth.Show();
        }
    }
}
