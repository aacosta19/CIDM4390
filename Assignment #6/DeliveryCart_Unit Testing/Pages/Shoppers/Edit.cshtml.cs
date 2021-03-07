using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Data;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.Shoppers
{
    public class EditModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public EditModel(DeliveryCart.Data.DeliveryCartContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Shopper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopperExists(Shopper.ShopperID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShopperExists(string id)
        {
            return _context.Shopper.Any(e => e.ShopperID == id);
        }
    }
}
