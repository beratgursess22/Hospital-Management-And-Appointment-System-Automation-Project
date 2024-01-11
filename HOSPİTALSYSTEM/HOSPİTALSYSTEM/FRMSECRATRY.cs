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
    public partial class FRMSECRATRY : Form
    {
        public FRMSECRATRY()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();
        private void BTNLOGİN_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("select * from Table_secratry where SecratryTc=@p1 and SecratryPassoword=@p2 ", cnct.connection());
            order.Parameters.AddWithValue("@p1", MSKTCNO.Text);
            order.Parameters.AddWithValue("@p2", TXTPASSO.Text);
            SqlDataReader dr = order.ExecuteReader();
            if (dr.Read())
            {
                FRMSECRATRYDETAIL frs = new FRMSECRATRYDETAIL();
                frs.tcno1 = MSKTCNO.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrond tc or passoword ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnct.connection().Close();
        }
    }
}
