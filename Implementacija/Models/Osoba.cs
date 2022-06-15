using System.ComponentModel.DataAnnotations;

namespace Projekat___Parking.Models
{
    public abstract class Osoba
    {
        protected Osoba()
        {
        }

        public string ime { get; set; }
        public string prezime { get; set; }
        [Key]
        public string jmbg { get; set; }

    }
}