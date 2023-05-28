using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Application_interface
{
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            this.Hide();
            form.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (unameTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill the blank spaces");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT [Admin],[Password] FROM Admin WHERE Admin=@Ad and Password=@Pa", con);
                    cmd.Parameters.AddWithValue("@Ad", unameTxt.Text);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully logged in");
                        AdminPanel let = new AdminPanel();
                        this.Hide();
                        let.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username or Password");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (unameTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill the blank spaces");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT [Cemail],[Password] FROM Customer WHERE Cemail=@Ce and Password=@Pa", con);
                    cmd.Parameters.AddWithValue("@Ce", unameTxt.Text);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully logged in");
                        booking form = new booking();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username or Password");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
