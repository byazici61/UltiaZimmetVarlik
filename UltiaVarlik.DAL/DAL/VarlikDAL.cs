using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL
{
    public class VarlikDAL : IVeriCek<Varlik>, IVeriCekID<Varlik> , IVeriDuzenle<Varlik>
    {
        List<Varlik> Varliklar;
        public List<Varlik> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select v.VarlikID as [Kayıt Numarası],v.Barkod, vg.VarlikGrubuAdi as[Ürün Tipi], mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model , fy.ParaMiktari as Fiyat " +
                "from Varlik v " +
                "inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID inner " +
                "join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                "inner Join Fiyat fy on fy.VarlikID = v.VarlikID " +
                "where v.AktifMi='True' and fy.AktifMi='True'");
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

        public List<Varlik> VeriCek(int id)
        {

            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select v.VarlikID as [Kayıt Numarası], v.Barkod, b.BirimID as [Birim ID], b.BirimAdi as [Birim Adi],  vg.VarlikGrubuID as [Ürün Tipi ID], vg.VarlikGrubuAdi as [Ürün Tipi], mm1.MarkaModelID as [Marka ID], mm1.MarkaModelAdi as Marka, mm.MarkaModelID as [Model ID], mm.MarkaModelAdi as Model, IIf(v.GarantiliMİ = 1, 'Var', 'Yok') as [Garanti Durumu], v.CikisTarihi as [Giris Tarihi], v.Aciklama, v.MaliyetFiyati as [Urun Maliyeti], pb.ParaBirimiID as [Maaliyet Para Birimi ID], pb.ParaBirimAdi as [Maliyet Para Birimi],v.Miktar " +
                "from Varlik v " +
                "inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID " +
                "left join Birim b on v.BirimID = b.BirimID " +
                "inner join ParaBirimi pb on v.MaliyetParaBirimiID = pb.ParaBirimiID " +
                "inner join Fiyat fy on fy.VarlikID = v.VarlikID " +
                "inner join ParaBirimi pb1 on fy.ParaBirimiID = pb1.ParaBirimiID " +
                "inner join MarkaModel mm on v.MarkaModelID = mm.MarkaModelID " +
                "inner join MarkaModel mm1 on mm.UstMarkaModelID = mm1.MarkaModelID " +
                $"where v.VarlikID = {id}");
        
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
                    { //TODO barkotsuzu bi kontrol et
                        varlik.Barkot = Guid.Empty;
                        varlik.Birim = new Birim() { BirimID = rdr.GetInt32(2), BirimAdi = rdr.GetString(3) };
                        varlik.Miktar = Convert.ToInt32(rdr.GetDecimal(16));
                    }
                    
                    varlik.VarlikGrubu = new VarlikGrubu() { VarlikGrubuID = rdr.GetInt32(4), VarlikGrubuAdi = rdr.GetString(5) };
                    varlik.MarkaModel = new MarkaModel() { MarkaModelID = rdr.GetInt32(8), MarkaModeAdi = rdr.GetString(9), UstMarkaModel = new MarkaModel() { MarkaModelID = rdr.GetInt32(6), MarkaModeAdi = rdr.GetString(7) } };
                    varlik.GarantiliMi = (rdr.GetString(10) == "Var" );
                    varlik.CikisTarihi = rdr.GetDateTime(11);
                    varlik.Aciklama = rdr.GetString(12);
                    varlik.MaliyetFiyati = Convert.ToDouble(rdr.GetDecimal(13));
                    varlik.MaaliyetParaBirimi = new ParaBirimi() { ParaBirimiID = rdr.GetInt32(14), ParaBirimiAdi = rdr.GetString(15) };

                    Varliklar.Add(varlik);

                }

            }
            con.BaglantiKapat();
            return Varliklar;


        }

        public GeriDonusum VeriDuzenle(Varlik duzenlenecekVeri)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("update Varlik set GarantiliMi=@garanti , Aciklama=@aciklama  where VarlikID =@varlikid");
            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@garanti", duzenlenecekVeri.GarantiliMi));
            parametreListem.Add(new SqlParameter("@aciklama", duzenlenecekVeri.Aciklama ));
            parametreListem.Add(new SqlParameter("@varlikid", duzenlenecekVeri.VarlikID));
            con.ParametreEkle(parametreListem.ToArray());
            int etkilenenSatirSayisi = con.ExcecuteNon();

            return new GeriDonusum()
            {
                GeriDonus = etkilenenSatirSayisi,
                GeriDonusMesaji = etkilenenSatirSayisi > 0 ? "Varlık Başarıyla Guncelelndi" : "Varlık Güncellenemedi",
                GeriDonusTipi = etkilenenSatirSayisi > 0
            };


        }
    }
}
