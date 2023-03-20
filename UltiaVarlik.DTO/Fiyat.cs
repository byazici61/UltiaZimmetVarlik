using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Fiyat
    {
        public int FiyatID { get; set; }
        public Varlik Varlik { get; set; }
        public double ParaMiktari { get; set; }
        public ParaBirimi ParaBirimi { get; set; }
        public DateTime GüncellemeTarihi { get; set; }
    }
}
