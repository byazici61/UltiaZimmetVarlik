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
    public class ModelDAL : IVeriCekID<MarkaModel>
    {
        List<MarkaModel> MarkaListesi;
        public List<MarkaModel> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select DISTINCT mm1.MarkaModelID,  mm1.MarkaModelAdi  from MarkaModel mm inner join MarkaModel mm1 on mm1.UstMarkaModelID != mm1.MarkaModelID where mm1.AktifMi = 'True' and mm1.UstMarkaModelID ={id}");
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
