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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation ua = new Reservation();
            ua.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilkinDataSet2.tp' table. You can move, or remove it, as needed.
            this.tpTableAdapter2.Fill(this.ilkinDataSet2.tp);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tpTableAdapter2.Fill(this.ilkinDataSet2.tp);
        }

        private void reservationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewtablereservationinfo ua = new Viewtablereservationinfo();
            ua.ShowDialog();
        }

       

        private void evaluateRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Managertab ua = new Managertab();
            ua.ShowDialog();
        }

        private void requestForReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation ua = new Reservation();
            ua.ShowDialog();
        }
    }
}

