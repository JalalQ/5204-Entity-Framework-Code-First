using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FoodStock.Models
{
    public class Order
    {
        //[Key]
        [Display(Name = "Order ID")]
        public int ID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderOn { get; set; }

        [Display(Name = "Ordered by")]
        //For future improvement - if we want to associate the name/ user ID of the person who placed the order.
        public string OrderedBy { get; set; }

        //Generall an order can have several food items being orderd.
        //However for the sake of simplicity I assume in this case that the order can include
        //only one menu item.

        //Foreign Key ID.
        [Display(Name = "Food ID")]
        public int? FoodID { get; set; }

        public virtual Menu Menu { get; set; }

    }
}