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

namespace FIOTask
{
    public partial class Fullname : Form
    {
        private const string loginQuery = "SELECT * FROM Peoples WHERE first_name='{0}' AND second_name='{1}'";
        private Database db;
        private string nameInput,
                       surnameInput,
                       dataSourceInput,
                       initCatalogInput;

        private void authButton_Click(object sender, EventArgs e)
        {
            nameInput = nameTextBox.Text;
            surnameInput = surnameTextBox.Text;

            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrEmpty(surnameInput))
            {
                MessageBox.Show("Ошибка", "Вы не заполнили все поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(
                String.Format(loginQuery, nameInput, surnameInput),
                db.GetConnection());

            adapter.SelectCommand = command;

            if (adapter.Fill(table) == 1)
            {
                MessageBox.Show($"Вы вошли как: {nameInput} {surnameInput}", "Успешный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Неверные данные авторизации : {nameInput} {surnameInput}", "Что-то не так",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public Fullname()
        {
            InitializeComponent();


        }

        ~Fullname()
        {
            db.CloseConnection();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            dataSourceInput = dataSourceTextBox.Text;
            initCatalogInput = initCatalogTextBox.Text;

            if (string.IsNullOrEmpty(dataSourceInput) || string.IsNullOrEmpty(initCatalogInput))
            {
                MessageBox.Show("Ошибка ввода", "Вы не заполнили все поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((db = new Database(dataSourceInput, initCatalogInput)).OpenConnection())
            {
                dbConnectGroupBox.Visible = false;
                authGroupBox.Visible = true;
            } else
            {
                MessageBox.Show("Ошибка подключения",
                    $"Не удалось подключиться к БД с параметрами: {dataSourceInput} {initCatalogInput}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
