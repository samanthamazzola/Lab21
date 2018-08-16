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
    public class AlsoUserInfo : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //parameterless constructor
        public AlsoUserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNum = "";
            Pwd = "";
        }

        [Required] // the feature Required is an attributes: hold code behind it
        // required is saying, if FirstName is set, give it. validates input
        [RegularExpression("[a-zA-Z]{1}[a-zA-Z]{1,}")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("[a-zA-Z]{1}[a-zA-Z]{1,}")]
        public string LastName { set; get; }


        [Required]
        [RegularExpression("([w-.]+u0040([w-]+.)+[w-]{2,4})")]
        public string Email { set; get; }


        [Required]
        [RegularExpression("d{3}-d{3}-d{4}")]
        public string PhoneNum { set; get; }


        [Required]
        [RegularExpression("W")]
        public string Pwd { set; get; }


        public AlsoUserInfo(string fn, string ln, string email, string phoneNum, string pwd)
        {
            FirstName = fn;
            LastName = ln;
            Email = email;
            PhoneNum = phoneNum;
            Pwd = pwd;
        }

    }
}
