using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Data;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.Shoppers
{
    public class DeleteModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public DeleteModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Shopper Shopper { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shopper = await _context.Shopper.FirstOrDefaultAsync(m => m.ShopperID == id);

            if (Shopper == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shopper = await _context.Shopper.FindAsync(id);

            if (Shopper != null)
            {
                _context.Shopper.Remove(Shopper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
