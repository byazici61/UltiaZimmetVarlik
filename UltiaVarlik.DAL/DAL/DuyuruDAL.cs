using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    /// <summary>
    /// DataBaseden Tüm Duyurulaarı Çeken DAL
    /// </summary>
    public class DuyuruDAL : IVeriCek<Duyuru>
    {

        List<Duyuru> Duyurular;
        public List<Duyuru> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select DuyuruBasligi,DuyuruMetni from Duyuru");

            SqlDataReader rdr = con.ExcuteRedaer();

            if (rdr.HasRows)
            {
                Duyurular = new List<Duyuru>();
                while (rdr.Read())
                {
                    Duyurular.Add(new Duyuru()
                    {
                        DuyuruBasligi = rdr.GetString(0),
                        DuyuruMetni = rdr.GetString(1) 
                        
                    });

                }

            }
            return Duyurular;
        }
    }
}
