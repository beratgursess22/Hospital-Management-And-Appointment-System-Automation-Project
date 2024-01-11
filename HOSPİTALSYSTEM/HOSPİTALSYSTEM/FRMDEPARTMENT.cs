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
    public partial class FRMDEPARTMENT : Form
    {
        public FRMDEPARTMENT()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();
        private void FRMDEPARTMENT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Table_department ", cnct.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("insert into Table_department (DepartmentName) values (@b1)", cnct.connection());
            order.Parameters.AddWithValue("@b1", TXTDEPARTMENTNAME.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("added new department", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TXTDEPARTMENTID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            TXTDEPARTMENTNAME.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();

        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("delete from Table_department where DepartmentID=@p1", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTDEPARTMENTID.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("department deleted");
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("update Table_department set DepartmentName=@p1 where DepartmentID=@p2", cnct.connection());
            order.Parameters.AddWithValue("@p1", TXTDEPARTMENTNAME.Text);
            order.Parameters.AddWithValue("@p2", TXTDEPARTMENTID.Text);
            order.ExecuteNonQuery();
            cnct.connection().Close();
            MessageBox.Show("department updated");

        }
    }
}
