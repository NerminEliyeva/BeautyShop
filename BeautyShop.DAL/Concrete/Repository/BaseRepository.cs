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

        public async Task<T> GetById(int id)
        {
            return await _beautyShopDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _beautyShopDbContext.Set<T>().ToListAsync();
        }

        public async Task Add<K>(T entity) where K : class
        {
            await _beautyShopDbContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _beautyShopDbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _beautyShopDbContext.Set<T>().Update(entity);
        }

        public void Save()
        {
            _beautyShopDbContext.SaveChanges();
        }
    }
}
