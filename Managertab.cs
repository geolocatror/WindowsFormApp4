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
    public partial class Managertab : Form
    {
        public Managertab()
        {
            InitializeComponent();
        }

        private void Managertab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilkinDataSet2.tp' table. You can move, or remove it, as needed.
            this.tpTableAdapter.Fill(this.ilkinDataSet2.tp);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=10.123.132.64;Initial Catalog=ilkin;Persist Security Info=True;User ID=sa;Password=Qwerty1");

            string InsertQuey = "INSERT INTO dbo.tp (acceptedrequests) VALUES ('" + gridLookUpEdit1.Text + "') ";

            SqlCommand cmd = new SqlCommand(InsertQuey, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("All the values are saved");
        }
    }
}
