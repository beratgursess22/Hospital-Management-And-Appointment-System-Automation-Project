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
    public partial class FRMDUYURU : Form
    {
        public FRMDUYURU()
        {
            InitializeComponent();
        }
        sqlconnection cnct = new sqlconnection();

        private void FRMDUYURU_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Notice ", cnct.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
