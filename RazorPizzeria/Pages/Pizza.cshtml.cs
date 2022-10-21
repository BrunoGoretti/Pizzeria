using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitles="Margerita",
                PizzaName="Margerita",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice= 4},

            new PizzasModel(){
                ImageTitles="Bolognese",
                PizzaName="Bolognese",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice= 5},

            new PizzasModel(){
                ImageTitles="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Pineapple=true,
                FinalPrice= 15},

            new PizzasModel(){
                ImageTitles="Carbonara",
                PizzaName="Carbonara",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Mushroom=true,
                FinalPrice= 6},

            new PizzasModel(){
                ImageTitles="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                FinalPrice= 6},

            new PizzasModel(){
                ImageTitles="Mushroom",
                PizzaName="Mushroom",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice= 5},

            new PizzasModel(){
                ImageTitles="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                FinalPrice= 5},

            new PizzasModel(){
                ImageTitles="Seafood",
                PizzaName="Seafood",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice= 5},

            new PizzasModel(){
                ImageTitles="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=20,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice= 12},
        };

        public void OnGet()
        {
        }
    }
}
