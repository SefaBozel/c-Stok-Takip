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
    public partial class StokSilme : Form
    {
        public StokSilme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void StokSilme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Urunler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Adi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_Marka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Miktar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Personel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Fiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Urunler where UrunAdi=@u1", bgl.baglanti());
            komut.Parameters.AddWithValue("@u1",txt_Adi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi.");
        }
    }
}
