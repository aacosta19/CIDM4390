using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryCart.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        
        [Required]
        [Display(Name="Schedule Groceries Delivery")]
        public DateTime OrderDateCreated { get; set; }

        [Display(Name="Order Status")]
        public string OrderStatus { get; set; }

        [Display(Name="Customer Username")]
        public string CustID { get; set; }

        [Display(Name="Choose a Shopper")]
        public string ShopperID { get; set; }

        public Customer Customer { get; set; }

        public Shopper Shopper { get; set; }
        
    }
}