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
    public partial class Reservation : Form
    {
        public Reservation()
        {

            InitializeComponent();

        }
        

        private bool salam()
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString() +
            //dateTimePicker2.Value.ToString() + timeEdit1.Time + 
            //timeEdit2.Time);

            SqlConnection con = new SqlConnection(@"Data Source=10.123.132.64;Initial Catalog=ilkin;Persist Security Info=True;User ID=sa;Password=Qwerty1");

            string InsertQuey = "select * from dbo.tp where secstartdate like '" +
                dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'and secendtime like'" +
                dateTimePicker2.Value.ToString("dd-MM-yyyy") + "' and sectime1 like '" +
                timeEdit1.Time + "' and sectime2 like'" +
               timeEdit2.Time + "' and secRooms like'" + lookUpEdit1.Text + "'";

            SqlCommand cmd = new SqlCommand(InsertQuey, con);

            con.Open();


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("The room is reserved in that specific time");
                return false;
            }
            else
            {
                return true;
            }
        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilkinDataSet.Casrescohost' table. You can move, or remove it, as needed.
            this.casrescohostTableAdapter.Fill(this.ilkinDataSet.Casrescohost);
            // TODO: This line of code loads data into the 'ilkinDataSet.Casreservehost' table. You can move, or remove it, as needed.
            this.casreservehostTableAdapter.Fill(this.ilkinDataSet.Casreservehost);
            // TODO: This line of code loads data into the 'ilkinDataSet.Casreseventtype' table. You can move, or remove it, as needed.
            this.casreseventtypeTableAdapter.Fill(this.ilkinDataSet.Casreseventtype);
            // TODO: This line of code loads data into the 'ilkinDataSet.Casreservepriority' table. You can move, or remove it, as needed.
            this.casreservepriorityTableAdapter.Fill(this.ilkinDataSet.Casreservepriority);
            // TODO: This line of code loads data into the 'ilkinDataSet.Casreserverooms' table. You can move, or remove it, as needed.
            this.casreserveroomsTableAdapter.Fill(this.ilkinDataSet.Casreserverooms);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (salam())
            {
                SqlConnection con = new SqlConnection(@"Data Source=10.123.132.64;Initial Catalog=ilkin;Persist Security Info=True;User ID=sa;Password=Qwerty1");

                string InsertQuey = "INSERT INTO dbo.tp (secParticipantn, secParticipants, secRooms, secEventType, secHost, secCoHost, secPrirority, secNoofparticipants, secstartdate, secendtime, sectime1, sectime2) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + lookUpEdit1.Text + "','" + lookUpEdit2.Text + "','" + lookUpEdit3.Text + "','" + lookUpEdit4.Text + "', '" + lookUpEdit5.Text + "','" + textBox3.Text + "','"
                    + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "', '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "', '" + timeEdit1.Time + "', '" + timeEdit2.Time + "') ";

                SqlCommand cmd = new SqlCommand(InsertQuey, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("All the values are saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
  
    