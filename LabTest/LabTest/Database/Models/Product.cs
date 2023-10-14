namespace LabTest.Database.Models
{
    public class Product
    {

        public Product(){
            ID = ++DbContext._productID;
        }

        public Product(string name, string description, int price)
        {
            ID = ++DbContext._productID;
            Name = name;
            Description = description;
            Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
