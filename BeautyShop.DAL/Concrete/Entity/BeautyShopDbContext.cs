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

        public DbSet<BrandEntity> Brand { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<ProductReviewEntity> ProductReview { get; set; }
    }
}
