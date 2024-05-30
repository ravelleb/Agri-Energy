using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;


namespace Agri_Energy.Models
{
    [Table("OrderDetail")]

    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int VegetableId  { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public Order Orders { get; set; }
        public Vegetable Vegetables { get; set; }
        
    }
}
