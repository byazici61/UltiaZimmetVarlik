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
    public class FiyatDAL : IVeriCekID<Fiyat>
    {
        // TODO düzenlemeye devam et
        List<Fiyat> fiyatlar;
        public List<Fiyat> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select f.FiyatID, f.ParaMiktari,p.ParaBirimiID,p.ParaBirimAdi from Fiyat f  inner join ParaBirimi p on f.ParaBirimiID = p.ParaBirimiID where f.AktifMi = 'True' and f.VarlikID = {id}");
            //con.BaglantiAc();
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                fiyatlar = new List<Fiyat>();
                while (rdr.Read())
                {
                    fiyatlar.Add(new Fiyat()
                    {
                        FiyatID = rdr.GetInt32(0),
                        ParaMiktari = Convert.ToDouble(rdr.GetDecimal(1)),
                        ParaBirimi = new ParaBirimi()
                        {
                            ParaBirimiID=rdr.GetInt32(2),
                            ParaBirimiAdi = rdr.GetString(3),
                        }

                    });
                }

            }
            return fiyatlar;
        }
    }
}
