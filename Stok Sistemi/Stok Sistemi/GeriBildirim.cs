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
    public partial class GeriBildirim : Form
    {
        public GeriBildirim()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string musteriad;
        private void GeriBildirim_Load(object sender, EventArgs e)
        {
            txt_adsoyad.Text = musteriad;
            SqlCommand komut1 = new SqlCommand("select KullaniciID from Kullanıcı where (KullaniciAdi+' '+KullaniciSoyadi)=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txt_adsoyad.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                txt_ID.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            DateTime islemtarihi = DateTime.Now;
            SqlCommand komut2 = new SqlCommand("insert into Bildirim (MusteriID,MusteriAdiSoyadi,Bildirim,Tarih) values (@b1,@b2,@b3,@b4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1",txt_ID.Text);
            komut2.Parameters.AddWithValue("@b2", txt_adsoyad.Text);
            komut2.Parameters.AddWithValue("@b3", richTextBox1.Text);
            komut2.Parameters.AddWithValue("@b4", islemtarihi);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesajınız başarılı bir şekilde iletilmiştir.");

        }
    }
}
