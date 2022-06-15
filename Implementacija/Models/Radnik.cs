using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat___Parking.Models
{
    public class Radnik : Osoba
    {
        public Radnik()
        {
        }
        [ForeignKey("Parking")]
        public Parking parking { get; set; }

    }
}