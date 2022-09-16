using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool assalam()
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString() +
            //dateTimePicker2.Value.ToString() + timeEdit1.Time + 
            //timeEdit2.Time);

            SqlConnection con = new SqlConnection(@"Data Source=10.123.132.64;Initial Catalog=ilkin;Persist Security Info=True;User ID=sa;Password=Qwerty1");

            string InsertQuey = "select * from dbo.LoginID where Login like '" +
                textBox1.Text + "'and Password like'" +
                textBox2.Text + "' and WorkID like '" +
                textBox3.Text + "' and Departament like'" +
               textBox4.Text + "' and DepartementID like'" + 
               textBox5.Text + "' and Office like '" + textBox6.Text + "'";

            SqlCommand cmd = new SqlCommand(InsertQuey, con);

            con.Open();


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                return true;
                
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (assalam())
            {

                Main ua = new Main();
                ua.ShowDialog();

            }
        }
    }
}
