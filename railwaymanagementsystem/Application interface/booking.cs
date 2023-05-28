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
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Booking([booking_id],[from_station],[to_station],[train_id],[journey_date],[amount],[booking_status],[created_time])values(@Bi,@Fs,@Ts,@Ti,@Jd,@Am,@Bs,@Ct)", con);
            cmd.Parameters.AddWithValue("@Bi", bookidTxt.Text);
            cmd.Parameters.AddWithValue("@Fs", fstatiCb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Ts", tstatiTxt.Text);
            cmd.Parameters.AddWithValue("@Ti", trainidTxt.Text);
            cmd.Parameters.AddWithValue("@Jd", jdateDate.Value.Date);
            cmd.Parameters.AddWithValue("@Am", amountCb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Bs", bookstCb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Ct", bdateDate.Value.Date);
            cmd.ExecuteNonQuery();
            payment form = new payment();
            this.Hide();
            form.Show();



            //payment form = new payment();
            //form.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
