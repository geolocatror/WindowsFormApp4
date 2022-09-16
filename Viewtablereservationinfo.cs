using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Viewtablereservationinfo : Form
    {
        public Viewtablereservationinfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'ilkinDataSet2.tp' table. You can move, or remove it, as needed.
            this.tpTableAdapter.Fill(this.ilkinDataSet2.tp);

        }
    }
}
