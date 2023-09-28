using CRUDWebApp.Core;
using CRUDWebApp.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWebApp.Infrastructure.Implementations
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly CRUDWebAppContext _appContext;
        public ProductsRepository(CRUDWebAppContext appContext)
        {
            _appContext = appContext;
        }
        public async Task Add(Product model)
        {
            await _appContext.Products.AddAsync(model);
            await _appContext.SaveChangesAsync();
            return;
        }

        public async Task Delete(int id)
        {
            var product = await _appContext.Products.FindAsync(id);
            _appContext.Products.Remove(product);
            await _appContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _appContext.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _appContext.Products.FindAsync(id);
        }

        public async Task Update(Product model)
        {
            _appContext.Entry(model).State = EntityState.Modified;
            await _appContext.SaveChangesAsync();
            return;
        }
    }
}
