using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Concrete.Repository
{
    public class BaseRepository<T> :IBaseRepository<T> where T : class
    {
        private readonly BeautyShopDbContext _beautyShopDbContext;
        public BaseRepository(BeautyShopDbContext beautyShopDbContext)
        {
            _beautyShopDbContext = beautyShopDbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _beautyShopDbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _beautyShopDbContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _beautyShopDbContext.Set<T>().Add(entity);
        }

        public void Save()
        {
            _beautyShopDbContext.SaveChanges();
        }
    }
}
