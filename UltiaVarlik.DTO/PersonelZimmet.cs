using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class PersonelZimmet
    {
        public int KullaniciZimmetID { get; set; }
        public Personel Personel { get; set; }
        public Zimmet Zimmet { get; set; }
        public DateTime ZimmetBaslangicTarihi { get; set; }
        public DateTime ZimmetBitisTarihi { get; set; }
    }
}
