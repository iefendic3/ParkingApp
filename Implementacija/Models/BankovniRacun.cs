using System.ComponentModel.DataAnnotations;

namespace Projekat___Parking.Models
{
    public class BankovniRacun
    {
        [Key]
        public int brojRacuna { get; set; }
        public int jmbgVlasnikaRacuna { get; set; }
        public double raspolozivaSredstva { get; set; }

        public BankovniRacun()
        {

        }

    }
}