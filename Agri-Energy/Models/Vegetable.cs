using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agri_Energy.Models
{
    [Table("Vegetable")]

    public class Vegetable
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? VegetableName { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int VegTypeId { get; set; }
        public VegType Vegtypes { get; set; }
        public Order Orders { get; set; }
        public Vegetable Vegetables { get; set; } 
    }
}
