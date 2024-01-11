using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPİTALSYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnappatient_Click(object sender, EventArgs e)
        {
            FRMPPATIENTS fr = new FRMPPATIENTS();
            fr.Show();
            this.Hide();

        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            Frmdoctorenter fr = new Frmdoctorenter();
            fr.Show();
            this.Hide();

        }

        private void btnsecratary_Click(object sender, EventArgs e)
        {
            FRMSECRATRY fr = new FRMSECRATRY();
            fr.Show();
            this.Hide();

        }
    }
}
