using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    class MusteriVarlik : AnaDTO
    {
        public int MusteriVarlikID { get; set; }
        public  Musteri Musteri { get; set; }
        public Varlik Varlik { get; set; }
    }
}
