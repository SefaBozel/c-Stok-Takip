namespace Stok_Sistemi
{
    partial class YöneticiSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiSayfası));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Urunler = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Raporlar = new System.Windows.Forms.Button();
            this.btn_AnaSayfa = new System.Windows.Forms.Button();
            this.btn_GeriBildirim = new System.Windows.Forms.Button();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_Personel = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(278, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // txt_TC
            // 
            this.txt_TC.AutoSize = true;
            this.txt_TC.Location = new System.Drawing.Point(122, 107);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(90, 20);
            this.txt_TC.TabIndex = 4;
            this.txt_TC.Text = "000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "T.C:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.AutoSize = true;
            this.txt_Ad.Location = new System.Drawing.Point(122, 67);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(72, 20);
            this.txt_Ad.TabIndex = 2;
            this.txt_Ad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Urunler);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(323, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(788, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // dgv_Urunler
            // 
            this.dgv_Urunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Urunler.Location = new System.Drawing.Point(3, 24);
            this.dgv_Urunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Urunler.Name = "dgv_Urunler";
            this.dgv_Urunler.RowHeadersWidth = 51;
            this.dgv_Urunler.RowTemplate.Height = 24;
            this.dgv_Urunler.Size = new System.Drawing.Size(782, 252);
            this.dgv_Urunler.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(8, 298);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(662, 290);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Raporlar);
            this.groupBox3.Controls.Add(this.btn_AnaSayfa);
            this.groupBox3.Controls.Add(this.btn_GeriBildirim);
            this.groupBox3.Controls.Add(this.btn_Personel);
            this.groupBox3.Location = new System.Drawing.Point(15, 182);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(278, 365);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.Location = new System.Drawing.Point(28, 265);
            this.btn_Raporlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Size = new System.Drawing.Size(182, 60);
            this.btn_Raporlar.TabIndex = 3;
            this.btn_Raporlar.Text = "Sipariş Geçmişi";
            this.btn_Raporlar.UseVisualStyleBackColor = true;
            this.btn_Raporlar.Click += new System.EventHandler(this.btn_Raporlar_Click);
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Location = new System.Drawing.Point(28, 198);
            this.btn_AnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(182, 60);
            this.btn_AnaSayfa.TabIndex = 2;
            this.btn_AnaSayfa.Text = "Ana Sayfa";
            this.btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // btn_GeriBildirim
            // 
            this.btn_GeriBildirim.Location = new System.Drawing.Point(28, 130);
            this.btn_GeriBildirim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GeriBildirim.Name = "btn_GeriBildirim";
            this.btn_GeriBildirim.Size = new System.Drawing.Size(182, 60);
            this.btn_GeriBildirim.TabIndex = 1;
            this.btn_GeriBildirim.Text = "Geri Bildirim";
            this.btn_GeriBildirim.UseVisualStyleBackColor = true;
            this.btn_GeriBildirim.Click += new System.EventHandler(this.btn_GeriBildirim_Click);
            // 
            // btn_Personel
            // 
            this.btn_Personel.Location = new System.Drawing.Point(28, 62);
            this.btn_Personel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(182, 60);
            this.btn_Personel.TabIndex = 0;
            this.btn_Personel.Text = "Personel Listesi";
            this.btn_Personel.UseVisualStyleBackColor = true;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_Personel);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(323, 302);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(788, 245);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personel Listesi";
            // 
            // dgv_Personel
            // 
            this.dgv_Personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Personel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Personel.Location = new System.Drawing.Point(3, 24);
            this.dgv_Personel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Personel.Name = "dgv_Personel";
            this.dgv_Personel.RowHeadersWidth = 51;
            this.dgv_Personel.RowTemplate.Height = 24;
            this.dgv_Personel.Size = new System.Drawing.Size(782, 217);
            this.dgv_Personel.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(8, 298);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(662, 290);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // YöneticiSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1123, 560);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "YöneticiSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Sayfası";
            this.Load += new System.EventHandler(this.YöneticiSayfası_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Urunler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Raporlar;
        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.Button btn_GeriBildirim;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgv_Personel;
    }
}