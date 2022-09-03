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
                ImageTitle = "Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomateSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle = "Hawaiian",
                PizzaName="Hawaii",
                BasePrice=2,
                TomateSauce=true,
                Cheese=true,
                Pineapple=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle = "MeatFeast",
                PizzaName="Meat",
                BasePrice=2,
                TomateSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                FinalPrice=6},
            new PizzasModel(){
                ImageTitle = "Mushroom",
                PizzaName="Fungi",
                BasePrice=2,
                TomateSauce=true,
                Cheese=true,
                Mushroom=true,
                Ham=true,
                FinalPrice=6},
            new PizzasModel(){
                ImageTitle = "Seafood",
                PizzaName="Tuna",
                BasePrice=2,
                TomateSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=5}
        };
        public void OnGet()
        {
        }
    }
}
