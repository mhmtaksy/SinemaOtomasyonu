using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sinemaotomasyonu.Models
{
    public class Seanslar
    {
        [Key]
        public int seansID { get; set; }
        [Required]
        public string seansAdi { get; set; }

        public DateTime seansSaati { get; set; }

        [ForeignKey("görevliID")]
        public int görevliID { get; set; }

        public virtual Görevli Görevli { get; set; }
    }
}
