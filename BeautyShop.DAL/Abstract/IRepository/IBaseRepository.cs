using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Abstract.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add<K>(T entity) where K : class;
        void Save();

        void Delete(T entity);
        void Update(T entity);
    }
}
