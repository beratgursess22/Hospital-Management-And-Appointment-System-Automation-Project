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
    public partial class FRMDOCTORDETAIL : Form
    {
        public FRMDOCTORDETAIL()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();
        public string Tc;

        private void FRMDOCTORDETAİL_Load(object sender, EventArgs e)
        {
            LBLTC.Text = Tc;

            SqlCommand order = new SqlCommand("select DoctorName,DoctorSurname from Table_doctors where DoctorTC=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", LBLTC.Text);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                LBLNAMESURNAME.Text = dr[0] + " " + dr[1];
            }
            cnct.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Appointments where AppointmentDoctor='" + LBLNAMESURNAME.Text + "'", cnct.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void BTNARİNFORMATİON_Click(object sender, EventArgs e)
        {
            FRMDOCTORINFOARRANGE fr = new FRMDOCTORINFOARRANGE();
            fr.tcno = LBLTC.Text;
            fr.Show();
        }

        private void BTNMEMORANDUMS_Click(object sender, EventArgs e)
        {
            FRMDUYURU fr = new FRMDUYURU();
            fr.Show();

        }

        private void BTNEXİTS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            RTBAPDETAİL.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
