using FoodStock.Models;
using System.Data.Entity;

namespace FoodStock.DAL
{
    public class StockContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}