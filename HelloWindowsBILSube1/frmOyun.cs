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
        int sure = 3;
        public frmOyun()
        {
            InitializeComponent();
            lblSure.Text = sure.ToString();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }

            var rnd = new Random();
            btnYakala.Location = new Point(rnd.Next(this.ClientSize.Width - btnYakala.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btnYakala.Height));
            skor++;
            lblSkor.Text = skor.ToString();

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
        }
    }
}
