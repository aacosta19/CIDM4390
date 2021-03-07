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
    public class IndexModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public IndexModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Shopper> Shopper { get;set; }

        public async Task OnGetAsync()
        {
            Shopper = await _context.Shopper.ToListAsync();
        }
    }
}
