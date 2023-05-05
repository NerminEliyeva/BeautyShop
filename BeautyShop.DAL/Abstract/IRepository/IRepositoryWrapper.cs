using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Abstract.IRepository
{
    public interface IRepositoryWrapper
    {
        IBrandRepository Brand { get; }
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
       int Save();
    }
}
