namespace Stok_Sistemi
{
    partial class StokSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokSilme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.txt_Personel = new System.Windows.Forms.TextBox();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Location = new System.Drawing.Point(217, 104);
            this.cmb_Marka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(220, 33);
            this.cmb_Marka.TabIndex = 17;
            // 
            // txt_Personel
            // 
            this.txt_Personel.Location = new System.Drawing.Point(769, 192);
            this.txt_Personel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Personel.Name = "txt_Personel";
            this.txt_Personel.Size = new System.Drawing.Size(220, 30);
            this.txt_Personel.TabIndex = 16;
            this.txt_Personel.Visible = false;
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(636, 48);
            this.txt_Miktar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(220, 30);
            this.txt_Miktar.TabIndex = 15;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(217, 51);
            this.txt_Adi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(220, 30);
            this.txt_Adi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ekleyen Personel";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Markası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(335, 154);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(262, 66);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(636, 104);
            this.txt_Fiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(220, 30);
            this.txt_Fiyat.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // StokSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Sil);
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
            this.Name = "StokSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Silme";
            this.Load += new System.EventHandler(this.StokSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.TextBox txt_Personel;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label5;
    }
}