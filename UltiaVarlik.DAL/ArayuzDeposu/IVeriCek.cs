using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    public interface IVeriCek<T> where T : AnaDTO
    {
        List<T> VeriCek();
        
    }
}
