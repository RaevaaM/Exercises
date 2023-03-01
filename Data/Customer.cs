using Microsoft.AspNetCore.Identity;

namespace BorsaUsers.Data
{
    public class Customer:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime RegisterOn { get; set; }
        ICollection<Order> Orders { get; set; } //1-N(orders)
    }
}