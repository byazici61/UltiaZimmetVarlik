using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class ZimmetDAL : IVeriEkle<Zimmet>
    {
        /// <summary>
        /// zimmet tablosuna bir zimmet ekleyen dal
        /// </summary>
        /// <param name="eklenecekVeri"></param>
        /// <returns></returns>
        public GeriDonusum VeriEkle(Zimmet eklenecekVeri)
        {

            MSSQLSaglayicisi con = new MSSQLSaglayicisi("insert into Zimmet(ZimmedNedeniID,ZimmetTuruID,VarlikDepoID,Acıklama,AktifMi)Values(@zimmetnedeniıd,@zimmetturuid,@varlikdepoid,@aciklama,@aktifmi)");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@zimmetnedeniıd", eklenecekVeri.ZimmetNedeni.ZimmetNedeniID));
            parametreListem.Add(new SqlParameter("@zimmetturuid", eklenecekVeri.ZimmetTuru.ZimmetTuruID));
            parametreListem.Add(new SqlParameter("@varlikdepoid", eklenecekVeri.VarlikDepo.VarlikDepoID));
            parametreListem.Add(new SqlParameter("@aciklama", eklenecekVeri.Aciklama));
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

        /// <summary>
        /// en son eklenen zimmetin id sinin dönen dal
        /// </summary>
        /// <returns></returns>
        public int IdDon()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select Top(1) ZimmedID from Zimmet order by ZimmedID desc");
           
            return Convert.ToInt32(con.ExecutScalar());
        }
    }
}
