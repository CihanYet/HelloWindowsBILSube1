using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {
                using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulDbSube1BIL;Integrated Security=true"))
                {
                    using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
                    {
                        SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };
                        cmd.Parameters.AddRange(p);

                        cn.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        return sonuc > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
            //finally
            //{
            //    if (cn != null && cn.State != ConnectionState.Closed)
            //    {
            //        cn.Close();
            //        cn.Dispose();
            //        cmd.Dispose();
            //    }
            //}
        }
    }
}
//n Katmanlı Mimari