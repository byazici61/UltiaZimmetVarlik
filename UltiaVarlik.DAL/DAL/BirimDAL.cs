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
    /// <summary>
    /// DataBaseden Tüm Birimleri Çeken DAL
    /// </summary>
    public class BirimDAL : IVeriCek<Birim>
    {
        List<Birim> birimler;
        public List<Birim> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select BirimAdi,BirimID from Birim");

            SqlDataReader rdr = con.ExcuteRedaer();

            if (rdr.HasRows)
            {
                birimler = new List<Birim>();
                while (rdr.Read())
                {
                    birimler.Add(new Birim()
                    {
                        BirimAdi = rdr.GetString(0),
                        BirimID = rdr.GetInt32(1)
                    });

                }

            }
            return birimler;
        }
    }
}
