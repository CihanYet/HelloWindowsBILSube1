namespace HelloWindowsBILSube1
{
    partial class frmEvent
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
            this.lblMetin = new System.Windows.Forms.Label();
            this.lblKoordinat = new System.Windows.Forms.Label();
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Location = new System.Drawing.Point(52, 55);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(0, 13);
            this.lblMetin.TabIndex = 0;
            // 
            // lblKoordinat
            // 
            this.lblKoordinat.AutoSize = true;
            this.lblKoordinat.Location = new System.Drawing.Point(52, 165);
            this.lblKoordinat.Name = "lblKoordinat";
            this.lblKoordinat.Size = new System.Drawing.Size(0, 13);
            this.lblKoordinat.TabIndex = 1;
            // 
            // btnSayi1
            // 
            this.btnSayi1.Location = new System.Drawing.Point(369, 155);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(75, 23);
            this.btnSayi1.TabIndex = 2;
            this.btnSayi1.Text = "20";
            this.btnSayi1.UseVisualStyleBackColor = true;
            this.btnSayi1.Click += new System.EventHandler(this.Topla);
            // 
            // btnSayi2
            // 
            this.btnSayi2.Location = new System.Drawing.Point(369, 191);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(75, 23);
            this.btnSayi2.TabIndex = 3;
            this.btnSayi2.Text = "30";
            this.btnSayi2.UseVisualStyleBackColor = true;
            this.btnSayi2.Click += new System.EventHandler(this.Topla);
            // 
            // btnSayi3
            // 
            this.btnSayi3.Location = new System.Drawing.Point(369, 229);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(75, 23);
            this.btnSayi3.TabIndex = 4;
            this.btnSayi3.Text = "40";
            this.btnSayi3.UseVisualStyleBackColor = true;
            this.btnSayi3.Click += new System.EventHandler(this.Topla);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(328, 272);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(162, 23);
            this.btnSonuc.TabIndex = 5;
            this.btnSonuc.Text = "Sonuç Göster";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnSayi3);
            this.Controls.Add(this.btnSayi2);
            this.Controls.Add(this.btnSayi1);
            this.Controls.Add(this.lblKoordinat);
            this.Controls.Add(this.lblMetin);
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.MouseLeave += new System.EventHandler(this.frmEvent_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEvent_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.Label lblKoordinat;
        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button btnSonuc;
    }
}