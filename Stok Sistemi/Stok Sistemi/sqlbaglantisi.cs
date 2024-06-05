using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stok_Sistemi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S59HMG2\\MSSQLSERVER03;Initial Catalog=Stok_Sistemi;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
