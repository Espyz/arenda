using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace WinFormsApp1
{
    public partial class RentForm : Form
    {
        private long placeId = -1;
        public long PlaceId { get => placeId; set => placeId = value; }
        public RentForm()
        {
            InitializeComponent();
            DateStartPicker.MinDate = DateTime.Now;
            DateEndPicker.MinDate = DateTime.Now.AddDays(1);
        }

        private void StartRentButton_Click(object sender, EventArgs e)
        {
            if (DateEndPicker.Value <= DateStartPicker.Value)
            {
                MessageBox.Show("Дата завершения аренды не может быть меньше даты начала аренды");
                return;
            }
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            //Для начала проверим не арендовали ли данное помещение
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM rent WHERE \"placeId\" = @1 AND \"dateEnd\" > now()", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Bigint).Value = placeId;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данное помещение уже арендовано, обновите таблицу для получения актуального списка помещений");
                db.closeConnection();
                return;
            }
            command = new NpgsqlCommand("INSERT INTO rent (\"placeId\", \"clientId\", \"dateStart\", \"dateEnd\") VALUES (@1, @2, @3, @4)", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Bigint).Value = placeId;
            command.Parameters.Add("@2", NpgsqlDbType.Bigint).Value = Form1.LoginId;
            command.Parameters.Add("@3", NpgsqlDbType.Date).Value = DateStartPicker.Value;
            command.Parameters.Add("@4", NpgsqlDbType.Date).Value = DateEndPicker.Value;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно арендовали помещение.");
            }
            else
            {
                MessageBox.Show("Арендовать помещение не удалось");
            }
            db.closeConnection();
            this.Close();
        }

        private void DateStartPicker_ValueChanged(object sender, EventArgs e)
        {
            DateEndPicker.MinDate = DateStartPicker.Value.AddDays(1);
            if (DateEndPicker.Value <= DateStartPicker.Value)
            {
                DateEndPicker.Value = DateStartPicker.Value.AddDays(1);
            }
        }
    }
}
