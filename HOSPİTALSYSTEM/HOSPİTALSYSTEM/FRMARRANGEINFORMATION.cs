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
    public partial class FRMARRANGEINFORMATION : Form
    {
        public FRMARRANGEINFORMATION()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlconnection cnct = new sqlconnection();
        private void FRMARRANGEİNFORMATİON_Load(object sender, EventArgs e)
        {
            MSKTCNOR.Text = tcno;
            SqlCommand order = new SqlCommand("select * from Table_patients where PatientTC=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTCNOR.Text);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                TXTNAME.Text = dr[1].ToString();
                TXTSURNAME.Text = dr[2].ToString();
                MSKTELNO.Text = dr[4].ToString();
                TXTPASSOR.Text = dr[5].ToString();
                CMBGENDER.Text = dr[6].ToString();
            }
            cnct.connection().Close();
        }

        private void BTNSİNG_Click(object sender, EventArgs e)
        {
            SqlCommand order2 = new SqlCommand("update Table_patients set Patientname=@p1,Patientsurname=@p2,PatientTel=@p3,PatientPassoword=@p4,PatientGender=@p5 where PatientTC=@p6", cnct.connection());
            order2.Parameters.AddWithValue("@p1", TXTNAME.Text);
            order2.Parameters.AddWithValue("@p2", TXTSURNAME.Text);
            order2.Parameters.AddWithValue("@p3", MSKTELNO.Text);
            order2.Parameters.AddWithValue("@p4", TXTPASSOR.Text);
            order2.Parameters.AddWithValue("@p5", CMBGENDER.Text);
            order2.Parameters.AddWithValue("@p6", MSKTCNOR.Text);
            order2.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("update the information", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
