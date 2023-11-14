namespace HelloWindowsBILSube1
{
    partial class frmGiris
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
            this.grpKullanici = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.grpSeviye = new System.Windows.Forms.GroupBox();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.grpKullanici.SuspendLayout();
            this.grpSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullanici
            // 
            this.grpKullanici.Controls.Add(this.txtSoyad);
            this.grpKullanici.Controls.Add(this.txtAd);
            this.grpKullanici.Controls.Add(this.lblSoyad);
            this.grpKullanici.Controls.Add(this.lblAd);
            this.grpKullanici.Location = new System.Drawing.Point(30, 22);
            this.grpKullanici.Name = "grpKullanici";
            this.grpKullanici.Size = new System.Drawing.Size(216, 125);
            this.grpKullanici.TabIndex = 0;
            this.grpKullanici.TabStop = false;
            this.grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(82, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(82, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(27, 74);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(27, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(30, 257);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(216, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Oyunu Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // grpSeviye
            // 
            this.grpSeviye.Controls.Add(this.rdZor);
            this.grpSeviye.Controls.Add(this.rdOrta);
            this.grpSeviye.Controls.Add(this.rdKolay);
            this.grpSeviye.Location = new System.Drawing.Point(30, 159);
            this.grpSeviye.Name = "grpSeviye";
            this.grpSeviye.Size = new System.Drawing.Size(216, 81);
            this.grpSeviye.TabIndex = 2;
            this.grpSeviye.TabStop = false;
            this.grpSeviye.Text = "Seviye İşlemleri";
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Location = new System.Drawing.Point(30, 38);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 0;
            this.rdKolay.TabStop = true;
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(87, 38);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 1;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(138, 38);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 2;
            this.rdZor.TabStop = true;
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 303);
            this.Controls.Add(this.grpSeviye);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.grpKullanici);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.grpKullanici.ResumeLayout(false);
            this.grpKullanici.PerformLayout();
            this.grpSeviye.ResumeLayout(false);
            this.grpSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullanici;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.GroupBox grpSeviye;
        private System.Windows.Forms.RadioButton rdZor;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdKolay;
    }
}