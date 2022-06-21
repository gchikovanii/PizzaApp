using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public double PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 0.5;
            if (Pizza.MayoSauce) PizzaPrice += 0.5;
            if (Pizza.Cheese) PizzaPrice += 2.5;
            if (Pizza.Peperoni) PizzaPrice += 2.5;
            if (Pizza.Mushroom) PizzaPrice += 1.5;
            if (Pizza.Ham) PizzaPrice += 2.0;
            if (Pizza.Beef) PizzaPrice += 3.0;
            if (Pizza.Pineapple) PizzaPrice += 1.0;
            if (Pizza.Tuna) PizzaPrice += 1.3;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName,PizzaPrice});
        }

    }
}
