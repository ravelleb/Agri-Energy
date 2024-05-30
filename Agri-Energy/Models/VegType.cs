using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Agri_Energy.Models
{
        [Table("VegType")]

        public class VegType
        {
            public int Id { get; set; }

            [Required]
            [MaxLength(40)]
            public string? VegTypeName { get; set; }
            public int VegTypeId {  get; set; }
            public List<Vegetable> Vegetables { get; set; }

        }
}

