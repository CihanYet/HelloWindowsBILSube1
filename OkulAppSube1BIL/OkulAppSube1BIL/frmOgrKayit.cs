using OkulApp.MODEL;
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
using OkulApp.BLL;

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
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
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


    interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);

    }

    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        //
    }
}

//Garbage Collector
