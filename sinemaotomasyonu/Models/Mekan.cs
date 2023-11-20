using System.ComponentModel.DataAnnotations;

namespace sinemaotomasyonu.Models
{
    public class Mekan
    {
        [Key]
        public int mekanID { get; set; }
        public string mekanAdi { get; set; }
        public string  mekanAdres { get; set; }

        
    }
}
