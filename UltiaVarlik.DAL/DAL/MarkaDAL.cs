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
    public class MarkaDAL : IVeriCek<MarkaModel>
    {
        List<MarkaModel> MarkaListesi;
        public List<MarkaModel> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select DISTINCT mm1.MarkaModelID,mm1.MarkaModelAdi " +
                "from MarkaModel mm " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                "where mm1.AktifMi = 'True'");
            //con.BaglantiAc();
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                MarkaListesi = new List<MarkaModel>();
                while (rdr.Read())
                {
                    MarkaListesi.Add(new MarkaModel()
                    {
                        MarkaModelID = rdr.GetInt32(0),
                        MarkaModeAdi = rdr.GetString(1),

                    });
                }

            }
            return MarkaListesi;
        }
    }
}
