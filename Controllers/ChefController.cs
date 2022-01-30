using ChefsNDishes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChefsNDishes.Controllers
{
    public class ChefController : Controller
    {
        [HttpGet("chefs/new")]
        public ViewResult ChefForm() {
            return View();
        }

        [HttpPost("/chefs/new")]
        public IActionResult CreateChef(Chef newChef) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index", "Home");
            }
            return View("ChefForm");
        }
    }
}