using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.DAL.ArayüzDeposu
{
    public interface IVeriEkle<T> where T:class
    {
        GeriDonusum VeriEkle(T EklenecekVeri);
    }
}
