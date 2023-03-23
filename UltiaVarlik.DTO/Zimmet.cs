

namespace UltiaVarlik.DTO
{
    public class Zimmet : AnaDTO
    {
        public int ZimmetID { get; set; }
        public Varlik Varlik { get; set; }
        public VarlikDepo VarlikDepo { get; set; }
        public ZimmetNedeni ZimmetNedeni { get; set; }
        public ZimmetTuru ZimmetTuru { get; set; }
        public string  Aciklama { get; set; }
    }
}
