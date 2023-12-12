using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        bool OgrenciEkle(string ad, string soyad, string numara)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulDbSube1BIL;Integrated Security=true");
                SqlCommand cmd = new SqlCommand($"Insert into tblOgrenciler values ('{ad}','{soyad}','{numara}')", cn);
                cn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc > 0;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciEkle(txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtNumara.Text.Trim());
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }
    }
}
