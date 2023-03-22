using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DAL.ArayuzDeposu;

using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class FiyatDAL : IVeriCekID<Fiyat> ,IVeriEkle<Fiyat>
    {
        // TODO düzenlemeye devam et
        List<Fiyat> fiyatlar;
        public List<Fiyat> VeriCek(int id)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select f.FiyatID, f.ParaMiktari,p.ParaBirimiID,p.ParaBirimAdi " +
                "from Fiyat f  " +
                "inner join ParaBirimi p on f.ParaBirimiID = p.ParaBirimiID " +
                $"where f.AktifMi = 'True' and f.VarlikID = {id}");
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

        public GeriDonusum VeriEkle(Fiyat eklenecekVeri)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("insert into Fiyat(VarlikID,ParaMiktari,GuncellemeTarihi,ParaBirimiID,AktifMi) " +
                "Values(@varlikid,@paramiktari,@tarih,@birimi,@aktifmi)");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@varlikid", eklenecekVeri.Varlik.VarlikID));
            parametreListem.Add(new SqlParameter("@paramiktari", eklenecekVeri.ParaMiktari));
            parametreListem.Add(new SqlParameter("@tarih", DateTime.Now));
            parametreListem.Add(new SqlParameter("@birimi", eklenecekVeri.ParaBirimi.ParaBirimiID));
            parametreListem.Add(new SqlParameter("@aktifmi", true));
            con.ParametreEkle(parametreListem.ToArray());
            int etkilenenSatirSayisi = con.ExcecuteNon();

            return new GeriDonusum()
            {
                GeriDonus = etkilenenSatirSayisi,
                GeriDonusMesaji = etkilenenSatirSayisi > 0 ? "Fiyat Bilgisi Başarıyla Eklendi" : "Fiyat Eklenemedi",
                GeriDonusTipi = etkilenenSatirSayisi > 0
            };
        }
    }
}
