using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Soru : AnaDTO
    {
        public int SoruID { get; set; }
        public string SoruMetni { get; set; }
        public string Cevap { get; set; }
    }
}
