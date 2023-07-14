
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DataGridClick1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {

                InitializeComponent();

                dataGridView1.CellClick += DataGridView_CellClick;

                string connectionString = "Server=localhost;Database=MyDatabase;User ID=SKGMPC\\skgmy;Password=shax;Trusted_Connection=true;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM datagridclick;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                Form2 form2 = new Form2();

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("name");
                dt2.Columns.Add("age");
                dt2.Rows.Add(selectedRow.Cells["name"].Value, selectedRow.Cells["age"].Value);

                form2.DataToShow = dt2;

                form2.Show();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}