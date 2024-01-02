namespace OkulAppSube1BIL
{
    partial class frmOgrBul
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
            this.grpBul = new System.Windows.Forms.GroupBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.grpBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBul
            // 
            this.grpBul.Controls.Add(this.btnBul);
            this.grpBul.Controls.Add(this.label1);
            this.grpBul.Controls.Add(this.txtOgrNo);
            this.grpBul.Location = new System.Drawing.Point(12, 12);
            this.grpBul.Name = "grpBul";
            this.grpBul.Size = new System.Drawing.Size(268, 176);
            this.grpBul.TabIndex = 0;
            this.grpBul.TabStop = false;
            this.grpBul.Text = "Öğrenci Bul";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(79, 68);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(79, 103);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 201);
            this.Controls.Add(this.grpBul);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.grpBul.ResumeLayout(false);
            this.grpBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrNo;
    }
}