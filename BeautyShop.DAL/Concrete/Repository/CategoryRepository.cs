using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Entity;
using BeautyShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Concrete.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BeautyShopDbContext beautyShopDbContext) : base(beautyShopDbContext)
        {
        }
    }
}
