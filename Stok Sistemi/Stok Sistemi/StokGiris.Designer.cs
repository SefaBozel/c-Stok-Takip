namespace Stok_Sistemi
{
    partial class StokGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.txt_Personel = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Markası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ekleyen Personel";
            this.label4.Visible = false;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(187, 58);
            this.txt_Adi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(148, 30);
            this.txt_Adi.TabIndex = 1;
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(549, 63);
            this.txt_Miktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(148, 30);
            this.txt_Miktar.TabIndex = 3;
            // 
            // txt_Personel
            // 
            this.txt_Personel.Enabled = false;
            this.txt_Personel.Location = new System.Drawing.Point(597, 312);
            this.txt_Personel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Personel.Name = "txt_Personel";
            this.txt_Personel.Size = new System.Drawing.Size(148, 30);
            this.txt_Personel.TabIndex = 4;
            this.txt_Personel.Visible = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(247, 223);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(275, 75);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Items.AddRange(new object[] {
            "Eti ",
            "Ülker",
            "Torku ",
            "Sütaş",
            "Tadelle"});
            this.cmb_Marka.Location = new System.Drawing.Point(187, 150);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(148, 33);
            this.cmb_Marka.TabIndex = 2;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(549, 150);
            this.txt_Fiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(148, 30);
            this.txt_Fiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // StokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 416);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Marka);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Personel);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.txt_Adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StokGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Giriş";
            this.Load += new System.EventHandler(this.StokGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.TextBox txt_Personel;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label5;
    }
}