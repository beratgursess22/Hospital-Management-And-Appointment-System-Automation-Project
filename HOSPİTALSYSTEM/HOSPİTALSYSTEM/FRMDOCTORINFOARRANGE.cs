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
    public partial class FRMDOCTORINFOARRANGE : Form
    {
        public FRMDOCTORINFOARRANGE()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();
        public string tcno;

        private void FRMDOCTORİNFOARRANGE_Load(object sender, EventArgs e)
        {
            MSKTCNOR.Text = tcno;

            SqlCommand order = new SqlCommand("select * from Table_doctors where DoctorTC=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTCNOR.Text);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                TXTNAME.Text = dr[1].ToString();
                TXTSURNAME.Text = dr[2].ToString();
                CMBDEPARTMENT.Text = dr[3].ToString();
                TXTPASSOR.Text = dr[5].ToString();
            }
            cnct.connection().Close();

        }

        private void BTNSİNG_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("update Table_doctors set DoctorName=@p1,DoctorSurname=@p2, DoctorDepartment=@p3,DoctorPassoword=@p4 where DoctorTC=@p5", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTNAME.Text);
            order.Parameters.AddWithValue("@p2", TXTSURNAME.Text);
            order.Parameters.AddWithValue("@p3", CMBDEPARTMENT.Text);
            order.Parameters.AddWithValue("@p4", TXTPASSOR.Text);
            order.Parameters.AddWithValue("@p5", MSKTCNOR.Text);
            order.ExecuteReader();
            cnct.connection().Close();
            MessageBox.Show("updated doctor information");
        }
    }
}
