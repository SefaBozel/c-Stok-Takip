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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Kullanıcı", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Tel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmb_Yetki.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanıcı (KullaniciAdi, KullaniciSoyadi, KullaniciSifre, KullaniciTC, KullaniciTel, KullanıcıYetki) values (@k1,@k2,@k3,@k4,@k5,@k6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@k4", txt_Tc.Text);
            komut.Parameters.AddWithValue("@k5", txt_Tel.Text);
            komut.Parameters.AddWithValue("@k6", cmb_Yetki.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from kullanıcı where kullaniciTC=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Tc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Kullanıcı SET KullaniciAdi=@k1, KullaniciSoyadi=@k2, KullaniciSifre=@k3, KullaniciTel=@k4, KullanıcıYetki=@k5 where KullaniciTC=@k6", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3",txt_Sifre.Text);
            komut.Parameters.AddWithValue("@k6", txt_Tc.Text);
            komut.Parameters.AddWithValue("@k4", txt_Tel.Text);
            komut.Parameters.AddWithValue("@k5", cmb_Yetki.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
