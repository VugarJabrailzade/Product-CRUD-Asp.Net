using LabTest.Database.Models;

namespace LabTest.Database
{
    public class DbContext
    {
        public static int _productID;

        public static List<Product> _products = new List<Product>
        {
            new Product("Alma", "Code1", 250),
            new Product("Armud", "Code2", 350),
            new Product("Nar", "Code3", 450)
        };
    }
}
