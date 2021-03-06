using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStock.Models
{
    public class Menu
    {
        [Display(Name = "Food ID")]
        [Key]
        public int ID { get; set; }

        //The regex ensures that only alphabet letters and space is used for the food name.
        [Display(Name = "Food Item")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage ="Food Name is required. Do not enter numbers/ special characters.")]
        public string FoodName { get; set; }

        //the cost of the individual food item. The range ensures that price is not negetive or 
        //a very high value.
        [Display(Name = "Price(CAD$)")]
        [Required(ErrorMessage = "Food Cost is required")]
        [Range(0, 2000, ErrorMessage = "Enter a price between 0 and 2000.00")]
        public decimal Price { get; set; }

        //A food item can be part of many orders.
        public ICollection<Order> Orders { get; set; }

    }

    public class MenuDto
    {
        [Display(Name = "Food ID")]
        public int ID { get; set; }

        [Display(Name = "Food Item")]
        public string FoodName { get; set; }

        [Display(Name = "Price(CAD$)")]
        public decimal Price { get; set; }

    }

}