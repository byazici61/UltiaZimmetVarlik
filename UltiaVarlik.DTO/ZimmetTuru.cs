

namespace UltiaVarlik.DTO
{
    public class ZimmetTuru : AnaDTO
    {
        public int ZimmetTuruID { get; set; }
        public string ZimmetTuruAdi { get; set; }
        public override string ToString()
        {
            return ZimmetTuruAdi;
        }
    }
}
