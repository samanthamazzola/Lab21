using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

//added using statement to use controller info for the new variable you created for firstname and lastname

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab21.Models
{
    public class UserInfo : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //parameterless constructor
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
        }

        [Required] // the feature Required is an attributes: hold code behind it
        // required is saying, if FirstName is set, give it. validates input
        [RegularExpression("[a-zA-Z]{1}[a-zA-Z]{1,}")]
        public string FirstName { set; get; }
        [Required]
        [RegularExpression("[a-zA-Z]{1}[a-zA-Z]{1,}")]
        public string LastName { set; get; }

        public UserInfo(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

    }
}
