using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class VarlikDepo
    {
        public int VarlikDepoID { get; set; }
        public Varlik Varlik { get; set; }
        public Depo Depo { get; set; }
        public string Aciklama { get; set; }
       
    }
}
