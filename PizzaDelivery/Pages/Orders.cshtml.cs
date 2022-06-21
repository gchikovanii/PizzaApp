using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Data;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzasOrder> pizzasOrders = new List<PizzasOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            pizzasOrders = _context.PizzasOrders.ToList();
        }
    }
}
