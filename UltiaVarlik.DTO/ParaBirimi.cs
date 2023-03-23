

namespace UltiaVarlik.DTO
{
    public class ParaBirimi : AnaDTO
    {
        public int ParaBirimiID { get; set; }
        public string ParaBirimiAdi { get; set; }

        public override string ToString()
        {
            return ParaBirimiAdi;
        }
    }
}
