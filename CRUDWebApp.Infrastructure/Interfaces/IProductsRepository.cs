using CRUDWebApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWebApp.Infrastructure.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task Add(Product model);
        Task Update(Product model);
        Task Delete(int id);
    }
}
