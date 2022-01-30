using System;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChefsNDishes.Controllers
{
    public class DishController : Controller
    {
        [HttpGet("/dishes")]
        public ViewResult Dishes() {
            return View();
        }

        [HttpGet("/dishes/new")]
        public ViewResult DishForm() {
            return View();
        }

        [HttpPost("/dishes/new")]
        public IActionResult CreateDish(Dish newDish) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index", "Home");
            }
            return View("DishForm");
        }
    }
}