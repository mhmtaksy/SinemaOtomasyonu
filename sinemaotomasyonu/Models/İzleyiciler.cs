using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sinemaotomasyonu.Models
{
    public class İzleyiciler
    {
        [Key]
        public int izleyiciID { get; set; }
        [Required]
        public string izleyiciAdi { get; set; }
        [Required]
        public string izleyiciSoyad {get; set; }
        
        [ForeignKey("seansID")]
        public int seansID { get; set; }
        public virtual Seanslar Seanslar { get; set; }
    }
}
