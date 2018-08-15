using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab21.Models;


namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
            ViewBag.Message = "Your application description page."; 

            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost("Register/{id:fistName}")]
        //public IActionResult ShowProduct(string id)
        //{
        //    // ...
        //}

        public IActionResult AddUser(UserInfo newUser)
        {
            // To do: add validation
            if (ModelState.IsValid) //checks the model state.. the [Required] attributes on the UserInfo.cs
            {
                // To do: add the data to the database
                // To do: confirmation or maybe send back to the Index page
                //ViewData["ConfMessage"] = "Thanks " + newUser.FirstName + " !"; //this is dictionary/hashtable OLD
                //New dynamic dictionary; both data structures
                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;  
                return View("Confirm"); //action goes to the View of Confirm page 
            }

            else 
            {
                return View("Error");
            }

        }

        public IActionResult Signup()
        {
            //ViewData["SignupMessage"] = "Please sign up here!";
            ViewBag.SignupMessage = "Please sign up here!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


