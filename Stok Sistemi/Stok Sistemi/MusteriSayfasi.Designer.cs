namespace Stok_Sistemi
{
    partial class MusteriSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSayfasi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Geribldrm = new System.Windows.Forms.Button();
            this.btn_Gecmis = new System.Windows.Forms.Button();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_UrunID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SatinAl = new System.Windows.Forms.Button();
            this.cmb_UrunMiktar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(178, 108);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 24);
            this.txt_Id.TabIndex = 4;
            this.txt_Id.Visible = false;
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TC.Location = new System.Drawing.Point(128, 79);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(104, 18);
            this.lbl_TC.TabIndex = 3;
            this.lbl_TC.Text = "000000000000";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(128, 39);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(62, 18);
            this.lbl_AdSoyad.TabIndex = 2;
            this.lbl_AdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 471);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Geribldrm);
            this.groupBox2.Controls.Add(this.btn_Gecmis);
            this.groupBox2.Controls.Add(this.txt_Fiyat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_UrunAdi);
            this.groupBox2.Controls.Add(this.txt_UrunID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_SatinAl);
            this.groupBox2.Controls.Add(this.cmb_UrunMiktar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 326);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_Geribldrm
            // 
            this.btn_Geribldrm.Location = new System.Drawing.Point(167, 191);
            this.btn_Geribldrm.Name = "btn_Geribldrm";
            this.btn_Geribldrm.Size = new System.Drawing.Size(89, 122);
            this.btn_Geribldrm.TabIndex = 12;
            this.btn_Geribldrm.Text = "Geri Bildirim";
            this.btn_Geribldrm.UseVisualStyleBackColor = true;
            this.btn_Geribldrm.Click += new System.EventHandler(this.btn_Geribldrm_Click);
            // 
            // btn_Gecmis
            // 
            this.btn_Gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gecmis.Location = new System.Drawing.Point(6, 255);
            this.btn_Gecmis.Name = "btn_Gecmis";
            this.btn_Gecmis.Size = new System.Drawing.Size(155, 58);
            this.btn_Gecmis.TabIndex = 11;
            this.btn_Gecmis.Text = "Geçmiş Siparişlerim";
            this.btn_Gecmis.UseVisualStyleBackColor = true;
            this.btn_Gecmis.Click += new System.EventHandler(this.btn_Gecmis_Click);
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Enabled = false;
            this.txt_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Fiyat.Location = new System.Drawing.Point(106, 115);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(150, 27);
            this.txt_Fiyat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ürün Fiyat:";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Enabled = false;
            this.txt_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunAdi.Location = new System.Drawing.Point(106, 82);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(150, 27);
            this.txt_UrunAdi.TabIndex = 8;
            // 
            // txt_UrunID
            // 
            this.txt_UrunID.Enabled = false;
            this.txt_UrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunID.Location = new System.Drawing.Point(106, 45);
            this.txt_UrunID.Name = "txt_UrunID";
            this.txt_UrunID.Size = new System.Drawing.Size(150, 27);
            this.txt_UrunID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ürün ID:";
            // 
            // btn_SatinAl
            // 
            this.btn_SatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SatinAl.Location = new System.Drawing.Point(6, 191);
            this.btn_SatinAl.Name = "btn_SatinAl";
            this.btn_SatinAl.Size = new System.Drawing.Size(155, 58);
            this.btn_SatinAl.TabIndex = 4;
            this.btn_SatinAl.Text = "Satın Al";
            this.btn_SatinAl.UseVisualStyleBackColor = true;
            this.btn_SatinAl.Click += new System.EventHandler(this.btn_SatinAl_Click);
            // 
            // cmb_UrunMiktar
            // 
            this.cmb_UrunMiktar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UrunMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_UrunMiktar.FormattingEnabled = true;
            this.cmb_UrunMiktar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_UrunMiktar.Location = new System.Drawing.Point(106, 148);
            this.cmb_UrunMiktar.Name = "cmb_UrunMiktar";
            this.cmb_UrunMiktar.Size = new System.Drawing.Size(150, 28);
            this.cmb_UrunMiktar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // MusteriSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusteriSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sayfası";
            this.Load += new System.EventHandler(this.MusteriSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_UrunID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SatinAl;
        private System.Windows.Forms.ComboBox cmb_UrunMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Gecmis;
        private System.Windows.Forms.Button btn_Geribldrm;
    }
}