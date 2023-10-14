using LabTest.Database;
using LabTest.Database.Models;
using LabTest.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;

namespace LabTest.Admin
{
    [Route("admin/product")]
    public class ProductController : Controller
    {
        [HttpGet("list", Name ="product-list")]
        public IActionResult List()
        {
            var products = DbContext._products.
                Select(s=> new ListViewModel(s.ID, s.Name, s.Description,s.Price)).ToList();

            return View(products);
        }

        [HttpGet("add", Name ="product-add")]
        public IActionResult AddProduct()
        {   
            return View();
        }

        [HttpPost("add", Name ="product-add")]
        public IActionResult AddProduct(AddViewModel model)
        {
            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price
            };

            DbContext._products.Add(product);

            return RedirectToRoute("product-list");
        }

    }
}
