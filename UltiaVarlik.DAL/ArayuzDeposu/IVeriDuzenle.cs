using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    public interface IVeriDuzenle<T> where T : AnaDTO
    {
        GeriDonusum VeriDuzenle(T DuzenlenecekVeri);
    }
}
