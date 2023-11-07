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
    public partial class frmEvent : Form
    {
        Random rnd = new Random();
        int sonuc = 0;
        public frmEvent()
        {
            InitializeComponent();
            btnSayi1.Text = rnd.Next(100).ToString();
            btnSayi2.Text = rnd.Next(100).ToString();
            btnSayi3.Text = rnd.Next(100).ToString();
        }

        private void frmEvent_MouseMove(object sender, MouseEventArgs e)
        {
            lblMetin.Text = "Gazi";
            lblKoordinat.Text = e.Location.ToString();
        }

        private void frmEvent_MouseLeave(object sender, EventArgs e)
        {
            lblMetin.Text = String.Empty;
        }

        private void Topla(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sonuc += int.Parse(btn.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"İşlemin sonucu:{sonuc}");
            sonuc = 0;
        }
    }
}
