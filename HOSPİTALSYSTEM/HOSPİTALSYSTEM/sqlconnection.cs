using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HOSPİTALSYSTEM
{
    class sqlconnection
    {
        public SqlConnection connection ()
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-FPTE8E0E\\SQLEXPRESS;Initial Catalog=HASTANE_PROJECT;Integrated Security=True");
            connect.Open();
            return connect;

        }
    }
}
