using System.Collections.Generic;
using UltiaVarlik.DTO;


namespace UltiaVarlik.DAL.ArayuzDeposu
{
    public interface IVeriCek<T> where T : AnaDTO
    {
        List<T> VeriCek();
        
    }
}
