using System.ComponentModel.DataAnnotations;

namespace ProjektAspNet.Models.Entities
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        public string Nazwa { get; set; }

        [Required]
        public string Lokalizacja { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal CenaZaNoc { get; set; }

        [Required]
        [Range(0, 100)]
        public int DostępnePokoje { get; set; }
    }
}
