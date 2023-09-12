using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.Entities
{
    public class Room
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Type { get; set; }

        [StringLength(50)]
        [Required]
        public string Price { get; set; } 

        [StringLength(50)]
        [Required]
        public string PhotoPath { get; set; }

    }
}