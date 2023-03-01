using System.ComponentModel.DataAnnotations.Schema;

namespace BorsaUsers.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypesProductsId { get; set; } //FK M-1
        public TypesProduct TypesProducts { get; set; }//table
        public DateTime CreatedOn { get; set; }

        //ICollection<Order> Orders { get; set; } //1-N (orders)

    }
}
