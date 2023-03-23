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
    public class PersonelDAL : IVeriCek<Personel>
    {

        List<Personel> PersonelListesi;


        public List<Personel> VeriCek()
        {
            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select PersonelID,PersonelAdi,PersonelSoyadi from Personel where AktifMi = 'True'");

            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                PersonelListesi = new List<Personel>();
                while (rdr.Read())
                {
                    PersonelListesi.Add(new Personel()
                    {
                        PersonelID = rdr.GetInt32(0),
                        PersonelAdi = rdr.GetString(1),
                        PersonelSoyadi = rdr.GetString(2)

                    });
                }

            }
            return PersonelListesi;
        }


    }
}
