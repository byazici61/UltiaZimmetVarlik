using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class DepoDAL : IVeriCek<Depo>
    {

        List<Depo> DepoListesi;

        /// <summary>
        /// Dbden depoları çeken DAL
        /// </summary>
        /// <returns></returns>
        public List<Depo> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select DepoID, DepoAdi from Depo where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                DepoListesi = new List<Depo>();
                while (rdr.Read())
                {
                    DepoListesi.Add(new Depo()
                    {
                        DepoID = rdr.GetInt32(0),
                        DepoAdi = rdr.GetString(1),

                    });
                }

            }
            return DepoListesi;
        }
    }

}

