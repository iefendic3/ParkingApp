using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat___Parking.Models
{
    public class VIPKorisnik : Korisnik
    {
        public VIPKorisnik()
        {
        }
        [ForeignKey("Parking")]
        public Parking parkingVip { get; set; }

    }
}