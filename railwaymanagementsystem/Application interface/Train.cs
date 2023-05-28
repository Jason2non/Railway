using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Application_interface
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Train([train_no],[train_type],[train_name],[arrival_time],[departure_time])values(@To,@Tt,@Tn,@At,@Dt)",con);
                cmd.Parameters.AddWithValue("@Tn", tnoTxt.Text);
                cmd.Parameters.AddWithValue("@Tt", ttypeTxt.Text);
                cmd.Parameters.AddWithValue("@Tn", tnameTxt.Text);
                cmd.Parameters.AddWithValue("@At", dateArrival.Value.Date.ToString());
                cmd.Parameters.AddWithValue("@Dt", dateDepart.Value.Date.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
