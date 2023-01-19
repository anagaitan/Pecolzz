namespace Pecolzz.Models
{
    public class Cod
    {
        public int ID { get; set; }
        public decimal CodArticol { get; set; }
        public ICollection<Produs>? Produse { get; set; } //navigation property
    }
}
