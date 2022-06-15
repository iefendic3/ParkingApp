using System.ComponentModel.DataAnnotations;

namespace Projekat___Parking.Models
{
    public class Grad
    {
        public Grad()
        {
        }
        [Key]
        public int postanskiBroj { get; set; }
        public string imeGrada { get; set; }
        public int brojStanovnika { get; set; }

    }
}