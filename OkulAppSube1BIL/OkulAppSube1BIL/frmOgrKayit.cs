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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulDbSube1BIL;Integrated Security=true");
                SqlCommand cmd = new SqlCommand($"Insert into tblOgrenciler values ('{txtAd.Text.Trim()}','{txtSoyad.Text.Trim()}','{txtNumara.Text.Trim()}')", cn);
                cn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(sonuc > 0 ? "Ekleme Başarılı" : "Ekleme Başarısız!");
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
                MessageBox.Show("Bir hata oluştu!");
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}
