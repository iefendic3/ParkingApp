using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat___Parking.Models
{
    public class Vlasnik : Osoba
    {
        public Vlasnik()
        {
        }
        [ForeignKey("Parking")]
        public Parking parking { get; set; }

    }
}
