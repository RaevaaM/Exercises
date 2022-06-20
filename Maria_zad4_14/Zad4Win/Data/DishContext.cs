using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Win.Data
{
    public class DishContext:DbContext
    {
        public DishContext() : base("name=DishContext")
        {

        }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
