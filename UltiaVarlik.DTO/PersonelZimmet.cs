using System;

namespace UltiaVarlik.DTO
{
    public class PersonelZimmet : AnaDTO
    {
        public int KullaniciZimmetID { get; set; }
        public Personel Personel { get; set; }
        public Zimmet Zimmet { get; set; }
        public DateTime ZimmetBaslangicTarihi { get; set; }
        public DateTime ZimmetBitisTarihi { get; set; }
    }
}
