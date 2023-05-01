using BeautyShop.Models.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Concrete.Entity
{
    public class BeautyShopDbContext : DbContext
    {
        public BeautyShopDbContext(DbContextOptions<BeautyShopDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
    }
}
