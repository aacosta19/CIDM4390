using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;
using DeliveryCart.Data;

namespace DeliveryCart.Pages_Customer
{
    public class IndexModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public IndexModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } 

        public async Task OnGetAsync()
        {
            
            Customer = await _context.Customer.ToListAsync();
        }
    }
}