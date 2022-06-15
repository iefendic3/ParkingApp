using System.ComponentModel.DataAnnotations;

namespace Projekat___Parking.Models
{
    public class Vozilo
    {
        public Vozilo()
        {
        }

        public TipVozila tipVozila { get; set; }
        [Key]
        public string tabliceVozila { get; set; }

    }
}