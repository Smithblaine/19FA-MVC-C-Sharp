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