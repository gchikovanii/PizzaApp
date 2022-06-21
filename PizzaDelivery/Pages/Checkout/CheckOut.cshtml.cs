using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Data;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOutModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public string PizzaName { get; set; }
        public double PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public CheckOutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzasOrder pizzasOrder = new PizzasOrder();
            pizzasOrder.PizzaName = ImageTitle;
            pizzasOrder.BasePrice = PizzaPrice;
            _context.PizzasOrders.Add(pizzasOrder);
            _context.SaveChanges();

        }
    }
}
