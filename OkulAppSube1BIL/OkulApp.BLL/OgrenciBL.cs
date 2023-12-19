using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara)", p)>0;

        }
    }
}
//n Katmanlı Mimari