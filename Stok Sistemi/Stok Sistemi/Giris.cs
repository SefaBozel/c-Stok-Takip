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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lbl_Kayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt_Ol ko = new Kayıt_Ol();
            ko.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Kullanıcı WHERE (KullaniciAdi + ' ' + KullaniciSoyadi) = @k1 AND KullaniciSifre = @k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string adSoyad = dr["KullaniciAdi"].ToString() + " " + dr["KullaniciSoyadi"].ToString();
                string kullaniciYetki = dr["KullanıcıYetki"].ToString(); // KullanıcıYetki değerini al

                if (kullaniciYetki == "Yonetici") // Eğer kullanıcı yetki değeri 1 ise
                {
                    YöneticiSayfası ys = new YöneticiSayfası();
                    ys.yönetici = adSoyad; // Yönetici sayfasına ad soyadı değil, kullanıcı yetkisini gönder
                    ys.Show();
                    this.Hide();
                }
                else if(kullaniciYetki == "Personel")
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.personel = adSoyad;
                    ana.Show();
                    this.Hide();
                }
                else {
                    MusteriSayfasi ms = new MusteriSayfasi();
                    ms.musteri = adSoyad;
                    ms.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Veri Girdiniz.");
            }
            dr.Close();
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
