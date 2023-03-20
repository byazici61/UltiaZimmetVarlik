using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class SirketEkipZimmet
    {
        public int SirketEkipZimmetID { get; set; }
        public SirketEkip SirketEkip { get; set; }
        public Zimmet Zimmet { get; set; }
        public DateTime ZimmetBaslangicTarihi { get; set; }
        public DateTime ZimmetBitisTarihi { get; set; }
    }
}
