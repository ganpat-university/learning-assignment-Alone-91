using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Productlist.Models
{
    [Table("Produts")]
    public class Product
    {

        [Display(Name = "Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} character.")]
        [MinLength(3, ErrorMessage = "{0} should contain mor than {1} character.")]
        public string ProductName { get; set; }


        [Display(Name = "Product Quantity")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "Quntity should between {0} and {1}")]
        public int Quantity { get; set; }

        [Display(Name = "Product Price")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "Price should between {0} and {1}")]
        public int Price { get; set; }
    }
}
