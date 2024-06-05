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
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Kayıt_Ol_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanıcı (KullaniciAdi,KullaniciSoyadi,KullaniciSifre,KullaniciTC,KullaniciTel,KullanıcıYetki) values (@k1,@k2,@k3,@k4,@k5,@k6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@k4", txt_TC.Text);
            komut.Parameters.AddWithValue("@k5", txt_Tel.Text);
            komut.Parameters.AddWithValue("@k6", lbl_Musteri.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşti. \n Şifreniz: " + txt_Sifre.Text,"bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
