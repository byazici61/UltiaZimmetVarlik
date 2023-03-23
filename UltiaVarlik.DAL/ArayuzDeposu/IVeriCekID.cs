using System.Collections.Generic;
using UltiaVarlik.DTO;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    interface IVeriCekID<T> where T : AnaDTO
    {
        List<T> VeriCek(int id);
    }
}
