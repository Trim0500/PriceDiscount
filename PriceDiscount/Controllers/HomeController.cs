using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceDiscount.Model;

namespace PriceDiscount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.subTotal = 0;
            ViewBag.discountPercent = 0;
            ViewBag.discountTotal = 0;
            ViewBag.grandTotal = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Price model)
        {
            ViewBag.discountTotal = model.calculateDiscountTotal();
            ViewBag.grandTotal = model.calculateGrandTotal();
            return View(model);
        }
    }
}
