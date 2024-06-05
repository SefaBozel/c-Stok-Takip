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
    public partial class StokGiris : Form
    {
        public StokGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string personelAdi;
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Urunler (UrunMarkasi,UrunAdi,StokMiktari,UrunEkleyen,UrunFiyat) values (@u1,@u2,@u3,@u4,@u5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@u1", cmb_Marka.Text);
            komut.Parameters.AddWithValue("@u2", txt_Adi.Text);
            komut.Parameters.AddWithValue("@u3", txt_Miktar.Text);
            komut.Parameters.AddWithValue("@u4", txt_Personel.Text);
            komut.Parameters.AddWithValue("@u5", txt_Fiyat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StokGiris_Load(object sender, EventArgs e)
        {
            cmb_Marka.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Personel.Text = personelAdi;
        }
    }
}
