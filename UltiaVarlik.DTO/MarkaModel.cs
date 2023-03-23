

namespace UltiaVarlik.DTO
{
    public class MarkaModel : AnaDTO
    {
        public int MarkaModelID { get; set; }
        public string MarkaModeAdi { get; set; }
        public MarkaModel UstMarkaModel { get; set; }
        public override string ToString()
        {
            return MarkaModeAdi;
        }
    }
}
