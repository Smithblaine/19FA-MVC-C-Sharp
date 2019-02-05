/*
 * Blaine Smith
 * Project 1 Due Tuesday, 02-05-2019
 * NONE
 * This program will allow the user to create and order for any size regular pizza that they want.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BSmith_MoreyPizza1.Models;

namespace BSmith_MoreyPizza1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PizzaForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PizzaForm(PizzaChoice pizzaChoice)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou",pizzaChoice);
            }
            else
            {
                return View();
            }
        }
    }
}