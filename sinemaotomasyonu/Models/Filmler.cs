using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sinemaotomasyonu.Models
{
    public class Filmler
    {
        [Key]
        public int filmID { get; set; }
        [Required]
        public string filmAdi { get; set; }
        public string filmKonu { get; set;}
        public decimal filmUcret {get; set;}
        [ForeignKey("mekanID")]
        public int mekanID { get; set; }

        public virtual Mekan Mekan { get; set; }

    }
}
