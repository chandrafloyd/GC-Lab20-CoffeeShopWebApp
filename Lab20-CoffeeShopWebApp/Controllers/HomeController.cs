using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Net.Mail.MailAddress;

namespace Lab20_CoffeeShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserRegistrationPage()
        {
            ViewBag.Message = "User Registration Page";

            return View();
        }

        public ActionResult ConfirmRegistration()
            //need to call this method on the ConfirmRegistration page as a viewbag

        {
            return View();
        }

        public ActionResult RecieveUserInfo(string FirstName, string LastName, string Email, string Phone, string Password ) //bool SubscribeToEmail

        //this is a METHOD called RecieveUserInfo with a parameter of the names from the input form. it does stuff and returns the result. 
        //has the same name as the form that recieves the fields
        //have to ViewBag each item on the input fields in order for it to display


        {
            ViewBag.FirstName = FirstName;
            ViewBag.LastName = LastName;
            ViewBag.Email = Email;
            ViewBag.Phone = Phone;
            ViewBag.Password = Password;
            //ViewBag.SubscribeToEmail = SubscribeToEmail;

            return View("ConfirmRegistration");
        }
       




        // EMAIL VALIDATION pass the email address to the MailAddress.MailAddress(String) class constructor.
        //public bool IsEmailValid(string Email)
        //        {
        //            try
        //            {
        //                MailAddress m = new MailAddress(Email);
        //                return true;
        //            }
        //            catch (FormatException)
        //            {
        //                return false;
        //            }
        //        }
    }

}
