using System.Data.SqlClient;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class PersonelGirisDAL 
    {
        /// <summary>
        /// MAil ve şifre bilgisine göre ilglili personeli dönen DAL
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public Personel VeriCek(string mail,string sifre)
        {
            Personel GirisYapanKullanici = null;
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("SELECT p.PersonelID,p.PersonelAdi,p.PersonelSoyadi, rl.RolAdi, se.SirketEkipAdi, se.SirketEkipID  " +
                "from Personel p " +
                "inner join Rol rl on rl.RolID = p.RolID " +
                "inner join SirketEkip se on p.SirketEkipID = se.SirketEkipID " +
                $"where p.EMail = '{mail}' and p.PersonelSifresi = '{sifre}' and p.AktifMi='True'");

            SqlDataReader rdr =con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                

                while (rdr.Read())
                {
                    GirisYapanKullanici = new Personel()
                    {
                        PersonelID = rdr.GetInt32(0),
                        PersonelAdi = rdr.GetString(1),
                        PersonelSoyadi = rdr.GetString(2),
                        Rol = new Rol() { RolAdi = rdr.GetString(3) },
                        SirketEkip = new SirketEkip { SirketEkipAdi = rdr.GetString(4),SirketEkipID=rdr.GetInt32(5) }

                    };
                    
                }
                
            }
            return GirisYapanKullanici;

        }
    }
}
