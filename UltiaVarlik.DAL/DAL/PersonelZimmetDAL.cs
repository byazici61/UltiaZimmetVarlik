using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class PersonelZimmetDAL : IVeriCekID<PersonelZimmet>,IVeriEkle<PersonelZimmet>
    {
        List<PersonelZimmet> Zimmetler;

        /// <summary>
        /// PErsonel Zimmet Tablosundan bir personele ait zimmetleri çeken DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<PersonelZimmet> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select pz.KullaniciZimmetID as [Kayıt Numarası],v.Barkod, vg.VarlikGrubuAdi as [Ürün Tipi],fy.ParaMiktari as Fiyat ,mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model,v.VarlikID  " +
                "from PersonelZimmet pz " +
                "inner join Personel p on pz.PersonelID = p.PersonelID " +
                "inner join Zimmet z on pz.ZimmetID = z.ZimmedID " +
                "inner join VarlikDepo vd on z.VarlikDepoID = vd.VarlikDepoID " +
                "inner join Varlik v on vd.VarlikID = v.VarlikID " +
                "inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID " +
                "inner join Fiyat fy on fy.VarlikID = v.VarlikID " +
                "inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                $"where pz.PersonelID = {id} and pz.AktifMi = 'True' and fy.AktifMi='True'");
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                Zimmetler = new List<PersonelZimmet>();

                while (rdr.Read())
                {
                    VarlikGrubu varlikGrubu = new VarlikGrubu() { VarlikGrubuAdi = rdr.GetString(2) };
                    MarkaModel markaModel = new MarkaModel() { MarkaModeAdi = rdr.GetString(4)+" "+rdr.GetString(5)};
                    Varlik varlik = new Varlik() { VarlikID = rdr.GetInt32(6), Barkot = Guid.Empty, VarlikGrubu = varlikGrubu, MarkaModel = markaModel, Fiyat = Convert.ToDouble(rdr.GetDecimal(3)) };
                    Zimmet zimmet = new Zimmet() { ZimmetID = rdr.GetInt32(0),Varlik = varlik };
                    PersonelZimmet personelZimmet = new PersonelZimmet() { KullaniciZimmetID = rdr.GetInt32(0), Zimmet = zimmet };
                    try
                    {
                        personelZimmet.Zimmet.Varlik.Barkot = rdr.GetGuid(1);
                    }
                    catch (Exception )
                    {

                    }
                    Zimmetler.Add(personelZimmet);
                }

                
            }
            return Zimmetler;
        }

        /// <summary>
        /// personel zimmete personel zimmet tipinde bir nesne ekleyen dal
        /// </summary>
        /// <param name="eklenecekVeri"></param>
        /// <returns></returns>
        public GeriDonusum VeriEkle(PersonelZimmet eklenecekVeri)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("insert into PersonelZimmet(PersonelID,ZimmetID,BaslangicTarihi,BitisTarihi,AktifMi)values(@personelid,@zimmetid,@bastarih,@bittarih,@aktifmi)");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@personelid", eklenecekVeri.Personel.PersonelID));
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
