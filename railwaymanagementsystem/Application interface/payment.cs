using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_interface
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking form = new booking();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(onlineCb.SelectedIndex == -1)
            {
                MessageBox.Show("Choose payment option");
            }
            else
            {
                MessageBox.Show("Booked Successful");
            }
        }
    }
}
