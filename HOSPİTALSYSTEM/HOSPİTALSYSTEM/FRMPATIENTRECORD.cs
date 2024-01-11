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
    public partial class FRMPATIENTRECORD : Form
    {
        public FRMPATIENTRECORD()
        {
            InitializeComponent();
        }

        sqlconnection cnct = new sqlconnection();

        private void BTNSİNG_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("insert into Table_patients (Patientname,Patientsurname,PatientTC,PatientTel,Patientpassoword,PatientGender) values(@p1,@p2,@p3,@p4,@p5,@p6)", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTNAME.Text);
            order.Parameters.AddWithValue("@p2", TXTSURNAME.Text);
            order.Parameters.AddWithValue("@p3", MSKTCNOR.Text);
            order.Parameters.AddWithValue("@p4", MSKTELNO.Text);
            order.Parameters.AddWithValue("@p5", TXTPASSOR.Text);
            order.Parameters.AddWithValue("@p6", CMBGENDER.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("saved the system pasoword is: " + TXTPASSOR.Text, "information: ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FRMPATİENTRECORD_Load(object sender, EventArgs e)
        {

        }
    }
}
