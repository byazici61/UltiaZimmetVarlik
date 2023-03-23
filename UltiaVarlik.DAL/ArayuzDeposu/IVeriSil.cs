using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    public interface IVeriSil<T> where T : AnaDTO
    {

        GeriDonusum VeriSil(object SilinecekVeriID);
    }
}
