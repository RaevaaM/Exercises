namespace BorsaUsers.Data
{
    public class TypesProduct
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public DateTime RegisteredOn { get; set; }
        ICollection<Product> Products { get; set;} //1-M
    }
}
