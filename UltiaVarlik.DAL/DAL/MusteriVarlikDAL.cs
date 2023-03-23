using System.Collections.Generic;
using System.Data.SqlClient;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class MusteriVarlikDAL : IVeriEkle<MusteriVarlik>
    {

        /// <summary>
        /// MüşteriVarlik tablosuna müşteriVarlik tipindeki bir neseneyi ekleyen DAL
        /// </summary>
        /// <param name="eklenecekVeri"></param>
        /// <returns></returns>
        public GeriDonusum VeriEkle(MusteriVarlik eklenecekVeri)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("insert into MusteriVarlik(MusteriID,VarlıkID,Açıklama,AktifMİ) " +
                "Values(@musteriid,@varlikid,@Aciklama,@AktifMi)");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@musteriid", eklenecekVeri.Musteri.MusteriID));
            parametreListem.Add(new SqlParameter("@varlikid", eklenecekVeri.Varlik.VarlikID));
            parametreListem.Add(new SqlParameter("@Aciklama", eklenecekVeri.Aciklama));
            parametreListem.Add(new SqlParameter("@AktifMi", true));
            con.ParametreEkle(parametreListem.ToArray());
            int etkilenenSatirSayisi = con.ExcecuteNon();

            return new GeriDonusum()
            {
                GeriDonus = etkilenenSatirSayisi,
                GeriDonusMesaji = etkilenenSatirSayisi > 0 ? "Tüketim Atandı" : "Tüketim Atanamadi. Girilen Abone Numarası Doğru Değil-",
                GeriDonusTipi = etkilenenSatirSayisi > 0
            };
        }
    }
}
