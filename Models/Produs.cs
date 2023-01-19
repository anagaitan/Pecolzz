using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Security.Policy;

namespace Pecolzz.Models
{
    public class Produs
    {
        public int ID { get; set; }

        [Display(Name = "Denumire produs")]
        public string Denumire_produs { get; set; }

        public string Descriere { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAdaugarii { get; set; }

        public int? CodID { get; set; }
        public Cod? Cod { get; set; }
    } //navigation property
}

