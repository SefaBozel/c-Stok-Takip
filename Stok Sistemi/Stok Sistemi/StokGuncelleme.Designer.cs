namespace Stok_Sistemi
{
    partial class StokGuncelleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokGuncelleme));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.txt_Personel = new System.Windows.Forms.TextBox();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urun_ID = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(347, 143);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(262, 66);
            this.btn_Guncelle.TabIndex = 28;
            this.btn_Guncelle.Text = "Guncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Location = new System.Drawing.Point(229, 93);
            this.cmb_Marka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(220, 33);
            this.cmb_Marka.TabIndex = 27;
            // 
            // txt_Personel
            // 
            this.txt_Personel.Enabled = false;
            this.txt_Personel.Location = new System.Drawing.Point(161, 161);
            this.txt_Personel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Personel.Name = "txt_Personel";
            this.txt_Personel.Size = new System.Drawing.Size(220, 30);
            this.txt_Personel.TabIndex = 26;
            this.txt_Personel.Visible = false;
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(648, 37);
            this.txt_Miktar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(220, 30);
            this.txt_Miktar.TabIndex = 25;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(229, 40);
            this.txt_Adi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(220, 30);
            this.txt_Adi.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-18, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ekleyen Personel";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Markası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 290);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urun_ID
            // 
            this.urun_ID.AutoSize = true;
            this.urun_ID.Location = new System.Drawing.Point(835, 164);
            this.urun_ID.Name = "urun_ID";
            this.urun_ID.Size = new System.Drawing.Size(64, 25);
            this.urun_ID.TabIndex = 29;
            this.urun_ID.Text = "label5";
            this.urun_ID.Visible = false;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(648, 91);
            this.txt_Fiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(220, 30);
            this.txt_Fiyat.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // StokGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(989, 528);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urun_ID);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cmb_Marka);
            this.Controls.Add(this.txt_Personel);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.txt_Adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StokGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Güncelleme";
            this.Load += new System.EventHandler(this.StokGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.TextBox txt_Personel;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label urun_ID;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label5;
    }
}