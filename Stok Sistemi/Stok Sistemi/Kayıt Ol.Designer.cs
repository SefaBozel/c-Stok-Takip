namespace Stok_Sistemi
{
    partial class Kayıt_Ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt_Ol));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Kayıt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Tel = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Musteri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C Kimlik NO:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(178, 62);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(156, 30);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(178, 102);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(156, 30);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(179, 142);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_Kayıt
            // 
            this.btn_Kayıt.Location = new System.Drawing.Point(83, 276);
            this.btn_Kayıt.Name = "btn_Kayıt";
            this.btn_Kayıt.Size = new System.Drawing.Size(219, 81);
            this.btn_Kayıt.TabIndex = 8;
            this.btn_Kayıt.Text = "Kayıt Ol";
            this.btn_Kayıt.UseVisualStyleBackColor = true;
            this.btn_Kayıt.Click += new System.EventHandler(this.btn_Kayıt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon NO:";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(178, 180);
            this.txt_TC.Mask = "00000000000";
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(156, 30);
            this.txt_TC.TabIndex = 4;
            this.txt_TC.ValidatingType = typeof(int);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(178, 219);
            this.txt_Tel.Mask = "(999) 000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(156, 30);
            this.txt_Tel.TabIndex = 5;
            // 
            // lbl_Musteri
            // 
            this.lbl_Musteri.AutoSize = true;
            this.lbl_Musteri.Location = new System.Drawing.Point(12, 9);
            this.lbl_Musteri.Name = "lbl_Musteri";
            this.lbl_Musteri.Size = new System.Drawing.Size(76, 25);
            this.lbl_Musteri.TabIndex = 10;
            this.lbl_Musteri.Text = "Musteri";
            // 
            // Kayıt_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(370, 405);
            this.Controls.Add(this.lbl_Musteri);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Kayıt);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Kayıt_Ol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Kayıt_Ol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Kayıt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_TC;
        private System.Windows.Forms.MaskedTextBox txt_Tel;
        private System.Windows.Forms.Label lbl_Musteri;
    }
}