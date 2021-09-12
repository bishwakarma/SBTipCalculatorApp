using Microsoft.AspNetCore.Mvc;
using SBTipCalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBTipCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //Gets request from the client.
        public IActionResult Index()
        {
            var model = new TipCalculatorModel();

            //Below I am have created 4 properties for index() method if the ViewBag Property, which are auto available to the controllers and View for this App.
            ViewBag.costOfMeal = "";
            //Setting the FifteenPercentTip property to the decimal value to the right. 
            ViewBag.FifteenPercentTip = 0;
            //Setting the TwentyPercentTip property to the decimal value to the right. 
            ViewBag.TwentyPercentTip = 0;

            //Setting the TwentyFivePercentTip property to the decimal value to the right. 
            ViewBag.TwentyFivePercentTip = 0;

            //Using View() method to return a ViewResult Object for the view accociated with the Index() action method.
            return View(model);
        }
        [HttpPost] //Posts response to the Index screen for client requst from the model class.
        public IActionResult Index(TipCalculatorModel model)
        {
            //Validating if the data is correct. 
            if (ModelState.IsValid)
            {
                //Calling the results from the custom methods from class TipCalculator and passing in to the ViewBag below.  
                ViewBag.FifteenPercentTip = model.CalculateTips_15();
                ViewBag.TwentyPercentTip = model.CalculateTips_20();
                ViewBag.TwentyFivePercentTip = model.CalculateTips_25();
            }
            else
            {
                //Set the fields to zero.
                ViewBag.FifteenPercentTip = 0;
                ViewBag.TwentyPercentTip = 0;
                ViewBag.TwentyFivePercentTip = 0;

            }
            //Return the model to the view for client display.
            return View(model);
        }
    }
}
