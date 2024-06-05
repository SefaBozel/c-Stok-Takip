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
    public partial class StokGuncelleme : Form
    {
        public StokGuncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string personelName;
        private void StokGuncelleme_Load(object sender, EventArgs e)
        {
            txt_Personel.Text = personelName;
            //DataGridView'e veri çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Urunler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            urun_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmb_Marka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Adi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Miktar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Personel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Fiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Urunler SET UrunMarkasi=@u1, UrunAdi=@u2, StokMiktari=@u3, UrunEkleyen=@u4 where UrunID=@u5", bgl.baglanti());
            komut.Parameters.AddWithValue("@u1", cmb_Marka.Text);
            komut.Parameters.AddWithValue("u2", txt_Adi.Text);
            komut.Parameters.AddWithValue("@u3", txt_Miktar.Text);
            komut.Parameters.AddWithValue("@u4", txt_Personel.Text);
            komut.Parameters.AddWithValue("@u5", urun_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
