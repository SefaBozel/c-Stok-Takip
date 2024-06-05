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
using System.Data.Common;

namespace Stok_Sistemi
{
    public partial class YöneticiSayfası : Form
    {
        public YöneticiSayfası()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string yönetici;

        private void YöneticiSayfası_Load(object sender, EventArgs e)
        {
            txt_Ad.Text = yönetici;
            //TC no Çekme
            SqlCommand komut1 = new SqlCommand("select KullaniciTC from Kullanıcı where (KullaniciAdi+' '+KullaniciSoyadi)=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txt_Ad.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                txt_TC.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //Ürünleri Çekme 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from urunler",bgl.baglanti());
            da.Fill(dt);
            dgv_Urunler.DataSource = dt;
            //Personel Listesini Çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Kullanıcı", bgl.baglanti());
            da2.Fill(dt2);
            dgv_Personel.DataSource = dt2;
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            PersonelListesi pl = new PersonelListesi();
            pl.Show();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        { 
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            YGecmisSiparis gs = new YGecmisSiparis();
            gs.Show();
        }

        private void btn_GeriBildirim_Click(object sender, EventArgs e)
        {
            YGeriBildirim g = new YGeriBildirim();
            g.Show();
        }
    }
}
