using Microsoft.AspNetCore.Mvc;
using ReceivingParameter.Models;

namespace ReceivingParameter.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id = 1, Name = "Tao", Price = 1000},
            new Product(){Id = 1, Name = "Nho", Price = 1500},
            new Product(){Id = 1, Name = "Le", Price = 2000},
            new Product(){Id = 1, Name = "Man", Price = 3000}
        };
        public IActionResult Details()  
        {
            return View(products);
        }
    }
}
