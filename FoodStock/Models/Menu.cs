using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FoodStock.Models
{
    public class Menu
    {
        [Display(Name = "Food ID")]
        public int ID { get; set; }

        [Display(Name = "Food Item")]
        public string FoodName { get; set; }

        //the cost of the individual food item.
        [Display(Name = "Price(CAD$)")]
        public decimal Price { get; set; }

        //A food item can be part of many orders.
        public ICollection<Order> Orders { get; set; }

    }
}