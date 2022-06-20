using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Win.Data
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public DishType Type { get; set; }
        public int TypeId { get; set; }
    }
}
