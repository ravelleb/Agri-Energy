using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agri_Energy.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCart_Id { get; set; }
        public int VegetableId { get; set; }
        public int Quantity { get; set; }
        public Vegetable Vegetable { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
