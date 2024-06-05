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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string personel;
        private void btn_StokGiris_Click(object sender, EventArgs e)
        {
            StokGiris sg = new StokGiris();
            sg.personelAdi = personel;
            sg.Show();
        }

        private void btn_StokSilme_Click(object sender, EventArgs e)
        {
            StokSilme ss = new StokSilme();
            ss.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lbl_Ad.Text = personel;
            //TC NO çekme
            SqlCommand komut1 = new SqlCommand("select KullaniciTC from Kullanıcı where (KullaniciAdi+' '+KullaniciSoyadi)=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbl_Ad.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbl_TC.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //DataGridView'e nesne çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Urunler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            StokGuncelleme sgu = new StokGuncelleme();
            sgu.personelName = personel;
            sgu.Show();
        }
    }
}
