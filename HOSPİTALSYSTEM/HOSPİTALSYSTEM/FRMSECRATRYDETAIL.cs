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
    public partial class FRMSECRATRYDETAIL : Form
    {
        public FRMSECRATRYDETAIL()
        {
            InitializeComponent();
        }
        public string tcno1;
        sqlconnection cnct = new sqlconnection();
        private void FRMSECRATRYDETAİL_Load(object sender, EventArgs e)
        {
            LBLTC.Text = tcno1;

            SqlCommand order1 = new SqlCommand("select Secratrynamesruname from Table_secratry where SecratryTc=@p1", cnct.connection());
            order1.Parameters.AddWithValue("@p1", LBLTC.Text);
            SqlDataReader dr1 = order1.ExecuteReader();
            while (dr1.Read())
            {
                LBNAMESURNAME.Text = dr1[0].ToString();
            }
            cnct.connection().Close();


            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_department ", cnct.connection());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoctorName+' '+DoctorSurname) as DOCTROS, DoctorDepartment from Table_doctors", cnct.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand order2 = new SqlCommand("select DepartmentName from Table_department", cnct.connection());
            SqlDataReader dr2 = order2.ExecuteReader();
            while (dr2.Read())
            {
                CMBDEPARTMENT.Items.Add(dr2[0]);
            }
            cnct.connection().Close();


        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            SqlCommand ordersave = new SqlCommand("insert into Table_Appointments (AppointmentDate, AppointmentTime, AppointmentDepartment,AppointmentDoctor) values(@p1,@p2,@p3,@p4)", cnct.connection());
            ordersave.Parameters.AddWithValue("@p1", MSKDATE.Text);
            ordersave.Parameters.AddWithValue("@p2", MSKTIME.Text);
            ordersave.Parameters.AddWithValue("@p3", CMBDEPARTMENT.Text);
            ordersave.Parameters.AddWithValue("@p4", CMBDOCTOR.Text);
            ordersave.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("Appointment saved");

        }

        private void CMBDEPARTMENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBDOCTOR.Items.Clear();

            SqlCommand order = new SqlCommand("select DoctorName,DoctorSurname from Table_doctors where DoctorDepartment=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", CMBDEPARTMENT.Text);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                CMBDOCTOR.Items.Add(dr[0] + " " + dr[1]);
            }
            cnct.connection().Close();
        }

        private void TBNCREATE_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("insert into Table_Notice (notice) values (@p1)", cnct.connection());
            order.Parameters.AddWithValue("@p1", RCHNOTİCE.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("created the  new notice"); 
        }

        private void BTNDOCTORSPANEL_Click(object sender, EventArgs e)
        {
            FRMDOCTORPANEL frm = new FRMDOCTORPANEL();
            frm.Show();
        }

        private void BTNDEPARTMENTPANEL_Click(object sender, EventArgs e)
        {
            FRMDEPARTMENT frm = new FRMDEPARTMENT();
            frm.Show();

        }

        private void BTNAPPOİNTMENTPANEL_Click(object sender, EventArgs e)
        {
            FRMAPPOINTMENTLIST frs = new FRMAPPOINTMENTLIST();
            frs.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMDUYURU fr = new FRMDUYURU();
            fr.Show();

        }
    }
}


