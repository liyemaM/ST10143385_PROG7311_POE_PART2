using System.ComponentModel.DataAnnotations;

namespace PROGPOE1.Models.DBEntities
{
    public class Farmer
    {
        [Key]
        public int FarmerId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FarmName { get; set; }

        [Required]
        public string Location { get; set; }

        // Navigation property (optional)
        public List<Product>? Products { get; set; }
    }
}
