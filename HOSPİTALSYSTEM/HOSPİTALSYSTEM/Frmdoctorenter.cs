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

namespace HOSPİTALSYSTEM
{
    public partial class Frmdoctorenter : Form
    {
        public Frmdoctorenter()
        {
            InitializeComponent();
        }

        sqlconnection cnct = new sqlconnection();

        private void BTNLOGİN_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("select * from Table_doctors where DoctorTC=@p1 and DoctorPassoword=@p2 ", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTCNO.Text);
            order.Parameters.AddWithValue("@p2", TXTPASSO.Text);
            SqlDataReader dr = order.ExecuteReader();

            if (dr.Read())
            {
                FRMDOCTORDETAIL fr = new FRMDOCTORDETAIL();
                fr.Tc = MSKTCNO.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong tc or passoword");

            }
            cnct.connection().Close();

            

        }

        private void Frmdoctorenter_Load(object sender, EventArgs e)
        {

        }
    }
}
