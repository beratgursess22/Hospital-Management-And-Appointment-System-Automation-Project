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
    public partial class FRMDOCTORPANEL : Form
    {
        public FRMDOCTORPANEL()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();

        private void FRMDOCTORPANELİ_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Table_doctors", cnct.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


            SqlCommand order2 = new SqlCommand("select DepartmentName from Table_department", cnct.connection());
            SqlDataReader dr2 = order2.ExecuteReader();
            while (dr2.Read())
            {
                CMBDEPARTMENT.Items.Add(dr2[0]);
            }
            cnct.connection().Close();

        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("insert into Table_doctors (DoctorName,DoctorSurname,DoctorDepartment,DoctorTC,DoctorPassoword) values(@p1,@p2,@p3,@p4,@p5)", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTNAME.Text);
            order.Parameters.AddWithValue("@p2", TXTSURNAME.Text);
            order.Parameters.AddWithValue("@p3", CMBDEPARTMENT.Text);
            order.Parameters.AddWithValue("@p4", MSKTC.Text);
            order.Parameters.AddWithValue("@p5", TXTPASSO.Text);
            order.ExecuteReader();
            cnct.connection().Close();
            MessageBox.Show("added the new doctor","information",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TXTNAME.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TXTSURNAME.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            CMBDEPARTMENT.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            MSKTC.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            TXTPASSO.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();

        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("delete from Table_doctors where DoctorTC=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTC.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("record deleted ", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("update Table_doctors set DoctorName=@p1, DoctorSurname=@p2, DoctorDepartment=@p3, DoctorPassoword=@p5 where DoctorTC=@p4", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTNAME.Text);
            order.Parameters.AddWithValue("@p2", TXTSURNAME.Text);
            order.Parameters.AddWithValue("@p3", CMBDEPARTMENT.Text);
            order.Parameters.AddWithValue("@p4", MSKTC.Text);
            order.Parameters.AddWithValue("@p5", TXTPASSO.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("updated the doctors information", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
