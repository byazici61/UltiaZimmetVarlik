using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DTO;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    interface IVeriCekID<T> where T : AnaDTO
    {
        List<T> VeriCek(int id);
    }
}
