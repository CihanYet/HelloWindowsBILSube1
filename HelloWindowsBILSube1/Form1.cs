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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btn=new Button();
            btn.Text = "Bizim Button";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(50, 50);
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizim Button Clicklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Windows!!");
        }
    }
}
