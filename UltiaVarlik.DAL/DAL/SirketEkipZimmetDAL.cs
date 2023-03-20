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
    public class SirketEkipZimmetDAL : IVeriCekID<SirketEkipZimmet>
    {
        List<SirketEkipZimmet> Zimmetler;

        public List<SirketEkipZimmet> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select sez.SirketEkipID as [Kayıt Numarası],v.Barkod, vg.VarlikGrubuAdi as [Ürün Tipi],fy.ParaMiktari as Fiyat ,mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model from SirketEkipZimmet sez inner join SirketEkip se on sez.SirketEkipID = se.SirketEkipID inner join Zimmet z on sez.ZimmetID = z.ZimmedID inner join VarlikDepo vd on z.VarlikDepoID = vd.VarlikDepoID inner join Varlik v on vd.VarlikID = v.VarlikID inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID inner join Fiyat fy on fy.VarlikID = v.VarlikID inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID where sez.SirketEkipID = {id} and sez.AktifMi=1");
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                Zimmetler = new List<SirketEkipZimmet>();

                while (rdr.Read())
                {
                    VarlikGrubu varlikGrubu = new VarlikGrubu() { VarlikGrubuAdi = rdr.GetString(2) };
                    MarkaModel markaModel = new MarkaModel() { MarkaModeAdi = rdr.GetString(4) + " " + rdr.GetString(5) };
                    Varlik varlik = new Varlik() { Barkot = Guid.Empty, VarlikGrubu = varlikGrubu, MarkaModel = markaModel, Fiyat = Convert.ToDouble(rdr.GetDecimal(3)) };
                    Zimmet zimmet = new Zimmet() { ZimmetID = rdr.GetInt32(0), Varlik = varlik };
                    SirketEkipZimmet sirketZimmet = new SirketEkipZimmet() { SirketEkipZimmetID = rdr.GetInt32(0), Zimmet = zimmet };
                    try
                    {
                        sirketZimmet.Zimmet.Varlik.Barkot = rdr.GetGuid(1);
                    }
                    catch (Exception ex)
                    {
                        // do nothing, default value already set

                    }
                    Zimmetler.Add(sirketZimmet);
                }


            }




            return Zimmetler;
        }
    }
}
