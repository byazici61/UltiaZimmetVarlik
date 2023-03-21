using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Varlik : AnaDTO
    {
        public int VarlikID { get; set; }
        public Guid? Barkot { get; set; }
        public double Fiyat { get; set; }
        public VarlikDurumu VarlikDurumu { get; set; }
        public VarlikGrubu VarlikGrubu { get; set; }
        public MarkaModel MarkaModel { get; set; }
        public bool GarantiliMi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double MaliyetFiyati { get; set; }
        public ParaBirimi MaaliyetParaBirimi { get; set; }
        public double? Miktar { get; set; }
        public Birim Birim { get; set; } = null;
        public DateTime? EmeklilikTarihi { get; set; } 
        public string Aciklama { get; set; }
        public string DosyaYolu { get; set; }
    }
}
