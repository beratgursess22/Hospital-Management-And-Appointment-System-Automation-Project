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
    public partial class FRMPPATIENTS : Form
    {
        public FRMPPATIENTS()
        {
            InitializeComponent();
        }


        sqlconnection cnct = new sqlconnection();
        private void LNKSİNG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMPATIENTRECORD fr = new FRMPATIENTRECORD();
            fr.Show();
            
        }

        private void BTNLOGİN_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("select * from Table_patients where PatientTC=@p1 and Patientpassoword=@p2", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTCNO.Text);
            order.Parameters.AddWithValue("@p2", TXTPASSO.Text);
            SqlDataReader dr = order.ExecuteReader();
            if (dr.Read())
            {
                FRMPATIENTDETAIL fr = new FRMPATIENTDETAIL();
                fr.tc = MSKTCNO.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong passoword or TC no ");

            }
            cnct.connection().Close();

        }
    }
}
