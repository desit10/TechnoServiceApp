using System;
using System.Windows.Forms;
using Npgsql;

namespace TechnoServiceApp
{
    public partial class FormMain : Form
    {
        DataBase db = new DataBase();
        int? roleUser {  get; set; }
        string login { get; set; }
        public FormMain(int? roleUser, string login)
        {
            InitializeComponent();

            this.roleUser = roleUser;
            this.login = login;

            switch(roleUser)
            {
                case 1:
                    showApplicationsCard("");
                    break;
                case 2:
                    showApplicationsCard("");
                    break;
                case 3:
                    showApplicationsCard("");

                    btnCreateApplication.Enabled = false;
                    btnCreateApplication.Hide();
                    btnMetric.Enabled = false;
                    btnMetric.Hide();
                    break;
                case 4:
                    showApplicationsCard("");

                    btnMetric.Enabled = false;
                    btnMetric.Hide();
                    break;                
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form formAuth = new FormAuth();
            formAuth.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            Form formCreateApplications = new FormCreateApplication(roleUser, login);

            if (formCreateApplications.ShowDialog() == DialogResult.OK)
            {
                showApplicationsCard("");
            }
        }

        private void showApplicationsCard(string filtr)
        {
            flowLayoutPanelApplications.Controls.Clear();

            db.openConnection();

            string cmd = "";
            switch (roleUser)
            {
                case 1:
                    cmd = $"SELECT " +
                        $"applications.id, applications.date, applications.hardware, applications.type_of_fault, applications.desc_problem, applications.state," +
                        $"clients.surname, clients.\"name\", clients.patronymic, clients.telephone, " +
                        $"staffs.surname, staffs.\"name\", staffs.patronymic, staffs.telephone " +
                        $"FROM applications " +
                        $"INNER JOIN clients ON applications.id_client = clients.id " +
                        $"LEFT JOIN staffs ON applications.id_staff = staffs.id " + filtr;
                    break;
                case 2:
                    cmd = $"SELECT " +
                        $"applications.id, applications.date, applications.hardware, applications.type_of_fault, applications.desc_problem, applications.state," +
                        $"clients.surname, clients.\"name\", clients.patronymic, clients.telephone, " +
                        $"staffs.surname, staffs.\"name\", staffs.patronymic, staffs.telephone " +
                        $"FROM applications " +
                        $"INNER JOIN clients ON applications.id_client = clients.id " +
                        $"LEFT JOIN staffs ON applications.id_staff = staffs.id " + filtr;
                    break;
                case 3:
                    NpgsqlCommand getStaffId = new NpgsqlCommand($"SELECT staffs.id FROM staffs INNER JOIN users ON staffs.id_users = users.id WHERE users.login = '{login}'", db.getConnection());
                    int idStaff = (int)getStaffId.ExecuteScalar();                                     

                    cmd = $"SELECT " +
                        $"applications.id, applications.date, applications.hardware, applications.type_of_fault, applications.desc_problem, applications.state," +
                        $"clients.surname, clients.\"name\", clients.patronymic, clients.telephone, " +
                        $"staffs.surname, staffs.\"name\", staffs.patronymic, staffs.telephone " +
                        $"FROM applications " +
                        $"INNER JOIN clients ON applications.id_client = clients.id " +
                        $"INNER JOIN staffs ON applications.id_staff = staffs.id WHERE staffs.id = {idStaff} " + filtr;
                    break;
                case 4:
                    NpgsqlCommand getClientId = new NpgsqlCommand($"SELECT clients.id FROM clients INNER JOIN users ON clients.id_users = users.id WHERE users.login = '{login}'", db.getConnection());
                    int idClient = (int)getClientId.ExecuteScalar();

                    cmd = $"SELECT " +
                        $"applications.id, applications.date, applications.hardware, applications.type_of_fault, applications.desc_problem, applications.state," +
                        $"clients.surname, clients.\"name\", clients.patronymic, clients.telephone, " +
                        $"staffs.surname, staffs.\"name\", staffs.patronymic, staffs.telephone " +
                        $"FROM applications " +
                        $"INNER JOIN clients ON applications.id_client = clients.id " +
                        $"LEFT JOIN staffs ON applications.id_staff = staffs.id WHERE clients.id = {idClient} " + filtr;
                    break;

            }

            NpgsqlCommand getApplications = new NpgsqlCommand(cmd, db.getConnection());

            NpgsqlDataReader readerApplications = getApplications.ExecuteReader();

            while(readerApplications.Read())
            {
                if (!readerApplications.IsDBNull(0))
                {
                    int id = readerApplications.GetInt32(0);
                    string date = readerApplications.GetDateTime(1).ToString("dd.mm.yyyy");
                    string hardware = readerApplications.GetString(2);
                    string typeFault = readerApplications.GetString(3);
                    string descProblem = readerApplications.GetString(4);
                    string state = readerApplications.GetString(5);
                    string client = $"{readerApplications.GetString(6)} {readerApplications.GetString(7)} {readerApplications.GetString(8)}";
                    string telephoneClient = readerApplications.GetString(9);
                    string staff;
                    string telephoneStaff;
                    if (!readerApplications.IsDBNull(10))
                    {
                        staff = $"{readerApplications.GetString(10)} {readerApplications.GetString(11)} {readerApplications.GetString(12)}";
                        telephoneStaff = readerApplications.GetString(13);
                    }
                    else
                    {
                        staff = "";
                        telephoneStaff = "";
                    }

                    ApplicationCard applicationCard = new ApplicationCard(roleUser, id, client, staff, date, telephoneClient, telephoneStaff, hardware, typeFault, descProblem, state);

                    flowLayoutPanelApplications.Controls.Add(applicationCard);
                }
            }

            db.closeConnection();
        }

        private void btnMetric_Click(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand getCountInWaiting = new NpgsqlCommand("SELECT COUNT(id) FROM applications WHERE state = 'В ожидании'", db.getConnection());
            NpgsqlCommand getCountAtWork = new NpgsqlCommand("SELECT COUNT(id) FROM applications WHERE state = 'В работе'", db.getConnection());
            NpgsqlCommand getCountCompleted = new NpgsqlCommand("SELECT COUNT(id) FROM applications WHERE state = 'Выполнена'", db.getConnection());
            NpgsqlCommand getCountNotCompleted = new NpgsqlCommand("SELECT COUNT(id) FROM applications WHERE state = 'Не выполнена'", db.getConnection());

            MessageBox.Show(
                $"Заявок в ожидании: {(long)getCountInWaiting.ExecuteScalar()}\n" +
                $"Заявок в работе: {(long)getCountAtWork.ExecuteScalar()}\n" +
                $"Заявок выполено: {(long)getCountCompleted.ExecuteScalar()}\n" +
                $"Заявок не выполнено: {(long)getCountNotCompleted.ExecuteScalar()}"
                );

            db.closeConnection();
        }

        private void textBoxFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFind.Text))
            {
                showApplicationsCard($"");
            }
            else
            {
                try
                {
                    showApplicationsCard($"WHERE applications.id = {textBoxFind.Text}");
                }
                catch
                {
                    showApplicationsCard($"WHERE applications.hardware LIKE '%{textBoxFind.Text}%'");
                }
            }
        }
    }
}
