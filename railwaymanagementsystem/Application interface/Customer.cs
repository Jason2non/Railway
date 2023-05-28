using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Application_interface
{
    public partial class Customer : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adm\OneDrive\Documents\RailWayDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adm\OneDrive\Desktop\Projects\railway.mdb");
        public Customer()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTxt.Text == "" || fnameTxt.Text == "" || lnameTxt.Text == "" || emailTxt.Text == "" || phoneTxt.Text == "" || genderCb.SelectedIndex == -1 || addTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill in the missing spaces");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Customer([Id],[Cfname],[Clname],[Cemail],[Cphone],[Cgender],[Caddress],[Password])values(@Id,@Cf,@Cl,@Ce,@Cp,@Cg,@Ca,@Pa)",con);
                    cmd.Parameters.AddWithValue("@Id", idTxt.Text);
                    cmd.Parameters.AddWithValue("@Cf", fnameTxt.Text); 
                    cmd.Parameters.AddWithValue("@Cl", lnameTxt.Text);
                    cmd.Parameters.AddWithValue("@Ce", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@Cp", phoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Cg", genderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ca", addTxt.Text);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    con.Close();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
