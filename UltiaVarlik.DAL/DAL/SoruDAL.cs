using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class SoruDAL : IVeriCek<Soru>
    {
        List<Soru> Sorular;

        /// <summary>
        /// DB den Tüm sorulari çeken DAL
        /// </summary>
        /// <returns></returns>
        public List<Soru> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select Soru,cevap from Soru");

            SqlDataReader rdr = con.ExcuteRedaer();

            if (rdr.HasRows)
            {
                Sorular = new List<Soru>();
                while (rdr.Read())
                {
                    Sorular.Add( new Soru()
                    {
                        SoruMetni = rdr.GetString(0),
                        Cevap = rdr.GetString(1)
                    });

                }
                
            }
            return Sorular;
        }
        
            
        
}
}
