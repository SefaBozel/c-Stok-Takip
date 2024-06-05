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

namespace Stok_Sistemi
{
    public partial class GecmisSiparisler : Form
    {
        public GecmisSiparisler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string ıd;
        private void GecmisSiparisler_Load(object sender, EventArgs e)
        {
            txt_ID.Text = ıd;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SatisID,UrunID,UrunAdi,BirimFiyat,Miktar,ToplamFiyat from Satislar where MusteriID="+ıd,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
