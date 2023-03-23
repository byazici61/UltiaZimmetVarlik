using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class ZimmetNedeni : AnaDTO
    {
        public int ZimmetNedeniID { get; set; }
        public string ZimmetNedeniAdi { get; set; }
        public override string ToString()
        {
            return ZimmetNedeniAdi;
        }
    }
}
