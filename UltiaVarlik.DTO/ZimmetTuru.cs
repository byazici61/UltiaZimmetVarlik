using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class ZimmetTuru : AnaDTO
    {
        public int ZimmetTuruID { get; set; }
        public string ZimmetTuruAdi { get; set; }
        public override string ToString()
        {
            return ZimmetTuruAdi;
        }
    }
}
