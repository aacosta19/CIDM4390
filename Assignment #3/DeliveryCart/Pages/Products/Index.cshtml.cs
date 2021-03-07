using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryCart.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly DeliveryCart.Data.DeliveryCartContext _context;

        public IndexModel(DeliveryCart.Data.DeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } 
       

        public async Task OnGetAsync()
        {
            var products = from p in _context.Products
                select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(p => p.ProductName.Contains(SearchString));
            }
            
            Products = await _context.Products.ToListAsync();
        }
    }
}
