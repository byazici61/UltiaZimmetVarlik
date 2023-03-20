using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class SirketEkip
    {
        public int SirketEkipID { get; set; }
        public string SirketEkipAdi { get; set; }
        public SirketEkip UstSirketEkip { get; set; }
    }
}
