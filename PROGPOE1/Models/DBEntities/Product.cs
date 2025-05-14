using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PROGPOE1.Models.DBEntities
{
    public class Product
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
