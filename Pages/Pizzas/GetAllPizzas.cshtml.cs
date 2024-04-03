using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;


namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        PizzaCatalog pizzaCatalog = new PizzaCatalog();
        public IActionResult OnGet()
        {
            pizzaCatalog.AllPizzas();
            return Page();
        }

        public Dictionary<int, Pizza> Pizzas { get => pizzaCatalog.Pizzas; }
    }
}