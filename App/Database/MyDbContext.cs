using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplicationRazor.Models;

namespace ECommerceWebsite.App.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }


        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {

            
        }



    }
}
