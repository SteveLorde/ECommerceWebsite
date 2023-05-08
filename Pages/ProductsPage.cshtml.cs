using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor.Models;

namespace WebApplicationRazor.Pages{
    public class ProductModel : PageModel
    {
        public string MyString = "hello";
        public Product[] products = new Product[]
        {
            new Product { Name = "Product 1", Description="xxx", Price=999},
            new Product { Name = "Product 2", Description="xxx", Price=999},
            new Product { Name = "Product 3", Description="xxx", Price=999}
        };
    }
}
