using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.DAL.ArayuzDeposu
{
    public interface IVeriEkle<T> where T : AnaDTO
    {
        GeriDonusum VeriEkle(T eklenecekVeri);
    }
}
