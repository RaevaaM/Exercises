using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4Win.Business;
using Zad4Win.Data;

namespace Zad4Win.Business
{
    public class DishTypeLogic
    {
        private DishContext _typeContext = new DishContext(); //database for DishType

        public List<DishType> GetAllTypes()
        {
            return _typeContext.DishTypes.ToList();
        }

        public string GetTypeById(int id)
        {
            return _typeContext.DishTypes.Find(id).TypeName;
        }
    }
}
