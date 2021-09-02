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
        [HttpGet] //Use a tag to mapp the call to the get protocol
        public IActionResult Index()
        {
            //Set all the fields for the index to 0
            ViewBag.subTotal = 0;
            ViewBag.discountPercent = 0;
            ViewBag.discountTotal = 0;
            ViewBag.grandTotal = 0;
            return View();
        }

        [HttpPost] //Use a tag top map the submit button post call to this function
        public IActionResult Index(Price model)
        {
            if(ModelState.IsValid) //Check if the model data is valid
            {
                ViewBag.discountTotal = model.calculateDiscountTotal(); //Set the discount toal to the model class' function
                ViewBag.grandTotal = model.calculateGrandTotal(); //Set the grand total to the model class' function
            }
            else //If the model is invalid, set everything to 0
            {
                ViewBag.discountTotal = 0;
                ViewBag.grandTotal = 0;
            }
            return View(model);
        }
    }
}
