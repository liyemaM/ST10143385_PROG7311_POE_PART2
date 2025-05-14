using System.ComponentModel.DataAnnotations;

namespace PROGPOE1.Models.DBEntities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } = string.Empty;

        // ❌ REMOVE these — handled in Farmer.cs
        // public string FullName { get; set; }
        // public string FarmName { get; set; }
        // public string Email { get; set; }
        // public string Location { get; set; }
    }
}