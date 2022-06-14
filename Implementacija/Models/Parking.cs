namespace Projekat___Parking.Models
{
    public class Parking
    {
        public string nazivParkinga { get; set; }
        public int kapacitetParkinga { get; set; }
        public double cijenaParkinga { get; set; }
        public int brojZauzetihMjesta { get; set; }
        public int brojRezervisanihMjesta { get; set; }
        public Vlasnik vlasnik { get; set; }
        public Grad grad { get; set; }

    }
}
