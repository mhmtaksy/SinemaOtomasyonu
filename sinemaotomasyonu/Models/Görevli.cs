using System.ComponentModel.DataAnnotations;

namespace sinemaotomasyonu.Models
{
    public class Görevli
    {
        [Key]
        public int görevliID { get; set; }
        [Required]
        public string görevliAdi { get; set; }
        [Required]
        public string görevliSoyad { get; set; }
        public decimal görevliMaas { get; set; }
    }
}
