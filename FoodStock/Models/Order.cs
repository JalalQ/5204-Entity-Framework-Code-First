using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStock.Models
{
    public class Order
    {
        //[Key]
        [Display(Name = "Order ID")]
        [Key]
        public int ID { get; set; }

        [Display(Name = "Order Date dd/mm/yyyy")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter the date the Food was ordered.")]
        public DateTime OrderOn { get; set; }

        [Display(Name = "Ordered by")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Person's Name is required. Do not enter numbers/ special characters.")]
        //For future improvement - if we want to associate the name/ user ID of the person who placed the order.
        public string OrderedBy { get; set; }

        //Generally an order can have several food items being orderd.
        //However for the sake of simplicity I assume in this case that the order can include
        //only one menu item. In the future this can be extended.

        //Foreign Key ID.
        [Display(Name = "Food ID")]
        [ForeignKey("Menu")]

        public int? FoodID { get; set; }

        public virtual Menu Menu { get; set; }

    }

    public class OrderDto{

        [Display(Name = "Order ID")]
        public int ID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderOn { get; set; }

        [Display(Name = "Ordered by")]
        //For future improvement - if we want to associate the name/ user ID of the person who placed the order.
        public string OrderedBy { get; set; }

        //Foreign Key ID.
        [Display(Name = "Food ID")]
        public int FoodID { get; set; }

    }
}