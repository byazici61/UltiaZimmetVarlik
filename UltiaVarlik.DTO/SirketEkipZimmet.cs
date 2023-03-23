using System;


namespace UltiaVarlik.DTO
{
    public class SirketEkipZimmet : AnaDTO
    {
        public int SirketEkipZimmetID { get; set; }
        public SirketEkip SirketEkip { get; set; }

        public Zimmet Zimmet { get; set; }
        public DateTime ZimmetBaslangicTarihi { get; set; }
        public DateTime ZimmetBitisTarihi { get; set; }
    }
}
