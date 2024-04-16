using Npgsql;
using System.Data;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static int loginId = 0;
        public static int LoginId
        {
            get => loginId;
            set => Change_LoginId(value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private static void Change_LoginId(int value)
        {
            loginId = value;
            loginButton.Text = "Выйти";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            placesTable places = new placesTable();
            places.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginId == 0)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                loginId = 0;
                loginButton.Text = "Войти";
            }
        }

        private void MassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void MassBox_Leave(object sender, EventArgs e)
        {

            MassBox.Text = Math.Round(double.Parse(MassBox.Text), 2).ToString();
        }

        private void LBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void LBox_Leave(object sender, EventArgs e)
        {

            LBox.Text = Math.Round(double.Parse(LBox.Text), 2).ToString();
        }

        private void MassButton_Click(object sender, EventArgs e)
        {
            double IMTParam = Math.Round(double.Parse(MassBox.Text) / Math.Pow(double.Parse(LBox.Text), 2), 2);
            if (IMTParam < 18.5)
            {
                MessageBox.Show("У вас недостаточный вес!\nИндекс массы вышего тела: " + IMTParam.ToString());
            }
            else if (IMTParam > 25)
            {
                MessageBox.Show("У вас избыточный вес!\nИндекс массы вышего тела: " + IMTParam.ToString());
            }
            else
            {
                MessageBox.Show("У вас нормальный вес!\nИндекс массы вышего тела: " + IMTParam.ToString());
            }
        }
    }
}
