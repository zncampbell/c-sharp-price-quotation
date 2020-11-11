using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;
 public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.discount = 0;
            ViewBag.total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
        if (ModelState.IsValid)
        {
            ViewBag.discount = model.CalculateDiscount();
            ViewBag.total = model.CalculateTotal();
        }
        else
        {
            ViewBag.discount = 0;
            ViewBag.total = 0;
        }
            return View(model);
        }
    }
