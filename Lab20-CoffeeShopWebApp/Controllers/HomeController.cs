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

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult UserRegistration()
        {
            ViewBag.Message = "User Registration Page";

            return View();
        }

        public ActionResult ConfirmRegistration()
        //need to call this method on the ConfirmRegistration page as a viewbag

        {
            return View();
        }

        public ActionResult DisplayNewUserInfo(string FirstName, string LastName, string Email, string Phone, string Password) //bool SubscribeToEmail

        //this is a METHOD with a parameter of the names from the input form. it does stuff and returns the result. 
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

        public ActionResult SearchByItem(string ItemName)
        {

            //1. Create an object from the ORM class in the .context file (this is what converts from database to object)
            Lab22CoffeeShopDB MyORM = new Lab22CoffeeShopDB();

            ViewBag.DisplayItems = MyORM.Items.Where(x => x.ItemName.Contains(ItemName)).toList();
            return View(SearchByItem);

        }


        public ActionResult AddNewUser(User newUser)
        {
            //1: create object
            Lab22CoffeeShopDB MyORM = new Lab22CoffeeShopDB();



            {
                MyORM.Customers.Add(newUser);  /* this addds the new customer. because we connected the tables, we will add data to the form in the correct place. Don't need to create individual objects; can add, remove, insert customers now */

                MyORM.SaveChanges();/*MUST save changes. this moves the change to the database. otherwise you just added it to a list that didn't go beyond this file*/
            }
            return View("AddNewUser");





        }
    }
}
