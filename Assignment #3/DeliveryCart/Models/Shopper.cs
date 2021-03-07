using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryCart.Models
{
    public class Shopper
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="Username")]
        public string ShopperID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string ShopperPassword { get; set; }
        
        [Required]
        [Display(Name="Name")]
        public string ShopperName { get; set; }

        [Required]
        [Display(Name="Phone")]
        public string ShopperPhone { get; set; }
        
    }
}