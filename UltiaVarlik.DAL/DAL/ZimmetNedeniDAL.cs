using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class ZimmetNedeniDAL : IVeriCek<ZimmetNedeni>
    {

        List<ZimmetNedeni> ZimmetNedeniListes;

        /// <summary>
        /// dbden zimmet nedenlerini çeken dal
        /// </summary>
        /// <returns></returns>
        public List<ZimmetNedeni> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select ZimmetNedeniID,ZimmetNedeniAdi from ZimmetNedeni where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                ZimmetNedeniListes = new List<ZimmetNedeni>();
                while (rdr.Read())
                {
                    ZimmetNedeniListes.Add(new ZimmetNedeni()
                    {
                        ZimmetNedeniID = rdr.GetInt32(0),
                        ZimmetNedeniAdi = rdr.GetString(1),

                    });
                }

            }
            return ZimmetNedeniListes;
        }


    }
}
