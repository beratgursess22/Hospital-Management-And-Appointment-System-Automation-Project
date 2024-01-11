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
    public partial class FRMPATIENTDETAIL : Form
    {
        public FRMPATIENTDETAIL()
        {
            InitializeComponent();
        }
        public string tc;

        sqlconnection cnct = new sqlconnection();
        private void FRMPATİENTDETAİL_Load(object sender, EventArgs e)
        {
            LBLTC.Text = tc;

            SqlCommand order = new SqlCommand("select Patientname,Patientsurname from Table_patients where PatientTC=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", LBLTC.Text);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                LBLNAMESURNAME.Text = dr[0] + " " + dr[1];
            }
            cnct.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Appointments where PatientTC=" +tc, cnct.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            SqlCommand order2 = new SqlCommand("select DepartmentName from Table_department", cnct.connection());
            SqlDataReader dr2 = order2.ExecuteReader();
            while (dr2.Read())
            {
                CMBDEPARTMENT.Items.Add(dr2[0]);
            }
            cnct.connection().Close();
        }

        private void CMBDEPARTMENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBDOCTOR.Items.Clear();
            SqlCommand order3 = new SqlCommand("select DoctorName, DoctorSurname from Table_doctors where DoctorDepartment=@p1", cnct.connection());
            order3.Parameters.AddWithValue("@p1", CMBDEPARTMENT.Text);
            SqlDataReader dr3 = order3.ExecuteReader();
            while (dr3.Read())
            {
                CMBDOCTOR.Items.Add(dr3[0] + " " + dr3[1]);
            }
            cnct.connection().Close();
        }

        private void CMBDOCTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Appointments where AppointmentDepartment='" + CMBDEPARTMENT.Text +"'"+" and AppointmentDoctor='"+CMBDOCTOR.Text+"' and AppointmentCondition=0", cnct.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void LNKARRANGEİNFORMATİON_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMARRANGEINFORMATION fr = new FRMARRANGEINFORMATION();
            fr.tcno = LBLTC.Text;
            fr.Show();



            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TXTID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
        }

        private void BTNSİNGUP_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("update Table_Appointment set AppointmentCondition=1,PatientTC=@p1,PatientComplaint=@p2 where PatientID=@p3", cnct.connection());
            order.Parameters.AddWithValue("@p1", LBLTC.Text);
            order.Parameters.AddWithValue("@p2", RTBCOMPLAİNT.Text);
            order.Parameters.AddWithValue("@p3", TXTID.Text);
            cnct.connection().Close();
            MessageBox.Show("taked appointmnet ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
