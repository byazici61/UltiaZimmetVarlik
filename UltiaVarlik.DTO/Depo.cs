using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Depo: AnaDTO
    {
        public int DepoID { get; set; }
        public string DepoAdi { get; set; }
        public SirketEkip SirketEkip { get; set; }
    }
}
