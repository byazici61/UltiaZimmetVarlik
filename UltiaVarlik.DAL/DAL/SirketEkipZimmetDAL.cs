using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class SirketEkipZimmetDAL : IVeriCekID<SirketEkipZimmet>,IVeriEkle<SirketEkipZimmet>
    {
        List<SirketEkipZimmet> Zimmetler;

        /// <summary>
        /// SirketEKipTablosundan sirketekip id bilgisine göre Veri Çeken DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<SirketEkipZimmet> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select sez.SirketEkipID as [Kayıt Numarası],v.VarlikID,v.Barkod, vg.VarlikGrubuAdi as [Ürün Tipi],fy.ParaMiktari as Fiyat ,mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model " +
                "from SirketEkipZimmet sez inner join SirketEkip se on sez.SirketEkipID = se.SirketEkipID " +
                "inner join Zimmet z on sez.ZimmetID = z.ZimmedID " +
                "inner join VarlikDepo vd on z.VarlikDepoID = vd.VarlikDepoID " +
                "inner join Varlik v on vd.VarlikID = v.VarlikID " +
                "inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID " +
                "inner join Fiyat fy on fy.VarlikID = v.VarlikID " +
                "inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                $"where sez.SirketEkipID = {id} and sez.AktifMi='True' and fy.AktifMi='True'");
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                Zimmetler = new List<SirketEkipZimmet>();

                while (rdr.Read())
                {
                    VarlikGrubu varlikGrubu = new VarlikGrubu() { VarlikGrubuAdi = rdr.GetString(3) };
                    MarkaModel markaModel = new MarkaModel() { MarkaModeAdi = rdr.GetString(5) + " " + rdr.GetString(6) };
                    Varlik varlik = new Varlik() {VarlikID=rdr.GetInt32(1), Barkot = Guid.Empty, VarlikGrubu = varlikGrubu, MarkaModel = markaModel, Fiyat = Convert.ToDouble(rdr.GetDecimal(4)) };
                    Zimmet zimmet = new Zimmet() { ZimmetID = rdr.GetInt32(0), Varlik = varlik };
                    SirketEkipZimmet sirketZimmet = new SirketEkipZimmet() { Zimmet = zimmet };
                    try
                    {
                        sirketZimmet.Zimmet.Varlik.Barkot = rdr.GetGuid(2);
                    }
                    catch (Exception )
                    {
                       

                    }
                    Zimmetler.Add(sirketZimmet);
                }


            }

            return Zimmetler;
        }
        /// <summary>
        /// Sirket ekip tipinde aldığı nesne ile db ye yeni nesne ekleyen dal
        /// </summary>
        /// <param name="eklenecekVeri"></param>
        /// <returns></returns>
        public GeriDonusum VeriEkle(SirketEkipZimmet eklenecekVeri)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("insert into SirketEkipZimmet(SirketEkipID,ZimmetID,BaslangicTarihi,BitisTarihi,AktifMi)values(@ekipID,@zimmetid,@bastarih,@bittarih,@aktifmi)");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@ekipID", eklenecekVeri.SirketEkip.SirketEkipID));
            parametreListem.Add(new SqlParameter("@zimmetid", eklenecekVeri.Zimmet.ZimmetID));
            parametreListem.Add(new SqlParameter("@bastarih", eklenecekVeri.ZimmetBaslangicTarihi));
            parametreListem.Add(new SqlParameter("@bittarih", eklenecekVeri.ZimmetBitisTarihi));
            parametreListem.Add(new SqlParameter("@aktifmi", true));
            con.ParametreEkle(parametreListem.ToArray());
            int etkilenenSatirSayisi = con.ExcecuteNon();

            return new GeriDonusum()
            {
                GeriDonus = etkilenenSatirSayisi,
                GeriDonusMesaji = etkilenenSatirSayisi > 0 ? "Yeni Zimmet Oluşturuldu" : "Zimmet Oluşturulamadi",
                GeriDonusTipi = etkilenenSatirSayisi > 0
            };
        }
    }
}
