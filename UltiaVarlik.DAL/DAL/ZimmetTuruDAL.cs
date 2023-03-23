using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class ZimmetTuruDAL : IVeriCek<ZimmetTuru>
    {

        List<ZimmetTuru> ZimmetTuruistesi;

        /// <summary>
        /// db den zimemt türlerini çeken dal
        /// </summary>
        /// <returns></returns>
        public List<ZimmetTuru> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select ZimmmetTuruID,ZimmetTuru from ZimmetTuru where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                ZimmetTuruistesi = new List<ZimmetTuru>();
                while (rdr.Read())
                {
                    ZimmetTuruistesi.Add(new ZimmetTuru()
                    {
                        ZimmetTuruID = rdr.GetInt32(0),
                        ZimmetTuruAdi = rdr.GetString(1),

                    });
                }

            }
            return ZimmetTuruistesi;
        }


    }
}
