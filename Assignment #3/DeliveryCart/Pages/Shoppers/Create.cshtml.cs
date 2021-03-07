using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DeliveryCart.Data;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.Shoppers
{
    public class CreateModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public CreateModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shopper Shopper { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shopper.Add(Shopper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
