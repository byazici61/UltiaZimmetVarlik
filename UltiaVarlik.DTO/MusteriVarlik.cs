
namespace UltiaVarlik.DTO
{
    public class MusteriVarlik : AnaDTO
    {
        public int MusteriVarlikID { get; set; }
        public  Musteri Musteri { get; set; }
        public Varlik Varlik { get; set; }
        public string Aciklama { get; set; }
    }
}
