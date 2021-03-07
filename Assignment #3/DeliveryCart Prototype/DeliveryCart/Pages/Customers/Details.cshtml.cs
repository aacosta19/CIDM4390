using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Data;
using DeliveryCart.Models;

namespace DeliveryCart.Pages_Customers
{
    public class DetailsModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public DetailsModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
