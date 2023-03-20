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
    public class PersonelGirisDAL 
    {
        public GeriDonusum VeriCek(string mail,string sifre)
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi($"select COUNT(*) from Personel where EMail = '{mail}' and PersonelSifresi = '{sifre}'");
            
            int sonuc =Convert.ToInt32(con.ExecutScalar());
            return new GeriDonusum()
            {
                GeriDonusMesaji = sonuc > 0 ? "Başarıyla Giriş Yapıldı." : "Kullanıcı Adı veya Parola Hatalı.",
                GeriDonus = sonuc,
                GeriDonusTipi = sonuc > 0,
            };
        }
    }
}
