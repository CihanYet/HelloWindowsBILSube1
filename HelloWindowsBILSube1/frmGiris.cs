using GameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsBILSube1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == String.Empty || txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Ad ve soyad zorunludur!");
            }
            else
            {
                Level seviye;
                if (rdKolay.Checked)
                {
                    seviye = Level.Kolay;
                }
                else if (rdOrta.Checked)
                {
                    seviye = Level.Orta;
                }
                else if (rdZor.Checked)
                {
                    seviye = Level.Zor;
                }
                else
                {
                    MessageBox.Show("Seviye seçiniz!");
                    return;
                }

                //var info = new GameInfo();
                //info.Ad = txtAd.Text.Trim();
                //info.Soyad=txtSoyad.Text.Trim();
                //info.Seviye = seviye;

                var frm = new frmOyun(new GameInfo { Ad=txtAd.Text.Trim(),Soyad=txtSoyad.Text.Trim(),Seviye=seviye});
                frm.Show();
            }
        }
    }
}
