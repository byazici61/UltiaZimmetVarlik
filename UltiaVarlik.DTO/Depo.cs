
namespace UltiaVarlik.DTO
{
    public class Depo: AnaDTO
    {
        public int DepoID { get; set; }
        public string DepoAdi { get; set; }
        public SirketEkip SirketEkip { get; set; }
        public override string ToString()
        {
            return DepoAdi;     
        }
    }
}
