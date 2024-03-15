using System;
using System.Windows.Forms;
using Npgsql;

namespace TechnoServiceApp
{
    public partial class FormCreateApplication : Form
    {
        DataBase db = new DataBase();
        int? roleUser {  get; set; }
        string login { get; set; }

        public FormCreateApplication(int? roleUser, string login)
        {
            InitializeComponent();

            this.roleUser = roleUser;
            this.login = login;

            btnBack.DialogResult = DialogResult.Cancel;
            btnCreate.DialogResult = DialogResult.OK;

            if(roleUser == 4)
            {
                labelClient.Hide();
                labelTelephoneClient.Hide();
                textBoxClient.Hide();
                maskedTextBoxTelephone.Hide();
                textBoxClient.Enabled = false;
                maskedTextBoxTelephone.Enabled = false;
            }
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string hardware = textBoxHardware.Text;
            string typeFault = textBoxTypeFault.Text;
            string descProblem = richTextBoxDescProblem.Text;
            string client = textBoxClient.Text;
            string telephone = maskedTextBoxTelephone.Text;

            if(String.IsNullOrEmpty(hardware))
            {
                MessageBox.Show("Заполните поле Оборудование.");

                return;
            }

            if (String.IsNullOrEmpty(typeFault))
            {
                MessageBox.Show("Заполните поле Тип неисправности.");

                return;
            }

            if (String.IsNullOrEmpty(descProblem))
            {
                MessageBox.Show("Заполните поле Описание проблемы.");

                return;
            }

            if (String.IsNullOrEmpty(client) && textBoxClient.Enabled == true)
            {
                MessageBox.Show("Заполните поле Клиент.");

                return;
            }

            if (telephone.Length != 18 && maskedTextBoxTelephone.Enabled == true)
            {
                MessageBox.Show("Заполните поле Номер телефона.");

                return;
            }

            db.openConnection();

            int idClient;
            if (roleUser == 4) 
            {
                NpgsqlCommand getClientId = new NpgsqlCommand($"SELECT clients.id FROM clients INNER JOIN users ON clients.id_users = users.id WHERE users.login = '{login}'" , db.getConnection());
                idClient = (int)getClientId.ExecuteScalar();

                NpgsqlCommand insertApplication = new NpgsqlCommand($"INSERT INTO applications " +
                    $"VALUES ({db.autoincriment("applications")}, '{DateTime.Now.Date}', '{hardware}', '{typeFault}', '{descProblem}', {idClient}, null, 'в ожидании')", db.getConnection());
                insertApplication.ExecuteNonQuery();
            }
            else
            {
                string[] arrayFIO = client.Split(' ');

                idClient = db.autoincriment("clients");
                NpgsqlCommand insertClient = new NpgsqlCommand($"INSERT INTO clients " +
                    $"VALUES ({idClient}, '{arrayFIO[0]}', '{arrayFIO[1]}', '{arrayFIO[2]}', '{telephone}')", db.getConnection());
                insertClient.ExecuteNonQuery();

                NpgsqlCommand insertApplication = new NpgsqlCommand($"INSERT INTO applications " +
                    $"VALUES ({db.autoincriment("applications")}, '{DateTime.Now.Date}', '{hardware}', '{typeFault}', '{descProblem}', {idClient}, null, 'в ожидании')", db.getConnection());
                insertApplication.ExecuteNonQuery();
            }

            db.closeConnection();

            MessageBox.Show("Заявка успешно создана.");

            this.Close();
        }        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
