using Microsoft.VisualBasic.Logging;
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
    public partial class placesTable : Form
    {
        const int TableColumnsCount = 5;
        private string[] columnNames = { "id", "floor", "haveCold", "pricePerDay", "square" };
        private string[] columnNamesRus = { "Номер помещения", "Этаж", "Наличие кондиционера", "Стоимость за день", "Площадь" };
        public placesTable()
        {
            InitializeComponent();
        }

        private void placesTable_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT p.id," +
                                                            " p.floor," +
                                                            " CASE WHEN p.\"haveCold\" IS TRUE THEN 'Есть' ELSE 'Нет' END AS \"haveCold\"," +
                                                            " CONCAT(p.\"pricePerDay\", ' руб.') AS \"pricePerDay\"," +
                                                            " CONCAT(p.square, ' кв. м.') AS square" +
                                                            " FROM places p" +
                                                            "       LEFT JOIN rent r ON p.id = r.\"placeId\" AND r.\"dateEnd\" > now()" +
                                                            " WHERE r.id IS NULL" +
                                                            " ORDER BY id", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < TableColumnsCount; i++)
                {
                    dataGridView1.Columns.Add(columnNames[i], columnNamesRus[i]);
                }
                dataGridView1.ColumnHeadersVisible = true;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (dataGridView1.Rows.Count - 1 < i)
                    {
                        dataGridView1.Rows.Add();
                    }
                    for (int j = 0; j < TableColumnsCount; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = table.Rows[i][columnNames[j]];
                    }
                }
                if (Form1.LoginId != 0)
                {
                    dataGridView1.Columns.Add(new DataGridViewButtonColumn());
                    dataGridView1.Columns[TableColumnsCount].HeaderCell.Value = "Арендовать";
                }
            }
            else
            {
                MessageBox.Show("Нет доступных помещений для аренды");
                CloseButton_Click(sender, e);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView) sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                RentForm rentForm = new RentForm();
                rentForm.PlaceId = (long)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                rentForm.ShowDialog();
            }
        }
    }
}
