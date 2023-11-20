using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sinemaotomasyonu.Models
{
    public class Koltuklar
    {
        [Key]
        public int koltukID { get; set; }
        [Required]
        public string koltukAdi { get; set; }
        public string koltukÇeşidi { get; set; }
        
        [ForeignKey("filmID")]
        public int filmID { get; set; }

        public virtual Filmler Filmler { get; set; }
    }
}
