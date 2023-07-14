using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridClick1
{
    public partial class Form2 : Form
    {
        public DataTable DataToShow { get; set; }

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(DataToShow != null)
            {
                dataGridView1.DataSource = DataToShow;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}

