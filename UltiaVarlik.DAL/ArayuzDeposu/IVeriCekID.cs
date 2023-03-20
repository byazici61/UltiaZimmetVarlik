using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    interface IVeriCekID<T> where T : class
    {
        List<T> VeriCek(int id);
    }
}
