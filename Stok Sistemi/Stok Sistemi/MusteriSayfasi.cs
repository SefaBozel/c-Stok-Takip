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
    public partial class MusteriSayfasi : Form
    {
        public MusteriSayfasi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string musteri;
        private void MusteriSayfasi_Load(object sender, EventArgs e)
        {
            lbl_AdSoyad.Text = musteri;
            SqlCommand komut1 = new SqlCommand("select KullaniciTC,KullaniciID from Kullanıcı where (KullaniciAdi+' '+KullaniciSoyadi)=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbl_AdSoyad.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbl_TC.Text = dr[0].ToString();
                txt_Id.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
            //DataGridView'e veri aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select UrunID,UrunMarkasi,UrunAdi,StokMiktari,UrunFiyat from urunler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_UrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_UrunAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Fiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btn_SatinAl_Click(object sender, EventArgs e)
        {
            int fiyat = int.Parse(txt_Fiyat.Text);
            int miktar = int.Parse(cmb_UrunMiktar.Text);
            DateTime islemtarihi = DateTime.Now;
            int toplamfiyat = fiyat * miktar;
            SqlCommand komut = new SqlCommand("insert into Satislar (MusteriID,UrunID,UrunAdi,BirimFiyat,Miktar,ToplamFiyat,Tarih) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@s1", txt_Id.Text);
            komut.Parameters.AddWithValue("@s2", txt_UrunID.Text);
            komut.Parameters.AddWithValue("@s3", txt_UrunAdi.Text);
            komut.Parameters.AddWithValue("@s4", txt_Fiyat.Text);
            komut.Parameters.AddWithValue("s5", cmb_UrunMiktar.Text);
            komut.Parameters.AddWithValue("s6", toplamfiyat);
            komut.Parameters.AddWithValue("@s7", islemtarihi);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Aldığınız Ürün: " + txt_UrunAdi.Text + "\n Miktar: " + cmb_UrunMiktar.Text + "\n Toplam Tutar: " + toplamfiyat + "TL");
            /////////////////////////////////////////////////////////
            int satınalınanmiktar = int.Parse(cmb_UrunMiktar.Text);

            SqlCommand komut1 = new SqlCommand("SELECT stokmiktari FROM urunler WHERE urunID = @urunID", bgl.baglanti());
            komut1.Parameters.AddWithValue("@urunID", txt_UrunID.Text);

            int mevcutmiktar = (int)komut1.ExecuteScalar();
            int yenimiktar = mevcutmiktar - satınalınanmiktar;

            SqlCommand komut2 = new SqlCommand("UPDATE urunler SET stokmiktari = @yenimiktar WHERE urunID = @urunID", bgl.baglanti());
            komut2.Parameters.AddWithValue("@yenimiktar", yenimiktar);
            komut2.Parameters.AddWithValue("@urunID", txt_UrunID.Text);
            komut2.ExecuteNonQuery();
        }

        private void btn_Gecmis_Click(object sender, EventArgs e)
        {
            GecmisSiparisler gs = new GecmisSiparisler();
            gs.ıd = txt_Id.Text;
            gs.Show();
        }

        private void btn_Geribldrm_Click(object sender, EventArgs e)
        {
            GeriBildirim gb = new GeriBildirim();
            gb.musteriad = lbl_AdSoyad.Text;
            gb.Show();
        }
    }
}
