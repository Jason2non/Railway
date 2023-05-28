using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_interface
{
    public partial class viewpass : Form
    {
        public viewpass()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel();
            form.ShowDialog();
            showpass();
        }
        private void showpass()
            {
                con.Open();
                string query = "Select * from Booking";
                OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
                OleDbCommandBuilder Builder = new OleDbCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                passDVG.DataSource = ds.Tables[0];
                con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
