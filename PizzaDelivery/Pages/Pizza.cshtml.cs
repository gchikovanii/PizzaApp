using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita",PizzaName="Margerita",BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 35},
            new PizzasModel(){ImageTitle="Bolognese",PizzaName="Bolognese",BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 35,Ham=true},
            new PizzasModel(){ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 35},
            new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawaiian",Pineapple = true, BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 35},
            new PizzasModel(){ImageTitle="MeatFeast",PizzaName="MeatFeast",Beef = true, BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 35},
            new PizzasModel(){ImageTitle="Mushroom",PizzaName="MushroomPizza",Mushroom = true, BasePrice = 2,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 15},
            new PizzasModel(){ImageTitle="Pepperoni",PizzaName="Pepperoni", Peperoni = true, BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 25},
            new PizzasModel(){ImageTitle="Vegetarian",PizzaName="Vegetarian",BasePrice = 2,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 25},
            new PizzasModel(){ImageTitle="Seafood",PizzaName="SeaFood",Tuna = true, BasePrice = 3,TomatoSauce=true,Cheese = true,MayoSauce= true,FinalPrice = 25},
        };
        public void OnGet()
        {
        }
    }
}
