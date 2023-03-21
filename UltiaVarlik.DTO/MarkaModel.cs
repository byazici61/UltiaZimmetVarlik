using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class MarkaModel : AnaDTO
    {
        public int MarkaModelID { get; set; }
        public string MarkaModeAdi { get; set; }
        public MarkaModel UstMarkaModel { get; set; }
        public override string ToString()
        {
            return MarkaModeAdi;
        }
    }
}
