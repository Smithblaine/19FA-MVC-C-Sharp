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

namespace BSmith_MoreyPizza1.Models
{
    public class PizzaChoice
    {
        public string done = "Thank you";
        public string Name { get; set; }
        public bool Delivery { get; set; }
        public string Size { get; set; }
    }
}