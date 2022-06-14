using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat___Parking.Models
{
    public class Parking
    {
        public Parking()
        {
        }
        [Key]
        public int id { get; set; }
        public string nazivParkinga { get; set; }
        public int kapacitetParkinga { get; set; }
        public double cijenaParkinga { get; set; }
        public int brojZauzetihMjesta { get; set; }
        public int brojRezervisanihMjesta { get; set; }
        [ForeignKey("Vlasnik")]
        public Vlasnik vlasnik { get; set; }
        [ForeignKey("Grad")]
        public Grad grad { get; set; }

    }
}
