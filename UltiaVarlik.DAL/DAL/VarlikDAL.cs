using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL
{
    public class VarlikDAL : IVeriCek<Varlik>
    {
        List<Varlik> Varliklar;
        public List<Varlik> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select v.VarlikID as [Kayıt Numarası],v.Barkod, vg.VarlikGrubuAdi as[Ürün Tipi], mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model , fy.ParaMiktari as Fiyat from Varlik v inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID inner Join Fiyat fy on fy.VarlikID = v.VarlikID where v.AktifMi=1");
            //con.BaglantiAc();
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                Varliklar = new List<Varlik>();

                while (rdr.Read())
                {
                    Varlik varlik = new Varlik();
                    varlik.VarlikID = rdr.GetInt32(0);
                    try
                    {
                        varlik.Barkot = rdr.GetGuid(1);

                    }
                    catch (Exception ex)
                    {
                        varlik.Barkot = Guid.Empty;
                    }
                    varlik.VarlikGrubu = new VarlikGrubu() { VarlikGrubuAdi = rdr.GetString(2) };
                    varlik.MarkaModel = new MarkaModel() { MarkaModeAdi = rdr.GetString(3)+ " "+rdr.GetString(4) };
                    varlik.Fiyat = Convert.ToDouble(rdr.GetDecimal(5));

                   
                    Varliklar.Add(varlik);

                }

            }
            con.BaglantiKapat();
            return Varliklar;
               
           
        }
    }
}
