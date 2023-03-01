using System.Security.Principal;

namespace BorsaUsers.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }//FK M-
        public Customer Customers {get; set; }//table
        public int ProductId { get; set; }//FK M-1

        public Product Products { get; set; }//table

    }
}