using GameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsBILSube1
{
    
    public partial class frmOyun : Form
    {
        int skor = 0;
        int sure = 10;
        public frmOyun(GameInfo bilgi)
        {
            InitializeComponent();
            lblSure.Text = sure.ToString();
            lblKullanici.Text = $"{bilgi.Ad} {bilgi.Soyad}";
            switch (bilgi.Seviye)
            {
                case Level.Kolay:
                    this.Size = new Size(300, 300);
                    break;
                case Level.Orta:
                    this.Size = new Size(500, 500);
                    break;
                case Level.Zor:
                    this.Size = new Size(800, 800);
                    break;
                default:
                    break;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }

            var rnd = new Random();
            b.Location = new Point(rnd.Next(this.ClientSize.Width - b.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - b.Height));
            if (b.Name == "btnYakala")
            {
                skor++;
            }
            else
            {
                skor -= 5;
            }

            lblSkor.Text = skor.ToString();

            if (skor % 10 == 0)
            {
                var btn = new Button();
                btn.Size = new Size(50, 50);
                btn.BackColor = Color.Red;
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btn.Height));
                btn.MouseMove += button1_MouseMove;
                this.Controls.Add(btn);
            }
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                btnYakala.Enabled = false;
                MessageBox.Show($"Süreniz doldu!Skorunuz:{skor}");
            }
        }
    }
}
