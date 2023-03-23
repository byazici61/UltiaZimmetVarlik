
namespace UltiaVarlik.DTO
{
    public class VarlikDepo : AnaDTO
    {
        public int VarlikDepoID { get; set; }
        public Varlik Varlik { get; set; }
        public Depo Depo { get; set; }
        public string Aciklama { get; set; }
       
    }
}
