using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class ParaBirimiDAL : IVeriCek<ParaBirimi>
    {
        
        List<ParaBirimi> paraBirimiListesi;

        /// <summary>
        /// DB den tüm para birimlerini çeken DAL
        /// </summary>
        /// <returns></returns>
        public List<ParaBirimi> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select ParaBirimiID, ParaBirimAdi from ParaBirimi where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                paraBirimiListesi = new List<ParaBirimi>();
                while (rdr.Read())
                {
                    paraBirimiListesi.Add(new ParaBirimi()
                    {
                        ParaBirimiID = rdr.GetInt32(0),
                        ParaBirimiAdi = rdr.GetString(1),

                    });
                }

            }
            return paraBirimiListesi;
        }
    }
}
