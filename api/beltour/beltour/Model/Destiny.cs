using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace beltour.Model
{
    [Table("Destinos")]
    public class Destiny
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? City { get; set; }

        [Required]
        [StringLength(50)]
        public string? State { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? Country { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? International { get; set; }
        
    }
}
