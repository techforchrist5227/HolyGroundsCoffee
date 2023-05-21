using HolyGroundsCoffee.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolyGroundsCoffee.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepo _coffeeRepo;
        private readonly ICoffeeCategoryRepo _coffeeCategoryRepo;

        public CoffeeController(ICoffeeRepo coffeeRepo, ICoffeeCategoryRepo coffeeCategoryRepo)
        {
            _coffeeRepo = coffeeRepo;
            _coffeeCategoryRepo = coffeeCategoryRepo;
        }

        public IActionResult List()
        {
            return View(_coffeeRepo.Coffees);
        }
    }
}
