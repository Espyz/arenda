using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passBox.Size = new Size(passBox.Size.Width, 47);
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "Введите пароль")
            {
                passBox.Text = "";
                passBox.UseSystemPasswordChar = true;
                passBox.ForeColor = Color.Black;
            }
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {
                passBox.Text = "Введите пароль";
                passBox.UseSystemPasswordChar = false;
                passBox.ForeColor = Color.Gray;
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

        private void AuthoriseLabel_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            this.Close();
            regForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                MessageBox.Show(LoginBox.Text);
                return;
            }
            if (passBox.Text == "Введите пароль")
            {
                MessageBox.Show(passBox.Text);
            }
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients WHERE \"login\" = @1 AND \"password\" = @2", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Varchar).Value = LoginBox.Text;
            command.Parameters.Add("@2", NpgsqlDbType.Varchar).Value = passBox.Text;
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Form1.LoginId = reader.GetInt32(0);
                MessageBox.Show("Авторизация произошла успешно");
                db.closeConnection();
                this.Close();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Авторизация не удалась");
            }
        }
    }
}
