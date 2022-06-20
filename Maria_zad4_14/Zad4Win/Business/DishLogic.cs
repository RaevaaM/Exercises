using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4Win.Data;

namespace Zad4Win.Business
{
    public class DishLogic
    {
        private DishContext _dishDbContext = new DishContext();

        public Dish Get(int id) //ReadById
        {
            Dish foundDish = _dishDbContext.Dishes.Find(id);
            if (foundDish != null)
            {
                _dishDbContext.Entry(foundDish).Reference(x => x.Type).Load();
            }
            return foundDish;
        }
        public List<Dish> GetAll() //ReadAll
        {
            return _dishDbContext.Dishes.Include("Type").ToList();

        }

        public void Add(Dish dish) //Create
        {


            _dishDbContext.Dishes.Add(dish);
            _dishDbContext.SaveChanges();

        }
        public void Update(int id, Dish dish) //Update
        {
            Dish foundDish = _dishDbContext.Dishes.Find(id);

            if (foundDish == null)
            {
                return;
            }
            foundDish.Name = dish.Name;
            foundDish.Discription = dish.Discription;
            foundDish.Price = dish.Price;
            foundDish.Weight = dish.Weight;
            foundDish.TypeId = dish.TypeId;
            _dishDbContext.SaveChanges();

        }
        public void Delete(int id) //Delete
        {
            var foundDish = _dishDbContext.Dishes.Find(id);
            _dishDbContext.Dishes.Remove(foundDish);
            _dishDbContext.SaveChanges();
        }
    }
}
