using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Data;
using DeliveryCart.Models;

namespace DeliveryCart.Pages_Products
{
    public class DetailsModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public DetailsModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ID == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
