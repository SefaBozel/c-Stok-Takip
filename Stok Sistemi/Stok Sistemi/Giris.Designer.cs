namespace Stok_Sistemi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lbl_KullanıcıAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.lbl_Kayıt = new System.Windows.Forms.LinkLabel();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_KullanıcıAdi
            // 
            this.lbl_KullanıcıAdi.AutoSize = true;
            this.lbl_KullanıcıAdi.Location = new System.Drawing.Point(142, 46);
            this.lbl_KullanıcıAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KullanıcıAdi.Name = "lbl_KullanıcıAdi";
            this.lbl_KullanıcıAdi.Size = new System.Drawing.Size(99, 25);
            this.lbl_KullanıcıAdi.TabIndex = 0;
            this.lbl_KullanıcıAdi.Text = "Ad Soyad";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(165, 145);
            this.lbl_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(52, 25);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(114, 191);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(148, 30);
            this.txt_Sifre.TabIndex = 2;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(84, 258);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(204, 69);
            this.btn_Giris.TabIndex = 3;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // lbl_Kayıt
            // 
            this.lbl_Kayıt.AutoSize = true;
            this.lbl_Kayıt.Location = new System.Drawing.Point(242, 332);
            this.lbl_Kayıt.Name = "lbl_Kayıt";
            this.lbl_Kayıt.Size = new System.Drawing.Size(81, 25);
            this.lbl_Kayıt.TabIndex = 4;
            this.lbl_Kayıt.TabStop = true;
            this.lbl_Kayıt.Text = "Kayıt Ol";
            this.lbl_Kayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Kayıt_LinkClicked);
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(114, 90);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(148, 30);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 407);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.lbl_Kayıt);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullanıcıAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullanıcıAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel lbl_Kayıt;
        private System.Windows.Forms.TextBox txt_AdSoyad;
    }
}

