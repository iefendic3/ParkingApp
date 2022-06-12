namespace Projekat___Parking.Models
{
    public class Korisnik : Osoba
    {
        public Vozilo vozilo { get; set; }
        public BankovniRacun racun { get; set; }

    }
}
