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
    public class SirketEkipDAL : IVeriCek<SirketEkip>
    {

        List<SirketEkip> EkipListesi;


        public List<SirketEkip> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select SirketEkipID,SirketEkipAdi from SirketEkip where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                EkipListesi = new List<SirketEkip>();
                while (rdr.Read())
                {
                    EkipListesi.Add(new SirketEkip()
                    {
                        SirketEkipID = rdr.GetInt32(0),
                        SirketEkipAdi = rdr.GetString(1),


                    });
                }

            }
            return EkipListesi;
        }


    }
}
