using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace WinFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            PassBox.Size = new Size(PassBox.Size.Width, 100);
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "Введите телефон")
            {
                PhoneBox.Text = "";
                PhoneBox.ForeColor = Color.Black;
            }
        }
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == "Введите пароль")
            {
                PassBox.Text = "";
                PassBox.UseSystemPasswordChar = true;
                PassBox.ForeColor = Color.Black;
            }
        }
        private void EmailBox_Enter(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Введите почту")
            {
                EmailBox.Text = "";
                EmailBox.ForeColor = Color.Black;
            }
        }
        private void FioBox_Enter(object sender, EventArgs e)
        {
            if (FioBox.Text == "Введите ФИО")
            {
                FioBox.Text = "";
                FioBox.ForeColor = Color.Black;
            }
        }

        private void PassportBox_Enter(object sender, EventArgs e)
        {
            if (PassportBox.Text == "Введите паспорт")
            {
                PassportBox.Text = "";
                PassportBox.ForeColor = Color.Black;
            }
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")
            {
                PassBox.Text = "Введите пароль";
                PassBox.UseSystemPasswordChar = false;
                PassBox.ForeColor = Color.Gray;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
                LoginBox.ForeColor = Color.Gray;
            }
        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "")
            {
                PhoneBox.Text = "Введите телефон";
                PhoneBox.ForeColor = Color.Gray;
            }
        }
        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                EmailBox.Text = "Введите почту";
                EmailBox.ForeColor = Color.Gray;
            }
        }

        private void FioBox_Leave(object sender, EventArgs e)
        {
            if (FioBox.Text == "")
            {
                FioBox.Text = "Введите ФИО";
                FioBox.ForeColor = Color.Gray;
            }
        }

        private void PassportBox_Leave(object sender, EventArgs e)
        {
            if (PassportBox.Text == "")
            {
                PassportBox.Text = "Введите паспорт";
                PassportBox.ForeColor = Color.Gray;
            }
        }

        private void AccauntLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string phone = PhoneBox.Text;
            string email = EmailBox.Text;
            string fio = FioBox.Text;
            string passport = PassportBox.Text;
            string password = PassBox.Text;
            string login = LoginBox.Text;

            if (phone == "Введите телефон")
            {
                MessageBox.Show(phone);
                return;
            }
            if (email == "Введите почту")
            {
                MessageBox.Show(email);
                return;
            }
            if (fio == "Введите ФИО")
            {
                MessageBox.Show(fio);
                return;
            }
            if (password == "Введите пароль")
            {
                MessageBox.Show(password);
                return;
            }
            if (passport == "Введите паспорт")
            {
                MessageBox.Show(passport);
                return;
            }
            if (login == "Введите логин")
            {
                MessageBox.Show(login);
                return;
            }

            if (checkLoginExist(login))
            {
                MessageBox.Show("Пользователь с данным логином уже существует. Введите новый или попробуйте авторизоваться");
                return;
            }
            if (checkPhoneExist(phone))
            {
                MessageBox.Show("Пользователь с данным телефоном уже существует. Введите новый или попробуйте авторизоваться");
                return;
            }
            if (checkPassportExist(passport))
            {
                MessageBox.Show("Пользователь с данным паспортом уже существует. Введите новый или попробуйте авторизоваться");
                return;
            }
            if (checkEmailExist(email))
            {
                MessageBox.Show("Пользователь с данной почтой уже существует. Введите новый или попробуйте авторизоваться");
                return;
            }

            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO clients (requisites, address, phone, fio, login, password) VALUES (@1, @2, @3, @4, @5, @6) RETURNING id", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = passport;
            command.Parameters.Add("@2", NpgsqlDbType.Varchar).Value = email;
            command.Parameters.Add("@3", NpgsqlDbType.Varchar).Value = phone;
            command.Parameters.Add("@4", NpgsqlDbType.Varchar).Value = fio;
            command.Parameters.Add("@5", NpgsqlDbType.Varchar).Value = login;
            command.Parameters.Add("@6", NpgsqlDbType.Varchar).Value = password;
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Form1.LoginId = reader.GetInt32(0);
                MessageBox.Show("Регистрация произошла успешно");
            }
            else 
            {
                MessageBox.Show("Регистрация не удалась");
            }

            db.closeConnection();
            this.Close();
        }

        private Boolean checkLoginExist(string login)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients WHERE login = @1", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = login;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
        private Boolean checkPhoneExist(string phone)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients WHERE phone = @1", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = phone;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
        private Boolean checkPassportExist(string passport)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients WHERE requisites = @1", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = passport;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
        private Boolean checkEmailExist(string email)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients WHERE address = @1", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = email;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
    }
}
