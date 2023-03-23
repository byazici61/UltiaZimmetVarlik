using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class VarlikDepoDAL : IVeriCekID<VarlikDepo>
    {
        List<VarlikDepo> VarlikDepolar;
        /// <summary>
        /// depo id ye  göre depo bilgisi çeken dal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<VarlikDepo> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select vd.VarlikDepoID, mm1.MarkaModelAdi,mm.MarkaModelAdi,f.ParaMiktari , pb.ParaBirimAdi from VarlikDepo vd " +
                "inner join Varlik v on vd.VarlikID = v.VarlikID " +
                "inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                "inner join Fiyat f on f.VarlikID = v.VarlikID " +
                "inner join ParaBirimi pb on f.ParaBirimiID = pb.ParaBirimiID " +
                $"where DepoID = {id} and f.AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                VarlikDepolar = new List<VarlikDepo>();
                while (rdr.Read())
                {
                    VarlikDepolar.Add(new VarlikDepo()
                    {
                        VarlikDepoID = rdr.GetInt32(0),
                        Varlik = new Varlik() { MarkaModel = new MarkaModel() {MarkaModeAdi = rdr.GetString(1)+" "+rdr.GetString(2)},Fiyat=Convert.ToDouble(rdr.GetDecimal(3)),Aciklama = rdr.GetString(4) }
                    });
                }

            }
            return VarlikDepolar;
        }
        VarlikDepo VarlikDepo;

        /// <summary>
        /// bir ürünün hangi depoda olduğunu bulan dal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VarlikDepo DepoBul(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select VarlikDepoID from VarlikDepo where VarlikID ={id}");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                VarlikDepo = new VarlikDepo();
                while (rdr.Read())
                {
                    VarlikDepo.VarlikDepoID = rdr.GetInt32(0);
    
                }

            }
            return VarlikDepo;



        }

    }
}
