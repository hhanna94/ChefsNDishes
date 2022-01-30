using System.Linq;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChefsNDishes.Controllers
{
    public class ChefController : Controller
    {
        private DataContext dbContext;
        public ChefController(DataContext context) {
            dbContext = context;
        }

        [HttpGet("chefs/new")]
        public ViewResult ChefForm() {
            return View();
        }

        [HttpPost("/chefs/new")]
        public IActionResult CreateChef(Chef newChef) {
            if (ModelState.IsValid) {
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("ChefForm");
        }

        [HttpGet("/chefs/{chefId}/delete")]
        public IActionResult DeleteChef(int chefId) {
            Chef retrievedChef = dbContext.Chefs.SingleOrDefault(chef => chef.Id == chefId);
            dbContext.Chefs.Remove(retrievedChef);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}