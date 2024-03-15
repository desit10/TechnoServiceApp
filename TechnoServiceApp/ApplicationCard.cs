using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoServiceApp
{
    public partial class ApplicationCard : UserControl
    {
        DataBase db = new DataBase();
        int? roleUser {  get; set; }
        int number { get; set; }
        string client { get; set; }
        string staff { get; set; }
        string date { get; set; }
        string telephoneClient { get; set; }
        string telephoneStaff { get; set; }
        string hardware { get; set; }
        string typeFault { get; set; }
        string descProblem { get; set; }
        string state { get; set; }


        public ApplicationCard(int? roleUser, int number, string client, string staff, string date, string telephoneClient, string telephoneStaff, string hardware, string typeFault, string descProblem, string state)
        {
            InitializeComponent();

            this.roleUser = roleUser;
            this.number = number;
            this.client = client;
            this.staff = staff;
            this.date = date;
            this.telephoneClient = telephoneClient;
            this.telephoneStaff = telephoneStaff;
            this.hardware = hardware;
            this.typeFault = typeFault;
            this.descProblem = descProblem;
            this.state = state;

            comboBoxStaffs.Text = staff;
            comboBoxState.Text = state;

            if (roleUser == 3)
            {
                comboBoxStaffs.Enabled = false;
            }
            if(roleUser == 4)
            {
                comboBoxStaffs.Enabled = false;
                comboBoxState.Enabled = false;
            }

            comboBoxStaffs.Text = staff;
            labelNumber.Text = "Номер заявки " + number.ToString();
            labelDate.Text = "Дата заявки " + date;
            labelClient.Text = "Клиент: " + client;
            labelTelephoneClient.Text = "Телефон клиента: " + telephoneClient;
            labelTelephoneStaff.Text = "Телефон работника: " + telephoneStaff;
            labelHardware.Text = "Оборудование, требующее ремонта: " + hardware;
            labelTypeFault.Text = "Тип неисправности: " + typeFault;
            richTextBoxDecsProblem.Text = descProblem;

            db.openConnection();

            NpgsqlCommand getStaffs = new NpgsqlCommand($"SELECT surname, name, patronymic FROM staffs INNER JOIN users ON staffs.id_users = users.id WHERE users.id_role = 3", db.getConnection());
            
            NpgsqlDataReader readerStaffs = getStaffs.ExecuteReader();

            while (readerStaffs.Read())
            {
                comboBoxStaffs.Items.Add($"{readerStaffs.GetString(0)} {readerStaffs.GetString(1)} {readerStaffs.GetString(2)}");
            }

            db.closeConnection();
        }

        private void richTextBoxDecsProblem_KeyUp(object sender, KeyEventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateProblem = new NpgsqlCommand($"UPDATE applications SET desc_problem = '{richTextBoxDecsProblem.Text}' WHERE id = {number}", db.getConnection());
            updateProblem.ExecuteNonQuery();

            db.closeConnection();
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateState = new NpgsqlCommand($"UPDATE applications SET state = '{comboBoxState.SelectedItem}' WHERE id = {number}", db.getConnection());
            updateState.ExecuteNonQuery();

            db.closeConnection();
        }

        private void comboBoxStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();

            string[] arrayStaff = comboBoxStaffs.SelectedItem.ToString().Split(' ');

            NpgsqlCommand getIdStaff = new NpgsqlCommand($"SELECT id FROM staffs WHERE surname = '{arrayStaff[0]}' AND name = '{arrayStaff[1]}' AND patronymic = '{arrayStaff[2]}'", db.getConnection());
            int idStaff = (int)getIdStaff.ExecuteScalar();

            NpgsqlCommand updateStaff = new NpgsqlCommand($"UPDATE applications SET id_staff = {idStaff} WHERE id = {number}", db.getConnection());
            updateStaff.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
