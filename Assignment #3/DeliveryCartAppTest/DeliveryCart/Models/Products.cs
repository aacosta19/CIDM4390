using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryCart.Models
{
    public class Products
    {
        [Required]
        public int ID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        
        [StringLength(100, MinimumLength = 1)]
        public string Description { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^#")]
        [Required]
        [Display(Name = "Store Number")]
        public int StoreID { get; set; }   
    }
}