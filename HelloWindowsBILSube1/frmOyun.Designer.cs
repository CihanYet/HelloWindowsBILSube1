namespace HelloWindowsBILSube1
{
    partial class frmOyun
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
            this.components = new System.ComponentModel.Container();
            this.btnYakala = new System.Windows.Forms.Button();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYakala
            // 
            this.btnYakala.Location = new System.Drawing.Point(0, 0);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(52, 46);
            this.btnYakala.TabIndex = 0;
            this.btnYakala.Text = "button1";
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlBilgi.Controls.Add(this.lblKullanici);
            this.pnlBilgi.Controls.Add(this.lblSure);
            this.pnlBilgi.Controls.Add(this.lblSkor);
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBilgi.Location = new System.Drawing.Point(657, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(143, 450);
            this.pnlBilgi.TabIndex = 1;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(30, 306);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 13);
            this.lblKullanici.TabIndex = 2;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(50, 202);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 25);
            this.lblSure.TabIndex = 1;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(66, 45);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(0, 25);
            this.lblSkor.TabIndex = 0;
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBilgi);
            this.Controls.Add(this.btnYakala);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.SizeChanged += new System.EventHandler(this.frmOyun_SizeChanged);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYakala;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKullanici;
    }
}