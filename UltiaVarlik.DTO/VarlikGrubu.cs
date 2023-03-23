

namespace UltiaVarlik.DTO
{
    public class VarlikGrubu : AnaDTO
    {
        public int VarlikGrubuID { get; set; }
        public string VarlikGrubuAdi { get; set; }

        public override string ToString()
        {
            return VarlikGrubuAdi;
        }
    }
}
