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
        public List<Fiyat> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select f.FiyatID, f.ParaMiktari,p.ParaBirimAdi from Fiyat f  inner join ParaBirimi p on f.ParaBirimiID = p.ParaBirimiID where f.AktifMi = 'True' and f.VarlikID = {id}");
            //con.BaglantiAc();
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                varlikGrubuListesi = new List<VarlikGrubu>();
                while (rdr.Read())
                {
                    varlikGrubuListesi.Add(new VarlikGrubu()
                    {
                        VarlikGrubuID = rdr.GetInt32(0),
                        VarlikGrubuAdi = rdr.GetString(1),

                    });
                }

            }
            return varlikGrubuListesi;
        }
    }
}
